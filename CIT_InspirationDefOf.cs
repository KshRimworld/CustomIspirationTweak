using RimWorld;

namespace CIT
{
    [DefOf]
    public static class CIT_InspirationDefOf
    {
        public static InspirationDef Frenzy_Work;

        public static InspirationDef Frenzy_Go;

        public static InspirationDef Frenzy_Shoot;

        public static InspirationDef Inspired_Surgery;

        static CIT_InspirationDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(CIT_InspirationDefOf));
        }
    }
}
