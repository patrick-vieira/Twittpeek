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
using TwittPeek.userControls;


namespace TwittPeek
{
    //Cpd2016/2 Senha email twittpeek@mail.com
    public partial class frmTweetPeek : Form
    {

        csMainTweetinvi oClassMainTweetinvi;

        private static userControl_SendTwitt oUserControl_SendTwitt;
        private static userControl_TimeLine oUserControl_TimeLine;
        private static userControl_GetFollowing oUserControl_GetFollowing;
        private static userControl_SearchTweet oUserControl_SearchTweet;

        private void inicializaUserControls()
        {
            oUserControl_SendTwitt = new userControl_SendTwitt(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_SendTwitt);
            oUserControl_SendTwitt.Dock = DockStyle.Fill;
            oUserControl_SendTwitt.Show();

            oUserControl_TimeLine = new userControl_TimeLine(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_TimeLine);
            oUserControl_TimeLine.Dock = DockStyle.Fill;
            oUserControl_TimeLine.Hide();

            oUserControl_GetFollowing = new userControl_GetFollowing(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_GetFollowing);
            oUserControl_GetFollowing.Dock = DockStyle.Fill;
            oUserControl_GetFollowing.Hide();

            oUserControl_SearchTweet = new userControl_SearchTweet(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_SearchTweet);
            oUserControl_SearchTweet.Dock = DockStyle.Fill;
            oUserControl_SearchTweet.Hide();
            

        }

        private void showUserControl(object oShowControl)
        {
            foreach (Control oControl in pnlMain.Controls)
            {

                if (oControl == oShowControl)
                    oControl.Show();
                else
                    oControl.Hide();

            }
        }

        public frmTweetPeek()
        {
            InitializeComponent();
            
            oClassMainTweetinvi = new csMainTweetinvi();

            oClassMainTweetinvi.startApplication();

            inicializaUserControls();
            
        }

        private void teste11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_SendTwitt);
        }

        private void teste21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_TimeLine);
        }

        private void triggerDeTestesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oClassMainTweetinvi.mTweetinvi_testes();
        }

        private void followingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_GetFollowing);
        }

        private void twittsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            showUserControl(oUserControl_SearchTweet);
        }
    }
}
