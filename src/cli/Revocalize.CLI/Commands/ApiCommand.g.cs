#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(ConversionApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(TrainingApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}