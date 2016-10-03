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
    public partial class userControl_Alg_ISBB : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek.Tweets[] oTweets;

        public userControl_Alg_ISBB(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            oClassMainTweetinvi = Tweetinvi;

            oTweets = (mainTwittPeek.Tweets[])frmTweetPeek.frmDados.mGetDados(100);
            
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
            
            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }
        }
        


        void insercao_direta_busca_binaria(mainTwittPeek.Tweets[] oTweets)
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
    }
}
