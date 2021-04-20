using CommandLine;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoTSeasonPassProgress
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            return await Parser.Default.ParseArguments<CommandLineOptions>(args)
            .MapResult(async (CommandLineOptions opts) =>
            {
                try
                {
                    // We have the parsed arguments, so let's just pass them down
                    ProcessProgressFile(opts.Path, opts.Incomplete);
                    return 0;
                }
                catch
                {
                    Console.WriteLine("Error!");
                    return -3; // Unhandled error
                }
            },
            errs => Task.FromResult(-1)); // Invalid arguments
        }

        static void ProcessProgressFile(string progressFilePath, bool onlyIncomplete)
        {
            string jsonString = File.ReadAllText(progressFilePath);
            var passProgress = JsonSerializer.Deserialize<SeasonPassProgress>(jsonString);

            foreach (var group in passProgress.ChallengeGroups)
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

                    Console.WriteLine($"    [{challengeDone}] {challenge.Title}");
                    foreach (var goal in challenge.Goals)
                    {
                        char goalDone = goal.ProgressValue == goal.Threshold ? 'X' : ' ';
                        if (onlyIncomplete && goalDone == 'X')
                        {
                            continue;
                        }
                        Console.WriteLine($"          [{goalDone}] {goal.ProgressValue:D}/{goal.Threshold:D} {goal.Title}");
                    }
                }
            }
        }
    }
}
