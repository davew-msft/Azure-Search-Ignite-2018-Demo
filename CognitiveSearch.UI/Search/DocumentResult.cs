﻿using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveSearch.UI
{
    public class DocumentResult
    {
        public List<object> Facets { get; set; }
        public Document Result { get; set; }
        public IList<SearchResult> Results { get; set; }
        public int? Count { get; set; }
        public string Token { get; set; }
        public List<object> Tags { get; set; }

    }
}
