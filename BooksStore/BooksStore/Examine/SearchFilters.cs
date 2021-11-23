using BooksStore.Examine;
using Examine.LuceneEngine.Providers;
using Examine.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore
{
    public class SearchFilters
    {
        private readonly BooleanOperation _booleanOperation;

        public SearchFilters(BooleanOperation booleanOperation)
        {
            _booleanOperation = booleanOperation;
            Filters = new List<SearchFilter>();
        }
        public List<SearchFilter> Filters { get; private set; }

        public void RatingFilter(BaseLuceneSearcher  )
    }
}