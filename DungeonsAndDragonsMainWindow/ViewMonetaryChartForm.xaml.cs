using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMonetaryChartForm.xaml
    /// </summary>
    public partial class ViewMonetaryChartForm : Window
    {
        GetCharts ChartEngine;
        MonsterTypes MonsterTypes;

        public ViewMonetaryChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        #region MonetaryButtonClicks
        private void Copperbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Copper");
        }

        private void Silverbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Silver");
        }

        private void Electrumbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Electrum");
        }

        private void Goldbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Gold");
        }

        private void Platinumbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Platinum");
        }
        #endregion MonetaryButtonClicks

        #region Monsters_A_To_K_ButtonClicks
        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.A;
            ChangeMonsterType("Monster Type A:");
        }

        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.B;
            ChangeMonsterType("Monster Type B:");
        }

        private void Monster_Type_Cbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.C;
            ChangeMonsterType("Monster Type C:");
        }

        private void Monster_Type_Dbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.D;
            ChangeMonsterType("Monster Type D:");
        }

        private void Monster_Type_Ebtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.E;
            ChangeMonsterType("Monster Type E:");
        }

        private void Monster_Type_Fbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.F;
            ChangeMonsterType("Monster Type F:");
        }

        private void Monster_Type_Gbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.G;
            ChangeMonsterType("Monster Type G:");
        }

        private void Monster_Type_Hbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.H;
            ChangeMonsterType("Monster Type H:");
        }

        private void Monster_Type_Ibtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.I;
            ChangeMonsterType("Monster Type I:");
        }

        private void Monster_Type_Jbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.J;
            ChangeMonsterType("Monster Type J:");
        }

        private void Monster_Type_Kbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.K;
            ChangeMonsterType("Monster Type K:");
        }
        #endregion Monsters_A_TO_K_ButtonClick
        #region Monsters_L_To_V_ButtonClicks
        private void Monster_Type_Lbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.L;
            ChangeMonsterType("Monster Type L:");
        }

        private void Monster_Type_Mbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.M;
            ChangeMonsterType("Monster Type M:");
        }

        private void Monster_Type_Nbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.N;
            ChangeMonsterType("Monster Type N:");
        }

        private void Monster_Type_Obtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.O;
            ChangeMonsterType("Monster Type O:");
        }

        private void Monster_Type_Pbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.P;
            ChangeMonsterType("Monster Type P:");
        }

        private void Monster_Type_Qbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.Q;
            ChangeMonsterType("Monster Type Q:");
        }

        private void Monster_Type_Rbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.R;
            ChangeMonsterType("Monster Type R:");
        }

        private void Monster_Type_Sbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.S;
            ChangeMonsterType("Monster Type S:");
        }

        private void Monster_Type_Tbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.T;
            ChangeMonsterType("Monster Type T:");
        }

        private void Monster_Type_Ubtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.U;
            ChangeMonsterType("Monster Type U:");
        }

        private void Monster_Type_Vbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = MonsterTypes.V;
            ChangeMonsterType("Monster Type V:");
        }
        #endregion Monsters_L_To_V_ButtonClicks

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

        private void ChangeMonsterType(string monsterCategory)
        {
            Monster_Typelbl.Content = monsterCategory;
        }
    }
}
