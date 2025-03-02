using System.Text.Json.Serialization;

namespace SBOMViewer.Blazor.Models.CycloneDX;

public class CycloneDXDocument
{
    [JsonPropertyName("bomFormat")]
    public string BomFormat { get; set; }

    [JsonPropertyName("specVersion")]
    public string SpecVersion { get; set; }

    [JsonPropertyName("serialNumber")]
    public string SerialNumber { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; }

    [JsonPropertyName("components")]
    public List<Component> Components { get; set; }

    [JsonPropertyName("dependencies")]
    public List<Dependency> Dependencies { get; set; }
}

public class Metadata
{
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    [JsonPropertyName("tools")]
    public List<Tool> Tools { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }
}

public class Tool
{
    [JsonPropertyName("vendor")]
    public string Vendor { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }
}

public class Component
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("bom-ref")]
    public string BomRef { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [JsonPropertyName("authors")]
    public List<Author> Authors { get; set; }

    [JsonPropertyName("hashes")]
    public List<Hash> Hashes { get; set; }

    [JsonPropertyName("licenses")]
    public List<LicenseWrapper> Licenses { get; set; }

    [JsonPropertyName("purl")]
    public string Purl { get; set; }

    [JsonPropertyName("externalReferences")]
    public List<ExternalReference> ExternalReferences { get; set; }

    [JsonPropertyName("copyright")]
    public string Copyright { get; set; }
}

public class Author
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class Hash
{
    [JsonPropertyName("alg")]
    public string Algorithm { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }
}

public class LicenseWrapper
{
    [JsonPropertyName("license")]
    public License License { get; set; }
}

public class License
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public class ExternalReference
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public class Dependency
{
    [JsonPropertyName("ref")]
    public string Ref { get; set; }

    [JsonPropertyName("dependsOn")]
    public List<string> DependsOn { get; set; }
}
