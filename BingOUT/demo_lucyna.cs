using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.SearchEngines;
using LuceneWrapper.Models;

namespace WindowsFormsApplication1
{
    public partial class demo_lucyna : Form
    {
        private MyBing bing;
        private Classes.SearchEngines.MyLucene lucene;

        public demo_lucyna()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bing = new MyBing(Properties.Settings.Default.BingKey);
            lucene = new MyLucene();

            var query = txtQuery.Text;
            if (String.IsNullOrEmpty(query))
                MessageBox.Show("Please insert query.");

            var resBing = bing.Search(query, 0, BingSearchMode.Web);
            txtBoxResult.Text = bing.myResults.GetResultsToList;

            var resLucene = lucene.Search(query);

            txtBoxResult.Text += lucene.GetResultFromLucene(resLucene);

            lblCompare.Text = String.Format("{0}%", CompareResult(resBing, resLucene).ToString());

        }

        private int CompareResult(List<MyResult> listBing, List<LuceneData> listLucene)
        {
            int counter = 0;
            int max = 0;
            if (listBing.Count == 0 || listLucene.Count == 0)
                return 0;

            foreach (var resBing in listBing)
            {
                var text = FilterDescription(resBing.Description);
                max += text.Count;
                for (int i = 0; i < listLucene.Count; i++)
                {
                    max += listLucene.Count;
                    for (int y = 0; y < text.Count; y++)
                    {
                        if (listLucene[i].Question.Contains(text[y]))
                            counter++;
                    }
                }
            }

            var result = (counter*100)/max;

            return result;
        }

        private List<string> FilterDescription(string text)
        {
            var collection = Regex.Matches(text, @"[\S]+");
            return collection.Cast<Match>().Select(x => x.Value).ToList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}