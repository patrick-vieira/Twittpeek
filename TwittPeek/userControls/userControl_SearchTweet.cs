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

namespace TwittPeek.userControls
{
    public partial class userControl_SearchTweet : UserControl
    {
        csMainTweetinvi oClassMainTweetinvi;

        public userControl_SearchTweet(csMainTweetinvi Tweetinvi)
        {
            InitializeComponent();

            txtKeyWord.KeyDown += new KeyEventHandler(txtKeyWord_KeyDown);
            oClassMainTweetinvi = Tweetinvi;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             dataGridViewSearchTwieet.DataSource = oClassMainTweetinvi.mSearchTweets(txtKeyWord.Text);
        }        
        
        private void txtKeyWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }

        }

        void salvarNomeColunas()
        {
            string fileColumns = "c:\\UFRGS\\mygridColumns.txt";

            List<string> lines = new List<string>();

            foreach (DataGridViewColumn col in dataGridViewSearchTwieet.Columns)
            {
                lines.Add(col.HeaderText);
            }

            using (StreamWriter outputFile = new StreamWriter(fileColumns))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }

        void salvarDataSet()
        {
            FolderBrowserDialog oDialog = new FolderBrowserDialog();
            oDialog.RootFolder = Environment.SpecialFolder.MyComputer;// = Directory.GetCurrentDirectory();
            oDialog.SelectedPath = Directory.GetCurrentDirectory();
            if (oDialog.ShowDialog() == DialogResult.OK)
            {

                //string fileXML = "c:\\UFRGS\\Search100Resultados.xml";
                string fileXML = oDialog.SelectedPath;

                DataTable oDataTable = new DataTable();
                DataSet oDataSet = new DataSet();

                oDataTable.TableName = "Search100Resultados";

                foreach (DataGridViewColumn col in dataGridViewSearchTwieet.Columns)
                {
                    oDataTable.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in dataGridViewSearchTwieet.Rows)
                {
                    DataRow dRow = oDataTable.NewRow();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }

                    oDataTable.Rows.Add(dRow);
                }

                oDataSet.Tables.Add(oDataTable);

                oDataSet.WriteXml(fileXML + "\\" + oDataTable.TableName + ".xml");
            }


            ///
        }

        void salvarBinario()
        {
            string file = "c:\\UFRGS\\Search100Resultados.bin";

            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dataGridViewSearchTwieet.Columns.Count);
                bw.Write(dataGridViewSearchTwieet.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridViewSearchTwieet.Rows)
                {
                    for (int j = 0; j < dataGridViewSearchTwieet.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarDataSet();
        }
    }
}
