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
using TwittPeek.userControls.algoritmos;


namespace TwittPeek
{
    //Cpd2016/2 Senha email twittpeek@mail.com
    public partial class frmTweetPeek : Form
    {

        csMainTweetinvi oClassMainTweetinvi;

        public static frmDados frmDados;

        private static userControl_SendTwitt oUserControl_SendTwitt;
        private static userControl_TimeLine oUserControl_TimeLine;
        private static userControl_GetFollowing oUserControl_GetFollowing;
        private static userControl_SearchTweet oUserControl_SearchTweet;
                
        private static userControl_Alg_ISBL oUserControl_Alg_ISBL;
        private static userControl_Alg_ISBB oUserControl_Alg_ISBB;
        private static userControl_Alg_SHST oUserControl_Alg_SHST;
        private static userControl_Alg_BBST oUserControl_Alg_BBST;
        private static userControl_Alg_QSRM oUserControl_Alg_QSRM;
        private static userControl_Alg_MGST oUserControl_Alg_MGST;
        private static userControl_Alg_HPST oUserControl_Alg_HPST;
        private static userControl_Alg_RMSD oUserControl_Alg_RMSD;

        private void inicializaUserControls()
        {
            frmDados = new frmDados();

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


            oUserControl_Alg_ISBL = new userControl_Alg_ISBL(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_ISBL);
            oUserControl_Alg_ISBL.Dock = DockStyle.Fill;
            oUserControl_Alg_ISBL.Hide();

            oUserControl_Alg_ISBB = new userControl_Alg_ISBB(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_ISBB);
            oUserControl_Alg_ISBB.Dock = DockStyle.Fill;
            oUserControl_Alg_ISBB.Hide();

            oUserControl_Alg_SHST = new userControl_Alg_SHST(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_SHST);
            oUserControl_Alg_SHST.Dock = DockStyle.Fill;
            oUserControl_Alg_SHST.Hide();

            oUserControl_Alg_QSRM = new userControl_Alg_QSRM(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_QSRM);
            oUserControl_Alg_QSRM.Dock = DockStyle.Fill;
            oUserControl_Alg_QSRM.Hide();

            oUserControl_Alg_BBST = new userControl_Alg_BBST(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_BBST);
            oUserControl_Alg_BBST.Dock = DockStyle.Fill;
            oUserControl_Alg_BBST.Hide();

            oUserControl_Alg_MGST = new userControl_Alg_MGST(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_MGST);
            oUserControl_Alg_MGST.Dock = DockStyle.Fill;
            oUserControl_Alg_MGST.Hide();

            oUserControl_Alg_HPST = new userControl_Alg_HPST(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_HPST);
            oUserControl_Alg_HPST.Dock = DockStyle.Fill;
            oUserControl_Alg_HPST.Hide();

            oUserControl_Alg_RMSD = new userControl_Alg_RMSD(oClassMainTweetinvi);
            pnlMain.Controls.Add(oUserControl_Alg_RMSD);
            oUserControl_Alg_RMSD.Dock = DockStyle.Fill;
            oUserControl_Alg_RMSD.Hide();

            

    }

        /// <summary>
        /// Função para mostrar no formulario principal o userControl passado pelo parametro
        /// </summary>
        /// <param name="oShowControl">userControl que vai ser mostrado</param>
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

        private void buscaLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_ISBL);
        }

        private void buscaBináriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_ISBB);
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_SHST);
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_BBST);
        }

        private void quickSortRandomizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_QSRM);
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_MGST);
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_HPST);
        }

        private void radixSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(oUserControl_Alg_RMSD);
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDados.Show();
        }
    }
}
