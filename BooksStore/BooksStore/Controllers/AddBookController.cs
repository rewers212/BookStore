using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace BooksStore.Controllers
{
    public class AddBookController : UmbracoApiController
    {
        [HttpPost]
        public void AddBook(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            var memberservice = Services.MemberService;
            var member = memberservice.CreateMemberWithIdentity(model.Name, model.Author, model.Genres, model.Rating);
            member.SetValue("name", model.Name);
            member.SetValue("author", model.Author);
            member.SetValue("genres", model.Genres);
            member.SetValue("rating", model.Rating);
        }
    }
}