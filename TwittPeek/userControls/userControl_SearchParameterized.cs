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
    public partial class userControl_SearchParameterized : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek oMainTwittPeek;
        public userControl_SearchParameterized(csMainTweetinvi tweetinvi, mainTwittPeek twittPeek)
        {
            InitializeComponent();

            oClassMainTweetinvi = tweetinvi;
            oMainTwittPeek = twittPeek;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string sSearch = txtKeyWord.Text;

            int maxNumberOfResults;
            int.TryParse(txtMaxNumberOfResults.Text, out maxNumberOfResults);

            DateTime Since = dateTimePickerSince.Value;
            DateTime Until = dateTimePickerUntil.Value;

            double latitude;
            double.TryParse(txtLatitude.Text, out latitude);

            double longitude;
            double.TryParse(txtLongitude.Text, out longitude);
            
            double radius;
            double.TryParse(txtRadius.Text, out radius);

            oMainTwittPeek.mCarregaDados(oClassMainTweetinvi.mSearchTweets(sSearch, maxNumberOfResults, Since, Until, latitude, longitude, radius));
            
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid();
        }
    }
}
