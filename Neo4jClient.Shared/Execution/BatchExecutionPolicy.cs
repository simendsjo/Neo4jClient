﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neo4jClient.Execution
{
    internal class BatchExecutionPolicy : GraphClientBasedExecutionPolicy
    {
        public BatchExecutionPolicy(IGraphClient client) : base(client)
        {
        }

        public override TransactionExecutionPolicy TransactionExecutionPolicy
        {
            get { return TransactionExecutionPolicy.Denied; }
        }

        public override void AfterExecution(IDictionary<string, object> executionMetadata, object executionContext)
        {
        }

        public override Uri BaseEndpoint
        {
            get { return Client.BatchEndpoint; }
        }
    }
}
