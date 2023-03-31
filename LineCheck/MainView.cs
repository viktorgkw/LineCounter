namespace LineCheck
{
    using System.Diagnostics;
    using LineCheck.Utilities;

    /// <summary>
    /// This is the Main View of the application.
    /// </summary>
    public partial class MainView : Form
    {
        private static string[] Extensions = null!;

        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called when somebody clicks the "Select Directory" button in the Main View.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int LinesCounter = 0;

            Extensions = checkMarkdown.Checked ?
                CodingFilesExtensions.ExtensionsWithMarkdown :
                CodingFilesExtensions.ExtensionsWithoutMarkdown;

            using FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dialogResult = fbd.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                lblResult.Text = "Result will be shown here.";
                return;
            }

            string path = fbd.SelectedPath;

            LinesCounter = CalculateLines(path, LinesCounter);

            lblResult.Text = $"This folder has total lines of code => {LinesCounter}";
        }

        /// <summary>
        /// This method calculates the lines of the selected folder.
        /// </summary>
        /// <param name="path">Project Folder Path</param>
        /// <param name="counter">Lines Counter</param>
        private static int CalculateLines(string path, int counter)
        {
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileExtension = GetExtension(file);

                if (Extensions.Contains(fileExtension))
                {
                    using StreamReader sr = new StreamReader(file);

                    counter += GetFileLines(sr);
                }
            }

            var directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                var directoryName = GetDirectoryName(directory.ToLower());

                if (!InvalidFolderNames.Names.Contains(directoryName))
                {
                    counter = CalculateLines(directory, counter);
                }
            }

            return counter;
        }

        /// <summary>
        /// This method returns the directory name from a given path.
        /// </summary>
        /// <param name="directoryPath">The path of the directory</param>
        /// <returns>String of the directory's name</returns>
        private static string GetDirectoryName(string directoryPath)
        {
            var nameStartIndex = directoryPath.LastIndexOf("\\") + 1;

            return directoryPath.Substring(nameStartIndex);
        }

        /// <summary>
        /// This method returns the extension of the given file.
        /// </summary>
        /// <param name="fileName">Full File Name</param>
        /// <returns>String of the file's extension.</returns>
        private static string GetExtension(string fileName)
        {
            var extensionStartIndex = fileName.LastIndexOf(".");

            return fileName.Substring(extensionStartIndex);
        }

        /// <summary>
        /// This method calculates the current file lines from the Stream Reader.
        /// Keep in mind that the method doesnt count empty lines, comments or usings/imports!
        /// </summary>
        /// <param name="sr">Stream Reader</param>
        /// <returns>Lines of code in the Stream Reader.</returns>
        private static int GetFileLines(StreamReader sr)
        {
            int counter = 0;
            string? line = sr.ReadLine();

            while (line != null)
            {
                // Line is null, empty or whitespace.
                if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line))
                {
                    line = sr.ReadLine();
                    continue;
                }

                // Starts with invalid line.
                string lineStart = line.Split(' ').First();

                if (InvalidLines.InvalidLinesArray.Contains(lineStart))
                {
                    line = sr.ReadLine();
                    continue;
                }

                counter++;
                line = sr.ReadLine();
            }

            return counter;
        }
    }
}