using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DungeonsAndDragons.ChartEngine.Utilities;


namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ViewMagicItemChartForm.xaml
    /// </summary>
    public partial class ViewMagicItemChartForm : Window
    {
        DungeonsAndDragons.ChartEngine.Charts.GetCharts GetCharts;
        MonsterTypes monsterTypes;

        public ViewMagicItemChartForm()
        {
            InitializeComponent();
            GetCharts = new DungeonsAndDragons.ChartEngine.Charts.GetCharts();
        }
        #region ButtonClick
        private void Monster_Type_Abtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.A;
        }

        private void Monster_Type_Bbtn_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.B;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.C;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.D;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.E;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            monsterTypes = MonsterTypes.F;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
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
        #endregion ButtonClick

    }
}
