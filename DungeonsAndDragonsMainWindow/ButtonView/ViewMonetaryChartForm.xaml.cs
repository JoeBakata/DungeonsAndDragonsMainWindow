using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow.ButtonView
{
    /// <summary>
    /// Interaction logic for ViewMonetaryChartForm.xaml
    /// </summary>
    public partial class ViewMonetaryChartForm : Window
    {
        GetCharts ChartEngine;
        MonsterTypes MonsterTypes;
        GeneralMethods generalMethods = new GeneralMethods();

        public ViewMonetaryChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        private void ChangeDisplay(string treasure)
        {
            Treasure_NameLbl.Content = treasure;
            var display = ChartEngine.MonetaryTreasure;
            var item = display[MonsterTypes];
            foreach (var item2 in item)
            {
                if (item2.TreasureName == treasure)
                {
                    DiceLbl.Content = item2.Dice.ToString();
                    Treasure_AmountLbl.Content = item2.TreasureAmount.ToString();
                    PercentLbl.Content = item2.Percent.ToString();
                }
            }
        }

        private void GetMonetaryType(object sender, RoutedEventArgs e)
        {
            string monetaryType = sender.ToString();
            monetaryType = generalMethods.FilteredString(monetaryType, Constants.BoilerPlate);
            monetaryType = generalMethods.FilteredString(monetaryType, ":");
            ChangeDisplay(monetaryType);
        }
        private void GetMonsterType(object sender, RoutedEventArgs e) 
        {
            string monsterType = sender.ToString();
            monsterType = generalMethods.FilteredString(monsterType, Constants.BoilerPlateMonsterType);
            MonsterTypes = generalMethods.GetMonsterType(monsterType, ChartEngine);
            Monster_Typelbl.Content = $"Monster Type {monsterType}:";
        }
    }
}
