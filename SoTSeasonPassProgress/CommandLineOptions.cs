using CommandLine;

namespace SoTSeasonPassProgress
{
    public class CommandLineOptions
    {
        [Value(index: 0, Required = true, HelpText = "file path to Sea of Seasons progress file", MetaName ="filepath")]
        public string Path { get; set; }

        [Option(shortName: 'i', longName: "incompleteOnly", Required = false, HelpText = "Only show incompleted goals", Default = false)]
        public bool Incomplete { get; set; }
    }
}