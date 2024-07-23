using Game_DB_API.Models.Buffs;

namespace Game_DB_API.Models.Abilities
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }
        public int MinimunSpawnLevel { get; set; }
        public double BaseCooldown { get; set; }
        public double BaseManacost { get; set; }

        public List<Buff> LinkedBuffs { get; set; }
    }
}
