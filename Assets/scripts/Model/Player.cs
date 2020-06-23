using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Model
{
    class Player
    {
        long xpPoints;
        long cashShopGems;

        List<Character> charactersStorage;
        List<Character> playingCharacters;

        WorldLevel currentWorldLevel;

        List<Stuff> allStuffsOwn;
        List<Stuff> nonEquipStuffs;
    }
}
