using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Data.Database.Model;
using LuceneWrapper.Models;

namespace WindowsFormsApplication1.Classes
{
    internal class DBManager
    {
        private LuceneDataEntities db;

        public void Add(LuceneData data, int rank)
        {
            using (db = new LuceneDataEntities())
            {
                var res = new Result();
                res.Description = data.Question;
                res.Rank = rank;
                res.Score = data.Score;
                res.Engine = "Lucene";
                res.Title = data.Answer;
                db.Result.Add(res);
                db.SaveChanges();
            }
        }

        public void Add(MyResult data, int rank)
        {
            using (var db = new LuceneDataEntities())
            {
                var res = new Result();
                res.Description = data.Description;
                res.Rank = rank;
                res.Engine = "Bing";
                res.Title = data.Title;
                db.Result.Add(res);
                db.SaveChanges();
            }
        }
    }

    public enum Engine
    {
        Bing = 0,
        Lucene
    };
}