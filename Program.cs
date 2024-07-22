using System.Collections.Concurrent;

namespace POCFileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string Path = "D:\\aproSCM\\Test.cs";

            string inform = "this is C# code";
            Console.WriteLine("Writing and reading Text file File:");
            File.WriteAllText(Path, inform);

            //using FIle
            string contents = File.ReadAllText(@"D:\aproSCM\Test.cs"); //also useful for reading html FILE.
            Console.WriteLine(contents);

            Console.WriteLine("======================================");

            //using STRAMREADRER
            string readContents;

            Console.WriteLine("this is reading a file using StreamReader:");
            using (StreamReader reader = new StreamReader("D:\\aproSCM\\Test.cs"))
            {
                readContents = reader.ReadToEnd();
            }
            Console.WriteLine(readContents);

            Console.WriteLine("======================================");

            Console.WriteLine("read and write in HTML file:");
            List<string> lines = new List<string>();
            lines.Add("<html>");
            lines.Add("<body>");
            lines.Add("Hello World");
            lines.Add("</body>");
            lines.Add("</html>");

            File.WriteAllLines("D:\\aproSCM\\myfile.htm", lines);

            string HtmContents= File.ReadAllText("D:\\aproSCM\\myfile.htm");
            Console.WriteLine(HtmContents);

        }
    }
}
