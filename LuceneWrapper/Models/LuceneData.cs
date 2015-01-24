using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneWrapper.Models
{
    public class LuceneData
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public float Score { get; set; }
    }
}