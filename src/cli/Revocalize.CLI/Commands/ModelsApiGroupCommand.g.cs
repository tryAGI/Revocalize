#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsCreateModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsListModelsCommandApiCommand.Create());
        return command;
    }
}