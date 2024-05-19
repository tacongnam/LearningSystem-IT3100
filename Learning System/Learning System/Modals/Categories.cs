using Learning_System.ProcessingClasses;
using Newtonsoft.Json;

namespace Learning_System.Modals
{
    public class Categories
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonProperty("SubArray")]
        public List<int> SubArray { get; set; } = new List<int>();
        [JsonProperty("QuestionArray")]
        public List<int> QuestionArray { get; set; } = new List<int>();
        public string? Description { get; set; }
        public string? IdNumber { get; set; }

        public static Categories DefaultCategory = new Categories
        {
            Id = -1,
            Name = "root",
            Description = "root category",
            IdNumber = "defaultId"
        };
    }

    public static class CategoriesTable
    {
        public static DataProcessing table = new();
    }
}
