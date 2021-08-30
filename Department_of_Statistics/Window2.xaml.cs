
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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public List<int> muns;
        public List<string> dpts;
        public Window2()
        {
            InitializeComponent();
            muns = new List<int>();
            dpts = new List<string>();
            fillChart();
        }

        private void fillChart()
        {
            
            
        }

        internal void setInfo(Country country)
        {
            muns = country.getMcpAmounts();
            dpts = country.getDptNames();
            List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < dpts.Count; i++)
            {
                if (dpts[i] != "")
                {
                    valueList.Add(new KeyValuePair<string, int>(dpts[i], muns[i]));
                }
            }
            pieChart.DataContext = valueList;

        }

    }
}
