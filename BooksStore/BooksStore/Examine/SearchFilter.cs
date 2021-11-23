using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Examine
{
    public class SearchFilter
    {
        public SearchFilter(string fieldName,object value)
        {
            FieldName = fieldName;
            Value = value;

        }
        public string FieldName { get; private set; }
        public object Value{ get; private set; }
    }
}