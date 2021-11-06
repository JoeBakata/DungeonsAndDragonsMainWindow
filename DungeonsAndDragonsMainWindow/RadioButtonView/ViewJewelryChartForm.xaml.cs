using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Charts.Treasure;
using DungeonsAndDragons.ChartEngine.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DungeonsAndDragonsMainWindow.RadioButtonView
{
    /// <summary>
    /// Interaction logic for ViewJewelryChartForm.xaml
    /// </summary>
    public partial class ViewJewelryChartForm : Window
    {
        public ViewJewelryChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }
        GetCharts ChartEngine;
        MonsterTypes monsterTypes;

        public void SelectionTypeDisplay(object sender, RoutedEventArgs e)
        {
            if (Braceletrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Bracelet);
            }
            else if (Pinrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Pin);
            }
            else if (Broochrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Brooch);
            }
            else if (Earringrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Earring);
            }
            else if (Pendantrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Pendant);
            }
            else if (Necklacerdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Necklace);
            }
            else if (Crownrdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Crown);
            }
            else if (Sceptrerdbtn.IsChecked == true)
            {
                ChangeDisplay(JewelryType.Sceptre);
            }
        }

        private void ChangeDisplay(JewelryType jewelryType)
        {
            List<JewelryValue> jewelryTreasures = ChartEngine.JewelryGPValueChart;
            JewelryValue list = jewelryTreasures.First(x => x.JewelryType == jewelryType);
            Jewlery_Typelbl.Content = jewelryType;
            Minimum_GP_Valuelbl.Content = list.MinimumGPValue;
            Maximum_GP_Valuelbl.Content = list.MaximumGPValue;

        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            var JewelryLogicRepository = new DungeonsAndDragons.ChartEngine.Services.JewelryLogicRepository();
            bool answer = JewelryLogicRepository.PercentageRoll(monsterTypes);
            Number_Rolled.Content = answer.ToString();
            Percentage_Rolled.Content = JewelryLogicRepository.NumberRolled;


        }

        private void MonsterTypeA(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A; 
        }

        private void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
        }

        private void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
        }

        private void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
        }

        private void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
        }

        private void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
        }

        private void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
        }

        private void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
        }

        private void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
        }

        private void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
        }

        private void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
        }

        private void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
        }

        private void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
        }

        private void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
        }

        private void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
        }

        private void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
        }

        private void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
        }

        private void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
        }

        private void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
        }

        private void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
        }

        private void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
        }

        private void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
        }
    }// Bracelet, Pin, Brooch, Earring, Pendant, Necklace, crown, Scepter
}
