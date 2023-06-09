using Refit;
using System.Threading.Tasks;

namespace QdrantCSharp.QdrantRestAPIs;

public interface IQdrantCollectionApi
{
    /// <summary>
    /// Get list name of all existing collections
    /// </summary>
    /// <returns></returns>
    [Get("/collections")]
    Task<QdrantHttpResponse<CollectionsResponse>> GetCollections();

    /// <summary>
    /// Create new collection with given parameters
    /// </summary>
    /// <param name="collectionName"></param>
    /// <returns></returns>
    [Put("/collections/{collection_name}")]
    Task<QdrantHttpResponse<bool>> CreateCollection([AliasAs("collection_name")] string collectionName, [Body] CollectCreationRequest body);
}
