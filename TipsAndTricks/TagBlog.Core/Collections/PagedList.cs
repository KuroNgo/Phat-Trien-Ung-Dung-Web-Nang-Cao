using System.Collections;
using TagBlog.Core.Constraints;
namespace TagBlog.Core.Collections
{
    public class PagedList<T> : IPagedList<T>
    {
        private readonly List<T> _list = new();
        public PagedList(IList<T> list, int pageNumber, int pageSize, int totalCount)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItemCount = totalCount;
            _list.AddRange(list);
        }

        public T this[int index] => throw new NotImplementedException();

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

        public int Count => throw new NotImplementedException();

        public int HasPreviousPage => throw new NotImplementedException();

        public int HasNextPage => throw new NotImplementedException();

        public bool IsFirstPage => throw new NotImplementedException();

        public bool IsLastPage => throw new NotImplementedException();

        public int FirstItemIndex => throw new NotImplementedException();

        public int LastItemIndex => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //public T this[int index] => _list[index];
        //public virtual int Count => _list.Count;
    }
}
