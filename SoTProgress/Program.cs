﻿using CommandLine;
using NegativeEddy.SoT;
using NegativeEddy.SoT.Reputation;
using NegativeEddy.SoT.Seasons;
using SoTProgress.Adventures;
using SoTProgress.MyChest;
using System.Text.Json;

const string Indent = "    ";

return await Parser.Default.ParseArguments<CommandLineOptions>(args)
        .MapResult(async (CommandLineOptions opts) =>
        {
            try
            {
                bool fileProcessed = false;

                if (opts.SeasonFilePath is not null)
                {
                    // We have the parsed arguments, so let's just pass them down
                    ProcessProgressFile(opts.SeasonFilePath, opts.Incomplete);
                    fileProcessed = true;
                }

                if (opts.ReputationFilePath is not null)
                {
                    ProcessReputationFile(opts.ReputationFilePath, opts.Incomplete);
                    fileProcessed = true;
                }

                if (opts.AdventureFilePath is not null)
                {
                    ProcessAdventureFile(opts.AdventureFilePath, opts.Incomplete);
                    fileProcessed = true;
                }

                if (opts.ChestFilePath is not null)
                {
                    ProcessChestFile(opts.ChestFilePath);
                    fileProcessed = true;
                }

                if (opts.LeaderboardFilePath is not null)
                {
                    ProcessLeaderboardFile(opts.LeaderboardFilePath);
                    fileProcessed = true;
                }

                if (!fileProcessed)
                {
                    Console.WriteLine(CommandLineOptions.HelpString);
                }
                return 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex);
                Console.WriteLine("Error!");
                return -3; // Unhandled error
            }
        },
        errs => Task.FromResult(-1)
        ); // Invalid arguments

void ProcessLeaderboardFile(string leaderboardFilePath)
{
    Console.WriteLine("Coming soon...");
}

void ProcessChestFile(string chestFilePath)
{
    string jsonString = File.ReadAllText(chestFilePath);
    var chest = JsonSerializer.Deserialize<MyChest>(jsonString);
    foreach (var category in chest.chestData)
    {
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine($"{category.Key}");
        Console.WriteLine();
        Console.WriteLine("===============================");

        Console.WriteLine();

        var itemGroups = category.Value.GroupBy(item => item.Taxonomy.Tags[0].Name).OrderBy(g => g.Key);
        foreach (var itemGroup in itemGroups)
        {
            Console.WriteLine(itemGroup.Key);

            Console.WriteLine();

            foreach (var item in itemGroup.OrderBy(i => i.title))
            {
                Console.WriteLine($"{Indent}{item.title}");
            }

            Console.WriteLine();
        }
    }
}

