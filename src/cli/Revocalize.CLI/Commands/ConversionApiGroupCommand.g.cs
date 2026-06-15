#nullable enable

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static class ConversionApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"conversion", @"Conversion endpoint commands.");
                         command.Subcommands.Add(ConversionCheckTaskCommandApiCommand.Create());
                         command.Subcommands.Add(ConversionConvertAudioCommandApiCommand.Create());
        return command;
    }
}