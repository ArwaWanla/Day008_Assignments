using System;

namespace Day008_assi1_builder
{
    class Program
    {
        class HTMLBuilder
        {
            private string value;

            public HTMLBuilder()
            {
                this.value = "";
            }


            //startTag
            public HTMLBuilder startTag(string val)
            {
                this.value += "<" + val + ">\n";
                return this;
            }
            //contentTag
            public HTMLBuilder contentTag(string val)
            {
                this.value += " " + val + " \n";
                return this;
            }
            //meta data
            public HTMLBuilder meta (string val)
            {
                this.value += "<meta " + val + ">\n";
                return this;
            }
            //endTag
            public HTMLBuilder endTag (string val)
            {
                this.value += "</" + val + ">\n";
                return this;
            }

            //get to put every thing together
            public string get()
            {
                return this.value;
            }
        }
        static void Main(string[] args)
        {
            HTMLBuilder builder = new HTMLBuilder();
            

            string result = builder.contentTag("<!DOCTYPE html>")
                   .startTag("html")
                        .startTag("title")
                            .contentTag("Introduction to C#")
                        .endTag("title")
                        .meta("name=\"viewport\" content=\"width = device - width, initial - scale = 1\"")
                        .startTag("body")
                            .startTag("div class =\"Heder\"")
                                .startTag("h1")
                                    .contentTag("What is C# used for?")
                                .endTag("h1")
                            .endTag("div")
                            .startTag("div class =\"container\"")
                                .startTag("p")
                                    .contentTag("C# is a general-purpose, modern and object-oriented programming language pronounced as “C sharp”. It was developed by Microsoft led by Anders Hejlsberg and his team within the .Net initiative and was approved by the European Computer Manufacturers Association (ECMA) and International Standards Organization (ISO). C# is among the languages for Common Language Infrastructure and the current version of C# is version 7.2. C# is a lot similar to Java syntactically and is easy for the users who have knowledge of C, C++ or Java.")
                                .endTag("p")
                            .endTag("div")
                        .endTag("body")
                   .endTag("html")
                   .get();
            Console.WriteLine(result);
        }
    }
}
