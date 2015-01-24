using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public class MyBing
    {
        private static int counter = 0;
        private MyResults results = new MyResults(0);

        /// <summary>
        /// Loads MyBing and forces to enter Bing API KEY
        /// </summary>
        /// <param name="bingKey">bing key</param>
        public MyBing(string bingKey)
        {
            BingKey = bingKey;
        }

        private string BingKey = "";
        public MyResults myResults = new MyResults(counter);

        public List<MyResult> Search(string queryText, int queryid, BingSearchMode mode)
        {
            DBManager db=new DBManager();
            string query = queryText;

            // Create a Bing container.
            string rootUri = "https://api.datamarket.azure.com/Bing/SearchWeb";

            var bingContainer = new Bing.BingSearchContainer(new Uri(rootUri));
            //my key in .config
            var accountKey = BingKey;
            // Configure bingContainer to use your credentials.
            bingContainer.Credentials = new NetworkCredential(accountKey, accountKey);


            if (mode == BingSearchMode.Web)
            {
                var Bweb = bingContainer.Web(query, null, null, null, null, null, null, null);
                var BingResults = Bweb.Execute();

                int i = 0;
                foreach(var result in BingResults)
                {
                    i++;
                    //myResults.addWeb(result.Title, result.Url, result.Description);    
                    myResults.addWeb(result.ID.ToString(), result.Url, result.Description);
                    db.Add(new MyResult(result.ID.ToString(),result.Url,result.Description),i);
                }
            }
            else if (mode == BingSearchMode.Image)
            {
                var Bimg = bingContainer.Image(query, null, null, null, null, null, null);
                var Res = Bimg.Execute();
                foreach (var result in Res)
                {
                    myResults.addImg(result.Title, result.ContentType, result.MediaUrl);

                }
            }
            counter++;
            myResults.Queryid++;
            return myResults.resultList;
        }
    }
}

public enum BingSearchMode
{
    Web,
    Image,
    Video
}

public class MyResults
{
    public int Queryid;
    public MyResults(int queryid)
    {
        Queryid=queryid;
    }
 
    public List<MyResult> resultList = new List<MyResult>();



    public void addWeb(string title, string url, string Description)
    {
        resultList.Add(new MyResult(Queryid, title, url, Description));
    }

    
    
    public void addImg(string title, string contentType, string url)
    {
        resultList.Add(new MyResult(title, contentType, url));
    }

    public string GetResultsToList
    {
        get
        {
            string r = "query #" + Queryid.ToString() + "\n" ;
            for (int a = 0; a < resultList.Count; a++)
            {
                r += resultList[a].Title + "\n" + resultList[a].Url + "\n" + resultList[a].ContentType +
                    resultList[a].Description+"\n"+
                    "\n------------\n";
            }
            r += "EOF\n";
            return r;

        }
    }
}

public class MyResult
{
    /// <summary>
    /// for WEB
    /// </summary>
    /// <param name="queryid"></param>
    /// <param name="title"></param>
    /// <param name="url"></param>
    public MyResult(int queryid, string title, string url, string descr)
    {
        ResultDate = DateTime.Now;
        QueryID = queryid;
        Title = title;
        Url = url;
        Description = descr;
    }


    /// <summary>
    /// for Image
    /// </summary>
    /// <param name="queryid"></param>
    /// <param name="title"></param>
    /// <param name="contenttype"></param>
    /// <param name="url"></param>
    public MyResult(string title, string contenttype, string url)
    {
        ResultDate = DateTime.Now;
        QueryID = 0;
        Title = title;
        Url = url;
        ContentType = contenttype;
    }

    public DateTime ResultDate;
    public int QueryID;
    public string Title;
    public string ContentType;
    public string Url;
    public string Description;
}