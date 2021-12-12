using System.Linq;
using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewGemChartForm.xaml
    /// </summary>
    public partial class ViewGemChartForm : Window
    {
        const string zero = "0";

        GetCharts ChartEngine;
        MonsterTypes monsterTypes;

        public ViewGemChartForm()
        {
            InitializeComponent();
            ChartEngine = new GetCharts();
        }

        #region ButtonClickGems
        public void Btn_Click_Quartz(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Quartz);
        }
        public void Btn_Click_Turquoise(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Turquoise);
        }
        public void Btn_Click_Citrine(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Citrine);
        }
        public void Btn_Click_Onyx(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Onyx);
        }
        public void Btn_Click_Amber(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Amber);
        }
        public void Btn_Click_Garnet(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Garnet);
        }
        public void Btn_Click_Pearl(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Pearl);
        }
        public void Btn_Click_Topaz(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Topaz);
        }
        public void Btn_Click_Opel(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Opal);
        }
        public void Btn_Click_Ruby(object sender, RoutedEventArgs e)
        {
            ChangeDisplay(GemType.Ruby);
        }
        #endregion ButtonClickGems

        #region monsterTypesA-L

        public void MonsterTypeA(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        #endregion monsterTypesA-L

        #region monsterTypesM-V
        public void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        public void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
            RollButtonEnabledByMonsterSelection(monsterTypes);
        }
        #endregion monsterTypesM-V

        private void ChangeDisplay(GemType gemType)
        {
            var gemTreasures = ChartEngine.GemGPValueChart;
            var list = gemTreasures.First(x => x.GemType == gemType);
            Gem_Typelbl.Content = gemType.ToString();
            Minimum_GP_Valuelbl.Content = list.MinimumGPValue.ToString();
            Minimum_Roll_Valuelbl.Content = list.MinimumRollValue.ToString();
            Maximum_Roll_Valuelbl.Content = list.MaximumRollValue.ToString();
            Dicelbl.Content = list.Dice.ToString();
        }

        private void Roll_Click(object sender, RoutedEventArgs e)
        {
            var logicRepository = new DungeonsAndDragons.ChartEngine.Services.GemLogicRepository();
            bool answer = logicRepository.PercentageRolled(monsterTypes);
            string numberOfGems = "0";
            ThereAreGemsBoolean.Content = answer.ToString();
            Percentage_Rolled.Content = logicRepository.PercentRollToSeeIfGems;
            if (answer)
            {
                numberOfGems = logicRepository.GetNumberOfGems(monsterTypes);
                TotalNumberOfGemsValue.Content = numberOfGems;
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
            }
            else
            {
                numberOfGems = zero;
                Quartz_GP_Value.Content = zero;
                Turquoise_GP_Value.Content = zero;
                Citrine_GP_Value.Content = zero;
                Onyx_GP_Value.Content = zero; 
                Amber_GP_Value.Content = zero;
                Garnet_GP_Value.Content = zero;
                Pearl_GP_Value.Content = zero;
                Topaz_GP_Value.Content = zero;
                Opal_GP_Value.Content = zero;
                Ruby_GP_Value.Content = zero;

                Quartz.Content = zero;
                Turquoise.Content = zero;
                Citrine.Content = zero;
                Onyx.Content = zero;
                Amber.Content = zero;
                Garnet.Content = zero;
                Pearl.Content = zero;
                Topaz.Content = zero;
                Opal.Content = zero;
                Ruby.Content = zero;

                TotalNumberOfGemsValue.Content = zero;
            }
        }

        private void RollButtonEnabledByMonsterSelection(MonsterTypes monsterTypes)
        {
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
            Roll.IsEnabled = true;
        }
    }
}
