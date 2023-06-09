using System.Text.Json.Serialization;

namespace QdrantCSharp.Models;

public class UpdateResult
{
    [JsonPropertyName("operation_id")]
    public int OperationId { get; set; }

    /// <summary>
    /// Refer to UpdateStatus
    /// </summary>
    public string Status { get; set;}
}
