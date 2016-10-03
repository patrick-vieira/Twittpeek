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


        void mMostraDados()
        {
            DataTable oTable = new DataTable("ISBL100");

            //melhorar isso aqui tbm, da pra fazer em poucas linhas, assim ta muito feio
                        
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

            dataGridView1.DataSource = oTable;

        }






        //Esses caras vão sair, coloquei na mão só pra testar o ordenamento com chaves diferentes

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
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
        }

    }
}
