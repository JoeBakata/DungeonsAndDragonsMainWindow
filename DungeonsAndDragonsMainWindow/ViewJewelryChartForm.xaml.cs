using System.Linq;
using System.Windows;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewJewelryChartForm.xaml
    /// </summary>
    public partial class ViewJewelryChartForm : Window
    {
        GetCharts ChartEngine;

        public ViewJewelryChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        #region ButtonClick
        private void Btn_Click_Bracelet(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Bracelet");
        }

        private void Btn_Click_Pin(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Pin");
        }

        private void Btn_Click_Brooch(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Brooch");
        }

        private void Btn_Click_Earring(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Earring");
        }

        private void Btn_Click_Pendant(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Pendant");
        }

        private void Btn_Click_Necklace(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Necklace");
        }

        private void Btn_Click_Crown(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Crown");
        }

        private void Btn_Click_Sceptre(object sender, RoutedEventArgs e)
        {
            JewelryLabel("Sceptre");
        }
        #endregion ButtonClick

        private void SetJewelryLabel(object sender, RoutedEventArgs e)
        {
            string jewelry = sender.ToString();
        }
        private void JewelryLabel(string jewleryType)
        {
            DungeonsAndDragons.ChartEngine.Charts.Treasure.JewelryValue element = ChartEngine.JewelryGPValueChart.First(x => x.JewelryType.ToString() == jewleryType);
            JewleryTypelbl.Content = element.JewelryType.ToString();
            MinimumGPValuelbl.Content = element.MinimumGPValue;
            MaximumGPValuelbl.Content = element.MaximumGPValue;
        }
    }
}
