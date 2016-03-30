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

            string fullIDKey;
            fullIDKey = txt_NameID.Text + userIDnum;

            string blogPost;
            blogPost = txt_BlogText.Text;

            addToBlogStore(fullIDKey, blogPost);
        }

        private void addToBlogStore(string fullIDKey, string blogPost)
        {
            blogStore.Add(fullIDKey, blogPost);
        }
    }
}
