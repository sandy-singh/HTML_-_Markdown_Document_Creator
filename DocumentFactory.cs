using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public interface IDocument {
        string GetFilename();
        //return this.fileName
        string Run();
        void AddElement(IElement element);
     
    }

    public interface IElement {
        string getElementType();
        //string getProps();
        string toString();
    }

    public interface IDocumentFactory
    {
        IDocument CreateDocument(string fileName);
        IElement CreateElement(string elementType, string props);
    }

     
   

    
}

  
