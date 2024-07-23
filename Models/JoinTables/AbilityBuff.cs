using Game_DB_API.Models.Abilities;
using Game_DB_API.Models.Buffs;

namespace Game_DB_API.Models.JoinTables
{
    public class AbilityBuff
    {
        public int AbilityId { get; set; }
        public int BuffId { get; set; }

        public Ability Ability { get; set; }
        public Buff Buff { get; set; }
    }
}
