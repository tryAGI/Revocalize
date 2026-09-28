#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class TrainingApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"training", @"Training endpoint commands.");
                         command.Subcommands.Add(TrainingTrainModelCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}