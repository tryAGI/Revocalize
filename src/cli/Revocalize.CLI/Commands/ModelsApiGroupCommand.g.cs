#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ModelsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsCreateModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsListModelsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}