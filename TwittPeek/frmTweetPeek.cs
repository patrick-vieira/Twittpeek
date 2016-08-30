using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TwittPeek
{
    //Cpd2016/2 Senha email twittpeek@mail.com
    public partial class frmTweetPeek : Form
    {

        csMainTweetinvi oClassMainTweetinvi;
        int nCountChar = 140;
        
        public frmTweetPeek()
        {
            InitializeComponent();

            oClassMainTweetinvi = new csMainTweetinvi();

            oClassMainTweetinvi.startApplication();

            dataGridViewFollowing.DataSource = oClassMainTweetinvi.mGetFollowing();
        }

        private void btnTweetPost_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status info:";

            if (oClassMainTweetinvi.mPostTwitt(txtTweetBox.Text))
            {
                lblStatus.Text += " Texto publicado!";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text += " Falha ao publicar texto!";
                lblStatus.ForeColor = Color.Red;
            }

        }

        private void txtTweetBox_TextChanged(object sender, EventArgs e)
        {
            if (txtTweetBox.TextLength >= nCountChar)
            {
                btnTweetPost.Enabled = false;

                txtTweetBox.ForeColor = Color.Red;
            }
            else
            {
                txtTweetBox.ForeColor = Color.CornflowerBlue;

                btnTweetPost.Enabled = true;
            }

            lblTweetCounter.Text = (nCountChar - txtTweetBox.TextLength).ToString();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            int numTwittsToGet = 10;

            int.TryParse(txtNumTwittsToGet.Text, out numTwittsToGet);

            dataGridViewTimeLine.DataSource = oClassMainTweetinvi.mGetHomeTimeline(numTwittsToGet);
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            oClassMainTweetinvi.mTweetinvi_testes();
        }
    }
}
