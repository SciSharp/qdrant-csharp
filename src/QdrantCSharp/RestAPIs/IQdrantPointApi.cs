using Refit;
using System.Threading.Tasks;

namespace QdrantCSharp.RestAPIs;

public interface IQdrantPointApi
{
    [Put("/collections/{collection_name}/points")]
    Task<QdrantHttpResponse<UpdateResult>> Upsert([AliasAs("collection_name")] string collectionName, [Body] PointsUpsertBody body);

    [Post("/collections/{collection_name}/points/search")]
    Task<QdrantHttpResponse<ScoredPoint[]>> Search([AliasAs("collection_name")] string collectionName, [Body] SearchBody body);
}
