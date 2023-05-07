internal class Program
{
    private static void Main(string[] args)
    {
        Languages.Langs();
        CreateC.C();
        CreateJavaScript.Js();
        CreatePython.Python();
        CreateJava.Java();
    }
    public class Languages
    {
        public static string? input;
        public static void Langs()
        {
            string[] langs = { "C", "JavaScript", "Java", "Python" };

            Console.WriteLine("Select a language to generate a starter template in:");
            for (int i = 0; i < langs.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {langs[i]}");
            }

            if (int.TryParse(Console.ReadLine(), out int inputNum) && inputNum > 0 && inputNum <= langs.Length)
            {
                input = langs[inputNum - 1];
                Console.WriteLine($"Creating your {input} project now");
            }
            else
            {
                Console.WriteLine("Invalid Selection Doofus");
            }
        }
    }
    class CreateC
    {
        public static void C()
        {
            string filePath = "/home/klungo/Project-Templates/c-template/main.c";

            if (File.Exists(filePath))
            {
                System.Console.WriteLine("Deleting existing template..");
                File.Delete(filePath);
            }

            switch (Languages.input)
            {
                case "C":
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine("#include <stdio.h>");
                        sw.WriteLine("int main()");
                        sw.WriteLine("{");
                        sw.WriteLine("printf(\"Hello World\\n\");");
                        sw.WriteLine("return 0;");
                        sw.WriteLine("}");
                    }
                    break;
            }
        }
    }
    class CreateJavaScript
    {
        public static void Js()
        {
            string indexFile = "/home/klungo/Project-Templates/js-template/index.js";
            string htmlFile = "/home/klungo/Project-Templates/js-template/index.html";
            string cssFile = "/home/klungo/Project-Templates/js-template/style.css";

            if (File.Exists(indexFile))
            {
                System.Console.WriteLine("Deleting existing template..");
                File.Delete(indexFile);
            }
            if (File.Exists(htmlFile))
            {
                File.Delete(htmlFile);
            }
            if (File.Exists(cssFile))
            {
                File.Delete(cssFile);
            }

            switch (Languages.input)
            {
                case "JavaScript":
                    using (StreamWriter sw = File.AppendText(htmlFile))
                    {
                        sw.WriteLine("<!DOCTYPE html>");
                        sw.WriteLine("<html lang=\"en\">");
                        sw.WriteLine("<head>");
                        sw.WriteLine("<title></title>");
                        sw.WriteLine("<meta charset=\"UTF-8\">");
                        sw.WriteLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
                        sw.WriteLine("<link href=\"./style.css\" rel=\"stylesheet\">");
                        sw.WriteLine("</head>");
                        sw.WriteLine("<body>");
                        sw.WriteLine("</body>");
                        sw.WriteLine("</html>");
                    }
                    using (StreamWriter sw = File.AppendText(cssFile))
                    {

                    }
                    using (StreamWriter sw = File.AppendText(indexFile))
                    {

                    }
                    break;
            }
        }
    }
    class CreatePython
    {
        public static void Python()
        {
            string filePath = "/home/klungo/Project-Templates/python-template/main.py";

            if (File.Exists(filePath))
            {
                System.Console.WriteLine("Deleting existing template..");
                File.Delete(filePath);
            }

            switch (Languages.input)
            {
                case "Python":
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine("#!/usr/bin/env python");
                        sw.WriteLine("# -*- coding: utf-8 -*-");
                        sw.WriteLine("");
                        sw.WriteLine("def main():");
                        sw.WriteLine("    # Your main code goes here");
                        sw.WriteLine("    print(\"Hello, world!\")");
                        sw.WriteLine("");
                        sw.WriteLine("if __name__ == '__main__':");
                        sw.WriteLine("    main()");
                    }
                    break;
            }
        }
    }
    class CreateJava
    {
        public static void Java()
        {
            string filePath = "/home/klungo/Project-Templates/java-template/main.java";

            if (File.Exists(filePath))
            {
                System.Console.WriteLine("Deleting existing template..");
                File.Delete(filePath);
            }

            switch (Languages.input)
            {
                case "Java":
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine("public class Main {");
                        sw.WriteLine("    public static void main(String[] args) {");
                        sw.WriteLine("        // Your main code goes here");
                        sw.WriteLine("        System.out.println(\"Hello, world!\");");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                    }
                    break;
            }
        }
    }
}