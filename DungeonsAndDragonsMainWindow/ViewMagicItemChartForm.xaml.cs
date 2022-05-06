using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Services;
using System.Collections.Generic;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMagicItemChartForm.xaml
    /// </summary>
    public partial class ViewMagicItemChartForm : Window
    {
        private readonly List<MonsterTypes> NoMagicItemsForTheseMonsters = new List<MonsterTypes>() 
        {MonsterTypes.J, MonsterTypes.K, MonsterTypes.L, MonsterTypes.M, MonsterTypes.P, MonsterTypes.Q, MonsterTypes.R, MonsterTypes.S, MonsterTypes.T};
        private const string RemoveBoilerPlate = "System.Windows.Controls.Button: Monster Type ";
        private const string RemoveMoreBoilerPlate = "System.Windows.Controls.Button: ";
        GetCharts getCharts;
        MonsterTypes monsterTypes;
        MagicItemLogicRepository magicItemLogicRepository;
        public ViewMagicItemChartForm()
        {
            InitializeComponent();
            getCharts = new GetCharts();
            magicItemLogicRepository = new MagicItemLogicRepository(getCharts);

        }
        private void Monster_Type_Click(object sender, RoutedEventArgs e)
        {
            SetMonsterType(sender.ToString());
            ChangeMonsterTypeLabelAndEnableRoll();
        }

        private void Monetarybtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(SetMonetaryType(sender.ToString()));
        }

        private void ChangeMonsterTypeLabelAndEnableRoll()
        {
            Monsterlbl.Content = monsterTypes.ToString();
            Roll.IsEnabled = true;
            IsTreasure.Content = NoMagicItemsForTheseMonsters.Contains(monsterTypes) ? "No Magic Items Here!" : "false";
            listOfTreasure.Content = string.Empty;
            NumberOfMagicItems.Content = "zero";
            RevealMagicItems.IsEnabled = false;
            ActualRolledMagicItem.Content = string.Empty;
            ChoosenMagicItems.Content = string.Empty;

        }

        private void ChangeMagicItemChartLabel(MonetaryTreasureTypes treasure)
        {
            var magicItemTreasure = getCharts.MagicItemValue[monsterTypes];
            Dicelbl.Content = magicItemTreasure.Dice.ToString();
            Percentlbl.Content = magicItemTreasure.Percent.ToString();
            Any_Magic_Itemslbl.Content = magicItemTreasure.AnyMagicItems.ToString();
            Except_Weaponslbl.Content = magicItemTreasure.ExceptWeapons.ToString();
            Number_Of_Rollslbl.Content = magicItemTreasure.NumberOfRolls.ToString();
            Max_Roll_Valuelbl.Content = magicItemTreasure.MaxRollValue.ToString();
            Magic_Item_Types_Formatted.Content = magicItemTreasure.MagicItemTypesFormatted.ToString();
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            if (magicItemLogicRepository.IsTreasureAvailable(monsterTypes))
            {
                IsTreasure.Content = "true";
                // Now we have to determine what magic items charts to roll on
                magicItemLogicRepository.WhatMagicItemsAreAvailable(monsterTypes);
                listOfTreasure.Content = magicItemLogicRepository.List;
                NumberOfMagicItems.Content = magicItemLogicRepository.NumberOfMagicItems.ToString();
                RevealMagicItems.IsEnabled = true;
                ActualRolledMagicItem.Content = "zero";// this did not fix the rolls either
            }
            else
            {
                IsTreasure.Content = "false";
                listOfTreasure.Content = string.Empty;
                NumberOfMagicItems.Content = "zero";
                RevealMagicItems.IsEnabled = false;
                ActualRolledMagicItem.Content = string.Empty;
                ChoosenMagicItems.Content = string.Empty;
            }
        }
        private void RollMagicItemClick(object sender, RoutedEventArgs e)
        {
            magicItemLogicRepository.ResetShowRoll();
            magicItemLogicRepository.RollForMagicSubtable();
            ChoosenMagicItems.Content = magicItemLogicRepository.Items;
            ActualRolledMagicItem.Content = string.Join(", ", magicItemLogicRepository.ShowRoll);
            RevealMagicItems.IsEnabled = false;
            RevealActualMagicItemLoot.IsEnabled = true;
        }

        private void RevealActualMagicItemLootTables(object sender, RoutedEventArgs e)
        {
            ActualMagicItemLoot acutalMagicItemLoot = new ActualMagicItemLoot(magicItemLogicRepository.Items.ToString());
            acutalMagicItemLoot.ShowDialog();
            ActualRolledMagicItem.Content = "zero";
            RevealActualMagicItemLoot.IsEnabled = false;
        }     
        
        private void SetMonsterType(string monsterTypeString)
        {
            string newMonsterTypeString = monsterTypeString.Replace(RemoveBoilerPlate, "").Replace(":", "");
            monsterTypes = getCharts.GetMonsterType(newMonsterTypeString); 
        }

        private MonetaryTreasureTypes SetMonetaryType(string monetaryTypeString)
        {
            string newMonetaryTypeString = monetaryTypeString.Replace(RemoveMoreBoilerPlate, "").Replace(":", "");
            return getCharts.GetMonetaryTreasureType(newMonetaryTypeString);
        }
    }
}