void ProcessAdventureFile(string adventureFilePath, bool incomplete)
{
    string jsonString = File.ReadAllText(adventureFilePath);
    var adventures = JsonSerializer.Deserialize<Adventure[]>(jsonString);

    foreach (var arc in adventures.SelectMany(x => x.Arcs))
    {
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine($"{arc.Meta.Title}: {arc.Subtitle}");
        Console.WriteLine();
        Console.WriteLine("===============================");

        Console.WriteLine("Mementos");
        foreach (var item in arc.Mementos.Items)
        {
            if (!item.Progress.IsLocked && incomplete)
            {
                continue;
            }

            char itemDone = item.Progress.IsLocked ? ' ' : 'X';
            string itemTitle = item.Entitlement.Text;
            Console.WriteLine($"{Indent}[{itemDone}] {itemTitle}: {item.Description}");
        }

        if (arc.Deeds?.Items?.Any() ?? false)
        {
            Console.WriteLine("Deeds");
            foreach (var item in arc.Deeds.Items)
            {
                if (!item.Progress.IsLocked && incomplete)
                {
                    continue;
                }

                char itemDone = item.Progress.IsLocked ? ' ' : 'X';
                string itemTitle = item.Name;
                Console.WriteLine($"{Indent}[{itemDone}] {itemTitle}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void ProcessProgressFile(string progressFilePath, bool onlyIncomplete)
{
    string jsonString = File.ReadAllText(progressFilePath);
    var seasons = JsonSerializer.Deserialize<SeasonProgress[]>(jsonString);

    foreach (var season in seasons)
    {
        Console.WriteLine("===============================");
        Console.WriteLine();
        Console.WriteLine(season.Title);
        Console.WriteLine();
        Console.WriteLine("===============================");

        Console.WriteLine();

        foreach (var group in season.ChallengeGroups)
        {
            char groupDone = group.isCompleted ? 'X' : ' ';
            if (onlyIncomplete && groupDone == 'X')
            {
                continue;
            }

            Console.WriteLine($"[{groupDone}] {group.Title}");
            foreach (var challenge in group.Challenges)
            {
                char challengeDone = challenge.isCompleted ? 'X' : ' ';
                if (onlyIncomplete && challengeDone == 'X')
                {
                    continue;
                }

                Console.WriteLine($"{Indent}[{challengeDone}] {challenge.Title}");
                foreach (var goal in challenge.Goals)
                {
                    char goalDone = goal.ProgressValue == goal.Threshold ? 'X' : ' ';
                    if (onlyIncomplete && goalDone == 'X')
                    {
                        continue;
                    }

                    Console.WriteLine($"{Indent}{Indent}[{goalDone}] {goal.ProgressValue:D}/{goal.Threshold:D} {goal.Title}");
                }
            }
            Console.WriteLine();
        }
    }
}

void ProcessReputationFile(string repFilePath, bool onlyIncomplete)
{
    string jsonString = File.ReadAllText(repFilePath);
    var passProgress = JsonSerializer.Deserialize<ReputationProgress>(jsonString);

    ShowReputationForTradingCompany(passProgress.AthenasFortune, "Athena's Fortune", onlyIncomplete);
    ShowReputationForTradingCompany(passProgress.OrderOfSouls, "Order of Souls", onlyIncomplete);
    ShowReputationForTradingCompany(passProgress.GoldHoarders, "Gold Hoarders", onlyIncomplete);
    ShowReputationForTradingCompany(passProgress.MerchantAlliance, "Merchant Alliance", onlyIncomplete);
    ShowReputationForTradingCompany(passProgress.ReapersBones, "Reapers Bones", onlyIncomplete);
    ShowReputationForCampaigns(passProgress.TallTales, "Tall Tales", onlyIncomplete);
    ShowReputationForCampaigns(passProgress.BilgeRats, "Bilge Rats", onlyIncomplete);
}

void ShowReputationForCampaigns(CampaignSet tallTales, string name, bool onlyIncomplete)
{
    char allTalesDone = tallTales.EmblemsTotal == tallTales.EmblemsUnlocked ? 'X' : ' ';
    Console.WriteLine($"[{allTalesDone}] {name}");

    if (allTalesDone == 'X')
    {
        return;
    }

    foreach (var tale in tallTales.Campaigns)
    {
        string campaignName = tale.Key;
        Campaign compaign = tale.Value;
        char campaignComplete = compaign.EmblemsTotal == compaign.EmblemsUnlocked ? 'X' : ' ';

        if (onlyIncomplete && campaignComplete == 'X')
        {
            continue;
        }

        Console.WriteLine($"{Indent}[{campaignComplete}] {compaign.Title}");

        PrintEmblems(compaign.Emblems, onlyIncomplete, 2);
    }
}

void ShowReputationForTradingCompany(TradingCompany tradingCompany, string name, bool onlyIncomplete)
{
    char companyDone = tradingCompany.EmblemsTotal == tradingCompany.EmblemsUnlocked ? 'X' : ' ';
    Console.WriteLine($"[{companyDone}] {name}");

    PrintEmblems(tradingCompany.Emblems.Emblems, onlyIncomplete, 1);
}

void PrintEmblems(IEnumerable<Emblem> emblems, bool onlyIncomplete, int indent)
{
    foreach (var emblem in emblems)
    {
        char emblemDone = emblem.Completed ? 'X' : ' ';
        if (onlyIncomplete && emblemDone == 'X')
        {
            continue;
        }

        for (int i = 0; i < indent; i++)
        {
            Console.Write(Indent);
        }

        if (emblem.HasScalar)
        {
            if (emblem.MaxGrade > 1)
            {
                Console.WriteLine($"[{emblemDone}] {emblem.Value}/{emblem.Threshold} for Grade {emblem.Grade}, {emblem.Description}");
            }
            else
            {
                Console.WriteLine($"[{emblemDone}] {emblem.Value}/{emblem.Threshold} {emblem.Description}");
            }
        }
        else
        {
            Console.WriteLine($"[{emblemDone}] {emblem.Description}");
        }
    }
}