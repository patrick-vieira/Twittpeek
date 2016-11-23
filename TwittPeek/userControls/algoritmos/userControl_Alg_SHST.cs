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
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_SHST(mainTwittPeek oTwittpeek)
        {
            InitializeComponent();

            oMainTwittpeek = oTwittpeek;

            mMostraDados();
        }


        void mMostraDados()
        {
            dataGridViewDados.ClearSelection();
            dataGridViewDados.DataSource = oMainTwittpeek.preencheGrid();
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

            shellSort(oMainTwittpeek.arrTweets, sCampo);

            TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - oStart);

            return (long)elapsedSpan.TotalMilliseconds; 
        }

        void shellSort(mainTwittPeek.Tweets[] oTweets, string sChave)
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
                    while (j >= 0 && (int)value.getField(sChave) < (int)oTweets[j].getField(sChave))
                    {
                        oTweets[j + gap] = oTweets[j];
                        j -= gap;
                    }
                    oTweets[j + gap] = value;
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {     
            long oStart = DateTime.Now.Ticks;

            shellSort(oMainTwittpeek.arrTweets, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
            
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            shellSort(oMainTwittpeek.arrTweets, "ID");
            

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            shellSort(oMainTwittpeek.arrTweets, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            shellSort(oMainTwittpeek.arrTweets, "FavoriteCount");

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            
            shellSort(oMainTwittpeek.arrTweets, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

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

    }
}
