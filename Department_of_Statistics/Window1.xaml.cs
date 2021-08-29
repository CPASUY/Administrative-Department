using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Department_of_Statistics
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private Country country;
        public Window1()
        {
            InitializeComponent();
            comboBoxLetter.Items.Add("A");
            comboBoxLetter.Items.Add("B");
            comboBoxLetter.Items.Add("C");
            comboBoxLetter.Items.Add("D");
            comboBoxLetter.Items.Add("E");
            comboBoxLetter.Items.Add("F");
            comboBoxLetter.Items.Add("G");
            comboBoxLetter.Items.Add("H");
            comboBoxLetter.Items.Add("I");
            comboBoxLetter.Items.Add("J");
            comboBoxLetter.Items.Add("K");
            comboBoxLetter.Items.Add("L");
            comboBoxLetter.Items.Add("M");
            comboBoxLetter.Items.Add("N");
            comboBoxLetter.Items.Add("O");
            comboBoxLetter.Items.Add("P");
            comboBoxLetter.Items.Add("Q");
            comboBoxLetter.Items.Add("R");
            comboBoxLetter.Items.Add("S");
            comboBoxLetter.Items.Add("T");
            comboBoxLetter.Items.Add("U");
            comboBoxLetter.Items.Add("V");
            comboBoxLetter.Items.Add("W");
            comboBoxLetter.Items.Add("X");
            comboBoxLetter.Items.Add("Y");
            comboBoxLetter.Items.Add("Z");
        }

        private void datagrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            string str = comboBoxLetter.Text;
            //string str = ((ComboBoxItem)comboBoxLetter.SelectedItem).Content.ToString(); //comboBoxLetter.SelectedValue().toString();
            List<Municipality> muns = country.beginsWith(str);
            datagrid2.Items.Clear();
            foreach (Municipality mun in muns)
            {
                datagrid2.Items.Add(mun);
            }
        }
        public void setCountry(Country c)
        {
            country = c;
        }
    }
}
