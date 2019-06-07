using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownDocument : IDocument
    {
        string fileName;
        List<IElement> elements = new List<IElement>();

        public MarkdownDocument(string s)
        {
            fileName = s;
        }

        public string GetFilename()
        {
            return this.fileName;
        }

        public string Run()
        {
            string finalDoc = "";
            foreach (IElement element in elements)
            {

                string line = element.toString();
                finalDoc += line;
                
            }
            

            return finalDoc;
        }
         

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

    }

}


