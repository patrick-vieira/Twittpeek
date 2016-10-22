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
            /*
            int[] a = {37, 23, 0, 17, 12, 72, 31,
              46, 100, 88, 54};

            int n = a.Length;
            int i;

            insertionSort(a, a.Length);

            lblArrayTeste.Text = "Sorted array:";
            for (i = 0; i < n; i++)
                lblArrayTeste.Text += a[i] + " ";
            */

            int[] arrArrayTeste = new int[10];

            int cont = 0, temp;

            foreach (char cChar in lblArrayTeste.Text)
            {
                int.TryParse(cChar.ToString(), out temp);
                arrArrayTeste[cont] = temp;
                cont++;
            }
            
            lblArrayTesteResultado.Text = "";

            insertionSort(arrArrayTeste, arrArrayTeste.Length);

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }
        }

        int binarySearch(int[] a, int item, int low, int high)
        {
            if (high <= low)
                return (item > a[low]) ? (low + 1) : low;

            int mid = (low + high) / 2;

            if (item == a[mid])
                return mid + 1;

            if (item > a[mid])
                return binarySearch(a, item, mid + 1, high);
            return binarySearch(a, item, low, mid - 1);
        }


        // Function to sort an array a[] of size 'n'
        void insertionSort(int[] a, int n)
        {
            int i, loc, j, selected;

            for (i = 1; i < n; ++i)
            {
                j = i - 1;
                selected = a[i];

                // find location where selected sould be inseretd
                loc = binarySearch(a, selected, 0, j);

                // Move all elements after location to create space
                while (j >= loc)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = selected;
            }
        }

        int binarySearch(mainTwittPeek.Tweets[] oTweets, mainTwittPeek.Tweets item, int low, int high, string sChave)
        {
            if (high <= low)
                return ((int)item.getField(sChave) > (int)oTweets[low].getField(sChave)) ? (low + 1) : low;

            int mid = (low + high) / 2;

            if (item.getField(sChave) == oTweets[mid].getField(sChave))
                return mid + 1;

            if ((int)item.getField(sChave) > (int)oTweets[mid].getField(sChave))
                return binarySearch(oTweets, item, mid + 1, high, sChave);
            return binarySearch(oTweets, item, low, mid - 1, sChave);
        }

        void insercao_direta_busca_binaria(mainTwittPeek.Tweets[] oTweets, string sChave)
        {
            int i, loc, j;

            mainTwittPeek.Tweets selected;

            for (i = 1; i < oTweets.Length; ++i)
            {
                j = i - 1;
                selected = oTweets[i];

                // find location where selected sould be inseretd
                loc = binarySearch(oTweets, selected, 0, j, sChave);

                // Move all elements after location to create space
                while (j >= loc)
                {
                    oTweets[j + 1] = oTweets[j];
                    j--;
                }
                oTweets[j + 1] = selected;
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

        private void btnExecutar_Click(object sender, EventArgs e)
        {
           

            
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oTweets, "PublishedTweetLength");
            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();


        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oTweets, "index");
            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oTweets, "ID");
            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oTweets, "RetweetCount");
            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oTweets, "FavoriteCount");
            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }
    }
}
