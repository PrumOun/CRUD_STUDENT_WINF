namespace ListStudent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadStudent("people.txt");
            Application.Run(new Main());
        }
        public static List<People> _student = new();
        private static void LoadStudent(String fileName)
        {
            String[] allLines = File.ReadAllLines(fileName);
            foreach (String line in allLines)
            {
                People? item = People.createInstance(line);
                _student.Add(item!);
            }

        }
    }
}