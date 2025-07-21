// <copyright file="EntityTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

using SimplexStandard.Domain;

namespace SimplexStandard.Tests.Domain
{
    /// <summary>
    /// Tests for the <see cref="Entity"/> class.
    /// </summary>
    [TestClass]
    public class EntityTests
    {
        /// <summary>
        /// Identifiers passed to the entity are correctly set.
        /// </summary>
        [TestMethod]
        public void Constructor_PassingId_SetsCorrectly()
        {
            var id = Guid.CreateVersion7();

            var entity = new TestEntity(id);

            Assert.AreEqual(id, entity.Id);
        }

        /// <summary>
        /// Constructor will throw exception on an empty id.
        /// </summary>
        [TestMethod]
        public void EmptyGuid_WhenPassed_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new TestEntity(Guid.Empty));
        }
    }
}
