using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DocumentFactory
{
    class Program
    {
        private static IDocumentFactory factory;
        private static IDocument document;
        // This just makes sure we're reading and writing to the correct directory
        // You can ignore it for this project
        static string RelativeToAbsolutePath(string path)
        {
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            return Path.Combine(projectFolder, "..", @path);
        }

        static void Main(string[] args)
        {
            string[] commands;
            string list = "";
            try
            {
                list = File.ReadAllText("CreateDocumentScript.txt");
                
            } catch(FileNotFoundException e)
            {
                Console.WriteLine("Input file not found (be sure CreateDocumentScript.txt is in the right directory: \"" + e.FileName + "\").");
                System.Environment.Exit(1);
            }

            commands = list.Split('#');

            // to be assigned below
            
            //string factoryType; // 'html' or 'markdown'

            foreach (var command in commands)
            {
                string strippedCommand = Regex.Replace(command, @"\t|\n|\r", ""); // this cleans up the text a bit
                string[] commandList = strippedCommand.Split(':');

                switch (commandList[0])
                {
                    //[0] - Either Document or Element
                    //[1] - Either filename if Document or ElementType if Element
                    //[2]- props
                    case "Document":
                        // Your document creation code goes here
                        // maybe create a concrete document and set the value of the `document` variable?
                        // commandList might look like: ["Document", "Markdown;index.md"]
                        //
                        string[] fileNameArray = commandList[1].Split(';');
                        if(fileNameArray[0] == "Markdown")
                        {
                            //fileNameArray[1] == fileName
                          factory = MarkdownFactory.Get();
                          document = factory.CreateDocument(fileNameArray[1]);
                          Console.WriteLine(fileNameArray[1]);
                        }
                        else if (fileNameArray[0] == "Html")
                        {
                          factory = HTMLFactory.Get();
                          document = factory.CreateDocument(fileNameArray[1]);
                          Console.WriteLine(fileNameArray[1]);
                        }
                      
                        break;
                    case "Element":
                    //[0] Element/Document
                    //[1] ElementType
                    //[2] props
                        // Your element creation code goes here
                        // maybe have the factory append a new element to the document?
                        // commandList might look like: ["Element", "Header", "1;The Header"]
                        // take a look at CreateDocumentScript.txt for all of them
                        // Console.Write(commandList[1] + "    ");
                        // Console.WriteLine(commandList[2]);
                        document.AddElement(factory.CreateElement(commandList[1], commandList[2]));
                        
                        break;
                    case "Run":
                        string name = document.GetFilename();
                        using (File.Create(name)){};
                        using (var writer = new StreamWriter(name, true)){
                            writer.WriteLine(document.Run());
                        };


                        //File.Create(RelativeToAbsolutePath(document.GetFilename()));
                        Console.WriteLine(document.Run());
                        // File.WriteAllText(RelativeToAbsolutePath(document.GetFilename()), document.Run());
                        // Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
