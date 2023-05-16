namespace EFCoreRelationships
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "knight";
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
