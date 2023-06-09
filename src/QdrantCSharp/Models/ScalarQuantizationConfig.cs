using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class ScalarQuantizationConfig
{
    /// <summary>
    /// Refer to ScalarType
    /// </summary>
    public string Type { get; set; }
    public float Quantile { get; set; }
    [JsonPropertyName("always_ram")]
    public bool AlwaysRam { get; set; }
}
