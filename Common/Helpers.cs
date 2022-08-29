namespace Week1.Common
{
    public class Helpers
    {

        public static string GetModelFileContent(string filePath)
        {
            return File.Exists($"{Directory.GetCurrentDirectory()}/Data/{filePath}.json") ?  File.ReadAllText($"{Directory.GetCurrentDirectory()}/Data/{filePath}.json") : String.Empty;
        }

    }
}
