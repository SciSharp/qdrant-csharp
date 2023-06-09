namespace QdrantCSharp.Models;

public class VectorParams
{
    int _size;
    public int Size => _size;

    string _distance;
    public string Distance => _distance;

    public VectorParams(int size, string distance)
    {
        _size = size;
        _distance = distance;
    }
}