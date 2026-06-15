#nullable enable

using System.CommandLine;
using Revocalize.CLI;
using Revocalize.CLI.Commands;

var rootCommand = new RootCommand(@"CLI tool for the Revocalize SDK.");
rootCommand.Options.Add(CliOptions.ApiKey);
rootCommand.Options.Add(CliOptions.BaseUrl);
rootCommand.Options.Add(CliOptions.Json);
rootCommand.Options.Add(CliOptions.Output);
rootCommand.Options.Add(CliOptions.OutputDirectory);
rootCommand.Subcommands.Add(AuthCommand.Create());
rootCommand.Subcommands.Add(ConversionApiGroupCommand.Create());
rootCommand.Subcommands.Add(ModelsApiGroupCommand.Create());
rootCommand.Subcommands.Add(TrainingApiGroupCommand.Create());

return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);