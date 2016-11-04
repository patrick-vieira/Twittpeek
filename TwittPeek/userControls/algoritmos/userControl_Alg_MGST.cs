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
    public partial class userControl_Alg_MGST : UserControl
    {
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_MGST(mainTwittPeek oTwittpeek)
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

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, sCampo);

            TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - oStart);

            return (long)elapsedSpan.TotalMilliseconds;
        }

        void mergeSort(mainTwittPeek.Tweets[] oTweets, int posicaoInicio, int posicaoFim, string sChave)
        {
            int i, j, k, metadeTamanho;
            mainTwittPeek.Tweets[] oTweetsTemp;

            if (posicaoInicio == posicaoFim)
                return;

            // ordenacao recursiva das duas metades
            metadeTamanho = (posicaoInicio + posicaoFim) / 2;
            mergeSort(oTweets, posicaoInicio, metadeTamanho, sChave);
            mergeSort(oTweets, metadeTamanho + 1, posicaoFim, sChave);

            // intercalacao no vetor temporario t
            i = posicaoInicio;
            j = metadeTamanho + 1;
            k = 0;

            oTweetsTemp = new mainTwittPeek.Tweets[posicaoFim - posicaoInicio + 1];

            while (i < metadeTamanho + 1 || j < posicaoFim + 1)
            {
                if (i == metadeTamanho + 1)
                { // i passou do final da primeira metade, pegar v[j]
                    oTweetsTemp[k] = oTweets[j];
                    j++;
                    k++;
                }
                else
                {
                    if (j == posicaoFim + 1)
                    { // j passou do final da segunda metade, pegar v[i]
                        oTweetsTemp[k] = oTweets[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        if ((int)oTweets[i].getField(sChave) < (int)oTweets[j].getField(sChave))
                        {
                            oTweetsTemp[k] = oTweets[i];
                            i++;
                            k++;
                        }
                        else
                        {
                            oTweetsTemp[k] = oTweets[j];
                            j++;
                            k++;
                        }
                    }
                }

            }
            // copia vetor intercalado para o vetor original
            for (i = posicaoInicio; i <= posicaoFim; i++)
            {
                oTweets[i] = oTweetsTemp[i - posicaoInicio];
            }
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
            
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, "ID");

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {

            long oStart = DateTime.Now.Ticks;

            mergeSort(oMainTwittpeek.arrTweets, 0, oMainTwittpeek.arrTweets.Length - 1, "FavoriteCount");

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

        void mergeSort(int[] vetor, int posicaoInicio, int posicaoFim)
        {
            int i, j, k, metadeTamanho;
            int[] vetorTemp;

            if (posicaoInicio == posicaoFim)
                return;

            // ordenacao recursiva das duas metades
            metadeTamanho = (posicaoInicio + posicaoFim) / 2;
            mergeSort(vetor, posicaoInicio, metadeTamanho);
            mergeSort(vetor, metadeTamanho + 1, posicaoFim);

            // intercalacao no vetor temporario t
            i = posicaoInicio;
            j = metadeTamanho + 1;
            k = 0;

            vetorTemp = new int[posicaoFim - posicaoInicio + 1];

            while (i < metadeTamanho + 1 || j < posicaoFim + 1)
            {
                if (i == metadeTamanho + 1)
                { // i passou do final da primeira metade, pegar v[j]
                    vetorTemp[k] = vetor[j];
                    j++;
                    k++;
                }
                else
                {
                    if (j == posicaoFim + 1)
                    { // j passou do final da segunda metade, pegar v[i]
                        vetorTemp[k] = vetor[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        if (vetor[i] < vetor[j])
                        {
                            vetorTemp[k] = vetor[i];
                            i++;
                            k++;
                        }
                        else
                        {
                            vetorTemp[k] = vetor[j];
                            j++;
                            k++;
                        }
                    }
                }

            }
            // copia vetor intercalado para o vetor original
            for (i = posicaoInicio; i <= posicaoFim; i++)
            {
                vetor[i] = vetorTemp[i - posicaoInicio];
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

            mergeSort(arrArrayTeste, 0, arrArrayTeste.Length - 1);

            lblArrayTesteResultado.Text = "";

            foreach (int iInterger in arrArrayTeste)
            {
                lblArrayTesteResultado.Text += iInterger.ToString();
            }

        }

    }
}
