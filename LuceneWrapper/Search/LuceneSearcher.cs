using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuceneWrapper.Writer;

namespace LuceneWrapper.Search
{
    public class LuceneSearcher : BaseSearcher
    {
        public LuceneSearcher(string dataFolder) : base(dataFolder)
        {
        }

        public SearchResult SearchData(string searchTerm, string field)
        {
            return Search<LuceneDocument>(field, searchTerm);
        }
    }
}
