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
    public partial class userControl_GetFollowing : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_GetFollowing(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();
            oClassMainTweetinvi = Tweetinvi;
            dataGridViewFollowing.DataSource = oClassMainTweetinvi.mGetFollowing();
        }
    }
}
