using LineCheck.Utilities;

namespace LineCheck
{
    public partial class MainView : Form
    {
        public static int LinesOfCode = 0;
        public MainView()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            LinesOfCode = 0;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult dialogResult = fbd.ShowDialog();

                string path = fbd.SelectedPath;

                CalculateLines(path);
            }

            lblResult.Text = $"This folder has total lines of code => {LinesOfCode}";
        }

        private void CalculateLines(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var fileExtension = GetExtension(file);

                if (CodingFilesExtensions.Extensions.Contains(fileExtension))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        LinesOfCode += GetFileLines(sr);
                    }
                }
            }

            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                var directoryName = GetDirectoryName(directory.ToLower());

                if (!InvalidFolderNames.Names.Contains(directoryName))
                {
                    CalculateLines(directory);
                }
            }
        }

        private string GetDirectoryName(string directoryPath)
        {
            var nameStartIndex = directoryPath.LastIndexOf("\\") + 1;

            return directoryPath.Substring(nameStartIndex);
        }

        private string GetExtension(string fileName)
        {
            var extensionStartIndex = fileName.LastIndexOf(".");

            return fileName.Substring(extensionStartIndex);
        }

        private int GetFileLines(StreamReader sr)
        {
            int counter = 0;
            string line = sr.ReadLine();

            while (line != null)
            {
                counter++;
                line = sr.ReadLine();
            }

            return counter;
        }
    }
}