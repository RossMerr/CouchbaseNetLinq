using System.Linq;
using Couchbase.Configuration.Client;
using Couchbase.Core;
using Microsoft.Extensions.Logging;

namespace Couchbase.Linq
{
    internal class QueryFactory
    {
        public static IQueryable<T> Queryable<T>(IBucket bucket, ILogger logger)
        {
            //TODO refactor so ClientConfiguration is injectable
            return new BucketQueryable<T>(bucket, new ClientConfiguration(logger), new BucketContext(bucket, logger), logger);
        }
    }
}