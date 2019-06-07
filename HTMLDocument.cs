using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DocumentFactory
{
    public class HTMLDocument : IDocument
    {
        string fileName;
        List<IElement> elements = new List<IElement>();

        public HTMLDocument(string s)
        {
            fileName = s;
        }

        public string GetFilename()
        {
            return this.fileName;
        }

          public void AddElement(IElement element)
        {
            elements.Add(element);
            
        }



        public string Run()
        {
             string finalHTMLPage = "";
            
            string heading = "<!doctype html><html><head></head><body>";
            
            string htmlPage = "";
            foreach (IElement element in elements)
            {

                string line = element.toString();
                htmlPage += line;
                
            }
            string ending = "</body></html>";
            
            finalHTMLPage = heading + htmlPage + ending;
            return finalHTMLPage;
        }
    }

}


