using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;
using LuceneWrapper.Models;
using LuceneWrapper.Search;
using LuceneWrapper.Writer;

namespace WindowsFormsApplication1.Classes.SearchEngines
{
    public class MyLucene
    {
        private IEnumerable<LuceneData> data;

        public List<LuceneData> Search(string query)
        {
            DBManager db = new DBManager();
            query = FilterQuery(query);
            List<LuceneData> resultData = new List<LuceneData>();
            data = GetData();
            var dir = AppDomain.CurrentDomain.BaseDirectory + "Data\\LuceneIndex";
            DirectoryInfo dirinfo = new DirectoryInfo(dir);
            if (!dirinfo.Exists)
            {
                var writer = new LuceneWriter(dir);
                writer.AddUpdateDataToIndex(data);
            }

            var searcher = new LuceneSearcher(dir);
            var search = searcher.SearchData(query, "Question");
            int i = 0;
            foreach (var item in search.SearchResultItems)
            {
                i++;
                var luc = new LuceneData();
                item.Id++;
                luc.Score = item.Score;
                luc.Id = data.First(x => x.Id == item.Id).Id;
                luc.Answer = data.First(x => x.Id == item.Id).Answer;
                luc.Question = data.First(x => x.Id == item.Id).Question;
                luc.Category = data.First(x => x.Id == item.Id).Category;
                resultData.Add(luc);
                db.Add(luc, i);
            }
            return resultData;
        }

        public string FilterQuery(string query)
        {
            string res = "";
            var collection = Regex.Matches(query, @"[\S]+");
            var list = collection.Cast<Match>().Select(x => x.Value).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Count() > 3)
                    res += " " + list[i];
            }
            return res;
        }

        private IEnumerable<LuceneData> GetData()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\data.xml";
            var list = new List<LuceneData>();
            var xmldoc = new XmlDataDocument();
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);

            var doc = new XmlDocument();
            doc.LoadXml(xmldoc.InnerXml);

            XmlNodeList node = doc.DocumentElement.SelectNodes("/jeopardy/clue");

            for (int i = 0; i < node.Count; i++)
            {
                LuceneData luc = new LuceneData();
                luc.Id = Convert.ToInt32(node[i].ChildNodes.Item(0).InnerText.Trim());
                luc.Category = node[i].ChildNodes.Item(1).InnerText.Trim();
                luc.Question = node[i].ChildNodes.Item(2).InnerText.Trim();
                luc.Answer = node[i].ChildNodes.Item(3).InnerText.Trim();
                list.Add(luc);
            }
            return list;
        }

        public string GetResultFromLucene(List<LuceneData> list)
        {
            string r = "\n-----LUCENE-------\n";
            for (int i = 0; i < list.Count; i++)
            {
                r += "\n------------\n";
                r += "query #" + list[i].Id + "\n";
                r += list[i].Category + "\n" + list[i].Answer + "\n" + list[i].Question + "\n" + "\n------------\n";
            }
            r += "EOF\n";
            return r;
        }
    }
}