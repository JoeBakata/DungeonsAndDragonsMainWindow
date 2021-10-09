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
            RadioButtonView.ViewMonetaryChartForm monetaryTreasureChartForm = new RadioButtonView.ViewMonetaryChartForm();
            monetaryTreasureChartForm.ShowDialog();
        }

        private void Gem_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            RadioButtonView.ViewGemChartForm viewGemChartForm = new RadioButtonView.ViewGemChartForm();
            viewGemChartForm.ShowDialog();
        }

        private void Jewelry_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            RadioButtonView.ViewJewelryChartForm viewJewelryChartForm = new RadioButtonView.ViewJewelryChartForm();// Changed namespace to RadioButtonView. to get the raidoButtons
            viewJewelryChartForm.ShowDialog();
        }

        private void Magic_Item_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ViewMagicItemChartForm viewMagicItemChartForm = new ViewMagicItemChartForm();
            viewMagicItemChartForm.ShowDialog();
        }
    }
}
