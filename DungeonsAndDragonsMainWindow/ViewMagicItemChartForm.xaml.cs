using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Services;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMagicItemChartForm.xaml
    /// </summary>
    public partial class ViewMagicItemChartForm : Window
    {
        GetCharts getCharts;
        MonsterTypes monsterTypes;
        MagicItemLogicRepository magicItemLogicRepository;
        public ViewMagicItemChartForm()
        {
            InitializeComponent();
            getCharts = new GetCharts();
            magicItemLogicRepository = new MagicItemLogicRepository(getCharts);

        }
        #region Monsters_A_To_K_ButtonClick
        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
            ChangeMonsterTypeLabelAndEnableRoll();
        }

        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
            ChangeMonsterTypeLabelAndEnableRoll();
        }

        private void Monster_Type_Cbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Dbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
            ChangeMonsterTypeLabelAndEnableRoll();
        }

        private void Monster_Type_Ebtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Fbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Gbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Hbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
            ChangeMonsterTypeLabelAndEnableRoll();


        }

        private void Monster_Type_Ibtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
            ChangeMonsterTypeLabelAndEnableRoll();


        }

        private void Monster_Type_Jbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
            ChangeMonsterTypeLabelAndEnableRoll();


        }

        private void Monster_Type_Kbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
            ChangeMonsterTypeLabelAndEnableRoll();


        }
        #endregion Monsters_A_To_K_ButtonClick

        #region Monsters_L_To_V_ButtonClick
        private void Monster_Type_Lbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Mbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Nbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Obtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Pbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Qbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Rbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Sbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Tbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Ubtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
            ChangeMonsterTypeLabelAndEnableRoll();

        }

        private void Monster_Type_Vbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
            ChangeMonsterTypeLabelAndEnableRoll();

        }
        #endregion Monsters_L_To_V_ButtonClick

        #region MonetaryButtonClick
        private void Copperbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(MonetaryTreasureTypes.Copper);
        }

        private void Silverbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(MonetaryTreasureTypes.Silver);
        }

        private void Electrumbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(MonetaryTreasureTypes.Electrum);
        }

        private void Goldbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(MonetaryTreasureTypes.Gold);
        }

        private void Platinumbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeMagicItemChartLabel(MonetaryTreasureTypes.Platinum);
        }
        #endregion MonetaryButtonClick

        private void ChangeMonsterTypeLabelAndEnableRoll()
        {
            Monsterlbl.Content = monsterTypes.ToString();
            Roll.IsEnabled = true;
            // Added the following lines to try to do what you asked of me
            IsTreasure.Content = "false";
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
            magicItemLogicRepository.RollForMagicSubtable();
            ChoosenMagicItems.Content = magicItemLogicRepository.Items;
            ActualRolledMagicItem.Content = magicItemLogicRepository.ShowRoll.ToString();
            RevealMagicItems.IsEnabled = false;
            RevealActualMagicItemLoot.IsEnabled = true;
        }

        private void RevealActualMagicItemLootTables(object sender, RoutedEventArgs e)
        {
            ActualMagicItemLoot acutalMagicItemLoot = new ActualMagicItemLoot(magicItemLogicRepository.Items.ToString());
            acutalMagicItemLoot.ShowDialog();
        }
    }
}
