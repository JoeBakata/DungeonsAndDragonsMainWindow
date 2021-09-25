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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void Monetary_Chartbtn_Click_1(object sender, RoutedEventArgs e)
        {
            ViewMonetaryChartForm monetaryTreasureChartForm = new ViewMonetaryChartForm();
            monetaryTreasureChartForm.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewGemChartForm viewGemChartForm = new ViewGemChartForm();
            viewGemChartForm.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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
