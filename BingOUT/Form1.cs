using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private MyBing mb = new MyBing(Properties.Settings.Default.BingKey);
        private int counter = 0;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!checkBoxDoNotClear.Checked)
            {
                mb.myResults.resultList.Clear();
            }
            if (radioButtonTxt.Checked)
            {
                mb.Search(textBoxQuery.Text, counter, BingSearchMode.Web);
                richTextBox1.Text = mb.myResults.GetResultsToList;
            }
            else
            {
                mb.Search(textBoxQuery.Text, counter, BingSearchMode.Image);
                richTextBox1.Text = mb.myResults.GetResultsToList;
            }
            LabelResults.Text = "Results: " + mb.myResults.resultList.Count.ToString();
            labelQueries.Text = "Queries: " + mb.myResults.Queryid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mb.myResults.resultList.Clear();
            richTextBox1.Text = "";
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}