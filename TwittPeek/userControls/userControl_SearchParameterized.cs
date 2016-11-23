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

            
            oMainTwittPeek.load_estruturado(oMainTwittPeek.ultimoAberto);
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid_estruturado();

            carregaComboBox();

            FieldInfo[] fi = typeof(mainTwittPeek.TweetsEstruturado).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo info in fi)
            {
                string fieldName = Regex.Match(info.Name, @"\<(.*)\>").Groups[1].Value;
                string tipo = info.FieldType.Name;
                if (tipo == "Int32")
                    cbCampos.Items.Add(fieldName);
                //if (tipo == "String" || tipo == "Int64")
                    //cbCamposFiltro.Items.Add(fieldName + '-' + tipo);
            }

            FieldInfo[] fi_texto = typeof(mainTwittPeek.Texto).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo info in fi_texto)
            {
                string fieldName = Regex.Match(info.Name, @"\<(.*)\>").Groups[1].Value;
                string tipo = info.FieldType.Name;
                if (tipo == "Int32")
                    cbCampos.Items.Add(fieldName);
                //if (tipo == "String" || tipo == "Int64")
                   // cbCamposFiltro.Items.Add(fieldName + '-' + tipo);
            }

            FieldInfo[] fi_usuario = typeof(mainTwittPeek.Usuarios).GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo info in fi_usuario)
            {
                string fieldName = Regex.Match(info.Name, @"\<(.*)\>").Groups[1].Value;
                string tipo = info.FieldType.Name;
                if (tipo == "Int32")
                    cbCampos.Items.Add(fieldName);
                //if (tipo == "String" || tipo == "Int64")
                    //cbCamposFiltro.Items.Add(fieldName + '-' + tipo);
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

            //oMainTwittPeek.mCarregaDados(oClassMainTweetinvi.mSearchTweets(sSearch, maxNumberOfResults, Since, Until, latitude, longitude, radius));
            oMainTwittPeek.mCarregaDados_estruturado(oClassMainTweetinvi.mSearchTweets(sSearch, maxNumberOfResults, Since, Until, latitude, longitude, radius));
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid_estruturado();
            oMainTwittPeek.save_estruturado(oMainTwittPeek.ultimoAberto);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //oMainTwittPeek.save(txtSaveName.Text);
            oMainTwittPeek.save_estruturado(txtSaveName.Text);
            carregaComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oMainTwittPeek.add(cbFiles.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //oMainTwittPeek.load(cbFiles.Text);
            oMainTwittPeek.load_estruturado(cbFiles.Text);
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid_estruturado();

        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            string chave = cbCampos.Text;

            RadixSort(oMainTwittPeek.arrTweetsEstruturado, chave, rbCrescente.Checked);

            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid_estruturado();
        }

        private void btnAppendSearch_Click(object sender, EventArgs e)
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

            
            oMainTwittPeek.mAppendDados_estruturado(oClassMainTweetinvi.mSearchTweets(sSearch, maxNumberOfResults, Since, Until, latitude, longitude, radius));
            dataGridViewSearchTwieet.ClearSelection();
            dataGridViewSearchTwieet.DataSource = oMainTwittPeek.preencheGrid_estruturado();
            oMainTwittPeek.save_estruturado(oMainTwittPeek.ultimoAberto);
        }
        void RadixSort(mainTwittPeek.TweetsEstruturado[] oTweets, string sChave, bool crescente)
        {
            int i;
            mainTwittPeek.TweetsEstruturado maior = oTweets[0]; //assume que o maior é o primeiro

            int bucketSize = 10;
            int[] contadorEscaninhos = new int[bucketSize]; //uma lista com o numero de elementos em cada escaninho

            List<mainTwittPeek.TweetsEstruturado[]> escaninhos = new List<mainTwittPeek.TweetsEstruturado[]>();

            for (i = 0; i < bucketSize; i++)
            {
                mainTwittPeek.TweetsEstruturado[] escaninho = new mainTwittPeek.TweetsEstruturado[oTweets.Length];
                escaninhos.Add(escaninho);
            }

            //pega o maior valor dessa chave, para saber quantos caracteres vamos precisar verificar
            int maiorNumero = 0;
            for (i = 0; i < oTweets.Length; i++)
            {
                if (maiorNumero < (int)oTweets[i].getField(sChave))
                    maiorNumero = (int)oTweets[i].getField(sChave);
            }
            int tamanhoMaiorNumero = maiorNumero.ToString().Length;
            //verificar digito a digito até o tamanho do maior, ex roda 4x se o maior valor for 8734
            for (int indexDigito = 0; indexDigito < tamanhoMaiorNumero; indexDigito++)
            {
                //para cada elemento ordenar nos buckets pelo digito de index
                for (i = 0; i < oTweets.Length; i++)
                {
                    int chave = (int)oTweets[i].getField(sChave);
                    int digito = (chave / (int)Math.Pow(10, indexDigito)) % 10;

                    //coloca o tweet no escaninho do digito, na posição da pilha marcada pelo contador de digitos do escaninho
                    escaninhos[digito][contadorEscaninhos[digito]] = oTweets[i];
                    contadorEscaninhos[digito]++;
                }

                int indexArrayPrincipal = crescente ? 0 : oTweets.Length-1 ;                
                int indexContadorEscaninhos = 0;
                //reordenar o array removendo os dados dos buckets em ordem                
                foreach (mainTwittPeek.TweetsEstruturado[] escaninho in escaninhos)
                {
                    int indexEscaninho = crescente ? 0 : contadorEscaninhos[indexContadorEscaninhos] -1;
                    while (contadorEscaninhos[indexContadorEscaninhos] > 0)
                    {
                        oTweets[indexArrayPrincipal] = escaninho[indexEscaninho];
                        contadorEscaninhos[indexContadorEscaninhos]--;
                        indexEscaninho = crescente ? indexEscaninho + 1: indexEscaninho - 1;
                        indexArrayPrincipal = crescente ? indexArrayPrincipal + 1 : indexArrayPrincipal - 1;
                    }
                    indexContadorEscaninhos++;
                    indexEscaninho = 0;
                }
            }
        }
        void RadixSort(mainTwittPeek.Tweets[] oTweets, string sChave, bool crescente)
        {
            int i;
            mainTwittPeek.Tweets maior = oTweets[0]; //assume que o maior é o primeiro

            int bucketSize = 10;
            int[] contadorEscaninhos = new int[bucketSize]; //uma lista com o numero de elementos em cada escaninho

            List<mainTwittPeek.Tweets[]> escaninhos = new List<mainTwittPeek.Tweets[]>();

            for (i = 0; i < bucketSize; i++)
            {
                mainTwittPeek.Tweets[] escaninho = new mainTwittPeek.Tweets[oTweets.Length];
                escaninhos.Add(escaninho);
            }

            //pega o maior valor dessa chave, para saber quantos caracteres vamos precisar verificar
            int maiorNumero = 0;
            for (i = 0; i < oTweets.Length; i++)
            {
                if (maiorNumero < (int)oTweets[i].getField(sChave))
                    maiorNumero = (int)oTweets[i].getField(sChave);
            }
            int tamanhoMaiorNumero = maiorNumero.ToString().Length;
            //verificar digito a digito até o tamanho do maior, ex roda 4x se o maior valor for 8734
            for (int indexDigito = 0; indexDigito < tamanhoMaiorNumero; indexDigito++)
            {
                //para cada elemento ordenar nos buckets pelo digito de index
                for (i = 0; i < oTweets.Length; i++)
                {
                    int chave = (int)oTweets[i].getField(sChave);
                    int digito = (chave / (int)Math.Pow(10, indexDigito)) % 10;

                    //coloca o tweet no escaninho do digito, na posição da pilha marcada pelo contador de digitos do escaninho
                    escaninhos[digito][contadorEscaninhos[digito]] = oTweets[i];
                    contadorEscaninhos[digito]++;
                }

                int indexArrayPrincipal = crescente ? 0 : oTweets.Length - 1;
                int indexContadorEscaninhos = 0;
                //reordenar o array removendo os dados dos buckets em ordem                
                foreach (mainTwittPeek.Tweets[] escaninho in escaninhos)
                {
                    int indexEscaninho = crescente ? 0 : contadorEscaninhos[indexContadorEscaninhos] - 1;
                    while (contadorEscaninhos[indexContadorEscaninhos] > 0)
                    {
                        oTweets[indexArrayPrincipal] = escaninho[indexEscaninho];
                        contadorEscaninhos[indexContadorEscaninhos]--;
                        indexEscaninho = crescente ? indexEscaninho + 1 : indexEscaninho - 1;
                        indexArrayPrincipal = crescente ? indexArrayPrincipal + 1 : indexArrayPrincipal - 1;
                    }
                    indexContadorEscaninhos++;
                    indexEscaninho = 0;
                }
            }
        }

        void BucketSort(mainTwittPeek.Tweets[] oTweets, string sChave, bool crescente)
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
                int[] bucket = new int[bucketSize];

                if (crescente)
                {
                    for (i = 0; i < oTweets.Length; i++)
                        bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]++; //contagem o simbolo % é tipo um limitador se a divisão for maior que 10 subtrai 10, ex 55/5 = 11, (55/5)%10 = 1
                    for (i = 1; i < bucketSize; i++)
                        bucket[i] += bucket[i - 1]; //somando o valor dos buckets
                    for (i = oTweets.Length - 1; i >= 0; i--)
                        b[--bucket[((int)oTweets[i].getField(sChave) / exp) % bucketSize]] = oTweets[i];
                    for (i = 0; i < oTweets.Length; i++)
                        oTweets[i] = b[i];
                }
                else
                {
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string campo = cbCamposFiltro.Text.Split('-')[0];
            string tipo = "";
            if (cbCamposFiltro.Text.Contains('-'))
                tipo = cbCamposFiltro.Text.Split('-')[1];

            if (campo == "")
                (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("");
            else
            {

                if (tipo == "string")
                {
                    switch(cbFiltro.Text)
                    {
                        case "começa com *":
                            (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("'{0}' LIKE '{1}*'", campo, txtFiltro.Text);
                            break;

                        case "contem *":
                            (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("'{0}' LIKE '*{1}*'", campo, txtFiltro.Text);
                            break;

                        case "não contem *":
                            (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("'{0}' NOT LIKE '%{1}%'", campo, txtFiltro.Text);
                            break;

                        default:
                            (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("'{0}' {1} '{2}'", campo, cbFiltro.Text, txtFiltro.Text);
                            break;
                    }
                }
                else
                    (dataGridViewSearchTwieet.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} {1} {2}", campo, cbFiltro.Text, txtFiltro.Text);
            }



            /*=
>
>=
<
<=
começa com*
contem*
não contem *

chave
ID
CreatedAt-string
oUsuario.Name-string
FullText-string
oTexto.Hashtags-string
oTexto.PublishedTweetLength
oUsuario.Location-string
oUsuario.FollowersCount
oUsuario.FriendsCount
oUsuario.ProfileImageUrl-string
Source-string
RetweetCount
FavoriteCount
oTexto.Language-string
Url-string
**/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
