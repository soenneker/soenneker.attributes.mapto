[![](https://img.shields.io/nuget/v/soenneker.attributes.mapto.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.mapto/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.mapto/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.mapto/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.mapto.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.mapto/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.mapto/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.mapto/actions/workflows/codeql.yml)

# Soenneker.Attributes.MapTo

A property marker that records the destination path used by a mapping component.

## Installation

```bash
dotnet add package Soenneker.Attributes.MapTo
```

## Usage

```csharp
using Soenneker.Attributes.MapTo;

public sealed class CustomerColumns
{
    [MapTo("Customer.Profile.DisplayName")]
    public string? Name { get; init; }
}
```

Consumers retrieve the path through reflection:

```csharp
using System.Reflection;

PropertyInfo property = typeof(CustomerColumns).GetProperty(
    nameof(CustomerColumns.Name))!;

string destinationPath = property
    .GetCustomAttribute<MapToAttribute>()!
    .Path;
```

This attribute is used by mapping-aware libraries such as `Soenneker.DataTables.Extensions.ServerSideRequest`, where an externally visible column can map to a different internal member path.

## Important behavior

- `MapToAttribute` can be applied to properties only.
- `Path` is stored verbatim. This package does not parse the path, access members, or perform a mapping itself.
- Path syntax and validation belong to the component reading the attribute.
- The attribute is not repeatable on a property.
