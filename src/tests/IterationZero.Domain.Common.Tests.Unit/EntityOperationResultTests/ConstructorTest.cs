using System;
using Xunit;

namespace IterationZero.Domain.Common.Tests.Unit.EntityOperationResultTests
{
    /// <summary>
    /// Unit tests for teh constructors of the <see cref="EntityOperationResult"/> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests the supplied entity parameter maps to the Entoty property.        
        /// </summary>
        [Fact]
        public void EntityShouldBindToProperty()
        {
            TestEntity testEntity = new TestEntity();
            EntityOperationResult<TestEntity, string> result
                = new EntityOperationResult<TestEntity, string>(testEntity);

            Assert.Equal<TestEntity>(testEntity, result.Entity);
        }
    }
}