using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwittPeek
{
    public partial class frmDados : Form
    {

        private DataSet oDataSetDados;
        private mainTwittPeek oMainTwittPeek;

        public frmDados()
        {
            InitializeComponent();
            oMainTwittPeek = new mainTwittPeek();
            carregarToolStripMenuItem_Click(null, null);
        }

        void mPreencheColunas()
        {
            string fileColumns = "c:\\UFRGS\\mygridColumns.txt";

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(fileColumns))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        DataGridViewColumn oColumn = new DataGridViewColumn();
                        oColumn.HeaderText = line;
                        dataGridViewDados.Columns.Add(oColumn);
                        Console.WriteLine(line);
                    }                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        void carregaBin()
        {
            string file = "c:\\UFRGS\\mygrid.bin";

            //DataGridView dgv = ...
            dataGridViewDados.Rows.Clear();
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dataGridViewDados.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridViewDados.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileXML = Directory.GetParent(Directory.GetCurrentDirectory()) + "\\Dados\\Search100Resultados.xml";
        
            oDataSetDados = new DataSet();

            oDataSetDados.ReadXml(fileXML);

            dataGridViewDados.DataSource = oDataSetDados.Tables["Search100Resultados"];
        }

        public object mGetDados(int nSizeData)
        {
            mainTwittPeek.Tweets[] oTweets;

            oTweets = mConverteParaArray(nSizeData);

            return oTweets; 
        }

        private mainTwittPeek.Tweets[] mConverteParaArray(int nArraySize)
        {
            mainTwittPeek.Tweets[] oTweets = new mainTwittPeek.Tweets[nArraySize];

            DataTable oTable = oDataSetDados.Tables["Search100Resultados"];

            int index = 0;

            int iTemp;
            bool bTemp;
            long lTemp;

            foreach (DataRow oRow in oTable.Rows)
            {
                //o id vai ser o que vem depois da ultima barra da URL
                Int64.TryParse(oRow["Url"].ToString().Split('/').Last(), out lTemp);
                oTweets[index].ID = lTemp;

                oTweets[index].CreatedAt = oRow["CreatedAt"].ToString();

                oTweets[index].Text = oRow["Text"].ToString();

                oTweets[index].FullText = oRow["FullText"].ToString();

                oTweets[index].Source = oRow["Source"].ToString();

                oTweets[index].CreatedBy = oRow["CreatedBy"].ToString();

                Int32.TryParse(oRow["RetweetCount"].ToString(), out iTemp);
                oTweets[index].RetweetCount = iTemp;

                Boolean.TryParse(oRow["Favorited"].ToString(), out bTemp);
                oTweets[index].Favorited = bTemp;

                Int32.TryParse(oRow["FavoriteCount"].ToString(), out iTemp);
                oTweets[index].FavoriteCount = iTemp;

                Boolean.TryParse(oRow["Retweeted"].ToString(), out bTemp);
                oTweets[index].Retweeted = bTemp;

                oTweets[index].Language = oRow["Language"].ToString();

                Int32.TryParse(oRow["PublishedTweetLength"].ToString(), out iTemp);
                oTweets[index].PublishedTweetLength = iTemp;

                oTweets[index].TweetLocalCreationDate = oRow["TweetLocalCreationDate"].ToString();

                Boolean.TryParse(oRow["IsRetweet"].ToString(), out bTemp);
                oTweets[index].IsRetweet = bTemp;

                Boolean.TryParse(oRow["IsTweetPublished"].ToString(), out bTemp);
                oTweets[index].IsTweetPublished = bTemp;

                Boolean.TryParse(oRow["IsTweetDestroyed"].ToString(), out bTemp);
                oTweets[index].IsTweetDestroyed = bTemp;

                oTweets[index].Url = oRow["Url"].ToString();

                index++;
            }

            return oTweets;
        }

    }
}
