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
        GeneralMethods generalMethods = new GeneralMethods();
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
                PopulateJewelryTotalPieces(JewelryLogicRepository.Bracelet.ToString(), JewelryLogicRepository.Pin.ToString(), JewelryLogicRepository.Brooch.ToString(),
                    JewelryLogicRepository.Earring.ToString(), JewelryLogicRepository.Pendant.ToString(), JewelryLogicRepository.Necklace.ToString(),
                    JewelryLogicRepository.Crown.ToString(), JewelryLogicRepository.Sceptre.ToString());

                PopulateJewelryGPValue(JewelryLogicRepository.BraceletGPValue.ToString(), JewelryLogicRepository.PinGPValue.ToString(),
                    JewelryLogicRepository.BroochGPValue.ToString(), JewelryLogicRepository.EarringGPValue.ToString(), JewelryLogicRepository.PendantGPValue.ToString(),
                    JewelryLogicRepository.NecklaceGPValue.ToString(), JewelryLogicRepository.CrownGPValue.ToString(), JewelryLogicRepository.SceptreGPValue.ToString());

                PopulateIndividualJewelryGPValue(JewelryLogicRepository.IndividualBraceletGPValue, JewelryLogicRepository.IndividualPinGPValue,
                    JewelryLogicRepository.IndividualBroochGPValue, JewelryLogicRepository.IndividualEarringGPValue,
                    JewelryLogicRepository.IndividualPendantGPValue, JewelryLogicRepository.IndividualNecklaceGPValue,
                    JewelryLogicRepository.IndividualCrownGPValue, JewelryLogicRepository.IndividualSceptreGPValue);

            }
            else
            {
                TotalNumberOfJewelsValue.Text = Constants.Zero;

                PopulateJewelryTotalPieces(Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero);

                PopulateJewelryGPValue(Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero);

                PopulateIndividualJewelryGPValue(Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero);
            }
        }

        private void PopulateJewelryTotalPieces(string bracelet, string pin, string brooch, string earring, 
            string pendant, string necklace, string crown, string sceptre)
        {
            Bracelet.Text = bracelet;
            Pin.Text = pin;
            Brooch.Text = brooch;
            Earring.Text = earring;
            Pendant.Text = pendant;
            Necklace.Text = necklace;
            Crown.Text = crown;
            Sceptre.Text = sceptre;
        }

        private void PopulateJewelryGPValue(string bracelet, string pin, string brooch, string earring,
            string pendant, string necklace, string crown, string sceptre)
        {
            Bracelet_GP_Value.Text = bracelet;
            Pin_GP_Value.Text = pin;
            Brooch_GP_Value.Text = brooch;
            Earring_GP_Value.Text = earring;
            Pendant_GP_Value.Text = pendant;
            Necklace_GP_Value.Text = necklace;
            Crown_GP_Value.Text = crown;
            Sceptre_GP_Value.Text = sceptre;
        }

        private void PopulateIndividualJewelryGPValue(string bracelet, string pin, string brooch, string earring,
            string pendant, string necklace, string crown, string sceptre)
        {
            Individual_Bracelet_GP_Value.Text = bracelet;
            Individual_Pin_GP_Value.Text = pin;
            Individual_Brooch_GP_Value.Text = brooch;
            Individual_Earring_GP_Value.Text = earring;
            Individual_Pendant_GP_Value.Text = pendant;
            Individual_Necklace_GP_Value.Text = necklace;
            Individual_Crown_GP_Value.Text = crown;
            Individual_Sceptre_GP_Value.Text = sceptre;
        }
        private void SetMonsterType(object sender, RoutedEventArgs e)
        {
            string monsterType = sender.ToString();
            monsterType = generalMethods.FilteredString(monsterType, Constants.BoilerPlateMonsterType);
            Monster_Type_Selected.Content = $"{Constants.MonsterSelection}{monsterType}";
            Roll.IsEnabled = true;
            monsterTypes = generalMethods.GetMonsterType(monsterType, ChartEngine);
        }
    }
}
