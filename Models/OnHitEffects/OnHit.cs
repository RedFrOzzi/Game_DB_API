using Game_DB_API.Models.Buffs;

namespace Game_DB_API.Models.OnHitEffects
{
    public class OnHit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Buff> LinkedBuffs { get; set; }
    }
}
