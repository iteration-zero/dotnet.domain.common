
namespace IterationZero.Domain.Common
{
    /// <summary>
    /// Represents the instructions for paging through a collection
    /// of objects.
    /// </summary>
    public class PagingInstructions
    {
        /// <summary>
        /// Creates a new instance of the <see cref="PagingInstructions" /> class.
        /// </summary>
        public PagingInstructions()
        {
            
        }

        /// <summary>
        /// Gets or sets the index of the current page.
        /// </summary>
        public int CurrentPageIndex { get; set; }

        /// <summary>
        /// Gets or sets the number of items contained in each page.
        /// </summary>
        public int PageSize { get; set; } = 25;
    }
}