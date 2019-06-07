using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    
        public class HTMLImage : IElement
        {
            string elementProps = "";
            public HTMLImage(string props)
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
                finalElement = "<img src=\"" + imageElement[0] + "\" alt=\"" + imageElement[1] + "\" title=\"" + imageElement[2] + "\"><br>";
                //Console.WriteLine(finalElement);
                return finalElement;
            }


          
        }



        public class HTMLHeader : IElement
        {
            string elementProps = "";
            public HTMLHeader(string props)
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
                string[] headerElement = elementProps.Split(';');
                finalElement = "<h" + headerElement[0] + "> " + headerElement[1] + "</h" + headerElement[0] + ">";
                 //Console.WriteLine(finalElement);
                return finalElement;
            }


          
        }



        public class HTMLList : IElement
        {
            string elementProps = "";
            public HTMLList(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "List";
            }

           

            public string toString()
            {
                string finalElement = "";
                string[] listElements = elementProps.Split(';');
                if (listElements[0].Equals("Ordered"))
                {
                    finalElement = "<ol> <li>" + listElements[1] + "</li> <li > " + listElements[2] + " </li > <li>" + listElements[3] + "</li> </ol>" ;
                }
                else if (listElements[0].Equals("Unordered"))
                {
                    finalElement = "<ul> <li>" + listElements[1] + "</li> <li > " + listElements[2] + " </li > <li>" + listElements[3] + "</li> </ul>";
                }
                 //Console.WriteLine(finalElement);
                return finalElement;
            }


          
        }

        public class HTMLTable : IElement
        {
            string elementProps = "";
            public HTMLTable(string props)
            {
                elementProps = props;
            }
            public string getElementType()
            {
                return "Table";
            }

           

            public string toString()
            {
                string finalElement;
                string [] lines = elementProps.Split(';');
                string [] parts = lines[0].Split('$');
                string[] rows = lines[1].Split('$');
                string[] rows2 = lines[2].Split('$');
                string[] rows3 = lines[3].Split('$');
                finalElement = "<table> <thead> <tr> <th> " + parts[1] + "</th> <th> " + parts[2] + "</th> <th> " + parts[3] + "</th> </tr> </thead> <tbody> <tr> <td>"
                        + rows[1] + "</td> <td> " + rows[2] + "</td> <td> " + rows[3] + "</td> </tr> <tr> <td> " + rows2[1] + "</td> <td> " + rows2[2] + "</td> <td> " + rows[3]
                        + "</td> </tr> <tr> <td> " + rows3[1] + "</td> <td> " + rows3[2] + "</td> <td> " + rows3[3] + "</td> </tr> </tbody> </table>";
                // Console.WriteLine(finalElement);
                return finalElement;
            }


          
        }
}




              

//         string toString()
//         {
//             string finalElement;
//             switch (getelementType)
//             {
                
//                 case "Image":
//                     string[] imageElement = getprops.Split(";");
//                     finalElement = "<img src=\"" + imageElement[0] + "\" alt=\"" + imageElement[1] + "\" title=\"" + imageElement[2] + "\"";
//                     break;
//                 case "Header":
//                     string[] headerElement = getProps.Split(';');
//                     finalElement = "<h" + headerElement[0] + "> " + headerElement[1] + "</h" + headerElement[0] + ">";
//                     break;
//                 case "List":
//                     string[] listElements = getProps.Split(';');
//                     if (listElements[0].Equals("Ordered"))
//                     {
//                         finalElement = "<ol> <li>" + listElements[1] + "</li> <li > " + listElements[2] + " </li > <li>" + listElements[3] + "</li> </ol>" ;
//                     }
//                     else if (listElements[0].Equals("Unordered"))
//                     {
//                         finalElement = "<ul> <li>" + listElements[1] + "</li> <li > " + listElements[2] + " </li > <li>" + listElements[3] + "</li> </ul>";
//                     }
//                     break;
//                 case "Table":
//                     string [] lines = getProps.Split(';');
//                     string [] parts = lines[0].Split('$');
//                     string[] rows = lines[1].Split('$');
//                     string[] rows2 = lines[2].Split('$');
//                     string[] rows3 = lines[3].Split('$');
//                     finalElement = "<table> <thead> <tr> <th> " + parts[1] + "</th> <th> " + parts[2] + "</th> <th> " + parts[3] + "</th> </tr> </thead> <tbody> <tr> <td>"
//                         + rows[1] + "</td> <td> " + rows[2] + "</td> <td> " + rows[3] + "</td> </tr> <tr> <td> " + rows2[1] + "</td> <td> " + rows2[2] + "</td> <td> " + rows[3]
//                         + "</td> </tr> <tr> <td> " + rows3[1] + "</td> <td> " + rows3[2] + "</td> <td> " + rows3[3] + "</td> </tr> </tbody> </table>";


//             }
//             return finalElement;

//         }


//     }
// }