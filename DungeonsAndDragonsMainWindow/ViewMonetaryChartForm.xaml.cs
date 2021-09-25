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
using System.Windows.Shapes;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMonetaryChartForm.xaml
    /// </summary>
    public partial class ViewMonetaryChartForm : Window
    {
        
        DungeonsAndDragons.ChartEngine.Charts.GetCharts ChartEngine;

        DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes MonsterTypes;

        public ViewMonetaryChartForm()
        {
            InitializeComponent();
            ChartEngine = new DungeonsAndDragons.ChartEngine.Charts.GetCharts();

        }

        #region ButtonClicks


        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.A;
            ChangeMonsterType("Monster Type A:");
        }


        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.B;
            ChangeMonsterType("Monster Type B:");

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



        private void Copperbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Copper");
        }

        private void Silverbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeDisplay("Silver");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.C;
            ChangeMonsterType("Monster Type C:");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.D;
            ChangeMonsterType("Monster Type D:");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.E;
            ChangeMonsterType("Monster Type E:");

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.F;
            ChangeMonsterType("Monster Type F:");

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.G;
            ChangeMonsterType("Monster Type G:");

        }

        private void Monster_Type_Hbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.H;
            ChangeMonsterType("Monster Type H:");

        }

        private void Monster_Type_Ibtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.I;
            ChangeMonsterType("Monster Type I:");

        }

        private void Monster_Type_Jbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.J;
            ChangeMonsterType("Monster Type J:");

        }

        private void Monster_Type_Kbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.K;
            ChangeMonsterType("Monster Type K:");

        }

        private void Monster_Type_Lbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.L;
            ChangeMonsterType("Monster Type L:");

        }

        private void Monster_Type_Mbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.M;
            ChangeMonsterType("Monster Type M:");

        }

        private void Monster_Type_Nbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.N;
            ChangeMonsterType("Monster Type N:");

        }

        private void Monster_Type_Obtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.O;
            ChangeMonsterType("Monster Type O:");

        }

        private void Monster_Type_Pbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.P;
            ChangeMonsterType("Monster Type P:");

        }

        private void Monster_Type_Qbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.Q;
            ChangeMonsterType("Monster Type Q:");

        }

        private void Monster_Type_Rbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.R;
            ChangeMonsterType("Monster Type R:");

        }

        private void Monster_Type_Sbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.S;
            ChangeMonsterType("Monster Type S:");

        }

        private void Monster_Type_Tbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.T;
            ChangeMonsterType("Monster Type T:");

        }

        private void Monster_Type_Ubtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.U;
            ChangeMonsterType("Monster Type U:");

        }

        private void Monster_Type_Vbtn_Click(object sender, RoutedEventArgs e)
        {
            MonsterTypes = DungeonsAndDragons.ChartEngine.Utilities.MonsterTypes.V;
            ChangeMonsterType("Monster Type V:");

        }



        #endregion ButtonClicks

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
