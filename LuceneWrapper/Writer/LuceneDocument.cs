using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuceneWrapper.Models;

namespace LuceneWrapper.Writer
{
    public class LuceneDocument : ADocument
    {
        private int id;
        private string category;
        private string answer;
        private string question;

        [SearchField]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                AddParameterToDocumentNoStoreParameter("Id", id);
            }
        }

        [SearchField]
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                AddParameterToDocumentNoStoreParameter("Category", category);
            }
        }

        [SearchField]
        public string Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                AddParameterToDocumentNoStoreParameter("Answer", answer);
            }
        }

        [SearchField]
        public string Question
        {
            get { return question; }
            set
            {
                question = value;
                AddParameterToDocumentNoStoreParameter("Question", question);
            }
        }

        public static explicit operator LuceneDocument(LuceneData data)
        {
            return new LuceneDocument()
            {
                Id = data.Id,
                Category = data.Category,
                Question = data.Question,
                Answer = data.Answer
            };
        }
    }
}