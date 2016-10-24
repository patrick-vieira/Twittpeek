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
    public partial class userControl_Alg_HPST : UserControl
    {
        mainTwittPeek oMainTwittpeek;

        private int heapSize;
        private string sChave;

        public userControl_Alg_HPST(mainTwittPeek oTwittpeek)
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

            heapSort(oMainTwittpeek.arrTweets, sCampo);

            return DateTime.Now.Ticks - oStart;            
        }

        private void Swap(mainTwittPeek.Tweets[] oTweets, int x, int y)//troca dois caras de lugar no array
        {
            mainTwittPeek.Tweets temp = oTweets[x];
            oTweets[x] = oTweets[y];
            oTweets[y] = temp;
        }
        private void Heapify(mainTwittPeek.Tweets[] oTweets, int posicao_pai)
        {
            int posicao_filho_esquerdo = 2 * posicao_pai;
            int posicao_filho_direito = 2 * posicao_pai + 1;
            int posicao_maior = posicao_pai;

            if (posicao_filho_esquerdo <= heapSize && (int)oTweets[posicao_filho_esquerdo].getField(sChave) > (int)oTweets[posicao_pai].getField(sChave)) //se o filho esquerdo ta dentro do heap e ele é > que o pai
            {
                posicao_maior = posicao_filho_esquerdo;
            }

            if (posicao_filho_direito <= heapSize && (int)oTweets[posicao_filho_direito].getField(sChave) > (int)oTweets[posicao_maior].getField(sChave)) //se o filho direito ta dentro do heap e ele é > que o pai
            {
                posicao_maior = posicao_filho_direito;
            }

            if (posicao_maior != posicao_pai)  //se o pai já não for o maior
            {
                Swap(oTweets, posicao_pai, posicao_maior);  //troca o pai com o maior
                Heapify(oTweets, posicao_maior);    //faz heapfy no novo maior
            }
        }

        private void BuildHeap(mainTwittPeek.Tweets[] oTweets)
        {
            heapSize = oTweets.Length - 1;      //define o tamanho do heap variavel global
            for (int i = heapSize / 2; i >= 0; i--)    //faz o heapfy só na metade pq o resto é folha
            {
                Heapify(oTweets, i);
            }
        }

        public void heapSort(mainTwittPeek.Tweets[] oTweets, string sChave)
        {
            this.sChave = sChave; // o this usa pra referenciar a variavel global, da pra usar o mesmo nome e tal ;)
            BuildHeap(oTweets);
            for (int i = oTweets.Length - 1; i >= 0; i--)
            {
                Swap(oTweets, 0, i);  //coloca o maior(1ª) no final
                heapSize--;         //decrementa o tamanho heap
                Heapify(oTweets, 0);    //arruma o heap de novo mas sem mecher no ultimo
            }
        }














        private void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            { Console.Write("[{0}]", arr[i]); }
        }

        private void Swap(int[] arr, int x, int y)//troca dois caras de lugar no array
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(int[] arr, int index)
        {
            int posicao_filho_esquerdo = 2 * index;
            int posicao_filho_direito = 2 * index + 1;
            int posicao_maior = index;

            if (posicao_filho_esquerdo <= heapSize && arr[posicao_filho_esquerdo] > arr[index]) //se o filho esquerdo ta dentro do heap e ele é > que o pai
            {
                posicao_maior = posicao_filho_esquerdo; 
            }

            if (posicao_filho_direito <= heapSize && arr[posicao_filho_direito] > arr[posicao_maior]) //se o filho direito ta dentro do heap e ele é > que o pai
            {
                posicao_maior = posicao_filho_direito;
            }

            if (posicao_maior != index)  //se o pai já não for o maior
            {
                Swap(arr, index, posicao_maior);  //troca o pai com o maior
                Heapify(arr, posicao_maior);    //faz heapfy no novo maior
            }
        }

        private void BuildHeap(int[] arr)
        {
            heapSize = arr.Length - 1;      //define o tamanho do heap variavel global
            for (int i = heapSize / 2; i >= 0; i--)    //faz o heapfy só na metade pq o resto é folha
            {
                Heapify(arr, i);
            }
        }

        public void heapSort(int[] arr)
        {
            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);  //coloca o maior(1ª) no final
                heapSize--;         //decrementa o tamanho heap
                Heapify(arr, 0);    //arruma o heap de novo mas sem mecher no ultimo
            }
            DisplayArray(arr);
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int[] arr = { 10, 64, 7, 52, 32, 18, 2, 48 };
            heapSort(arr);
            Console.ReadLine();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            heapSort(oMainTwittpeek.arrTweets, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            heapSort(oMainTwittpeek.arrTweets, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            heapSort(oMainTwittpeek.arrTweets, "ID");

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            heapSort(oMainTwittpeek.arrTweets, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            heapSort(oMainTwittpeek.arrTweets, "FavoriteCount");

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
    }
}
