#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ModelsCreateModelCommandApiCommand
{
    private static Option<byte[]> TrainingAudioFiles { get; } = new(
        name: @"--training-audio-files")
    {
        Description = @"ZIP containing model.json and an audio folder.",
        Required = true,
    };

    private static Option<string> TrainingAudioFilesname { get; } = new(
        name: @"--training-audio-filesname")
    {
        Description = @"ZIP containing model.json and an audio folder.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Revocalize.CreateModelResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Revocalize.CreateModelResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-model", @"Create a pending custom AI voice model");
                        command.Options.Add(TrainingAudioFiles);
                        command.Options.Add(TrainingAudioFilesname);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var trainingAudioFiles = parseResult.GetRequiredValue(TrainingAudioFiles);
                        var trainingAudioFilesname = parseResult.GetRequiredValue(TrainingAudioFilesname);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.CreateModelAsync(
                                    trainingAudioFiles: trainingAudioFiles,
                                    trainingAudioFilesname: trainingAudioFilesname,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Revocalize.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}