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
            ThereAreJewelsBoolean.Content = answer.ToString();
            Percentage_Rolled.Content = JewelryLogicRepository.DiceNumberRolled;
            TotalNumberOfJewelsValue.Content = JewelryLogicRepository.NumberOfJewelryPieces.ToString();
            
            if (answer)
            {
                Bracelet.Content = JewelryLogicRepository.Bracelet.ToString();
                Pin.Content = JewelryLogicRepository.Pin.ToString();
                Brooch.Content = JewelryLogicRepository.Brooch.ToString();
                Earring.Content = JewelryLogicRepository.Earring.ToString();
                Pendant.Content = JewelryLogicRepository.Pendant.ToString();
                Necklace.Content = JewelryLogicRepository.Necklace.ToString();
                Crown.Content = JewelryLogicRepository.Crown.ToString();
                Sceptre.Content = JewelryLogicRepository.Sceptre.ToString();
                // This puts the value to 0. How do I get the actual GPValue?
                // I figured this out on my own. Hopefully it is good, we can go over it to see.
                Bracelet_GP_Value.Content = JewelryLogicRepository.BraceletGPValue;
                Pin_GP_Value.Content = JewelryLogicRepository.PinGPValue;
                Brooch_GP_Value.Content = JewelryLogicRepository.BroochGPValue;
                Earring_GP_Value.Content = JewelryLogicRepository.EarringGPValue;
                Pendant_GP_Value.Content = JewelryLogicRepository.PendantGPValue;
                Necklace_GP_Value.Content = JewelryLogicRepository.NecklaceGPValue;
                Crown_GP_Value.Content = JewelryLogicRepository.CrownGPValue;
                Sceptre_GP_Value.Content = JewelryLogicRepository.SceptreGPValue;
                // I was so happy to figure this out. I added this to push the values to the GP spot on the .xaml and to get it to work I added
                // GetJewelryGPValue() to JewelryLogicRepository.cs  I can't explain in programming terms what is happening but I figured it out
                // Without using Google, Just by looking through the code and trying to figure out how to make it display to the screen. I used Logic!
            }
            else
            {
                TotalNumberOfJewelsValue.Content = "0";
                Bracelet_GP_Value.Content = "0";
                Pin_GP_Value.Content = "0";
                Brooch_GP_Value.Content = "0";
                Earring_GP_Value.Content = "0";
                Pendant_GP_Value.Content = "0";
                Necklace_GP_Value.Content = "0";
                Crown_GP_Value.Content = "0";
                Sceptre_GP_Value.Content = "0";

                Bracelet.Content = "0";
                Pin.Content = "0";
                Brooch.Content = "0";
                Earring.Content = "0";
                Pendant.Content = "0";
                Necklace.Content = "0";
                Crown.Content = "0";
                Sceptre.Content = "0";

            }


        }
        #region monsterTypesA-L

        private void MonsterTypeA(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        #endregion monsterTypesA-L

        #region monsterTypesM-V

        private void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }

        private void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        #endregion monsterTypesM-V

    }// Bracelet, Pin, Brooch, Earring, Pendant, Necklace, crown, Scepter
}
