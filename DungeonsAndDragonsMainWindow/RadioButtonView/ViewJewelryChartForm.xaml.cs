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
        MonsterTypes monsterTypes;// This second monsterTypes suppose to be Capital MonsterTypes?
        const string Zero = "0";

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
            Jewlery_Typelbl.Text = jewelryType.ToString();
            Minimum_GP_Valuelbl.Text = list.MinimumGPValue.ToString();
            Maximum_GP_Valuelbl.Text = list.MaximumGPValue.ToString();
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            var JewelryLogicRepository = new DungeonsAndDragons.ChartEngine.Services.JewelryLogicRepository();
            bool answer = JewelryLogicRepository.PercentageRoll(monsterTypes);
            ThereAreJewelsBoolean.Text = answer.ToString();
            Percentage_Rolled.Text = JewelryLogicRepository.DiceNumberRolled;
            TotalNumberOfJewelsValue.Text = JewelryLogicRepository.NumberOfJewelryPieces.ToString();
            
            if (answer)
            {
                Bracelet.Text = JewelryLogicRepository.Bracelet.ToString();
                Pin.Text = JewelryLogicRepository.Pin.ToString();
                Brooch.Text = JewelryLogicRepository.Brooch.ToString();
                Earring.Text = JewelryLogicRepository.Earring.ToString();
                Pendant.Text = JewelryLogicRepository.Pendant.ToString();
                Necklace.Text = JewelryLogicRepository.Necklace.ToString();
                Crown.Text = JewelryLogicRepository.Crown.ToString();
                Sceptre.Text = JewelryLogicRepository.Sceptre.ToString();

                Bracelet_GP_Value.Text = JewelryLogicRepository.BraceletGPValue.ToString();
                Pin_GP_Value.Text = JewelryLogicRepository.PinGPValue.ToString();
                Brooch_GP_Value.Text = JewelryLogicRepository.BroochGPValue.ToString();
                Earring_GP_Value.Text = JewelryLogicRepository.EarringGPValue.ToString();
                Pendant_GP_Value.Text = JewelryLogicRepository.PendantGPValue.ToString();
                Necklace_GP_Value.Text = JewelryLogicRepository.NecklaceGPValue.ToString();
                Crown_GP_Value.Text = JewelryLogicRepository.CrownGPValue.ToString();
                Sceptre_GP_Value.Text = JewelryLogicRepository.SceptreGPValue.ToString();

                Individual_Bracelet_GP_Value.Text = JewelryLogicRepository.IndividualBraceletGPValue;
                Individual_Pin_GP_Value.Text = JewelryLogicRepository.IndividualPinGPValue;
                Individual_Brooch_GP_Value.Text = JewelryLogicRepository.IndividualBroochGPValue;
                Individual_Earring_GP_Value.Text = JewelryLogicRepository.IndividualEarringGPValue;
                Individual_Pendant_GP_Value.Text = JewelryLogicRepository.IndividualPendantGPValue;
                Individual_Necklace_GP_Value.Text = JewelryLogicRepository.IndividualNecklaceGPValue;
                Individual_Crown_GP_Value.Text = JewelryLogicRepository.IndividualCrownGPValue;
                Individual_Sceptre_GP_Value.Text = JewelryLogicRepository.IndividualSceptreGPValue;
            }
            else
            {
                TotalNumberOfJewelsValue.Text = "0";
                Bracelet_GP_Value.Text = "0";
                Pin_GP_Value.Text = "0";
                Brooch_GP_Value.Text = "0";
                Earring_GP_Value.Text = "0";
                Pendant_GP_Value.Text = "0";
                Necklace_GP_Value.Text = "0";
                Crown_GP_Value.Text = "0";
                Sceptre_GP_Value.Text = "0";

                Bracelet.Text = "0";
                Pin.Text = "0";
                Brooch.Text = "0";
                Earring.Text = "0";
                Pendant.Text = "0";
                Necklace.Text = "0";
                Crown.Text = "0";
                Sceptre.Text = Zero;

                Individual_Bracelet_GP_Value.Text = Zero;
                Individual_Pin_GP_Value.Text = Zero;
                Individual_Brooch_GP_Value.Text = Zero;
                Individual_Earring_GP_Value.Text = Zero;
                Individual_Pendant_GP_Value.Text = Zero;
                Individual_Necklace_GP_Value.Text = Zero;
                Individual_Crown_GP_Value.Text = Zero;
                Individual_Sceptre_GP_Value.Text = Zero;
            }


        }
        #region monsterTypesA-L

        private void MonsterTypeA(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.A);
        }

        private void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.B);
        }

        private void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.C);
        }

        private void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.D);
        }

        private void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.E);
        }

        private void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.F);
        }

        private void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.G);
        }

        private void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.H);
        }

        private void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.I);
        }

        private void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.J);
        }

        private void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.K);
        }

        private void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.L);
        }
        #endregion monsterTypesA-L

        #region monsterTypesM-V

        private void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.M);
        }

        private void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.N);
        }

        private void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.O);
        }

        private void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.P);
        }

        private void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.Q);
        }

        private void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.R);
        }

        private void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.S);
        }

        private void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.T);
        }

        private void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.U);
        }

        private void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            RollButtonEnabledByMonsterSelection(MonsterTypes.V);
        }
        #endregion monsterTypesM-V

        private void RollButtonEnabledByMonsterSelection(MonsterTypes _monsterTypes)
        {
            monsterTypes = _monsterTypes;
            Monster_Type_Selected.Content = $"You selected monster type: {_monsterTypes}";
            Roll.IsEnabled = true;
        }
    }
}
