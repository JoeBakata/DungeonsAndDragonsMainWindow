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
using DungeonsAndDragons.ChartEngine.Charts;

namespace DungeonsAndDragonsMainWindow
{
    /// <summary>
    /// Interaction logic for ActualMagicItemLoot.xaml
    /// </summary>
    public partial class ActualMagicItemLoot : Window
    {
        public string Treasure { get; set; }

        public ActualMagicItemLoot()
        {
            InitializeComponent();
        }

        public ActualMagicItemLoot(string treasure)
        {
            InitializeComponent();
            Treasure = treasure;
            DisplayMagicItems displayMagicItems = new DisplayMagicItems();
            string formattedItem = displayMagicItems.ReturnFormatedDisplay(treasure);
            Jewlery_Typelbl.Text = formattedItem;
            Sword_Type.Text = formattedItem;// todo would love to get the swords in the swords column not sure how to seperate them
            Other_Weapon.Text = formattedItem;// todo would love to get all the specific magic items to show in that specific magic item row
            Armor_Shield.Text = formattedItem;
            Potion.Text = formattedItem;
            Scroll.Text = formattedItem;
            Ring.Text = formattedItem;
            Wand_Stave_Rod.Text = formattedItem;
            Miscellaneous_Item.Text = formattedItem;
        }
    }
}
