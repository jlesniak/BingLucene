using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuceneWrapper.Models;

namespace LuceneWrapper.Writer
{
    public class LuceneWriter : BaseWriter
    {
        public LuceneWriter(string dataFolder)
            : base(dataFolder)
        {
        }

        //public void AddUpdateDataToIndex(LuceneData data)
        //{
        //    AddUpdateItemsToIndex(new List<LuceneDocument> {(LuceneDocument) data};
        //}

        public void AddUpdateDataToIndex(IEnumerable<LuceneData> data)
        {
            AddUpdateItemsToIndex(data.Select(d => (LuceneDocument) d).ToList());
        }

        //public void DeleteDataFromIndex(LuceneData data)
        //{
        //    DeleteItemsFromIndex(new List<LuceneDocument> { (LuceneDocument)data });
        //}

        //public void DeleteDataFromIndex(int id)
        //{
        //    DeleteItemsFromIndex(new List<LuceneDocument> { new LuceneDocument { Id = id } });
        //}
    }
}