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
    public partial class userControl_Alg_ISBL : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek.Tweets[] oTweets;

        public userControl_Alg_ISBL(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;

            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);
            
            mMostraDados();
        }
        

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //imprime_tweets(oTweets);            

            long oStart = DateTime.Now.Ticks;            

            insercao_direta(oTweets);

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();

            //imprime_tweets(oTweets);
        }

        void imprime_tweets(mainTwittPeek.Tweets[] oTweets)
        {
            int i = 0;

            Console.WriteLine("TWEETS!\n");

            foreach (mainTwittPeek.Tweets oTweet in oTweets)
            {
                Console.WriteLine("chave = {0} ID = {1} PublishedTweetLength = {2}", i, oTweet.ID.ToString(), oTweet.PublishedTweetLength);
                i++;
            }
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






        //Esses caras vão sair, coloquei na mão só pra testar o ordenamento com chaves diferentes

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            if (oTweets == null)
                return;

            int i, j;
            mainTwittPeek.Tweets chave;

            long oStart = DateTime.Now.Ticks;

            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;

                while ((i >= 0) && (oTweets[i].ID) > chave.ID)
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            int i, j;
            mainTwittPeek.Tweets chave;

            long oStart = DateTime.Now.Ticks;

            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;

                while ((i >= 0) && (oTweets[i].RetweetCount) > chave.RetweetCount)
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            int i, j;
            mainTwittPeek.Tweets chave;

            long oStart = DateTime.Now.Ticks;

            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;

                while ((i >= 0) && (oTweets[i].FavoriteCount) > chave.FavoriteCount)
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
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

            ins_direta(arrArrayTeste);

            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }

        }

        //algoritmo dos slides, usei ele pra ordenar o vetorzinho
        void ins_direta(int[] C)
        {
            int i, j, chave;
            for (j = 1; j < C.Length; j++)
            {
                chave = C[j];

                i = j - 1;

                while ((i >= 0) && (C[i]) > chave)
                {
                    C[i + 1] = C[i];
                    i--;
                }
                C[i + 1] = chave;
            }

            int a = binarySearch(C, 3, C[1], C[C.Length - 1]);
        }
        int binarySearch(int[] a, int item, int low, int high)
        {
            if (high <= low)
                return (item > a[low]) ? (low + 1) : low;

            int mid = (low + high) / 2;

            if (item == a[mid])
                return mid + 1;

            if (item > a[mid])
                return binarySearch(a, item, mid + 1, high);//faz o corte para cima [56789]
            return binarySearch(a, item, low, mid - 1); //faz o corte para baixo [01234]
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
            int i, j;
            mainTwittPeek.Tweets chave;

            long oStart = DateTime.Now.Ticks;

            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;

                while ((i >= 0) && (oTweets[i].index) > chave.index)
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }
    }
}
