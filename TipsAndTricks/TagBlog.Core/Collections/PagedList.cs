using System.Collections;
using TagBlog.Core.Constraints;
namespace TagBlog.Core.Collections
{
    public class PagedList<T> : IPagedList<T>
    {
        private readonly List<T> _subset = new();
        public PagedList(IList<T> list, int pageNumber, int pageSize, int totalCount)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItemCount = totalCount;
            _subset.AddRange(list);
        }

        public int PageIndex { get; set; }

        public int TotalItemCount { get; set; }

        public int PageSize { get; set; }

        public int PageNumber
        {
            get => PageIndex + 1;
            set => PageIndex = value - 1;
        }

        public int PageCount
        {
            get
            {
                if (PageSize == 0) return 0;
                var total = TotalItemCount / PageSize;
                if (TotalItemCount % PageSize > 0) total++;
                return total;
            }
        }

        public bool HasPreviousPage => PageIndex > 0;

        public bool HasNextPage => (PageIndex<(PageCount-1));

        public bool IsFirstPage =>(PageIndex<=0);

        public bool IsLastPage => (PageIndex>=(PageCount-1));

        public int FirstItemIndex => (PageIndex * PageSize);

        public int LastItemIndex =>
            Math.Min(TotalItemCount,((PageIndex*PageSize)+PageSize));

        #region
        public IEnumerator<T> GetEnumerator()
        {
            return _subset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index] => _subset[index];

        public virtual int Count => _subset.Count;
        #endregion
    }
}
