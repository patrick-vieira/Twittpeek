using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TwittPeek.userControls.algoritmos
{
    public partial class userControl_Alg_QSRM : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek.Tweets[] oTweets;

        public userControl_Alg_QSRM(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;

            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);

            mMostraDados();
        }


        void quicksort(mainTwittPeek.Tweets[] oTweets, int lo, int hi, string sChave)
        {
            int pivo;

            if (lo < hi)
            {
                pivo = particiona(oTweets, lo, hi, sChave);
                quicksort(oTweets, lo, pivo, sChave);
                quicksort(oTweets, pivo + 1, hi, sChave);
            }
        }

        int particiona(mainTwittPeek.Tweets[] oTweets, int lo, int hi, string sChave)
        {
            int pivo = (int)oTweets[lo].getField(sChave);
            int i = lo - 1;
            int j = hi + 1;
            mainTwittPeek.Tweets temp;

            while (true)
            {
                do
                    i++;
                while ((int)oTweets[i].getField(sChave) < pivo);
                do
                    j = j - 1;
                while ((int)oTweets[j].getField(sChave) > pivo);

                if (i >= j)
                    return j;

                temp = oTweets[i];
                oTweets[i] = oTweets[j];
                oTweets[j] = temp;
            }
        }


        void quicksort(int[] vetor, int lo, int hi)
        {
            int pivo;

            if (lo < hi)
            {
                pivo = particiona(vetor, lo, hi);
                quicksort(vetor, lo, pivo);
                quicksort(vetor, pivo + 1, hi);
            }
        }

        int particiona(int[] vetor, int lo, int hi)
        {
            int pivo = vetor[lo];
            int i = lo - 1;
            int j = hi + 1;
            int temp;

            while (true)
            {
                do
                    i++;
                while (vetor[i] < pivo);
                do
                    j = j - 1;
                while (vetor[j] > pivo);

                if (i >= j)
                    return j;

                temp = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = temp;
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int[] arrArrayTeste = new int[10];
            int cont = 0, temp;

            foreach (char cChar in lblArrayTeste.Text)
            {
                int.TryParse(cChar.ToString(), out temp);
                arrArrayTeste[cont] = temp;
                cont++;
            }

            quicksort(arrArrayTeste, 0, arrArrayTeste.Length-1);

            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }
            
        }

        void mMostraDados()
        {
            //dataGridViewDados.DataSource = mainTwittPeek.preencheGrid(oTweets);
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            quicksort(oTweets, 0, oTweets.Length - 1, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            quicksort(oTweets, 0, oTweets.Length - 1, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }


        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            quicksort(oTweets, 0, oTweets.Length - 1, "ID");

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            quicksort(oTweets, 0, oTweets.Length - 1, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();

        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            quicksort(oTweets, 0, oTweets.Length - 1, "FavoriteCount");

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }




        private void btnCarrega100_Click(object sender, EventArgs e)
        {
            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);
            mMostraDados();
        }

        private void btnCarrega1000_Click(object sender, EventArgs e)
        {
            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(1000);
            mMostraDados();
        }

        private void btnCarrega10000_Click(object sender, EventArgs e)
        {
            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(10000);
            mMostraDados();
        }
    }
}
