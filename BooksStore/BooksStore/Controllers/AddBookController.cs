﻿using BooksStore.Models;
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

        }
    }
}