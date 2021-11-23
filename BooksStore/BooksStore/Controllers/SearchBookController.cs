using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Core.Persistence.Querying;
using Umbraco.Web.Mvc;

namespace BooksStore.Controllers
{
    public class SearchBookController : SurfaceController
    {
        [HttpPost]
        public void Search()
        {
            var filter = new List<SearchFilters>();

        }
    }
}