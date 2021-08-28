using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Departamento_Administrativo
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Navega entre los formularios
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Abre la carpeta de archivos
            OpenFileDialog path = new OpenFileDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = path.SafeFileName;
                string fpath= path.FileName;
                MessageBox.Show("  Datos cargados correctamente");
                deployedInformation(fpath);
            
            }
            else
            {
                MessageBox.Show("No se encontro el archivo");
            }
        }
        private void deployedInformation(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] splitList = list.Split('\n');
            string[] splitColumn;
            model = new Model(splitList.Length-6);
            for (int i = 1; i < splitList.Length; i++)
            {
                splitColumn = splitList[i].Split(',');
                model.addMunicipio(splitColumn);
                dataGridView1.Rows.Add(splitColumn);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
