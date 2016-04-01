using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BlogStorage_CollectionsEx2_
{
    public partial class Form1 : Form
    {
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        //setting up a hashtable to store the blogs
        Dictionary<string, string> blogStore = new Dictionary<string,string>();

        int postID = 0;

        private void btn_BlogSubmit_Click(object sender, EventArgs e)
        {
            //incrementing the ID number up by one
            //NOTE: this is a unique ID for the entry 
            postID++;

            //getting and storing the blog post
            string blogPost;
            blogPost = txt_BlogText.Text;

            //taking in the user's name
            string userName = txt_NameID.Text;
            
            //generating the full userID
            string fullUserID;
            fullUserID = userName + postID;

            addToBlogStore(fullUserID, blogPost);
        
            //adding the keys to the combo box
            foreach (KeyValuePair<string,string> blogPosts in blogStore)
            {
                cboBox_BlogSearchBox.Items.Add(blogPosts.Key);
            }
        }

        private void addToBlogStore(string fullUserID, string blogPost)
        {
            blogStore.Add(fullUserID, blogPost);
            txt_NameID.Text = String.Empty;
            txt_BlogText.Text = String.Empty;
        }

        private void btn_BlogSearch_Click(object sender, EventArgs e)
        {
            
            //bool found;
            //found = false;

            //found = txt_BlogSearchBox.Text.Contains(everything);
            ////clearing out the listbox to make it look all purty and clean
            //lbox_BlogSearchResults.Items.Clear();

            ////adding everything to listbox when nothing is entered
            //foreach (DictionaryEntry blogEntry in blogStore)
            //{
            //    string searchTerm = txt_BlogSearchBox.Text;
            //    if (txt_BlogSearchBox.Text != "")
            //    {
            //        if (blogStore.ContainsValue(txt_BlogSearchBox.Text))
            //        {
            //            for (blogEntry)
            //            int blogPostID = Int32.Parse(blogEntry.Key);
            //            lbox_BlogSearchResults.Items.Add(blogStore[txt_BlogSearchBox.Text]);
            //        }
                    
            //    }
            //    else
            //    {
            //    lbox_BlogSearchResults.Items.Add(blogEntry.Key + " | " + blogEntry.Value);
            //    }
            //}



            lbox_BlogSearchResults.Items.Add(blogStore[cboBox_BlogSearchBox.Text]);
        }

        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            lbox_BlogSearchResults.Text = String.Empty;
        }
    }
}
