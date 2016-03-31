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
        public Form1()
        {
            InitializeComponent();
        }

        //setting up a hashtable to store the blogs
        Hashtable blogStore = new Hashtable();

        int userIDnum = 0;

        private void btn_BlogSubmit_Click(object sender, EventArgs e)
        {
            //incrementing the ID number up by one
            //NOTE: this is a unique ID for the entry 
            userIDnum++;

            //getting and storing the blog post
            string blogPost;
            blogPost = txt_BlogText.Text;

            string fullBlogPost;
            fullBlogPost = blogPost +", "+ txt_NameID.Text;

            addToBlogStore(userIDnum, fullBlogPost);
        }

        private void addToBlogStore(int userIDnum, string fullBlogPost)
        {
            blogStore.Add(userIDnum, fullBlogPost);
            txt_NameID.Text = String.Empty;
            txt_BlogText.Text = String.Empty;
        }

        private void btn_BlogSearch_Click(object sender, EventArgs e)
        {
            bool found;
            found = false;

            string everything = "everything";
            found = everything.Contains(txt_BlogSearchBox.Text);
            //clearing out the listbox to make it look all purty and clean
            lbox_BlogSearchResults.Items.Clear();

            //adding everything to listbox when nothing is entered
            foreach (DictionaryEntry blogEntry in blogStore)
            {
                if (txt_BlogSearchBox.Text != "")
                {
                    if (blogStore.ContainsValue(txt_BlogSearchBox.Text))
                    {
                        lbox_BlogSearchResults.Items.Add(blogStore[txt_BlogSearchBox.Text]);
                    }
                    
                }
                else
                {
                lbox_BlogSearchResults.Items.Add(blogEntry.Key + " | " + blogEntry.Value);
                }
            }
        }

        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            txt_BlogSearchBox.Text = String.Empty;
        }
    }
}
