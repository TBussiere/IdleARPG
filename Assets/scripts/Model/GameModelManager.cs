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
        Player po;//PlayerObject

        List<Character> allCharacters;//stats/arbre serra link a la gestion des lvl.

        List<WorldLevel> worldLevelList;// drops/mob

        List<Stuff> allStuffs;//currency/item

        List<Lootable> lootablesList;// les box avec les rates
    }
}
