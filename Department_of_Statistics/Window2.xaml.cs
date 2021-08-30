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
//using LiveCharts;
//using LiveCharts.Defaults;
using LiveCharts.Wpf;

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
            fillChart();
        }

        private void fillChart()
        {
            
            var myValues = new LiveCharts.ChartValues<int>(muns);
            PieSeries ps = new PieSeries(myValues);
            //pieChart.ChartLegend.SetCurrentValue(dpts);
        }

        internal void setInfo(Country country)
        {
            muns = country.getMcpAmounts();
            dpts = country.getDptNames();

        }

    }
}
