#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ConversionCheckTaskCommandApiCommand
{
    private static Argument<string> TaskId { get; } = new(
        name: @"task-id")
    {
        Description = @"",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Revocalize.TaskStatusResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Revocalize.TaskStatusResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"check-task", @"Check conversion task status");
                        command.Arguments.Add(TaskId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var taskId = parseResult.GetRequiredValue(TaskId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Conversion.CheckTaskAsync(
                                    taskId: taskId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Revocalize.SourceGenerationContext.Default,
                                        @"OutputAudioUrls",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Revocalize.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}