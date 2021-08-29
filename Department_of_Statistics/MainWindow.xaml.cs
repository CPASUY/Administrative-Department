using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Department_of_Statistics
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Country country;
        public MainWindow()
        {
            InitializeComponent();
            country = new Country();
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            if (path.ShowDialog() == true)
            {
                textBoxPath.Text = path.SafeFileName;
                string fpath = path.FileName;
                MessageBox.Show("  Datos cargados correctamente");
                displayInformation(fpath);
            }
            else
            {
                MessageBox.Show("No se encontro el archivo");
            }
        }
        private void displayInformation(string path)
        {
            String list = File.ReadAllText(path);
            String[] splitList = list.Split('\n');
            string[] splitColumn;
            for (int i = 1; i < splitList.Length; i++)
            {
                splitColumn = splitList[i].Split(',');
                bool res = splitColumn.Count() == 5;
                if (res)  {
                country.addMunicipality(splitColumn);
            }
        }
            List<Municipality> municipalities = country.getAllMunicipalities();
            foreach (Municipality mun in municipalities)
            {
                datagrid1.Items.Add(mun);
            }
        }

        private void graphMunicipiesScreen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void begginsLetterScreen_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.setCountry(country);
            w1.Show();
            
        }
    }
}
