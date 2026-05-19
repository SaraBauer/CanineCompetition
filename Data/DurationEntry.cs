namespace CanineCompetition.Data
{
    public class DurationEntry
    {
        public DurationEntry()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; } = default;
    }
}
