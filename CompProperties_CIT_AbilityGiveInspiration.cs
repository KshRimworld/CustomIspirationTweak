using RimWorld;

namespace CIT
{
    public class CompProperties_CIT_AbilityGiveInspiration : CompProperties_AbilityEffect
    {
        public CompProperties_CIT_AbilityGiveInspiration()
        {
            compClass = typeof(CompAbilityEffect_CIT_GiveInspiration);
        }
    }
}
