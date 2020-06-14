using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Model
{
    class GameModelManager
    {
        long xpPoints;
        long cashShopGems;

        List<Character> allCharacters;//stats/arbre serra link a la gestion des lvl.
        List<Character> charactersStorage;
        List<Character> playingCharacters;

        List<WorldLevel> worldLevelList;// drops/mob
        WorldLevel currentWorldLevel;

        List<Stuff> allStuffs;//currency/item
        List<Stuff> allStuffsOwn;
        List<Stuff> nonEquipStuffs;

        List<Lootable> lootablesList;// les box avec les rates
    }
}
