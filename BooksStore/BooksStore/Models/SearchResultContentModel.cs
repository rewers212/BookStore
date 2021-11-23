using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace BooksStore.Models
{
    public class SearchResultContentModel : PublishedContentWrapped
    {
        public SearchResultModel Results { get; private set; }

        public SearchResultContentModel(IPublishedContent content, SearchResultModel results)
            : base(content)
        {
            Results = results;
        }
    }
}