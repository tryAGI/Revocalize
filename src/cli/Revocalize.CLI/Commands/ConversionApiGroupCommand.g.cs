#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ConversionApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"conversion", @"Conversion endpoint commands.");
                         command.Subcommands.Add(ConversionCheckTaskCommandApiCommand.Create());
                         command.Subcommands.Add(ConversionConvertAudioCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}