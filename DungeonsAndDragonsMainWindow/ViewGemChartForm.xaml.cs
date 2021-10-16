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
        GetCharts ChartEngine;
        MonsterTypes monsterTypes = MonsterTypes.B;

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
        }
        public void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
        }
        public void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
        }
        public void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
        }
        public void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
        }
        public void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
        }
        public void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
        }
        public void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
        }
        public void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
        }
        public void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
        }
        public void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
        }
        public void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
        }
        #endregion monsterTypesA-L

        #region monsterTypesM-V
        public void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
        }
        public void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
        }
        public void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
        }
        public void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
        }
        public void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
        }
        public void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
        }
        public void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
        }
        public void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
        }
        public void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
        }
        public void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
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
            var logicRepository = new DungeonsAndDragons.ChartEngine.Services.LogicRepository();
            bool answer = logicRepository.PercentageRoll(monsterTypes);
            User_Dice_Roll.Content = answer.ToString();
        }
    }
}
