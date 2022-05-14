using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts;


namespace DungeonsAndDragonsMainWindow
{
    public class GeneralMethods
    {
        public string FilteredString(string unfilteredString, string textToRemove)
        {
            string filteredString = unfilteredString.Replace(textToRemove, "");
            return filteredString;
        }

        public MonsterTypes GetMonsterType(string sender, GetCharts ChartEngine)
        {
            string monsterType = sender;
            monsterType = FilteredString(monsterType, Constants.BoilerPlateMonsterType);
            return ChartEngine.GetMonsterType(monsterType);
        }

    }
}
