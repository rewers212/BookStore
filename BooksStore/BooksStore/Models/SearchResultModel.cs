using Examine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BooksStore.Models
{
    [DataContract]
    public class SearchResultModel
    {
        public SearchResultModel(ISearchResults searchResults, double totalmilliseconds, string searchTerm, string orderBy)
        {
            SearchResults = searchResults;
            SearchTerm = searchTerm;
            OrderBy = orderBy;
        }

        [DataMember(Name = "orderBy")]
        public string OrderBy { get; set; }

        [DataMember(Name = "items")]
        public ISearchResults SearchResults { get; private set; }

        [DataMember(Name = "name")]
        public string SearchTerm { get; private set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }
    }
}