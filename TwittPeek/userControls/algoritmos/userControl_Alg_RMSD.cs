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
    public partial class userControl_Alg_RMSD : UserControl
    {
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_RMSD(mainTwittPeek oTwittpeek)
        {
            InitializeComponent();

            oMainTwittpeek = oTwittpeek;

            mMostraDados();
        }

        private void mMostraDados()
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

            RadixSort(oMainTwittpeek.arrTweets, sCampo);

            return DateTime.Now.Ticks - oStart;
        }

        static void RadixSort(mainTwittPeek.Tweets[] oTweets, string sChave)
        {
            int i;
            mainTwittPeek.Tweets maior = oTweets[0]; //assume que o maior é o primeiro
            int exp = 1;

            mainTwittPeek.Tweets[] b = new mainTwittPeek.Tweets[oTweets.Length];

            for (i = 0; i < oTweets.Length; i++)
            {
                if ((int)oTweets[i].getField(sChave) > (int)maior.getField(sChave)) // tenta achar um novo maior no vetor
                    maior = oTweets[i];
            }

            while ((int)maior.getField(sChave) / exp > 0)
            {
                int[] bucket = new int[oTweets.Length];
                for (i = 0; i < oTweets.Length; i++)
                    bucket[((int)oTweets[i].getField(sChave) / exp) % 10]++; //contagem o simbolo % é tipo um limitador se a divisão for maior que 10 subtrai 10, ex 55/5 = 11, (55/5)%10 = 1
                for (i = 1; i < 10; i++)
                    bucket[i] += bucket[i - 1];
                for (i = oTweets.Length - 1; i >= 0; i--)
                    b[--bucket[((int)oTweets[i].getField(sChave) / exp) % 10]] = oTweets[i];
                for (i = 0; i < oTweets.Length; i++)
                    oTweets[i] = b[i];
                exp *= 10;
            }
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            RadixSort(oMainTwittpeek.arrTweets, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            RadixSort(oMainTwittpeek.arrTweets, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            RadixSort(oMainTwittpeek.arrTweets, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            RadixSort(oMainTwittpeek.arrTweets, "FavoriteCount");

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }


        static void RadixSort(int[] vetor)
        {
            int i;
            int[] b;
            int maior = vetor[0]; //assume que o maior é o primeiro
            int exp = 1;

            b = new int[vetor.Length];

            for (i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior) // tenta achar um novo maior no vetor
                    maior = vetor[i];
            }

            while (maior / exp > 0)
            {
                int[] bucket = new int[vetor.Length];
                for (i = 0; i < vetor.Length; i++)
                    bucket[(vetor[i] / exp) % 10]++; //contagem o simbolo % é tipo um limitador se a divisão for maior que 10 subtrai 10, ex 55/5 = 11, (55/5)%10 = 1
                for (i = 1; i < 10; i++)
                    bucket[i] += bucket[i - 1];
                for (i = vetor.Length - 1; i >= 0; i--)
                    b[--bucket[(vetor[i] / exp) % 10]] = vetor[i];
                for (i = 0; i < vetor.Length; i++)
                    vetor[i] = b[i];
                exp *= 10;
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

            RadixSort(arrArrayTeste);

            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }
            
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

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
