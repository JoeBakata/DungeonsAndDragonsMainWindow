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

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewJewelryChartForm.xaml
    /// </summary>
    public partial class ViewJewelryChartForm : Window
    {
        DungeonsAndDragons.ChartEngine.Charts.GetCharts ChartEngine;

        public ViewJewelryChartForm()
        {
            InitializeComponent();
            ChartEngine = new DungeonsAndDragons.ChartEngine.Charts.GetCharts();
        }

        #region ButtonClick
        private void Btn_Click_Bracelet(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Bracelet");
        }

        private void Btn_Click_Pin(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Pin");
        }

        private void Btn_Click_Brooch(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Brooch");
        }

        private void Btn_Click_Earring(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Earring");
        }

        private void Btn_Click_Pendant(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Pendant");
        }

        private void Btn_Click_Necklace(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Necklace");
        }

        private void Btn_Click_Crown(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Crown");
        }

        private void Btn_Click_Sceptre(object sender, RoutedEventArgs e)
        {
            JewleryLabel("Sceptre");
        }
        #endregion ButtonClick
        private void JewleryLabel(string jewleryType)
        {
            DungeonsAndDragons.ChartEngine.Charts.Treasure.JewelryValue element = ChartEngine.JewelryGPValueChart.First(x => x.JewelryType.ToString() == jewleryType);
            JewleryTypelbl.Content = element.JewelryType.ToString();
            MinimumGPValuelbl.Content = element.MinimumGPValue;
            MaximumGPValuelbl.Content = element.MaximumGPValue;

        }

    }
}
