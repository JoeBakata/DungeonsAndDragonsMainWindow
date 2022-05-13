using System.Linq;
using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Services;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewGemChartForm.xaml
    /// </summary>
    public partial class ViewGemChartForm : Window
    {
        GetCharts ChartEngine;
        MonsterTypes monsterTypes;

        public ViewGemChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        private void ChangeDisplay(GemType gemType)
        {
            var gemTreasures = ChartEngine.GemGPValueChart;
            var list = gemTreasures.First(x => x.GemType == gemType);
            Gem_Typelbl.Text = gemType.ToString();
            Minimum_GP_Valuelbl.Text = list.MinimumGPValue.ToString();
            Minimum_Roll_Valuelbl.Text = list.MinimumRollValue.ToString();
            Maximum_Roll_Valuelbl.Text = list.MaximumRollValue.ToString();
            Dicelbl.Text = list.Dice.ToString();
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            var logicRepository = new GemLogicRepository();
            bool answer = logicRepository.PercentageRolled(monsterTypes);
            string numberOfGems = Constants.Zero;
            ThereAreGemsBoolean.Text = answer.ToString();
            Percentage_Rolled.Text = logicRepository.PercentRollToSeeIfGems;
            if (answer)
            {
                numberOfGems = logicRepository.GetNumberOfGems(monsterTypes);
                TotalNumberOfGemsValue.Text = numberOfGems;
                logicRepository.GetGemNumbers(numberOfGems);
                Quartz.Content = logicRepository.Quartz.ToString();
                Turquoise.Content = logicRepository.Turquoise.ToString();
                Citrine.Content = logicRepository.Citrine.ToString();
                Onyx.Content = logicRepository.Onyx.ToString();
                Amber.Content = logicRepository.Amber.ToString();
                Garnet.Content = logicRepository.Garnet.ToString();
                Pearl.Content = logicRepository.Pearl.ToString();
                Topaz.Content = logicRepository.Topaz.ToString();
                Opal.Content = logicRepository.Opal.ToString();
                Ruby.Content = logicRepository.Ruby.ToString();
                logicRepository.GetGemGPValue();
                Quartz_GP_Value.Content = logicRepository.QuartzGPValue;
                Turquoise_GP_Value.Content = logicRepository.TurquoiseGPValue;
                Citrine_GP_Value.Content = logicRepository.CitrineGPValue;
                Onyx_GP_Value.Content = logicRepository.OnyxGPValue;
                Amber_GP_Value.Content = logicRepository.AmberGPValue;
                Garnet_GP_Value.Content = logicRepository.GarnetGPValue;
                Pearl_GP_Value.Content = logicRepository.PearlGPValue;
                Topaz_GP_Value.Content = logicRepository.TopazGPValue;
                Opal_GP_Value.Content = logicRepository.OpalGPValue;
                Ruby_GP_Value.Content = logicRepository.RubyGPValue;

                Quartz_Individual_GP_Value.Content = logicRepository.IndividualQuartzGPValue;
                Turquoise_Individual_GP_Value.Content = logicRepository.IndividualTurquoiseGPValue;
                Citrine_Individual_GP_Value.Content = logicRepository.IndividualCitrineGPValue;
                Onyx_Individual_GP_Value.Content = logicRepository.IndividualOnyxGPValue;
                Amber_Individual_GP_Value.Content = logicRepository.IndividualAmberGPValue;
                Garnet_Individual_GP_Value.Content = logicRepository.IndividualGarnetGPValue;
                Pearl_Individual_GP_Value.Content = logicRepository.IndividualPearlGPValue;
                Topaz_Individual_GP_Value.Content = logicRepository.IndividualTopazGPValue;
                Opal_Individual_GP_Value.Content = logicRepository.IndividualOpalGPValue;
                Ruby_Individual_GP_Value.Content = logicRepository.IndividualRubyGPValue;
            }
            else
            {
                numberOfGems = Constants.Zero;
                Quartz_GP_Value.Content = Constants.Zero;
                Turquoise_GP_Value.Content = Constants.Zero;
                Citrine_GP_Value.Content = Constants.Zero;
                Onyx_GP_Value.Content = Constants.Zero;
                Amber_GP_Value.Content = Constants.Zero;
                Garnet_GP_Value.Content = Constants.Zero;
                Pearl_GP_Value.Content = Constants.Zero;
                Topaz_GP_Value.Content = Constants.Zero;
                Opal_GP_Value.Content = Constants.Zero;
                Ruby_GP_Value.Content = Constants.Zero;

                Quartz.Content = Constants.Zero;
                Turquoise.Content = Constants.Zero;
                Citrine.Content = Constants.Zero;
                Onyx.Content = Constants.Zero;
                Amber.Content = Constants.Zero;
                Garnet.Content = Constants.Zero;
                Pearl.Content = Constants.Zero;
                Topaz.Content = Constants.Zero;
                Opal.Content = Constants.Zero;
                Ruby.Content = Constants.Zero;

                Quartz_Individual_GP_Value.Content = Constants.Zero;
                Turquoise_Individual_GP_Value.Content = Constants.Zero;
                Citrine_Individual_GP_Value.Content = Constants.Zero;
                Onyx_Individual_GP_Value.Content = Constants.Zero;
                Amber_Individual_GP_Value.Content = Constants.Zero;
                Garnet_Individual_GP_Value.Content = Constants.Zero;
                Pearl_Individual_GP_Value.Content = Constants.Zero;
                Topaz_Individual_GP_Value.Content = Constants.Zero;
                Opal_Individual_GP_Value.Content = Constants.Zero;
                Ruby_Individual_GP_Value.Content = Constants.Zero;

                TotalNumberOfGemsValue.Text = Constants.Zero;
            }
        }

        private void SetGemLabel(object sender, RoutedEventArgs e)
        {
            string gemType = sender.ToString();
            gemType = FilteredString(gemType, Constants.BoilerPlate);
            GemType typeOfGem = ChartEngine.GetGemType(gemType);
            ChangeDisplay(typeOfGem);
        }

        private void SetMonsterType(object sender, RoutedEventArgs e)
        {
            string monsterType = sender.ToString();
            monsterType = FilteredString(monsterType, Constants.BoilerPlateMonsterType);
            monsterTypes = ChartEngine.GetMonsterType(monsterType);
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        private string FilteredString(string unfilteredString, string textToRemove)
        {
            string filteredString = unfilteredString.Replace(textToRemove, "");
            return filteredString;
        }
        private void RollButtonEnabledByMonsterSelection(MonsterTypes monsterTypes)
        {
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
            Roll.IsEnabled = true;
        }
    }
}
