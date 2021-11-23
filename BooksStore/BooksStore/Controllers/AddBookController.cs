using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Umbraco.Core.Services;

namespace BooksStore.Controllers
{
    public class AddBookController : UmbracoApiController
    {
        [HttpPost]
        public object AddBook(BookModel model)
        {
            var contentService = Services.ContentService;
            var content = contentService.Create(model.Name, 1, "name");
            content.SetValue("name", model.Name);
            content.SetValue("author", model.Author);
            content.SetValue("rating", model.Rating);
            content.SetValue("genres", model.Genres);
            contentService.Save(content);

            return Ok();
        }
    }
}