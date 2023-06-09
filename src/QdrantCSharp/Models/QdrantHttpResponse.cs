namespace QdrantCSharp.Models;

public class QdrantHttpResponse<T> where T : new()
{
    public float Time { get; set; }
    public string Status { get; set; } = "ok";
    public T Result { get; set; } = new();
}
