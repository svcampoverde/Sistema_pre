using System;
using System.Collections.Generic;

namespace LogicDeNegocio.Extensions
{
    public class Paginate<T> where T : class
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public double TotalPages { get; private set; }
        public int TotalCount { get; private set; }
        public IEnumerable<T> Items { get; set; }

        public Paginate(IEnumerable<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = count;
            TotalPages = Math.Ceiling(count / (double)pageSize);
            Items = items;
        }
    }
}
