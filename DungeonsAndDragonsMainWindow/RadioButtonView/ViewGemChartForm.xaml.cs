using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Charts.Treasure;
using DungeonsAndDragons.ChartEngine.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DungeonsAndDragonsMainWindow.RadioButtonView
{
    /// <summary>
    /// Interaction logic for ViewGemChartForm.xaml
    /// </summary>
    public partial class ViewGemChartForm : Window
    {
        public ViewGemChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }
        GetCharts ChartEngine;

        public void SelectionTypeDisplay(object sender, RoutedEventArgs e)
        {
            if (Quartzrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Quartz);
            }
            else if (Turqoiserdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Turquoise);
            }
            else if (Citrinerdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Citrine);
            }
            else if (Onyxrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Onyx);
            }
            else if (Amberrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Amber);
            }
            else if (Garnetrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Garnet);
            }
            else if (Pearlrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Pearl);
            }
            else if (Topazrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Topaz);
            }
            else if (Opelrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Opal);
            }
            else if (Rubyrdbtn.IsChecked == true)
            {
                ChangeDisplay(GemType.Ruby);
            }
        }
        private void ChangeDisplay(GemType gemType)
        {
            List<GemValue> gemTreasures = ChartEngine.GemGPValueChart;
            GemValue list = gemTreasures.First(x => x.GemType == gemType);
            Gem_Typelbl.Content = gemType;
            Minimum_GP_Valuelbl.Content = list.MinimumGPValue;
            Minimum_Roll_Valuelbl.Content = list.MinimumRollValue;
            Maximum_Roll_Valuelbl.Content = list.MaximumRollValue;
            Dicelbl.Content = list.Dice;

        }
    }
}
