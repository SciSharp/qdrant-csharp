using Refit;
using System.Threading.Tasks;

namespace QdrantCSharp.RestAPIs;

public interface IQdrantCollectionApi
{
    /// <summary>
    /// Get list name of all existing collections
    /// </summary>
    /// <returns></returns>
    [Get("/collections")]
    Task<QdrantHttpResponse<CollectionList>> GetCollections();

    /// <summary>
    /// Get detailed information about specified existing collection
    /// </summary>
    /// <param name="collectionName"></param>
    /// <returns></returns>
    [Get("/collections/{collection_name}")]
    Task<QdrantHttpResponse<CollectionInfo>> GetCollection([AliasAs("collection_name")] string collectionName);

    /// <summary>
    /// Create new collection with given parameters
    /// </summary>
    /// <param name="collectionName"></param>
    /// <returns></returns>
    [Put("/collections/{collection_name}")]
    Task<QdrantHttpResponse<bool>> CreateCollection([AliasAs("collection_name")] string collectionName, [Body] CollectCreationBody body);

    /// <summary>
    /// Drop collection and all associated data
    /// </summary>
    /// <param name="collectionName"></param>
    /// <returns></returns>
    [Delete("/collections/{collection_name}")]
    Task<QdrantHttpResponse<bool>> DeleteCollection([AliasAs("collection_name")] string collectionName);
}
