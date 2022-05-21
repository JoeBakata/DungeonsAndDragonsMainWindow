using System.Linq;
using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;
using DungeonsAndDragons.ChartEngine.Services;

namespace DungeonsAndDragonsMainWindow.ButtonView
{
    /// <summary>
    /// Interaction logic for ViewGemChartForm.xaml
    /// </summary>
    public partial class ViewGemChartForm : Window
    {
        GetCharts ChartEngine;
        MonsterTypes monsterTypes;
        GeneralMethods generalMethods = new GeneralMethods();

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
                logicRepository.GetGemNumbers(numberOfGems);
                TotalNumberOfGemsValue.Text = numberOfGems;
                logicRepository.GetGemGPValue();
                PopulateGemDisplays(logicRepository);
            }
            else
            {
                ZeroOutGemDisplays();
            }
        }

        private void PopulateGemDisplays(GemLogicRepository logicRepository)
        {
            PopulateGemTotal(logicRepository.Quartz.ToString(), logicRepository.Turquoise.ToString(), logicRepository.Citrine.ToString(),
                logicRepository.Onyx.ToString(), logicRepository.Amber.ToString(), logicRepository.Garnet.ToString(), logicRepository.Pearl.ToString(),
                logicRepository.Topaz.ToString(), logicRepository.Opal.ToString(), logicRepository.Ruby.ToString());

            PopulateGemGPValue(logicRepository.QuartzGPValue, logicRepository.TurquoiseGPValue, logicRepository.CitrineGPValue, logicRepository.OnyxGPValue,
                logicRepository.AmberGPValue, logicRepository.GarnetGPValue, logicRepository.PearlGPValue, logicRepository.TopazGPValue,
                logicRepository.OpalGPValue, logicRepository.RubyGPValue);

            // todo this is weird. the gem GP Value is an int. However, the gemtotal is also an int but we put .tostring() on it.  Why? Why not .toString() on GPValue?
            //Quartz_GP_Value.Content = logicRepository.QuartzGPValue;
            //Turquoise_GP_Value.Content = logicRepository.TurquoiseGPValue; 
            //Citrine_GP_Value.Content = logicRepository.CitrineGPValue;
            //Onyx_GP_Value.Content = logicRepository.OnyxGPValue;
            //Amber_GP_Value.Content = logicRepository.AmberGPValue;
            //Garnet_GP_Value.Content = logicRepository.GarnetGPValue;
            //Pearl_GP_Value.Content = logicRepository.PearlGPValue;
            //Topaz_GP_Value.Content = logicRepository.TopazGPValue;
            //Opal_GP_Value.Content = logicRepository.OpalGPValue;
            //Ruby_GP_Value.Content = logicRepository.RubyGPValue;

            PopulateIndividualGemGPValue(logicRepository.IndividualQuartzGPValue, logicRepository.IndividualTurquoiseGPValue,
                logicRepository.IndividualCitrineGPValue, logicRepository.IndividualOnyxGPValue, logicRepository.IndividualAmberGPValue,
                logicRepository.IndividualGarnetGPValue, logicRepository.IndividualPearlGPValue, logicRepository.IndividualTopazGPValue,
                logicRepository.IndividualOpalGPValue, logicRepository.IndividualRubyGPValue);
        }
        private void ZeroOutGemDisplays()
        {
            PopulateGemTotal(Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero,
                Constants.Zero, Constants.Zero, Constants.Zero, Constants.Zero);

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

        private void PopulateGemTotal(string quartz, string turquoise, string citrine, string onyx, string amber, string garnet, string pearl,
            string topaz, string opal, string ruby)
        {
            Quartz.Content = quartz;
            Turquoise.Content = turquoise;
            Citrine.Content = citrine;
            Onyx.Content = onyx;
            Amber.Content = amber;
            Garnet.Content = garnet;
            Pearl.Content = pearl;
            Topaz.Content = topaz;
            Opal.Content = opal;
            Ruby.Content = ruby;
        }

        private void PopulateGemGPValue(int quartz, int turquoise, int citrine, int onyx, int amber, int garnet, int pearl,
            int topaz, int opal, int ruby)
        {
            Quartz_GP_Value.Content = quartz;
            Turquoise_GP_Value.Content = turquoise;
            Citrine_GP_Value.Content = citrine;
            Onyx_GP_Value.Content = onyx;
            Amber_GP_Value.Content = amber;
            Garnet_GP_Value.Content = garnet;
            Pearl_GP_Value.Content = pearl;
            Topaz_GP_Value.Content = topaz;
            Opal_GP_Value.Content = opal;
            Ruby_GP_Value.Content = ruby;
        }

        private void PopulateIndividualGemGPValue(string quartz, string turquoise, string citrine, string onyx, string amber, string garnet, string pearl,
            string topaz, string opal, string ruby)
        {
            Quartz_Individual_GP_Value.Content = quartz;
            Turquoise_Individual_GP_Value.Content = turquoise;
            Citrine_Individual_GP_Value.Content = citrine;
            Onyx_Individual_GP_Value.Content = onyx;
            Amber_Individual_GP_Value.Content = amber;
            Garnet_Individual_GP_Value.Content = garnet;
            Pearl_Individual_GP_Value.Content = pearl;
            Topaz_Individual_GP_Value.Content = topaz;
            Opal_Individual_GP_Value.Content = opal;
            Ruby_Individual_GP_Value.Content = ruby;
        }

        private void SetGemLabel(object sender, RoutedEventArgs e)
        {
            string gemType = sender.ToString();
            gemType = generalMethods.FilteredString(gemType, Constants.BoilerPlate);
            GemType typeOfGem = ChartEngine.GetGemType(gemType);
            ChangeDisplay(typeOfGem);
        }

        private void SetMonsterType(object sender, RoutedEventArgs e)
        {
            monsterTypes = generalMethods.GetMonsterType(sender.ToString(), ChartEngine);
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        private void RollButtonEnabledByMonsterSelection(MonsterTypes monsterTypes)
        {
            Monster_Type_Selected.Content = $"{Constants.MonsterSelection}{monsterTypes}";
            Roll.IsEnabled = true;
        }
    }
}
