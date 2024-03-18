using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Default;

namespace NoManaSummoner
{
    public class ModifyItems : GlobalItem
    {
        public override void SetDefaults(Item entity)
        {
            if (entity.DamageType == DamageClass.Summon)
            {
                entity.mana = 0;
            }
        }
    }
}
