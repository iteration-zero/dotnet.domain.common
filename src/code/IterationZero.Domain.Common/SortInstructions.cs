
namespace IterationZero.Domain.Common
{
    /// <summary>
    /// Represents the sorting instructions for a collection of items.
    /// </summary>
    public class SortInstructions
    {
        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        public SortDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the property to sort the results by.
        /// </summary>
        public string SortProperty { get; set; }
    }
}