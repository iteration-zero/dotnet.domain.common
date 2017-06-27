using Xunit;

namespace IterationZero.Domain.Common.Tests.Unit.SearchFilterTests
{
    /// <summary>
    /// Unit tests for the constructors of the <see cref="SearchFilter" /> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests that a new instace of a class that derives from <see cref="SearchFilter" />
        /// has the expected state.
        /// </summary>
        [Fact]
        public void NewInstanceShouldHaveExpectedState()
        {
            ExampleSearchFilter filter = new ExampleSearchFilter();

            Assert.Null(filter.FullSearch);
            Assert.NotNull(filter.PagingInstructions);
            Assert.NotNull(filter.SortInstructions);
        }
    }
}