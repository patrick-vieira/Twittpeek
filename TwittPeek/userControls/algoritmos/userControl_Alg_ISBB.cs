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
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_ISBB(mainTwittPeek oTwittpeek)
        {
            InitializeComponent();

            oMainTwittpeek = oTwittpeek;
                        
            mMostraDados();
        }
        
        void mMostraDados()
        {
            dataGridViewDados.ClearSelection();
            dataGridViewDados.DataSource = oMainTwittpeek.preencheGrid(oMainTwittpeek.arrTweets);
        }
        /// <summary>
        /// executa o ordenamento e retorna o tempo gasto em ticks
        /// </summary>
        /// <param name="sCampo">Campo da struct que deseja usar como chave</param>
        /// <param name="nSize">quantidade de elementos 100, 1000 ou 10000</param>
        /// <returns>ticks de um DateTime</returns>
        public long executar(string sCampo, int nSize)
        {
            oMainTwittpeek.mCarregaDados(nSize);

            long oStart = DateTime.Now.Ticks;

            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, sCampo);

            TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - oStart);

            return (long)elapsedSpan.TotalMilliseconds;
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
                loc = busca_binaria(oTweets, selected, 0, j, sChave);

                // Move all elements after location to create space
                while (j >= loc)
                {
                    oTweets[j + 1] = oTweets[j];
                    j--;
                }
                oTweets[j + 1] = selected;
            }

        }

        int busca_binaria(mainTwittPeek.Tweets[] oTweets, mainTwittPeek.Tweets item, int low, int high, string sChave)
        {
            if (high <= low)
                return ((int)item.getField(sChave) > (int)oTweets[low].getField(sChave)) ? (low + 1) : low;

            int mid = (low + high) / 2;

            if (item.getField(sChave) == oTweets[mid].getField(sChave))
                return mid + 1;

            if ((int)item.getField(sChave) > (int)oTweets[mid].getField(sChave))
                return busca_binaria(oTweets, item, mid + 1, high, sChave);
            return busca_binaria(oTweets, item, low, mid - 1, sChave);
        }
        

        private void btnExecutar_Click(object sender, EventArgs e)
        {   
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, "PublishedTweetLength");
            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
            
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, "index");
            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, "ID");
            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, "RetweetCount");
            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            insercao_direta_busca_binaria(oMainTwittpeek.arrTweets, "FavoriteCount");
            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();
            mMostraDados();
        }

        private void btnCarrega100_Click(object sender, EventArgs e)
        {
            oMainTwittpeek.mCarregaDados(100);
            mMostraDados();
        }

        private void btnCarrega1000_Click(object sender, EventArgs e)
        {
            oMainTwittpeek.mCarregaDados(1000);
            mMostraDados();
        }

        private void btnCarrega10000_Click(object sender, EventArgs e)
        {
            oMainTwittpeek.mCarregaDados(10000);
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
    }
}
