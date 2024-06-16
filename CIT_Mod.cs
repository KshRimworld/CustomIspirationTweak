using UnityEngine;
using Verse;

namespace CIT
{
    public class CIT_Mod : Mod
    {
        private const string SETTINGS_CATEGORY_TITLE = "Custom Inspiration Tweak";

        public static CIT_Settings settings;

        public CIT_Mod(ModContentPack content) : base(content)
        {
            CIT_Mod.settings = GetSettings<CIT_Settings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();

            ls.Begin(inRect);

            ls.CheckboxLabeled(Translator.Translate("InspirationFrenzyWork"), ref CIT_Settings.isOnFrenzyWork);
            ls.CheckboxLabeled(Translator.Translate("InspirationFrenzyGo"), ref CIT_Settings.isOnFrenzyGo);
            ls.CheckboxLabeled(Translator.Translate("InspirationFrenzyShoot"), ref CIT_Settings.isOnFrenzyShoot);
            ls.CheckboxLabeled(Translator.Translate("InspirationSurgery"), ref CIT_Settings.isOnSurgery);
            ls.CheckboxLabeled(Translator.Translate("InspirationTrade"), ref CIT_Settings.isOnTrade);
            ls.CheckboxLabeled(Translator.Translate("InspirationRecruitment"), ref CIT_Settings.isOnRecruitment);
            ls.CheckboxLabeled(Translator.Translate("InspirationTaming"), ref CIT_Settings.isOnTaming);
            ls.CheckboxLabeled(Translator.Translate("InspirationCreativity"), ref CIT_Settings.isOnCreativity);

            ls.End();
        }

        public override string SettingsCategory()
        {
            return SETTINGS_CATEGORY_TITLE;
        }
    }
}
