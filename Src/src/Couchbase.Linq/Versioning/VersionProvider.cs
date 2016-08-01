using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Couchbase.Linq.Versioning
{
    /// <summary>
    /// Singleton for the <see cref="IVersionProvider"/> implementation in use for query generation.
    /// </summary>
    public static class VersionProvider
    {
        /// <summary>
        /// Singleton for the <see cref="IVersionProvider"/> implementation in use for query generation.
        /// </summary>
        public static IVersionProvider Current { get; set; }
        
        static VersionProvider()
        {
            Current = null;
        }

        public static void Setup(ILoggerFactory loggerFactory)
        {
            if (Current == null)
            {
                Current = new DefaultVersionProvider(loggerFactory);
            }
        }
    }
}
