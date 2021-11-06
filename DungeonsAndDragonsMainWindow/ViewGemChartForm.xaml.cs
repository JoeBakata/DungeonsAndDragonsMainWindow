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
        MonsterTypes monsterTypes = MonsterTypes.B;// Don't think this is needed anymore

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
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        public void MonsterTypeB(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeC(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeD(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        public void MonsterTypeE(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        public void MonsterTypeF(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeG(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeH(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeI(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeJ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeK(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeL(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        #endregion monsterTypesA-L

        #region monsterTypesM-V
        public void MonsterTypeM(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeN(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeO(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeP(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeQ(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeR(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeS(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";

        }
        public void MonsterTypeT(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        public void MonsterTypeU(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
        }
        public void MonsterTypeV(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
            Monster_Type_Selected.Content = $"You selected monster type: {monsterTypes}";
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
            string numberOfGems = "0";
            User_Dice_Roll.Content = answer.ToString();
            Percentage_Roll.Content = logicRepository.NumberRolled;
            if (answer)
            {
                numberOfGems = logicRepository.GetNumberOfGems(monsterTypes);
                NumberOfGems.Content = numberOfGems;
                logicRepository.GetGemNumbers(numberOfGems);
                Quartz.Content = logicRepository.Quartz.ToString();
                Turquoise.Content = logicRepository.Turquoise.ToString();
                Citrine.Content = logicRepository.Citrine.ToString();
                Onyx.Content = logicRepository.Onyx.ToString();
                Amber.Content = logicRepository.Amber.ToString();
                Garnet.Content = logicRepository.Garnet.ToString();
                Pearl.Content = logicRepository.Pearl.ToString();// This was logicRepository.Garnet. Fixed to dot Pearl. I think this will fix the for loop
                Topaz.Content = logicRepository.Topaz.ToString();
                Opal.Content = logicRepository.Opal.ToString();
                Ruby.Content = logicRepository.Ruby.ToString();
            }
            else
            {
                numberOfGems = "0";
                NumberOfGems.Content = "0";
            }
        }
    }
}
