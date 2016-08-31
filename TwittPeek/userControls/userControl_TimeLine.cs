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
    public partial class userControl_TimeLine : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_TimeLine(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();
            oClassMainTweetinvi = Tweetinvi;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            int numTwittsToGet = 10;

            int.TryParse(txtNumTwittsToGet.Text, out numTwittsToGet);

            dataGridViewTimeLine.DataSource = oClassMainTweetinvi.mGetHomeTimeline(numTwittsToGet);
        }
    
    }
}
