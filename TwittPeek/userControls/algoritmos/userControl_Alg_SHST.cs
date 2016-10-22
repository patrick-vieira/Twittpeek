using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwittPeek.userControls.algoritmos
{
    public partial class userControl_Alg_SHST : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek.Tweets[] oTweets;

        public userControl_Alg_SHST(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;

            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);
            
            mMostraDados();
        }


        void insercao_direta(mainTwittPeek.Tweets[] oTweets)
        {
            int i, j;
            mainTwittPeek.Tweets chave;
            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;
                //ver como pegar o campo da struct dinamicamente tipo oTweets[i]["ID"] assim podemos ordenar por qualquer campo usando o mesmo algoritmo
                while ((i >= 0) && (oTweets[i].PublishedTweetLength) > chave.PublishedTweetLength)
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }
        }

        void shellSort(mainTwittPeek.Tweets[] oTweets)
        {
            int i, j;
            mainTwittPeek.Tweets value;

            int gap = 1;
            while (gap < oTweets.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < oTweets.Length; i++)
                {
                    value = oTweets[i];
                    j = i - gap;
                    while (j >= 0 && value.PublishedTweetLength < oTweets[j].PublishedTweetLength)
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }
        }

        void shellSort(int[] vet, int size)
        {
            int i, j, value;
            int gap = 1;
            while (gap < size)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < size; i++)
                {
                    value = vet[i];
                    j = i - gap;
                    while (j >= 0 && value < vet[j])
                    {
                        vet[j + gap] = vet[j];
                        j -= gap;
                    }
                    vet[j + gap] = value;
                }
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

            shellSort(arrArrayTeste, arrArrayTeste.Length);

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

            shellSort(oTweets);

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
            
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets value;

            int gap = 1;
            while (gap < oTweets.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < oTweets.Length; i++)
                {
                    value = oTweets[i];
                    j = i - gap;
                    while (j >= 0 && value.ID < oTweets[j].ID)
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets value;

            int gap = 1;
            while (gap < oTweets.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < oTweets.Length; i++)
                {
                    value = oTweets[i];
                    j = i - gap;
                    while (j >= 0 && value.RetweetCount < oTweets[j].RetweetCount)
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets value;

            int gap = 1;
            while (gap < oTweets.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < oTweets.Length; i++)
                {
                    value = oTweets[i];
                    j = i - gap;
                    while (j >= 0 && value.FavoriteCount < oTweets[j].FavoriteCount)
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets value;

            int gap = 1;
            while (gap < oTweets.Length)
            {
                gap = 3 * gap + 1;
            }
            while (gap > 1)
            {
                gap /= 3;
                for (i = gap; i < oTweets.Length; i++)
                {
                    value = oTweets[i];
                    j = i - gap;
                    while (j >= 0 && value.index < oTweets[j].index)
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

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
