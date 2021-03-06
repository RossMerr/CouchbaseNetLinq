﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couchbase.Linq.Execution
{
    /// <summary>
    /// Used to extract the result row from an Any, All, or aggregate operation.
    /// </summary>
    public class ScalarResult<T>
    {
        // ReSharper disable once InconsistentNaming
        // Note: must be virtual to support change tracking for First/Single
        public virtual T result { get; set; }
    }
}
