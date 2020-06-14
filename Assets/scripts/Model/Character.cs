using Assets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Model
{
    class Character
    {
        int perstigeLevel;//max 1000
        long totalLVL;

        CharacterType type;
        CharacterElem elem;


        PassiveTree tree;

        int basePV;
        int baseCold;
        int baseFire;
        int baseLightning;
        int basePhys;
        int baseChaos;
        float baseSpeed;
        int baseResCold;
        int baseResFire;
        int baseResLightning;
        int baseResPhys;
        int baseResChaos;


        int increasePV;
        int increaseCold;
        int increaseFire;
        int increaseLightning;
        int increasePhys;
        int increaseChaos;
        float increaseSpeed;


        int morePV;
        int moreCold;
        int moreFire;
        int moreLightning;
        int morePhys;
        int moreChaos;
        float moreSpeed;


        float leach;
        int preventingRate;

        int overKillSplashRate;
    }
}
