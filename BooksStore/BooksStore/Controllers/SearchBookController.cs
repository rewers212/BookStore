using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.WebApi;

namespace BooksStore.Controllers
{
    public class SearchBookController : UmbracoApiController
    {
        public ActionResult Index(BookModel model,string name,string genres)
        {
            var searchPageModel = new BookModel();

            searchPageModel.Name = name;
            searchPageModel.Genres = genres;

            return null;
        }
    }
}