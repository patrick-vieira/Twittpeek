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
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_BBST(mainTwittPeek oTwittpeek)
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

            bubblesort(oMainTwittpeek.arrTweets, sCampo);

            TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - oStart);

            return (long)elapsedSpan.TotalMilliseconds;
        }
        void bubblesort(mainTwittPeek.Tweets[] oTweets, string sChave)
        {
            int i, j;
            mainTwittPeek.Tweets temp;
            for (i = oTweets.Length - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if ((int)oTweets[j].getField(sChave)> (int)oTweets[j + 1].getField(sChave))
                    {
                        temp = oTweets[j];
                        oTweets[j] = oTweets[j + 1];
                        oTweets[j + 1] = temp;
                    }
                }
            }
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            bubblesort(oMainTwittpeek.arrTweets, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }


        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            bubblesort(oMainTwittpeek.arrTweets, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            bubblesort(oMainTwittpeek.arrTweets, "ID");

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            bubblesort(oMainTwittpeek.arrTweets, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            bubblesort(oMainTwittpeek.arrTweets, "FavoriteCount");

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


    }
}
