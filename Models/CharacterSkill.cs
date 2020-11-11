namespace dotnet_rpg.Models
{
    public class CharacterSkill
    {
        public int SkillId { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public Skill Skill { get; set; }
    }
}