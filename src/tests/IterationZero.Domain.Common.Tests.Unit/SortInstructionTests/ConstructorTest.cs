using Xunit;

namespace IterationZero.Domain.Common.Tests.Unit.SortInstructionTests
{
    /// <summary>
    /// Unit tests for the <see cref="SortInstruction" /> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests that a new instance of the <see cref="SortInstructions"/>
        /// class has the expected values.
        /// </summary>
        [Fact]
        public void NewInstanceShouldHaveExpectedValues()
        {
            SortInstructions instructions = new SortInstructions();

            Assert.Equal<SortDirection>(SortDirection.Ascending, instructions.Direction);
            Assert.Null(instructions.SortProperty);
        }
    }
}