namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
            this.radioButtonImg = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelResults = new System.Windows.Forms.Label();
            this.labelQueries = new System.Windows.Forms.Label();
            this.checkBoxDoNotClear = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(237, 64);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Search";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(12, 67);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(219, 20);
            this.textBoxQuery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Search, powered by Bing";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 177);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 172);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // radioButtonTxt
            // 
            this.radioButtonTxt.AutoSize = true;
            this.radioButtonTxt.Checked = true;
            this.radioButtonTxt.Location = new System.Drawing.Point(12, 106);
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTxt.TabIndex = 7;
            this.radioButtonTxt.TabStop = true;
            this.radioButtonTxt.Text = "Text";
            this.radioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // radioButtonImg
            // 
            this.radioButtonImg.AutoSize = true;
            this.radioButtonImg.Location = new System.Drawing.Point(70, 106);
            this.radioButtonImg.Name = "radioButtonImg";
            this.radioButtonImg.Size = new System.Drawing.Size(54, 17);
            this.radioButtonImg.TabIndex = 8;
            this.radioButtonImg.Text = "Image";
            this.radioButtonImg.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelResults
            // 
            this.LabelResults.AutoSize = true;
            this.LabelResults.Location = new System.Drawing.Point(12, 161);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(54, 13);
            this.LabelResults.TabIndex = 10;
            this.LabelResults.Text = "Results: 0";
            // 
            // labelQueries
            // 
            this.labelQueries.AutoSize = true;
            this.labelQueries.Location = new System.Drawing.Point(89, 161);
            this.labelQueries.Name = "labelQueries";
            this.labelQueries.Size = new System.Drawing.Size(55, 13);
            this.labelQueries.TabIndex = 11;
            this.labelQueries.Text = "Queries: 0";
            // 
            // checkBoxDoNotClear
            // 
            this.checkBoxDoNotClear.AutoSize = true;
            this.checkBoxDoNotClear.Checked = true;
            this.checkBoxDoNotClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDoNotClear.Location = new System.Drawing.Point(237, 93);
            this.checkBoxDoNotClear.Name = "checkBoxDoNotClear";
            this.checkBoxDoNotClear.Size = new System.Drawing.Size(125, 17);
            this.checkBoxDoNotClear.TabIndex = 12;
            this.checkBoxDoNotClear.Text = "Do Not Clear Results";
            this.checkBoxDoNotClear.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "demo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxDoNotClear);
            this.Controls.Add(this.labelQueries);
            this.Controls.Add(this.LabelResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonImg);
            this.Controls.Add(this.radioButtonTxt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form1";
            this.Text = "BingOUT MZ303, WWSI 2015";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonTxt;
        private System.Windows.Forms.RadioButton radioButtonImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelResults;
        private System.Windows.Forms.Label labelQueries;
        private System.Windows.Forms.CheckBox checkBoxDoNotClear;
        private System.Windows.Forms.Button button2;
    }
}

