using System.Threading.Tasks;

namespace QdrantCSharp;

public interface IQdrantClient
{
    Task<QdrantHttpResponse<CollectionsResponse>> GetCollections();
    Task<QdrantHttpResponse<bool>> CreateCollection(string collection_name, VectorParams vectors_config);
}
