using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class HTMLFactory : IDocumentFactory
    {
        private static HTMLFactory _instance;

        private HTMLFactory()
        {
            Console.WriteLine("Creating HTML Factory (Singleton)");
        }
       public IDocument CreateDocument(string fileName)
        {
            return new HTMLDocument(fileName);
        }


        public static HTMLFactory Get()
        {
            if (_instance == null)
            {
                _instance = new HTMLFactory();
            }
            return _instance;
        }

      
        //tostring in each ielements
        public IElement CreateElement(string elementType, string props)
        {
            switch(elementType)
            {
                case "Header":
                    return new HTMLHeader(props);
                case "Image":
                    return new HTMLImage(props);
                case "List":
                    return new HTMLList(props);
                case "Table":
                    return new HTMLTable(props);
                default:
                    return null;

            }

        }
    }
}