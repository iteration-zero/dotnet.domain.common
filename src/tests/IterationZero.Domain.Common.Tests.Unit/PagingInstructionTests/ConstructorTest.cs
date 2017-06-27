using Xunit;
using IterationZero.Domain.Common;

namespace IterationZero.Domain.Common.Tests.Unit.PagingInstructionTests
{
    /// <summary>
    /// Unit tests for the constructors of the <see cref="PagingInstructions"/> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests that a new instance of the <see cref="PagingInstructions"/> class
        /// has the expected state.
        /// </summary>
        [Fact]
        public void NewInstanceShouldHaveExpectedValues()
        {
            PagingInstructions pagingInstructions = new PagingInstructions();

            Assert.Equal<int>(0, pagingInstructions.CurrentPageIndex);
            Assert.Equal<int>(25, pagingInstructions.PageSize);
        }
    }
}