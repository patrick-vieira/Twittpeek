using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwittPeek.userControls
{
    public partial class userControl_SearchTweet : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_SearchTweet(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             dataGridViewSearchTwieet.DataSource = oClassMainTweetinvi.mSearchTweets(txtKeyWord.Text);
        }
    }
}
