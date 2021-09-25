using System.Windows;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Monetary_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewMonetaryChartForm monetaryTreasureChartForm = new ViewMonetaryChartForm();
            monetaryTreasureChartForm.ShowDialog();
        }

        private void Gem_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewGemChartForm viewGemChartForm = new ViewGemChartForm();
            viewGemChartForm.ShowDialog();
        }

        private void Jewelry_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewJewelryChartForm viewJewelryChartForm = new ViewJewelryChartForm();
            viewJewelryChartForm.ShowDialog();
        }

        private void Magic_Item_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewMagicItemChartForm viewMagicItemChartForm = new ViewMagicItemChartForm();
            viewMagicItemChartForm.ShowDialog();
        }
    }
}
