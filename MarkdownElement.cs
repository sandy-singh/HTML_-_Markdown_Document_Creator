using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    public class MarkdownImage : IElement
    {
        string elementProps = "";
            public MarkdownImage(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "Image";
            }


            public string toString()
            {
                string finalElement;
                string[] imageElement = elementProps.Split(";");
                finalElement = "![" + imageElement[1] + "](" + imageElement[0] + " \"" + imageElement[2] + "\")\n";
                return finalElement;
            }
    }

    public class MarkdownHeader : IElement
    {
        string elementProps = "";
            public MarkdownHeader(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "Header";
            }


            public string toString()
            {
                string finalElement;
                string hash = "";
                string[] headerElement = elementProps.Split(';');
                for (var i = 0; i < Int32.Parse(headerElement[0]); i++)
                {
                    hash += "#";
                }
                finalElement = hash + " " + headerElement[1] + "\n";
                return finalElement;
            }
    }

    public class MarkdownList : IElement
    {
        string elementProps = "";
            public MarkdownList(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "List";
            }


            public string toString()
            {
                string finalElement="";
                string temp = "";
                string[] listElements = elementProps.Split(';');
                if (listElements[0].Equals("Ordered"))
                {
                    for(var i = 1; i < listElements.Length; i++)
                    {
                        temp = i + ". ";
                        finalElement += temp + listElements[i] + "\n";
                    }
                }
                else if (listElements[0].Equals("Unordered"))
                {
                    for (var i = 1; i < listElements.Length; i++)
                    {
                        temp = "* ";
                        finalElement += temp + listElements[i] + "\n";
                    }
                }
                return finalElement;
            }
    }



    public class MarkdownTable : IElement
    {
        string elementProps = "";
            public MarkdownTable(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "Table";
            }


            public string toString()
            {
                string finalElement="";
                string temp = "";
                string[] lines = elementProps.Split(';');
                string[] parts = lines[0].Split('$');
                for (var i = 1; i < parts.Length; i++)
                {
                        temp = "| ";
                        finalElement += temp + parts[i] + " ";
                }
                    finalElement += " | \n";

                    
                    for (var i = 1; i < parts.Length; i++)
                    {
                        temp = "| ";
                        finalElement += temp + "--- ";
                    }
                    finalElement += " | \n";

                    string[] rows1 = lines[1].Split('$');
                    for (var i = 1; i < rows1.Length; i++)
                    {
                        temp = "| ";
                        finalElement += temp + rows1[i] + " ";
                    }
                    finalElement += " | \n";

                    string[] rows2 = lines[1].Split('$');
                    for (var i = 1; i < rows2.Length; i++)
                    {
                        temp = "| ";
                        finalElement += temp + rows2[i] + " ";
                    }
                    finalElement += " | \n";

                    string[] rows3 = lines[1].Split('$');
                    for (var i = 1; i < rows1.Length; i++)
                    {
                        temp = "| ";
                        finalElement += temp + rows3[i] + " ";
                    }
                    finalElement += " | \n";
                return finalElement;
            }
    }
}