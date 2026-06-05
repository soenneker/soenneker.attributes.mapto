using System;

namespace Soenneker.Attributes.MapTo;

/// <summary>
/// A C# attribute for generic data mapping translation
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class MapToAttribute : Attribute
{
    /// <summary>
    /// Gets path.
    /// </summary>
    public string Path { get; }

    public MapToAttribute(string path) => Path = path;
}