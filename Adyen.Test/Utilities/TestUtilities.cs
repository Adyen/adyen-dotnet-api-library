namespace Adyen.Test.Utilities
{
    public class TestUtilities
    {
        public static string GetTestFileContent(string relativePath)
        {
            string rootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../"));
            string absolutePath = Path.Combine(rootPath, relativePath);
            
            return File.ReadAllText(absolutePath);
        }
    }
}