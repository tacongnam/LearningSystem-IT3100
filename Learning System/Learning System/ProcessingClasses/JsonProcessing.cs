// JsonProcessing.cs v3.0.1
// Last modified: 4.5.2023 by DH

using Newtonsoft.Json.Linq;

namespace Learning_System.ProcessingClasses
{
    /// <summary>
    /// Methods for processing Json file
    /// </summary>
    public class JsonProcessing
    {
        private static StreamReader SetFileJsonInDefaultFolder(string JsonPath)
        {
            StreamReader _fileReader;
            try
            {
                _fileReader = new StreamReader(JsonPath);
            }
            catch
            {
                _fileReader = new StreamReader("../../" + JsonPath);
            }
            return _fileReader;
        }
        private static StreamReader? GetFileJsonInDefaultFolder(string JsonPath, string? sampleJsonWebPath, string? sampleContent)
        {
            try
            {
                StreamReader? _readFile;
                _readFile = SetFileJsonInDefaultFolder(JsonPath);
                return _readFile;
            }
            catch
            {
                return null;
            }
        }

        public static readonly string ContestsPath = "contest.json";
        public static readonly string QuestionsPath = "question.json";
        public static readonly string CategoriesPath = "category.json";

        /// <summary>
        /// Get content in your request Json file. If file doesn't exist in default folder, we will create a new one (with sample content) for you.
        /// </summary>
        /// <param name="JsonPath">The relative path of your json file. The root folder is where you put for running application file (or bin folder if you are debugging).</param>
        /// <param name="sampleJsonWebPath">The json url you want to import if we need to create a new one for you.</param>
        /// <param name="sampleContent">The content you want to import if we need to create a new one for you (provided that you can't access to your web path)</param>
        /// <returns>Your data in JArray format. If something get error, it will return a null value.</returns>
        public static JArray? ImportJsonContentInDefaultFolder(string JsonPath, string? sampleJsonWebPath, string? sampleContent)
        {
            try
            {
                using (var _JsonFile = GetFileJsonInDefaultFolder(JsonPath, sampleJsonWebPath, sampleContent))
                {
                    if (_JsonFile == null)
                        throw new Exception();
                    JArray _JsonData = JArray.Parse(_JsonFile.ReadToEnd());
                    return _JsonData;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Add JsonData into Json file. If you don't have Json file in default folder, we will create a new one for you.
        /// </summary>
        /// <param name="JsonPath">The relative path of your json file. The root folder is where you put for running application file (or bin folder if you are debugging).</param>
        /// <param name="JsonData">Your data which you want to import to json file in JArray format.</param>
        /// <returns>Your new data in JArray format. If something get error, it will return a null value.</returns>
        public static JArray? ExportJsonContentInDefaultFolder(string JsonPath, JArray JsonData)
        {
            try
            {
                var _convertedJson = JsonData.ToString();

                string _fileName = JsonPath;
                if (File.Exists(_fileName))
                {
                    File.WriteAllText(_fileName, _convertedJson);
                    return ImportJsonContentInDefaultFolder(JsonPath, null, _convertedJson);
                }
                else
                    return ImportJsonContentInDefaultFolder(JsonPath, null, _convertedJson);
            }
            catch
            {
                return null;
            }
        }
    }
}
