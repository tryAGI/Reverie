# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Reverie SDK provides integration with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), enabling seamless interoperability with the unified .NET AI abstractions.

## Installation

```bash
dotnet add package Reverie
```

## Usage

```csharp
using Microsoft.Extensions.AI;
using Reverie;

using var client = new ReverieClient(
    apiKey: Environment.GetEnvironmentVariable("REVERIE_API_KEY")!,
    appId: Environment.GetEnvironmentVariable("REVERIE_APP_ID")!);

// Use with Microsoft.Extensions.AI abstractions
// See examples below for specific integration patterns
```

## Next Steps

- Check the [Examples](../index.md) for complete working code
- See the [centralized MEAI docs](https://tryagi.github.io/docs/meai/) for cross-SDK comparisons
- Visit the [Microsoft.Extensions.AI documentation](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) for framework details
