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
using DungeonsAndDragons.ChartEngine.Utilities;

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
            Sword_Type.Text = DisplayIndividualTreasure(displayMagicItems.Sword);
            Other_Weapon.Text = DisplayIndividualTreasure(displayMagicItems.OtherWeapons);
            Armor_Shield.Text = DisplayIndividualTreasure(displayMagicItems.ArmorShields);
            Potion.Text = DisplayIndividualTreasure(displayMagicItems.Potions);
            Scroll.Text = DisplayIndividualTreasure(displayMagicItems.Scrolls);
            Ring.Text = DisplayIndividualTreasure(displayMagicItems.Rings);
            Wand_Stave_Rod.Text = DisplayIndividualTreasure(displayMagicItems.WandsStavesRods);
            Miscellaneous_Item.Text = DisplayIndividualTreasure(displayMagicItems.MiscellaneousMagic);

        }

        private string DisplayIndividualTreasure(List<string> treasure)
        {
            string output = string.Empty;
            if (treasure.Count > 0)
            {
                foreach (var item in treasure)
                {
                   output = output == string.Empty ? item : $"{output} {item}";
                }
            }
            else
            {
                return string.Empty;
            }
            return output;
        }

        private void DisplayTreasure(string treasure)
        {
            var treasureArray = treasure.Split(' ').ToList<string>();

            string swordVariable = string.Empty;
            string otherWeaponVariable = string.Empty;
            string armorShieldVariable = string.Empty;
            string potionVariable = string.Empty;
            string scrollVariable = string.Empty;
            string ringVariable = string.Empty;
            string wandStaveRodVariable = string.Empty;
            string miscellaneousVariable = string.Empty;

            foreach (var magicItemElement in treasureArray)
            {
                switch (magicItemElement)
                {
                    case Constants.Sword:
                        swordVariable = swordVariable == string.Empty ? magicItemElement : $"{swordVariable} {magicItemElement}";
                        break;
                    case Constants.OtherWeapons:
                        otherWeaponVariable = otherWeaponVariable == string.Empty ? magicItemElement : $"{otherWeaponVariable} {magicItemElement}";
                        break;
                    case Constants.ArmorShields:
                        armorShieldVariable = armorShieldVariable == string.Empty ? magicItemElement : $"{armorShieldVariable} {magicItemElement}";
                        break;
                    case Constants.Potions:
                        potionVariable = potionVariable == string.Empty ? magicItemElement : $"{potionVariable} {magicItemElement}";
                        break;
                    case Constants.Scrolls:
                        scrollVariable = scrollVariable == string.Empty ? magicItemElement : $"{scrollVariable} {magicItemElement}";
                        break;
                    case Constants.Rings:
                        ringVariable = ringVariable == string.Empty ? magicItemElement : $"{ringVariable} {magicItemElement}";
                        break;
                    case Constants.WandsStavesRods:
                        wandStaveRodVariable = wandStaveRodVariable == string.Empty ? magicItemElement : $"{wandStaveRodVariable} {magicItemElement}";
                        break;
                    case Constants.MiscelaneousMagic:
                        miscellaneousVariable = miscellaneousVariable == string.Empty ? magicItemElement : $"{miscellaneousVariable} {magicItemElement}";
                        break;
                }
            }
            Sword_Type.Text = swordVariable;// todo would love to get the swords in the swords column not sure how to seperate them
            Other_Weapon.Text = otherWeaponVariable;// todo would love to get all the specific magic items to show in that specific magic item row
            Armor_Shield.Text = armorShieldVariable;
            Potion.Text = potionVariable;
            Scroll.Text = scrollVariable;
            Ring.Text = ringVariable;
            Wand_Stave_Rod.Text = wandStaveRodVariable;
            Miscellaneous_Item.Text = miscellaneousVariable;

        }
    }
}
