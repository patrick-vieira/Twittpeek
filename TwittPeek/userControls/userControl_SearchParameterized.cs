using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TwittPeek.userControls
{
    public partial class userControl_SearchParameterized : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;
        mainTwittPeek oMainTwittPeek;
        public userControl_SearchParameterized(csMainTweetinvi tweetinvi, mainTwittPeek twittPeek)
        {
            InitializeComponent();

            oClassMainTweetinvi = tweetinvi;
            oMainTwittPeek = twittPeek;

            oMainTwittPeek.load(oMainTwittPeek.ultimoAberto);
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid();

            carregaComboBox();

            FieldInfo[] fi = typeof(mainTwittPeek.Tweets).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo info in fi)
            {
                string fieldName = Regex.Match(info.Name, @"\<(.*)\>").Groups[1].Value;
                string tipo = info.FieldType.Name;
                cbCampos.Items.Add(fieldName + "-" + tipo);
            }

        }

        void carregaComboBox()
        {
            cbFiles.Items.Clear();

            foreach (string file in oMainTwittPeek.listaArquivos)
            {
                cbFiles.Items.Add(file);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string sSearch = txtKeyWord.Text;

            int maxNumberOfResults;
            int.TryParse(txtMaxNumberOfResults.Text, out maxNumberOfResults);

            DateTime Since = dateTimePickerSince.Value;
            DateTime Until = dateTimePickerUntil.Value;

            double latitude;
            double.TryParse(txtLatitude.Text, out latitude);

            double longitude;
            double.TryParse(txtLongitude.Text, out longitude);
            
            double radius;
            double.TryParse(txtRadius.Text, out radius);

            oMainTwittPeek.mCarregaDados(oClassMainTweetinvi.mSearchTweets(sSearch, maxNumberOfResults, Since, Until, latitude, longitude, radius));
            
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            oMainTwittPeek.save(txtSaveName.Text);
            carregaComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oMainTwittPeek.add(cbFiles.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            oMainTwittPeek.load(cbFiles.Text);
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid();

        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            string chave = cbCampos.Text.Split('-')[0];
            string tipo = cbCampos.Text.Split('-')[1];

            RadixSort(oMainTwittPeek.arrTweets, chave, rbCrescente.Checked);

            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid();
        }

        private void btnAppendSearch_Click(object sender, EventArgs e)
        {

        }


        void RadixSort(mainTwittPeek.Tweets[] oTweets, string sChave, bool crescente)
        {
            int i;
            mainTwittPeek.Tweets maior = oTweets[0]; //assume que o maior é o primeiro
            int exp = 1;

            mainTwittPeek.Tweets[] b = new mainTwittPeek.Tweets[oTweets.Length];

            //percorre todo arrei procurando o maior valor
            for (i = 0; i < oTweets.Length; i++)
            {
                if (true)
                {
                    if ((int)oTweets[i].getField(sChave) > (int)maior.getField(sChave)) // tenta achar um novo maior no vetor
                        maior = oTweets[i];
                }
                else
                {
                    if ((int)oTweets[i].getField(sChave) < (int)maior.getField(sChave)) // tenta achar um novo maior no vetor
                        maior = oTweets[i];
                }

            }

            int bucketSize = 10;
            while ((int)maior.getField(sChave) / exp > 0)
            {
                if (crescente)
                {
                    int[] bucket = new int[bucketSize];
                    for (i = 0; i < oTweets.Length; i++)
                        bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]++; //contagem o simbolo % é tipo um limitador se a divisão for maior que 10 subtrai 10, ex 55/5 = 11, (55/5)%10 = 1
                    for (i = 1; i < bucketSize; i++)
                        bucket[i] += bucket[i - 1];
                    for (i = oTweets.Length - 1; i >= 0; i--)
                        b[--bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]] = oTweets[i];
                    for (i = 0; i < oTweets.Length; i++)
                        oTweets[i] = b[i];
                }
                else
                {
                    int[] bucket = new int[bucketSize];
                    for (i = 0; i < oTweets.Length; i++)
                        bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]++; //contagem o simbolo % é tipo um limitador se a divisão for maior que 10 subtrai 10, ex 55/5 = 11, (55/5)%10 = 1
                    for (i = 1; i < bucketSize; i++)
                        bucket[i] += bucket[i - 1];
                    for (i = oTweets.Length - 1; i >= 0; i--)
                        b[--bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]] = oTweets[i];
                    for (i = 0; i < oTweets.Length; i++)
                        oTweets[oTweets.Length - 1 - i] = b[i];
                }
                exp *= bucketSize;
            }
        }

    }
}
