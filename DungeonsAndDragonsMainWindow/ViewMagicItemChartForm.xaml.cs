using System.Windows;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMagicItemChartForm.xaml
    /// </summary>
    public partial class ViewMagicItemChartForm : Window
    {
        GetCharts GetCharts; //todo what is with the 2nd getcharts? Why is it gray? I can get rid of it? Same with monsterTypes below?
        MonsterTypes monsterTypes;

        public ViewMagicItemChartForm()
        {
            InitializeComponent();
            GetCharts = new GetCharts();
        }
        #region Monsters_A_To_K_ButtonClick
        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
        }

        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
        }

        private void Monster_Type_Cbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
        }

        private void Monster_Type_Dbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
        }

        private void Monster_Type_Ebtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
        }

        private void Monster_Type_Fbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;
        }

        private void Monster_Type_Gbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.G;
        }

        private void Monster_Type_Hbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.H;

        }

        private void Monster_Type_Ibtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.I;

        }

        private void Monster_Type_Jbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.J;

        }

        private void Monster_Type_Kbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.K;

        }
        #endregion Monsters_A_To_K_ButtonClick

        #region Monsters_L_To_V_ButtonClick
        private void Monster_Type_Lbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.L;
        }

        private void Monster_Type_Mbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.M;
        }

        private void Monster_Type_Nbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.N;
        }

        private void Monster_Type_Obtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.O;
        }

        private void Monster_Type_Pbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.P;
        }

        private void Monster_Type_Qbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.Q;
        }

        private void Monster_Type_Rbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.R;
        }

        private void Monster_Type_Sbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.S;
        }

        private void Monster_Type_Tbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.T;
        }

        private void Monster_Type_Ubtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.U;
        }

        private void Monster_Type_Vbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.V;
        }
        #endregion Monsters_L_To_V_ButtonClick

        #region MonetaryButtonClick
        private void Copperbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Silverbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Electrumbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Goldbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Platinumbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion MonetaryButtonClick

    }
}
