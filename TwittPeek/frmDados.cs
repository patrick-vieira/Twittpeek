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
        public frmDados()
        {
            InitializeComponent();
            //mPreencheColunas();
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
            string fileXML = "c:\\UFRGS\\Search100Resultados.xml";

            DataSet oDataSet = new DataSet();
            
            oDataSet.ReadXml(fileXML);

            dataGridViewDados.DataSource = oDataSet.Tables["Search100Resultados"];
        }
    }
}
