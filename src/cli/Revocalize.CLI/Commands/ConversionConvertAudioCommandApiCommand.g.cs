#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Revocalize.CLI.Commands;

internal static partial class ConversionConvertAudioCommandApiCommand
{
    private static Option<byte[]> Audio { get; } = new(
        name: @"--audio")
    {
        Description = @"Input vocal audio file, preferably WAV.",
        Required = true,
    };

    private static Option<string> Audioname { get; } = new(
        name: @"--audioname")
    {
        Description = @"Input vocal audio file, preferably WAV.",
        Required = true,
    };

    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Target model ID.",
        Required = true,
    };

    private static Option<int?> Transpose { get; } = new(
        name: @"--transpose")
    {
        Description = @"",
    };

    private static Option<int?> GenerationsCount { get; } = new(
        name: @"--generations-count")
    {
        Description = @"",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Revocalize.TaskCreatedResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Revocalize.TaskCreatedResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"convert-audio", @"Convert a vocal audio file to a target voice model");
                        command.Options.Add(Audio);
                        command.Options.Add(Audioname);
                        command.Options.Add(Model);
                        command.Options.Add(Transpose);
                        command.Options.Add(GenerationsCount);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Revocalize.ConvertAudioRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Revocalize.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var audio = parseResult.GetRequiredValue(Audio);
                        var audioname = parseResult.GetRequiredValue(Audioname);
                        var model = parseResult.GetRequiredValue(Model);
                        var transpose = CliRuntime.WasSpecified(parseResult, Transpose) ? parseResult.GetValue(Transpose) : __requestBase is not null ? __requestBase.Transpose : default;
                        var generationsCount = CliRuntime.WasSpecified(parseResult, GenerationsCount) ? parseResult.GetValue(GenerationsCount) : __requestBase is not null ? __requestBase.GenerationsCount : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Conversion.ConvertAudioAsync(
                                    audio: audio,
                                    audioname: audioname,
                                    model: model,
                                    transpose: transpose,
                                    generationsCount: generationsCount,
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