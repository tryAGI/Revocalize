#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Revocalize \
  --clientClassName RevocalizeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# The project owns its reviewed package versions and build metadata. Remove only
# generated commands; retain the .csproj and other owner files in the CLI root.
if [[ -d ../../cli/Revocalize.CLI/Commands ]]; then
  find ../../cli/Revocalize.CLI/Commands -type f -name '*.g.cs' -delete
fi

autosdk cli-project openapi.yaml \
  --output ../../cli/Revocalize.CLI \
  --sdk-project ../../libs/Revocalize/Revocalize.csproj \
  --preserve-project-file \
  --targetFramework net10.0 \
  --namespace Revocalize \
  --clientClassName RevocalizeClient \
  --package-id Revocalize.CLI \
  --tool-command-name revocalize \
  --user-secrets-id Revocalize.CLI \
  --api-key-env-var REVOCALIZE_API_KEY \
  --base-url-env-var REVOCALIZE_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
