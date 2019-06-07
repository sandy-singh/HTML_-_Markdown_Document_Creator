using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownFactory : IDocumentFactory
    {
        private static MarkdownFactory _instance;

        private MarkdownFactory()
        {
            Console.WriteLine("Creating Markdown Factory (Singleton)");
        }

        public static MarkdownFactory Get()
        {
            if (_instance == null)
            {
                _instance = new MarkdownFactory();
            }
            return _instance;
        }

        public IDocument CreateDocument(string path)
        {
            return new MarkdownDocument(path);
        }

        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                case "Header":
                    return new MarkdownHeader(props);
                case "Image":
                    return new MarkdownImage(props);
                case "List":
                    return new MarkdownList(props);
                case "Table":
                    return new MarkdownTable(props);
                default:
                    return null;

            }
        }
    }
}