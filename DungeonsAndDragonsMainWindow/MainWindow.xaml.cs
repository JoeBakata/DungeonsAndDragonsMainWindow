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
            ButtonView.ViewMonetaryChartForm monetaryTreasureChartForm = new ButtonView.ViewMonetaryChartForm();
            monetaryTreasureChartForm.ShowDialog();
        }

        private void Gem_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ButtonView.ViewGemChartForm viewGemChartForm = new ButtonView.ViewGemChartForm();
            viewGemChartForm.ShowDialog();
        }

        private void Jewelry_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            RadioButtonView.ViewJewelryChartForm viewJewelryChartForm = new RadioButtonView.ViewJewelryChartForm();// Changed namespace to RadioButtonView. to get the raidoButtons
            viewJewelryChartForm.ShowDialog();
        }

        private void Magic_Item_Chartbtn_Click(object sender, RoutedEventArgs e)
        {
            ButtonView.ViewMagicItemChartForm viewMagicItemChartForm = new ButtonView.ViewMagicItemChartForm();
            viewMagicItemChartForm.ShowDialog();
        }
    }
}
