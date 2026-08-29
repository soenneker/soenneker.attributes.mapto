[![](https://img.shields.io/nuget/v/soenneker.attributes.mapto.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.mapto/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.mapto/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.mapto/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.mapto.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.mapto/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.mapto/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.mapto/actions/workflows/codeql.yml)

# Soenneker.Attributes.MapTo

A C# attribute for generic data mapping translation.

## Install

```bash
dotnet add package Soenneker.Attributes.MapTo
```

## Quick start

```csharp
using Soenneker.Attributes.MapTo;

public sealed class Request
{
    [MapTo]
    public string? Value { get; init; }
}
```

A C# attribute for generic data mapping translation.

## What you get

- `MapToAttribute` — A C# attribute for generic data mapping translation.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `MapToAttribute.Path` | Gets path. | Gets path. |
