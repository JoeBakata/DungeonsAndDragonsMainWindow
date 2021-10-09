using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMagicItemChartForm.xaml
    /// </summary>
    public partial class ViewMagicItemChartForm : Window
    {
        GetCharts getCharts;
        MonsterTypes monsterTypes;

        public ViewMagicItemChartForm()
        {
            InitializeComponent();
            getCharts = new GetCharts();
        }
        #region Monsters_A_To_K_ButtonClick
        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
            ChangeMonsterTypeLabel();
        }

        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Cbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Dbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
            ChangeMonsterTypeLabel();
        }

        private void Monster_Type_Ebtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Fbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Gbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Hbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
            ChangeMonsterTypeLabel();


        }

        private void Monster_Type_Ibtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
            ChangeMonsterTypeLabel();


        }

        private void Monster_Type_Jbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
            ChangeMonsterTypeLabel();


        }

        private void Monster_Type_Kbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
            ChangeMonsterTypeLabel();


        }
        #endregion Monsters_A_To_K_ButtonClick

        #region Monsters_L_To_V_ButtonClick
        private void Monster_Type_Lbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Mbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Nbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Obtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Pbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Qbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Rbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Sbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Tbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Ubtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
            ChangeMonsterTypeLabel();

        }

        private void Monster_Type_Vbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
            ChangeMonsterTypeLabel();

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

        private void ChangeMonsterTypeLabel()
        {
            Monsterlbl.Content = monsterTypes.ToString();
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
    }
}
