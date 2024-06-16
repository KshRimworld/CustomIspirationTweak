using OpenQA.Selenium;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace CIT
{
    public class CIT_Settings : ModSettings
    {
        public static bool isOnFrenzyWork;
        public static bool isOnFrenzyGo;
        public static bool isOnFrenzyShoot;
        public static bool isOnSurgery;
        public static bool isOnTrade;
        public static bool isOnRecruitment;
        public static bool isOnTaming;
        public static bool isOnCreativity;

        public CIT_Settings()
        {
            IEnumerable<InspirationDef> allDefs = DefDatabase<InspirationDef>.AllDefs;

            isOnFrenzyWork = true;
            isOnFrenzyGo = true;
            isOnFrenzyShoot = true;
            isOnSurgery = true;
            isOnTrade = true;
            isOnRecruitment = true;
            isOnTaming = true;
            isOnCreativity = true;

        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref CIT_Settings.isOnFrenzyWork, "isOnFrenzyWork");
            Scribe_Values.Look(ref CIT_Settings.isOnFrenzyGo, "isOnFrenzyGo");
            Scribe_Values.Look(ref CIT_Settings.isOnFrenzyShoot, "isOnFrenzyShoot");
            Scribe_Values.Look(ref CIT_Settings.isOnSurgery, "isOnSurgery");
            Scribe_Values.Look(ref CIT_Settings.isOnTrade, "isOnTrade");
            Scribe_Values.Look(ref CIT_Settings.isOnRecruitment, "isOnRecruitment");
            Scribe_Values.Look(ref CIT_Settings.isOnTaming, "isOnTaming");
            Scribe_Values.Look(ref CIT_Settings.isOnCreativity, "isOnCreativity");
        }

        public static int getIsOnCount()
        {
            int count = 0;

            if (isOnFrenzyWork) count++;
            if (isOnFrenzyGo) count++;
            if (isOnFrenzyShoot) count++;
            if (isOnSurgery) count++;
            if (isOnTrade) count++;
            if (isOnRecruitment) count++;
            if (isOnTaming) count++;
            if (isOnCreativity) count++;

            return count;
        }
    }
}
