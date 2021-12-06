using CommandLine;
using NegativeEddy.SoT.Seasons;
using NegativeEddy.SoT.Reputation;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace NegativeEddy.SoT
{
    class Program
    {
        private const string Indent = "    ";

        static async Task<int> Main(string[] args)
        {
            return await Parser.Default.ParseArguments<CommandLineOptions>(args)
            .MapResult(async (CommandLineOptions opts) =>
            {
                try
                {
                    if (opts.SeasonFilePath != null)
                    {
                        // We have the parsed arguments, so let's just pass them down
                        ProcessProgressFile(opts.SeasonFilePath, opts.Incomplete);
                    }
                    if (opts.ReputationFilePath != null)
                    {
                        ProcessReputationFile(opts.ReputationFilePath, opts.Incomplete);
                    }

                    if (opts.SeasonFilePath == null && opts.ReputationFilePath == null)
                    {
                        Console.WriteLine(
@"season or reputation file path missing. (--help for help)

EXAMPLE USAGE: 
SoTSeasonPassProgress.exe -h
SoTSeasonPassProgress.exe -s seasons.json
SoTSeasonPassProgress.exe -s seasons.json -i
SoTSeasonPassProgress.exe -r reputation.json");
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex);
                    Console.WriteLine("Error!");
                    return -3; // Unhandled error
                }
            },
            errs => Task.FromResult(-1)); // Invalid arguments
        }

        static void ProcessProgressFile(string progressFilePath, bool onlyIncomplete)
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
        static void ProcessReputationFile(string repFilePath, bool onlyIncomplete)
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

        private static void ShowReputationForCampaigns(CampaignSet tallTales, string name, bool onlyIncomplete)
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

        private static void ShowReputationForTradingCompany(TradingCompany tradingCompany, string name, bool onlyIncomplete)
        {
            char companyDone = tradingCompany.EmblemsTotal == tradingCompany.EmblemsUnlocked ? 'X' : ' ';
            Console.WriteLine($"[{companyDone}] {name}");

            PrintEmblems(tradingCompany.Emblems.Emblems, onlyIncomplete, 1);
        }

        private static void PrintEmblems(IEnumerable<Emblem> emblems, bool onlyIncomplete, int indent)
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
    }
}
