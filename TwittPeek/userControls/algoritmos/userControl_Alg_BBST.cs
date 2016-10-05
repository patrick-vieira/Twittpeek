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
    public partial class userControl_Alg_BBST : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek.Tweets[] oTweets;

        public userControl_Alg_BBST(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;

            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);

            mMostraDados();
        }

        void bubblesort(mainTwittPeek.Tweets[] oTweets)
        {
            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (oTweets[j].PublishedTweetLength > oTweets[j + 1].PublishedTweetLength)
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }
        }
        int[] bubblesort(int[] vetor, int tamanho)
        {
            int i, j, temp;
            for (i = tamanho - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
            return vetor;
        }

        bool mMostraDados()
        {
            if (oTweets == null)
                return false;

            DataTable oTable = new DataTable("ISBL100");

            //melhorar isso aqui tbm, da pra fazer em poucas linhas, assim ta muito feio

            oTable.Columns.Add("index", typeof(int));
            oTable.Columns.Add("ID", typeof(long));

            oTable.Columns.Add("CreatedAt", typeof(string));
            oTable.Columns.Add("Text", typeof(string));
            oTable.Columns.Add("FullText", typeof(string));
            oTable.Columns.Add("Source", typeof(string));
            oTable.Columns.Add("CreatedBy", typeof(string));

            oTable.Columns.Add("RetweetCount", typeof(int));
            oTable.Columns.Add("Favorited", typeof(bool));
            oTable.Columns.Add("FavoriteCount", typeof(int));
            oTable.Columns.Add("Retweeted", typeof(bool));

            oTable.Columns.Add("Language", typeof(string));

            oTable.Columns.Add("PublishedTweetLength", typeof(int));
            oTable.Columns.Add("TweetLocalCreationDate", typeof(string));
            oTable.Columns.Add("IsRetweet", typeof(bool));
            oTable.Columns.Add("IsTweetPublished", typeof(bool));
            oTable.Columns.Add("IsTweetDestroyed", typeof(bool));
            oTable.Columns.Add("Url", typeof(string));


            foreach (mainTwittPeek.Tweets oTweet in oTweets)
            {
                oTable.Rows.Add(oTweet.all);
            }

            dataGridViewDados.DataSource = oTable;

            return true;

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

            bubblesort(arrArrayTeste, arrArrayTeste.Length);

            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            bubblesort(oTweets);

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

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

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (oTweets[j].index > oTweets[j + 1].index)
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }


            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (oTweets[j].ID > oTweets[j + 1].ID)
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (oTweets[j].RetweetCount > oTweets[j + 1].RetweetCount)
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (oTweets[j].FavoriteCount > oTweets[j + 1].FavoriteCount)
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }
    }
}
