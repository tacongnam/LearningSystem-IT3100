using Learning_System.ProcessingClasses;

namespace Learning_System.Modals
{
    internal class Contests
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool DescriptionShow { get; set; }
        public List<int> QuestionArray { get; set; } = new List<int>();
        public bool ShuffleAnswer { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool StartEnable { get; set; }
        public bool EndEnable { get; set; }
        public int TimeLimit { get; set; }
        public bool TimeLimitEnable { get; set; }
        public double MaximumGrade { get; set; }
    }

    public static class ContestsTable
    {
        public static DataProcessing table = new();
    }
}
