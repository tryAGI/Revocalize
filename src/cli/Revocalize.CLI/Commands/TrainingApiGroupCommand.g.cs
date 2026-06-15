#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static class TrainingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"training", @"Training endpoint commands.");
                         command.Subcommands.Add(TrainingTrainModelCommandApiCommand.Create());
        return command;
    }
}