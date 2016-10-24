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
        mainTwittPeek oMainTwittpeek;

        public userControl_Alg_ISBL(mainTwittPeek oTwittpeek)
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

            insercao_direta(oMainTwittpeek.arrTweets, sCampo);

            return DateTime.Now.Ticks - oStart;
        }

        void insercao_direta(mainTwittPeek.Tweets[] oTweets, string sChave)
        {
            int i, j;
            mainTwittPeek.Tweets chave;
            for (j = 1; j < oTweets.Length; j++)
            {
                chave = oTweets[j];

                i = j - 1;
                //ver como pegar o campo da struct dinamicamente tipo oTweets[i]["ID"] assim podemos ordenar por qualquer campo usando o mesmo algoritmo
                while ((i >= 0) && ((int)oTweets[i].getField(sChave)) > (int)chave.getField(sChave))
                {
                    oTweets[i + 1] = oTweets[i];
                    i--;
                }
                oTweets[i + 1] = chave;
            }
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {   
            long oStart = DateTime.Now.Ticks;

            insercao_direta(oMainTwittpeek.arrTweets, "PublishedTweetLength");

            lblResultTime.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }


        private void btnExecutar_ID_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            insercao_direta(oMainTwittpeek.arrTweets, "ID");

            lblResultTime_ID.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_RetweetCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;
            
            insercao_direta(oMainTwittpeek.arrTweets, "RetweetCount");

            lblResultTime_RetweetCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_FavoriteCount_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            insercao_direta(oMainTwittpeek.arrTweets, "FavoriteCount");

            lblResultTime_FavoriteCount.Text = (DateTime.Now.Ticks - oStart).ToString();

            mMostraDados();
        }

        private void btnExecutar_Index_Click(object sender, EventArgs e)
        {
            long oStart = DateTime.Now.Ticks;

            insercao_direta(oMainTwittpeek.arrTweets, "index");

            lblResultTime_Index.Text = (DateTime.Now.Ticks - oStart).ToString();

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
