#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class TrainingTrainModelCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"",
    };

    private static Option<int> Epochs { get; } = new(
        name: @"--epochs")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Revocalize.TrainModelResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Revocalize.TrainModelResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"train-model", @"Train a custom AI voice model");
                        command.Arguments.Add(ModelId);
                        command.Options.Add(Epochs);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var epochs = parseResult.GetRequiredValue(Epochs);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Training.TrainModelAsync(
                                    modelId: modelId,
                                    epochs: epochs,
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