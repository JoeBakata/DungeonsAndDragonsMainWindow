using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Charts.Treasure;
using DungeonsAndDragons.ChartEngine.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DungeonsAndDragonsMainWindow.RadioButtonView
{
    /// <summary>
    /// Interaction logic for ViewMonetaryChartForm.xaml
    /// </summary>
    public partial class ViewMonetaryChartForm : Window
    {
        GetCharts ChartEngine;
        MonsterTypes monsterTypes;
        public ViewMonetaryChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        //#region MonetaryButtonClicks
        //private void Copperbtn_Click(object sender, RoutedEventArgs e)
        //{
        //    SetMonetaryType();
        //}

        //private void Silverbtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ChangeDisplay("Silver");
        //}


        //private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        //{

        //}
        //#endregion MonetaryButtonClicks

        #region Private Methods
        private void SetMonetaryLabel(object sender, RoutedEventArgs e)
        {
            string monetaryType = sender.ToString();
        }

        private void SetMonsterType(object sender, RoutedEventArgs e)
        {
            string monsterType = sender.ToString();
            monsterType = FilteredString(monsterType, Constants.BoilerPlateMonsterType);
            monsterTypes = ChartEngine.GetMonsterType(monsterType);

        }

        private string FilteredString(string unfilteredString, string textToRemove)
        {
            string filteredString = unfilteredString.Replace(textToRemove, "");
            return filteredString;
        }
        #endregion Private Methods
    }
}
