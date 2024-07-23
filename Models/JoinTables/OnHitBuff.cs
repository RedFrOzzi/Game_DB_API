using Game_DB_API.Models.Buffs;
using Game_DB_API.Models.OnHitEffects;

namespace Game_DB_API.Models.JoinTables
{
    public class OnHitBuff
    {
        public int OnHitId { get; set; }
        public int BuffId { get; set; }

        public OnHit OnHit { get; set; }
        public Buff Buff { get; set; }
    }
}
