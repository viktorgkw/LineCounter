namespace LineCounter.Utilities
{
    /// <summary>
    /// This is a static class that contains array of invalid folder names.
    /// </summary>
    public static class InvalidFolderNames
    {
        /// <summary>
        /// Array that contains invalid folder names.
        /// </summary>
        public readonly static string[] Names = new string[]
        {
            "resources",
            "properties",
            "bin",
            "obj",
            "lib",
            "pictures",
            "picture",
            "images",
            "image",
            "img",
            "gifs",
            "gif",
            "icons",
            ".git",
            ".github",
            ".vs",
        };
    }
}
