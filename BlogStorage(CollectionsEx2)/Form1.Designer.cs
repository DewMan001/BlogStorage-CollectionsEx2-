namespace BlogStorage_CollectionsEx2_
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
            this.txt_NameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BlogText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BlogSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BlogSearch = new System.Windows.Forms.Button();
            this.txt_BlogSearchBox = new System.Windows.Forms.TextBox();
            this.lbox_BlogSearchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_NameID
            // 
            this.txt_NameID.Location = new System.Drawing.Point(12, 71);
            this.txt_NameID.Name = "txt_NameID";
            this.txt_NameID.Size = new System.Drawing.Size(117, 26);
            this.txt_NameID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type your name";
            // 
            // txt_BlogText
            // 
            this.txt_BlogText.Location = new System.Drawing.Point(135, 71);
            this.txt_BlogText.Name = "txt_BlogText";
            this.txt_BlogText.Size = new System.Drawing.Size(396, 26);
            this.txt_BlogText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type a (brief) blog!";
            // 
            // btn_BlogSubmit
            // 
            this.btn_BlogSubmit.Location = new System.Drawing.Point(12, 103);
            this.btn_BlogSubmit.Name = "btn_BlogSubmit";
            this.btn_BlogSubmit.Size = new System.Drawing.Size(519, 35);
            this.btn_BlogSubmit.TabIndex = 8;
            this.btn_BlogSubmit.Text = "Submit a Blog";
            this.btn_BlogSubmit.UseVisualStyleBackColor = true;
            this.btn_BlogSubmit.Click += new System.EventHandler(this.btn_BlogSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search a blog! (by name of user)";
            // 
            // btn_BlogSearch
            // 
            this.btn_BlogSearch.Location = new System.Drawing.Point(394, 233);
            this.btn_BlogSearch.Name = "btn_BlogSearch";
            this.btn_BlogSearch.Size = new System.Drawing.Size(137, 26);
            this.btn_BlogSearch.TabIndex = 11;
            this.btn_BlogSearch.Text = "Search";
            this.btn_BlogSearch.UseVisualStyleBackColor = true;
            // 
            // txt_BlogSearchBox
            // 
            this.txt_BlogSearchBox.Location = new System.Drawing.Point(12, 233);
            this.txt_BlogSearchBox.Name = "txt_BlogSearchBox";
            this.txt_BlogSearchBox.Size = new System.Drawing.Size(376, 26);
            this.txt_BlogSearchBox.TabIndex = 10;
            // 
            // lbox_BlogSearchResults
            // 
            this.lbox_BlogSearchResults.FormattingEnabled = true;
            this.lbox_BlogSearchResults.ItemHeight = 20;
            this.lbox_BlogSearchResults.Location = new System.Drawing.Point(12, 265);
            this.lbox_BlogSearchResults.Name = "lbox_BlogSearchResults";
            this.lbox_BlogSearchResults.Size = new System.Drawing.Size(519, 144);
            this.lbox_BlogSearchResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_BlogSearch);
            this.Controls.Add(this.txt_BlogSearchBox);
            this.Controls.Add(this.lbox_BlogSearchResults);
            this.Controls.Add(this.btn_BlogSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BlogText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NameID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BlogText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BlogSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_BlogSearch;
        private System.Windows.Forms.TextBox txt_BlogSearchBox;
        private System.Windows.Forms.ListBox lbox_BlogSearchResults;
    }
}

