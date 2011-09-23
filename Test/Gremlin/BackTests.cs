﻿using NUnit.Framework;
using Neo4jClient.Gremlin;

namespace Neo4jClient.Test.Gremlin
{
    [TestFixture]
    public class BackTests
    {
        [Test]
        public void BackVWithCountShouldAppendStep()
        {
            var query = new NodeReference(123).BackV<object>(2);
            Assert.AreEqual("g.v(p0).back(p1)", query.QueryText);
            Assert.AreEqual(123, query.QueryParameters["p0"]);
            Assert.AreEqual(2, query.QueryParameters["p1"]);
        }

        [Test]
        public void BackVWithCountShouldReturnTypedNodeEnumerable()
        {
            var node = new NodeReference(123);
            var query = node.BackV<object>(2);
            Assert.IsInstanceOf<GremlinNodeEnumerable<object>>(query);
        }

        [Test]
        public void BackEWithCountShouldAppendStep()
        {
            var query = new NodeReference(123).BackE(2);
            Assert.AreEqual("g.v(p0).back(p1)", query.QueryText);
            Assert.AreEqual(123, query.QueryParameters["p0"]);
            Assert.AreEqual(2, query.QueryParameters["p1"]);
        }

        [Test]
        public void BackEWithCountShouldReturnRelationshipEnumerable()
        {
            var node = new NodeReference(123);
            var query = node.BackE(2);
            Assert.IsInstanceOf<GremlinRelationshipEnumerable>(query);
        }
    }
}