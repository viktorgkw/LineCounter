namespace LineCounter.Utilities
{
    /// <summary>
    /// This is a static class that contains array of valid language extensions.
    /// </summary>
    public static class CodingFilesExtensions
    {
        /// <summary>
        /// Array of valid programming language file extensions.
        /// </summary>
        public readonly static string[] ExtensionsWithMarkdown = new string[]
        {
            ".md", // Markdown File
            ".c", // C File
            ".cpp", // C++ File
            ".class", // Compiled Java File
            ".cs", // C# File
            ".cshtml", // C# HTML File
            ".html", // HTML File
            ".css", // CSS File
            ".js", // JavaScript File
            ".ts", // TypeScript File
            ".java", // Java File
            ".php", // PHP File
            ".py", // Python File
            ".sh", // Shell Script File
            ".swift", // Swift File
            ".vb", // Visual Basic File
            ".asp", // ASP File
            ".go", // GO File
            ".rs", // Rust File
        };

        public readonly static string[] ExtensionsWithoutMarkdown = new string[]
        {
            ".c", // C File
            ".cpp", // C++ File
            ".class", // Compiled Java File
            ".cs", // C# File
            ".cshtml", // C# HTML File
            ".html", // HTML File
            ".css", // CSS File
            ".js", // JavaScript File
            ".ts", // TypeScript File
            ".java", // Java File
            ".php", // PHP File
            ".py", // Python File
            ".sh", // Shell Script File
            ".swift", // Swift File
            ".vb", // Visual Basic File
            ".asp", // ASP File
            ".go", // GO File
            ".rs", // Rust File
        };
    }
}