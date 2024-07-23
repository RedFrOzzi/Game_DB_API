using Game_DB_API.Models.Abilities;
using Game_DB_API.Models.OnHitEffects;

namespace Game_DB_API.Models.Buffs
{
    public class Buff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }
        public double BaseDuration { get; set; }

        public List<Ability> AbilitySource { get; set; }
        public List<OnHit> OnHitSource { get; set; }
    }
}
