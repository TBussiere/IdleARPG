using Assets.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine.XR;

namespace Assets.scripts.Model
{
    class Character : DPSable
    {
        int perstigeLevel;//max 1000
        long totalLVL;

        CharacterType type;
        CharacterElem elem;

        Spell spell;

        Stuff hat;
        Stuff armor;
        Stuff belt;
        Stuff ring;
        Stuff arme;
        Stuff offHand;
        Stuff bossSoul;


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

        /*
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
        */

        float leach;
        int preventingRate;

        int overKillSplashRate;

        int curHP;

        public Character()
        {
            curHP = ge1TotalHealth();
        }

        int ge1TotalHealth()
        {
            int incrVal = (basePV + tree.getFlatHP() + this.getHPFlatStuff()) * (tree.getIncreaseHP() + this.getHPIncreaseStuff());

            int moreVal = incrVal + incrVal * (tree.getMoreHP() + this.getHPMoreStuff());

            return moreVal;
        }

        void dps(DPSable mob)
        {

        }
        void dps(List<DPSable> mobs)
        {

        }

        private int getHPMoreStuff()
        {
            throw new NotImplementedException();
        }

        private int getHPIncreaseStuff()
        {
            throw new NotImplementedException();
        }

        private int getHPFlatStuff()
        {
            throw new NotImplementedException();
        }

        public void damage(int dmg)
        {
            curHP -= dmg;
        }
    }
}
