using System.Threading.Tasks;

namespace QdrantCSharp;

public interface IQdrantClient
{
    Task<QdrantHttpResponse<CollectionList>> GetCollections();
    Task<QdrantHttpResponse<bool>> CreateCollection(string collection_name, VectorParams vectors_config);
    Task<QdrantHttpResponse<bool>> DeleteCollection(string collection_name);
}
