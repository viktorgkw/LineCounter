namespace LineCounter.Utilities
{
    /// <summary>
    /// This is a static class that contains an array of invalid line strings.
    /// </summary>
    public static class InvalidLines
    {
        /// <summary>
        /// This is an array that contains invalid line strings.
        /// </summary>
        public readonly static string[] InvalidLinesArray = new string[]
        {
            "using", // C# Import
            "#include", // C/C++ Import
            "import", // JavaScript Import (Way 1)
            "from", // JavaScript Import (Way 2)
            "///", // C# Summary
            "//", // C# and JavaScript Single-Line Comment
            "/*", // C# Opening Multi-Line Comment
            "*/", // C# Closing Multi-Line Comment
            "#", // Python Comment
            "<!--", // HTML and CSS Opening Comment
            "-->", // HTML and CSS Closing Comment
        };
    }
}
