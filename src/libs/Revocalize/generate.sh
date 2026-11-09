#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Revocalize \
  --clientClassName RevocalizeClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
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
