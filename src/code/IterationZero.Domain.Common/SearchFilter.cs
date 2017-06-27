
namespace IterationZero.Domain.Common
{
    /// <summary>
    /// Base class for filtering the results of a search.
    /// </summary>
    public abstract class SearchFilter
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SearchFilter"/>
        /// class.
        /// </summary>
        protected SearchFilter()
        {
            PagingInstructions = new PagingInstructions();
            SortInstructions = new SortInstructions();
        }
        
        /// <summary>
        /// Gets or sets the value to search for across all supported
        /// properties of the entity.
        /// </summary>
        public string FullSearch { get; set; }

        /// <summary>
        /// Gets or sets the paging instructions.
        /// </summary>
        public PagingInstructions PagingInstructions { get; set; }

        /// <summary>
        /// Gets or sets the sort instructions.
        /// </summary>
        public SortInstructions SortInstructions { get; set; }
    }
}