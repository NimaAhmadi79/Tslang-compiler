using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scanner
{
    class Program
    {

        

        static void Main(string[] args)
        {

            
            string program = System.IO.File.ReadAllText(@"D:\daneshgah\5\compiler\Test1.txt");

            
            char[] t = program.ToCharArray();
           
            Getchar g = new Getchar(t);
            
            Boolean istrue = true;
            Syntax_Analyser syntax_Analyser = new Syntax_Analyser();

            while (istrue)
            {
                string temp = g.getchar().ToString();
                if (g.array_finish)
                {
                    Console.WriteLine("this is end");
                    Console.ReadKey();
                    return;
                }
                g.ungetchar();
                
                string token= nexttoken();
                if (token == "nima")
                {
                    Console.ReadKey();
                    break;
                }

                syntax_Analyser.AddTokenTolist(token);
               
                
            }

            syntax_Analyser.initialize();
            

            string nexttoken()
            {

                //string c= g.getchar().ToString();
                
                string temp = "";
                if (g.array_size - g.pointer >= 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        temp += g.getchar().ToString();
                        if (i == 7)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "function" && (isalphabet(T) == false || g.is_space == true))
                            {

                                g.ungetchar();
                                g.pointer_now = g.pointer;

                                return "function";
                            }
                            else
                            {
                               while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }
  

                        }

                    }

                }
                
                

                temp = "";

                if (g.array_size - g.pointer >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        temp += g.getchar().ToString();
                        if (i == 2)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "val" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "val";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                        }





                    }

                }
                

                temp = "";



                if (g.array_size - g.pointer >= 8)
                {
                    for (int i = 0; i < 8; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 7)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "printInt" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "printInt";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }


                        }


                    }

                }


                temp = "";

                if (g.array_size - g.pointer >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 2)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "Int" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "Int";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                       
                        }


                    }

                }
                

                temp = "";


                if (g.array_size - g.pointer >= 7)
                {
                    for (int i = 0; i < 7; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 6)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "foreach" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "foreach";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                        }


                    }

                }
                

                temp = "";

                if (g.array_size - g.pointer >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 2)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "for" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "for";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                           
                        }


                    }

                }
                

                temp = "";


                if (g.array_size - g.pointer >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 4)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "Array" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "Array";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }


                    }

                }
                

                temp = "";


                if (g.array_size - g.pointer >= 4)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 3)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "main" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "main";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }

                    }

                }
                

                temp = "";




                if (g.array_size - g.pointer >= 7)
                {
                    for (int i = 0; i < 7; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 6)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "returns" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "returns";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }

                    }

                }
                


                temp = "";


                if (g.array_size - g.pointer >= 6)
                {
                    for (int i = 0; i < 6; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 5)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "return" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "return";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }

                    }

                }
                


                temp = "";


                if (g.array_size - g.pointer >= 4)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        temp += g.getchar().ToString();
                        if (i == 3)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "else" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "else";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }

                    }

                }
                


                temp = "";


                if (g.array_size - g.pointer >= 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        temp += g.getchar().ToString();

                        if (i == 2)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "end" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "end";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                           
                        }


                    }

                }
                


                temp = "";


                if (g.array_size - g.pointer >= 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        temp += g.getchar().ToString();

                        if (i == 4)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "while" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "while";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }


                    }

                }
                


                temp = "";

                if (g.array_size - g.pointer >= 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        temp += g.getchar().ToString();

                        if (i == 1)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "of" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "of";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }


                    }

                }

                


                temp = "";


                if (g.array_size - g.pointer >= 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        temp += g.getchar().ToString();

                        if (i == 1)
                        {
                            string T = g.getchar().ToString();
                            if (temp == "if" && (isalphabet(T) == false || g.is_space == true))
                            {
                                g.ungetchar();
                                g.pointer_now = g.pointer;
                                return "if";
                            }
                            else
                            {
                                while (true)
                                {
                                    if (g.pointer == g.pointer_now)
                                    {
                                        break;
                                    }
                                    g.ungetchar();
                                }
                            }

                            
                        }


                    }

                }
                


                temp = "";



                if (g.getchar().ToString() == "(")
                {
                    g.pointer_now = g.pointer;
                    return "(";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == ")")
                {
                    g.pointer_now = g.pointer;
                    return ")";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == ";")
                {
                    g.pointer_now = g.pointer;
                    return ";";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == "{")
                {
                    g.pointer_now = g.pointer;
                    return "{";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == "}")
                {
                    g.pointer_now = g.pointer;
                    return "}";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }


                if (g.getchar().ToString() == ",")
                {
                    g.pointer_now = g.pointer;
                    return ",";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }

                }

                if (g.getchar().ToString() == ":")
                {
                    g.pointer_now = g.pointer;
                    return ":";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }



                if(g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == "+")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == "+")
                        {
                            g.pointer_now = g.pointer;
                            return "++";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }
                        }

                        return "+";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }

                    }

                }



                if (g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == "-")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == "-")
                        {
                            g.pointer_now = g.pointer;
                            return "--";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        
                        return "-";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }
                    }

                }



                if (g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == "=")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == "=")
                        {
                            g.pointer_now = g.pointer;

                            return "==";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        
                        return "=";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }
                    }

                }


                if (g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == "<")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == "<")
                        {
                            g.pointer_now = g.pointer;

                            return "<<";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        if (g.getchar().ToString() == "=")
                        {
                            g.pointer_now = g.pointer;
                            return "<=";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        

                        return "<";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }
                    }

                }


                if (g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == ">")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == ">")
                        {
                            g.pointer_now = g.pointer;

                            return ">>";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        if (g.getchar().ToString() == "=")
                        {
                            g.pointer_now = g.pointer;

                            return ">=";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }

                        
                        return ">";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }
                    }

                }


                if (g.array_size - g.pointer >= 2)
                {
                    if (g.getchar().ToString() == "!")
                    {
                        g.pointer_now = g.pointer;
                        if (g.getchar().ToString() == "=")
                        {
                            g.pointer_now = g.pointer;

                            return "!=";
                        }
                        else
                        {
                            while (true)
                            {
                                if (g.pointer == g.pointer_now)
                                {
                                    break;
                                }
                                g.ungetchar();
                            }

                        }
                        
                        return "!";

                    }
                    else
                    {
                        while (true)
                        {
                            if (g.pointer == g.pointer_now)
                            {
                                break;
                            }
                            g.ungetchar();
                        }
                    }

                }
                


                if (g.getchar().ToString() == "*")
                {
                    g.pointer_now = g.pointer;
                    return "*";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == "%")
                {
                    g.pointer_now = g.pointer;
                    return "%";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == "[")
                {
                    g.pointer_now = g.pointer;
                    return "[";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }

                if (g.getchar().ToString() == "]")
                {
                    g.pointer_now = g.pointer;
                    return "]";

                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }
                }


                temp = g.getchar().ToString();

                if(isalphabet(temp) || temp=="-" || temp=="_")
                {
                    if (g.last_char)
                    {
                        g.pointer_now = g.pointer;
                        return temp;
                    }
                     string c = g.getchar().ToString();
                    while((isalphabet(c) || isdigit(c))&& g.is_space==false)
                    {

                        temp += c;
                        if (g.last_char)
                        {
                            g.pointer_now = g.pointer;
                            return temp;
                        }
                        c = g.getchar().ToString();

                    }
                    g.ungetchar();
                    g.pointer_now = g.pointer;
                    return temp;
                }
                else
                {
                    while (true)
                    {
                        if (g.pointer == g.pointer_now)
                        {
                            break;
                        }
                        g.ungetchar();
                    }

                }
                

                temp = "";


                temp= g.getchar().ToString();
                if (isdigit(temp))
                {
                    if (g.last_char)
                    {
                        g.pointer_now = g.pointer;
                        return temp;
                    }

                    string c = g.getchar().ToString();
                    while (isdigit(c)&& g.is_space==false )
                    {
                        temp += c;
                        if (g.last_char)
                        {
                            g.pointer_now = g.pointer;
                            return temp;
                        }
                        c = g.getchar().ToString(); ;

                    }
                    g.ungetchar();
                    g.pointer_now = g.pointer;
                    return temp;
                }

                



                

                return "eror";










            }


            Boolean isalphabet(string s)
            {

                Regex reg = new Regex(@"(?!\[)(?!\])^[a-zA-z]+$");
                if (reg.IsMatch(s))
                {
                    return true;
                }
                    return false;
            }

            Boolean isdigit(string s)
            {
                if(s=="0" || s == "1" || s == "2" || s == "3" || s == "4" || s == "5" || s == "6" || s == "7" || s == "8" || s == "9")
                {
                    return true;
                }
                return false;
            }









        }
        
    }


    class Getchar
    {
        public int pointer=0;
        char[] array;
        public Boolean is_space=false;
        public Boolean array_finish=false;
        public int array_size = 0;
        public Boolean last_char = false;
        public int pointer_now = 0;
        public Getchar(char [] a)
        {
            array = a;
            array_size = array.Length;
        }


        public void arrayfinish()
        {
            array_finish = true;

        }
        public char getchar()
        {
            char ch = '#';
            //Console.WriteLine("nima");
            if (pointer<=array.Length-1)
            {
                if(pointer_now== array.Length - 1)
                {
                    last_char = true;
                }
                
                ch = array[pointer];
                
            }
            else if(pointer_now==pointer)
            {
                arrayfinish();
             
            }
            
            if(ch.ToString()==" " || ch.ToString() == "\\")
            {
                while(ch.ToString() == " " || ch.ToString() == "\\")
                {
                    if(ch.ToString() == " ")
                    {
                        is_space = true;
                        pointer++;
                        if (pointer <= array.Length - 1)
                        {
                            if (pointer_now == array.Length - 1)
                            {
                                last_char = true;
                            }

                            ch = array[pointer];
                        }
                        else if (pointer_now == pointer)
                        {
                            arrayfinish();

                        }

                    }





                    if (ch.ToString() == "\\")
                    {
                        if (array[pointer + 1].ToString() == "n")
                        {
                            is_space = true;
                            pointer++;
                            pointer++;
                            if (pointer <= array.Length - 1)
                            {
                                if (pointer_now == array.Length - 1)
                                {
                                    last_char = true;
                                }

                                ch = array[pointer];
                            }
                            else if (pointer_now == pointer)
                            {
                                arrayfinish();

                            }

                        }

                    }
                    

                }

 
                
                
            }
            else
            {
                is_space = false;
            }


            /*if (ch.ToString() == "\n")
            {
                Console.Write("naaaaa");
                while (ch.ToString() == "\n ")
                {
                    is_space = true;
                    pointer++;
                    if (pointer <= array.Length - 1)
                    {
                        if (pointer_now == array.Length - 1)
                        {
                            last_char = true;
                        }

                        ch = array[pointer];
                    }
                    else if (pointer_now == pointer)
                    {
                        arrayfinish();

                    }

                }




            }
            else
            {
                is_space = false;
            }*/




            pointer++;
         
            return ch;


        }

        public void ungetchar()
        {
            
            pointer--;
            
        }


    }

    class Token
    {
        public List<string> list = new List<string>();
        int i=0;
        public string gettoken()
        {

            /*Console.WriteLine("chizi ke alan mikhad biad "+list[i]);
            Console.ReadKey();*/
            if (i > list.Count-1)
            {
                Console.WriteLine("compile b sorat kamel va bedon error anjam shod");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            return list[i];

        }

        public void droptoken()
        {
            i++;
        }
        public void tokenback()
        {
            i--;
        }
    }





    class Syntax_Analyser
    {
        Boolean isArray = true;  
        Boolean cond = false;
        int localType = -1;
        int localType2 = -1;
        List<Symbol> table =new  List<Symbol>();
        List<string> keyWords = new List<string>();

        public void initialize()
        {
            keyWords.Add("function");
            keyWords.Add("Array");
            keyWords.Add("Int");
            keyWords.Add("Nil");
            keyWords.Add("returns");
            keyWords.Add("val");
            keyWords.Add("if");
            keyWords.Add("else");
            keyWords.Add("end");
            keyWords.Add("return");
            keyWords.Add("of");
            Symbol Ksymobol = new Symbol("createArray",2,true,1);
            Symbol Knsymbol = new Symbol("i", 1, false, 0);
            Ksymobol.addparam(Knsymbol);
            table.Add(Ksymobol);
            Ksymobol.AddSymbol(Ksymobol);
            Symbol Ksymobol1 = new Symbol("printInt", 1, true, 1);
            Symbol Knsymbol1 = new Symbol("i", 1, false, 0);
            Ksymobol1.addparam(Knsymbol1);
            table.Add(Ksymobol1);
            Ksymobol1.AddSymbol(Ksymobol1);



            prog();


        }
        



        Token t = new Token();
        public void AddTokenTolist(string token)
        {
            t.list.Add(token);
        }

        public void start()
        {
            
        }
        public void prog()
        {
            if (func())
            {
                prog();
            }
            else
            {
                Console.WriteLine("error in program.");
                Console.ReadKey();
            }
        }

        public Boolean func()
        {
            string token = t.gettoken();

            if (token == "function")
            {
                Symbol symbol = new Symbol();
                symbol.SetFunc(true);
                t.droptoken();
                token = t.gettoken();
                int ide = iden(symbol,0,token);
                if (ide!=1)
                {
                    symbol.SetName(token);
                    t.droptoken();
                    if (t.gettoken() == "(")
                    {
                        t.droptoken();
                        if (flist(symbol,0)!=-1)
                        {
                            token = t.gettoken();
                            if (token == ")")
                            {
                                t.droptoken();
                                token = t.gettoken();
                                if (token == "returns")
                                {
                                    t.droptoken();
                                    int ty = type();
                                    if (ty!=-1)
                                    {
                                        t.droptoken();
                                        symbol.SetType(ty);
                                        token = t.gettoken();
                                        if (token == ":")
                                        {
                                            t.droptoken();
                                            table.Add(symbol);
                                            symbol.AddSymbol(symbol);                         
                                            if (body(symbol))
                                            {
                                                token = t.gettoken();
                                                if (token == "end")
                                                {
                                                    t.droptoken();
                                                    return true;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("error bdy end bzri");
                                                    Console.ReadKey();
                                                    return false;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("error badane tabe moshkel dare");
                                                Console.ReadKey();
                                                return false;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("error byd : bzri");
                                            Console.ReadKey();
                                            return false;
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine("error type ke gozashti valid nis");
                                        Console.ReadKey();
                                        return false;
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("error byd return bzri");
                                    Console.ReadKey();
                                    return false;
                                }


                            }
                            else
                            {
                                Console.WriteLine("error byd ) baste bzri");
                                Console.ReadKey();
                                return false;
                            }

                        }
                        else
                        {
                            Console.WriteLine("error tabe moshkel farakhani dre");
                            Console.ReadKey();
                            return false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("error byd ( bzri");
                        Console.ReadKey();
                        return false;
                    }



                }
                else
                {
                    Console.WriteLine("error esm function ghablan estefade shode");
                    Console.ReadKey();
                    return false;
                }


            }
            else
            {
                Console.WriteLine("error function byd benevisi");
                Console.ReadKey();
                return false;
            }


        }



        public Boolean body(Symbol symbol)
        {
            if (stmt(symbol))
            {
                return body(symbol);
            }
            else
            {
                return true;
            }
        
        

        }

        public Boolean stmt(Symbol symbol)
        {
            

            if (defvar(symbol))
            {
                string token = t.gettoken();
                if (token == ";")
                {
                    t.droptoken();
                    return true;

                }
                else
                {
                    Console.WriteLine("error ; bzr");
                    Console.ReadKey();
                    return false;
                    
                }

            }



            else if (t.gettoken() == "if")
            {
                t.droptoken();
                if (t.gettoken() == "(")
                {
                    t.droptoken();
                    int ex = expr(symbol, true,false);
                    if (ex != -1)
                    {
                        if (t.gettoken() == ")")
                        {
                            t.droptoken();
                            if (stmt(symbol))
                            {
                                if (t.gettoken() == "else")
                                {
                                    t.droptoken();
                                    if (stmt(symbol))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("error smt  bade else moshekel dre");
                                        Console.ReadKey();
                                        return false;
                                    }
                                }
                                return true;

                            }
                            else
                            {
                                Console.WriteLine("error stmt bade ) boshkel dre");
                                Console.ReadKey();
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error byd ) bzri");
                            Console.ReadKey();
                            return false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("error exeption dakheli moshkel dre");
                        Console.ReadKey();
                        return false;

                    }

                }
                else
                {

                    Console.WriteLine("error ( moshkel dare");
                    Console.ReadKey();
                    return false;
                }
            }





            else if (t.gettoken() == "while")
            {
                t.droptoken();
                if (t.gettoken() == "(")
                {
                    t.droptoken();
                    int ex = expr(symbol,true,false);
                    if (ex != -1)
                    {
                        if (t.gettoken() == ")")
                        {
                            t.droptoken();
                            if (t.gettoken() == "do")
                            {
                                t.droptoken();
                                if (stmt(symbol))
                                {
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine("error smt jolo do moshkel dre");
                                    Console.ReadKey();
                                    return false;
                                }

                            }
                            else
                            {
                                Console.WriteLine("error byd do bzri");
                                Console.ReadKey();
                                return false;

                            }

                        }
                        else
                        {
                            Console.WriteLine("error ) byd bzri.");
                            Console.ReadKey();
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error expersion dakhel while moshkel dare");
                        Console.ReadKey();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("error ( byd bzri");
                    Console.ReadKey();
                    return false;
                }
            }


            else if (t.gettoken() == "foreach")
            {
                t.droptoken();
                if (t.gettoken() == "(")
                {
                    t.droptoken();
                    string token = t.gettoken();
                    int ide = iden(symbol, 1, token);
                    if (ide != 0)
                    {
                        t.droptoken();
                        if (t.gettoken() == "of")
                        {
                            isArray = false;
                            t.droptoken();
                            int ex = expr(symbol,true,false);
                            if (ex != -1)
                            {
                                isArray = true;
                                if (t.gettoken() == ")")
                                {
                                    t.droptoken();
                                    if (stmt(symbol))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("error stmt jolo foreach moshkel dare");
                                        Console.ReadKey();
                                        return false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("error byd ) bzri");
                                    Console.ReadKey();
                                    return false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("error expersion jolo of moshkel dre");
                                Console.ReadKey();
                                return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error byd of bzri");
                            Console.ReadKey();
                            return false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("error in iden ghablan tarif shode");
                        Console.ReadKey();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("error byd ( bzri");
                    Console.ReadKey();
                    return false;
                }
            }

            else if (t.gettoken() == "return")
            {
                t.droptoken();
                int ex = expr(symbol,true,false);
                if (ex != -1)
                {
                    int numberOfParm = symbol.GetNumbrOfParms();
                    if (ex == symbol.GetTable()[numberOfParm].GetType())               //// avalin ozv table daronie symbol khode symbol ast ke function ast
                    {
                        if (t.gettoken() == ";")
                        {
                            t.droptoken();
                            return true;

                        }
                        else
                        {
                            Console.WriteLine("error ; bzr");
                            Console.ReadKey();
                            return false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("error tye khoroji ba type khoroji ke bayad bashe motefavete");
                        Console.ReadKey();
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("error exprsion jolo return moshkel dre");
                    Console.ReadKey();
                    return false;
                }

            }

            else if (t.gettoken() == ":")
            {
                t.droptoken();

                if (body(symbol))
                {
                    if (t.gettoken() == "end")
                    {
                        t.droptoken();
                        return true;

                    }
                    else
                    {
                        Console.WriteLine("error byd end bzri.");
                        Console.ReadKey();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("error body va smt dochar moshkel ast");
                    Console.ReadKey();
                    return false;
                }
            }
            Boolean chexkExpr = false;
            
            string checktoken = t.gettoken();  
            int checkIden=iden(symbol, 1, checktoken);
            Boolean checkNum = num(checktoken);
            if (checktoken == "end")
            {
                checkIden = 2;
            }
            if(checktoken=="("||checkIden!=2|| checkNum == true)
            {
                chexkExpr = true;
            }
            if (chexkExpr == true)
            {
                expr(symbol,false,false);
                
                if (t.gettoken() == ";")
                {
                    t.droptoken();
                    return true;
                }
                else
                {
                    Console.WriteLine("byd ; bzri");
                    Console.ReadKey();
                    return false;
                }
            }
            else
            {
                if (t.gettoken() == "end")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("error smt dorost shoro nashode");
                    Console.ReadKey();
                    return false;

                }
                

            }
            

            

        }


        public Boolean defvar(Symbol symbol)
        {
            if (t.gettoken()=="val")
            {
                Symbol symbol1 = new Symbol();
                symbol1.SetFunc(false);
                t.droptoken();
                int ty =type();
                if (ty!=-1)
                {
                    t.droptoken();
                    symbol1.SetType(ty);
                    string token = t.gettoken();
                    int ide = iden(symbol, 1,token);
                    if (ide!=1)
                    {
                        t.droptoken();
                        symbol1.SetName(token);
                        symbol.AddSymbol(symbol1);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("error in iden ghablan tarif shode");
                        Console.ReadKey();
                        //byd barname stop she
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("error type mored nazar ghable ghabol nis.");
                    Console.ReadKey();
                    //byd barname stop she
                    return false;
                }
            }
            else
            {
                return false;
            }

            
        }



        public int expr(Symbol symbol,Boolean wr,Boolean isIn)
        {

            return assign_expr(symbol,wr,isIn);
            /*string token = t.gettoken();
            int chk=iden(symbol, 1, token);
            int check = 0;
            if(chk==1)
            {
                t.droptoken();
                for(int i = 0; i < symbol.GetTable().Count; i++)
                {
                    if (symbol.GetTable()[i].GetName() == token)
                    {
                        check = symbol.GetTable()[i].GetType();
                    }
                }
                if (t.gettoken() == "=")
                {
                    if (check == cond_expr(symbol))
                    {
                        return check;
                    }
                    else
                    {
                        Console.WriteLine("type haii ke dari assign mikoni be ham nmikhoran");
                        Console.ReadKey();
                        return -1;
                    }
                    
                }
                else
                {
                    Console.WriteLine("bayad = bzri");
                    Console.ReadKey();
                    return -1;
                }
            }
            else if (chk == 0)
            {
                Console.WriteLine("in iden ghabln tarif nashode");
                Console.ReadKey();
                return -1;

            }
            else if (chk == 2)
            {
                Console.WriteLine("in iden nmitone bashe");
                Console.ReadKey();
                return -1;

            }
            else if (chk == 3)
            {
                Console.WriteLine("kalame kilidi nmitone iden bashe");
                Console.ReadKey();
                return -1;

            }
            return -1;*/



            

        }

        public int assign_expr(Symbol symbol , Boolean wr, Boolean Isin)
        {
            /*if (wr)
            {
                cond = true;
            }*/
            int un;
            int ex = cond_expr(symbol);
            if (wr || cond)
            {
                if (Isin)
                {
                    return ex;
                }
                else
                {
                    cond = false;

                    return ex;

                }
                
            }
            else
            {
                //t.tokenback();
                //un = unary_expr(symbol);
                if (t.gettoken() == ";")
                {
                    return ex;
                }
                if (t.gettoken() == "=")
                {
                    t.droptoken();
                    return assign_expr(symbol,true,false);


                }
                else
                {
                    Console.WriteLine("byd= bzri");
                    Console.ReadKey();
                    return ex;
                }
            }
           

        }

        public int cond_expr(Symbol symbol)
        {
            return or_expr(symbol);
            /*int ex = or_expr(symbol);
            if (ex!=-1)
            {
                return ex;
            }
            else
            {
                return -1;
            }*/
        }

        public int or_expr(Symbol symbol)
        {

            localType = and_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "||" )
            {
                cond = true;
                t.droptoken();
                if (localType == localType2)
                {
                    localType2 = and_expr(symbol);
                }
                else
                {
                    Console.WriteLine("type haii ke dara || mishan tki nis");
                    Console.ReadKey();

                }
            }
            return localType;
          
        }

        public int and_expr(Symbol symbol)
        {
            localType = equ_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "&&" )
            {
                cond = true;
                t.droptoken();
                if (localType == localType2)
                {
                    localType2 = equ_expr(symbol);
                }
                else
                {
                    Console.WriteLine("type haii ke daran && mishan yki nis");
                    Console.ReadKey();

                }
            }
            return localType;
           

        }

        public int equ_expr(Symbol symbol)
        {
            localType = relational_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "==" || t.gettoken() == "!=" )
            {
                cond = true;
                t.droptoken();
                if (localType == localType2)
                {
                    localType2 = relational_expr(symbol);
                }
                else
                {
                    Console.WriteLine("type haii ke dara == ya != mishan tki nis");
                    Console.ReadKey();

                }
            }
            return localType;


           


            



        }


        public int relational_expr(Symbol symbol)
        {

            localType = add_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "<" || t.gettoken() == ">" || t.gettoken() == ">=" || t.gettoken() == "<=")
            {
                cond = true;
                t.droptoken();
                if (localType == localType2)
                {
                    localType2 = add_expr(symbol);
                }
                else
                {
                    Console.WriteLine("type haii ke dara moghaiese mishan tki nis");
                    Console.ReadKey();

                }
            }
            return localType;



            

           

            
        }


        public int add_expr(Symbol symbol)
        {
            localType = mul_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "+" || t.gettoken() == "-")
            {
                cond = true;
                t.droptoken();
                if (localType == localType2)
                {
                    localType2 = mul_expr(symbol);
                }
                else
                {
                    Console.WriteLine("type haii ke dara * ya / ya5 mishan yeki nistan");
                    Console.ReadKey();

                }
            }
            return localType;
            

           

        }


        public int mul_expr(Symbol symbol)
        {
            localType = unary_expr(symbol);
            localType2 = localType;
            while (t.gettoken() == "*" || t.gettoken() == "/" || t.gettoken() == "%")
            {
                cond = true;
                t.droptoken();
                if (localType2 == localType)
                {
                    localType2=unary_expr(symbol);

                }
                else
                {
                    Console.WriteLine("type haii ke dara * ya / ya5 mishan yeki nistan");
                    Console.ReadKey();
                    return -1;
                }
                

            }
            return localType;
            

        }
        

        public int unary_expr(Symbol symbol)
        {
            while (unary_operator(symbol)) ;
            return postfix_expr(symbol);

            

            
        }

        public int postfix_expr(Symbol symbol)
        {
            int ide = -3;
            Boolean b = false;
            Boolean b2 = false;
            string token = t.gettoken();
            if (!num(token))
            {
                ide = iden(symbol, 1, token);

            }
             
            if(ide == 1){

                for(int i = 0; i < symbol.GetTable().Count; i++)
                {
                    if (symbol.GetTable()[i].GetName() == token)
                    {
                        if (symbol.GetTable()[i].GetFunc() == false && symbol.GetTable()[i].GetType() == 2)
                        {
                            b = true;
                        }
                    }
                }

            }
            if (b && isArray == true)
            {
                t.droptoken();
                t.gettoken();
                t.droptoken();
                string temp = t.gettoken();
                if (temp == "createArray")
                {
                    b2 = false;
                }
                else
                {
                    b2 = true;
                }
                t.tokenback();
                t.tokenback();
            }

            int ex = prim_expr(symbol);
            if (b2)
            {
                
                if (postfix_expr_extra(symbol) == true)
                {
                    isArray = true;
                    return 1;
                }
                else
                {
                    Console.WriteLine("error dr exprison haie jolo araye irad ast");
                    Console.ReadKey();
                    return -1;
                }

            }
            else
            {
                return ex;

                
            }

        }


        public Boolean postfix_expr_extra(Symbol symbol)
        {
            string token = t.gettoken();
            if (token == "[")
            {
                t.droptoken();
                int ex = expr(symbol,true,true);
                if (ex!= -1)
                {
                    if (ex == 1)
                    {
                        if (t.gettoken() == "]")
                        {
                            t.droptoken();
                            if (t.gettoken() == "[")
                            {

                                if (postfix_expr_extra(symbol))
                                {
                                    return true;

                                }
                                else
                                {
                                    return false;
                                }
                                
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error byd ] bzri");
                            Console.ReadKey();
                            return false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("index byd int bashe");
                        Console.ReadKey();
                        return false;
                    }
                    

                }
                else
                {
                    Console.WriteLine("exprison dakhel baket haie araye irad dare.");
                    Console.ReadKey();
                    return false;

                }
            }
            else
            {
                Console.WriteLine("byd [ bzri");
                Console.ReadKey();
                return false;
            }

        }

        public int prim_expr(Symbol symbol)
        {
            string token = t.gettoken();

            if (num(token))
            {
                t.droptoken();
                localType = 1;
                return 1;
            }
            int ide = iden(symbol, 1, token);
            if (ide == 1 || ide==2 )
            {
                t.droptoken();
                int type=-1;
                int index=-1;
                Boolean q=false;
                for (int i = 0; i < symbol.GetTable().Count; i++)
                {
                    if(token== symbol.GetTable()[i].GetName())
                    {
                        type = symbol.GetTable()[i].GetType();
                        index = i;
                        q = true;
                        break;
                    }
                }
                for(int i=0; i < table.Count; i++)
                {
                    if (token == table[i].GetName())
                    {
                        type = table[i].GetType();
                        index = i;
                        break;
                    }
                }
                

                if (t.gettoken() == "(")
                {
                    t.droptoken();
                    if (q)
                    {
                        if (symbol.GetTable()[index].GetFunc())
                        {
                            if (clist(symbol, 0, 0,index))
                            {

                                if (t.gettoken() == ")")
                                {
                                    t.droptoken();
                                    localType = type;
                                    return type;
                                }
                                else
                                {
                                    Console.WriteLine("error byd ) bzri");
                                    Console.ReadKey();
                                    return -1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("error dar ghesmat dadan argumenta irad ast");
                                Console.ReadKey();
                                return -1;
                            }

                        }
                        else
                        {
                            Console.WriteLine("error in iden esm tabe nis");
                            Console.ReadKey();
                            return -1;
                        }

                    }
                    else
                    {
                        
                        if (clist(symbol, 0, 0,index))
                        {

                            if (t.gettoken() == ")")
                            {
                                t.droptoken();
                                localType = type;   
                                return type;
                            }
                            else
                            {
                                Console.WriteLine("error byd ) bzri");
                                Console.ReadKey();
                                return -1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error dar ghesmat dadan argumenta irad ast");
                            Console.ReadKey();
                            return -1;
                        }

                    }
                    
                    
                    
                }
                localType = type;
                return type;
            }
            else if (ide == 0)
            {
                Console.WriteLine("error ide tarfi nashode ghablan");
                Console.ReadKey();
            }
            else if (t.gettoken() == "(")
            {
                t.droptoken();
                int ex = expr(symbol,true,true);
                if (ex!=-1)
                {
                    if (t.gettoken() == ")")
                    {
                        t.droptoken();
                        localType = ex;
                        return ex;
                    }
                    else
                    {
                        Console.WriteLine("error byd ) bzri");
                        Console.ReadKey();
                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine("error expersion dakhel () irad dare");
                    Console.ReadKey();
                    return -1;
                }
            }

            
            return -2;


            
        }

        public Boolean unary_operator(Symbol symbol)
        {
            if (t.gettoken() == "+")
            {
                t.droptoken();
                return true;
            }
            else if(t.gettoken() == "-")
            {
                t.droptoken();
                return true;
            }
            else if (t.gettoken() == "!")
            {
                t.droptoken();
                return true;
            }
           
            return false;
        }






      



        public int flist(Symbol symbol, int i)
        {
            if (i == 0)
            {
                int ty = type();
                
                if (ty!=-1)
                {
                    t.droptoken();
                    Symbol symbol2 = new Symbol();
                    symbol2.SetType(ty);
                    symbol2.SetFunc(false);
                    string token = t.gettoken();
                    int ide = iden(symbol, 0, token);
                    if (ide !=1)
                    {
                        t.droptoken();
                        symbol2.SetName(token);
                        symbol.AddSymbol(symbol2);
                        symbol.addparam(symbol2);
                        symbol.SetNumbrOfParms();
                        if (t.gettoken() == ",")
                        {
                            t.droptoken();
                            return flist(symbol, 1);

                        }
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("error in esm dr flisti ke dare midi ghabln estefade shode");
                        Console.ReadKey();
                        return -1;
                    }
                }
                else
                {
                    if (t.gettoken() == ")")
                    {
                        
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("error byd ) bzri");
                        Console.ReadKey();
                        return -1;
                    }
                    
                }

            }
            if (i == 1)
            {
                int ty1 = type();
                t.droptoken();
                if (ty1!=-1)
                {
                    Symbol symbol3 = new Symbol();
                    symbol3.SetType(ty1);
                    symbol3.SetFunc(false);
                    string token = t.gettoken();
                    int ide = iden(symbol, 0, token);
                    if (ide != 1)
                    {
                        t.droptoken();
                        symbol3.SetName(token);
                        symbol.AddSymbol(symbol3);
                        symbol.addparam(symbol3);
                        symbol.SetNumbrOfParms();
                        if (t.gettoken() == ",")
                        {
                            t.droptoken();
                            return flist(symbol, 1);

                        }
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("error in esm ghablan estefade shode");
                        Console.ReadKey();
                        return -1;
                    }
                }
                else
                {
                    Console.WriteLine("error byd argument ezafe koni");
                    Console.ReadKey();
                    return -1;
                }

            }
            /*Console.WriteLine("akhre flist moshkel dre");*/
            return -1;
            

           


        }


        public Boolean clist(Symbol symbol , int i , int j, int index)
        {
            ///j braie ink bfhamim bade , seda zade shode ya na. age 1 bashe yani bade virgol seda zade shode
            if (j == 0)
            {
                if (t.gettoken() == ")")
                {
                    return true;
                }

                int e = -1;
                string tk = t.gettoken();

                for (int y = 0; y < symbol.GetTable().Count; y++)
                {
                    if (tk == symbol.GetTable()[y].GetName())
                    {
                        e = symbol.GetTable()[y].GetType();
                        break;
                    }
                }
                for (int y = 0; y < table.Count; y++)
                {
                    if (tk == table[y].GetName())
                    {
                        e = table[y].GetType();
                        
                    }
                }

                if (e == 2)
                {
                    t.droptoken();
                    if (t.gettoken() == "[")
                    {
                        isArray = true;
                    }
                    else
                    {
                        isArray = false;
                    }
                    t.tokenback();

                }
                
                
                int type = expr(symbol,true,true);
                
                int numberOfParam = table[index].GetNumbrOfParms();
                if (i <= numberOfParam-1)
                {
                    if (table[index].GetParamTable()[i].GetType() == type)
                    {
                        if (t.gettoken() == ",")
                        {
                            t.droptoken();
                            int tempi = i + 1;
                            if (clist(symbol, tempi, 1,index))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (numberOfParam-1 > i)
                            {
                                Console.WriteLine("parametr haie vorodi kam ast");
                                Console.ReadKey();
                                return false;
                            }
                            return true;

                        }
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("type vorodi argoman ghalate");
                        Console.ReadKey();
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("error arguman haii k dari midi ziadie");
                    Console.ReadKey();
                    return false;
                }
                

            }
            if (j == 1)
            { 
                if (t.gettoken() == ")")
                {
                    Console.WriteLine("error, chra ) baste gozashti bade ,");
                    Console.ReadKey();
                    return false;
                }

                int e = -1;
                string tk = t.gettoken();

                for (int y = 0; y < symbol.GetTable().Count; y++)
                {
                    if (tk == symbol.GetTable()[y].GetName())
                    {
                        e = symbol.GetTable()[y].GetType();
                        break;
                    }
                }
                for (int y = 0; y < table.Count; y++)
                {
                    if (tk == table[y].GetName())
                    {
                        e = table[y].GetType();

                    }
                }

                if (e == 2)
                {
                    t.droptoken();
                    if (t.gettoken() == "[")
                    {
                        isArray = true;
                    }
                    else
                    {
                        isArray = false;
                    }
                    t.tokenback();

                }

                int type = expr(symbol,true,true);
                int numberOfParam = table[index].GetNumbrOfParms();
                if (i <= numberOfParam-1)
                {
                    if (table[index].GetParamTable()[i].GetType() == type)
                    {
                        if (t.gettoken() == ",")
                        {
                            t.droptoken();
                            if (clist(symbol, i++, 1,index))
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (numberOfParam-1 > i)
                            {
                                Console.WriteLine("parametr haie vorodi kam ast");
                                Console.ReadKey();
                                return false;
                            }

                            return true;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("error type vorodi function ghalate");
                        Console.ReadKey();
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("error, argumant haii ke dari midi ziadie");
                    Console.ReadKey();
                    return false;

                }
                

            }
            return false;
            


            
        }



        public int type()
        {
            string token =t.gettoken();
            if (token == "Nil" || token == "Array" || token == "Int")
            {
                if (token == "Nil")
                {
                    
                    return 0;
                }
                if (token == "Int")
                {
                    
                    return 1;

                }
                if (token == "Array")
                {
                    
                    return 2;
                }
                return -1;

            }
            else
            {
                return -1;
            }

        }

        public Boolean num(string token)
        {
            Regex reg = new Regex(@"^[0-9]*$");

            if (reg.IsMatch(token))
            {
                
                return true;
            }
            else
            {
                return false;
            }

        }


        public int iden(Symbol symbol, int j,string token)
        {
            //return 1 yani peid shode meslesh. 0 yani peida nashode. 2 yani asln match nashode. 3 yani kalame kilidi asan
            /// o bashe az function// age 1 bashe dakhel function
            
            if (j == 0)
            {
                Regex reg = new Regex(@"^[a-zA-Z_][a-zA-Z0-9_]*$");
                //string st = t.gettoken();
                if (reg.IsMatch(token))
                {
                    for (int i = 0; i < table.Count; i++)
                    {
                        if (table[i].GetName() == token)
                        {
                            return 1;
                        }

                    }
                    //symbol.SetName(st);
                    //t.droptoken();
                    return 0;

                }
                else
                {
                    Console.WriteLine(token + " cant be an iden");
                    Console.ReadKey();
                    return 2;
                }

            }
            if (j == 1)
            {
                int check = 0;
                for(int q = 0; q < keyWords.Count; q++)
                {
                    if (token == keyWords[q])
                    {
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    Regex reg = new Regex(@"^[a-zA-Z_][a-zA-Z0-9_]*$");
                    //string st = t.gettoken();
                    if (reg.IsMatch(token))
                    {
                        for (int i = 0; i < symbol.GetTable().Count; i++)
                        {
                            if (symbol.GetTable()[i].GetName() == token)
                            {
                                return 1;
                            }

                        }
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (table[i].GetName() == token)
                            {
                                return 1;
                            }

                        }


                        //t.droptoken();
                        return 0;

                    }
                    else
                    {
                        Console.WriteLine(token + " cant be an iden");
                        Console.ReadKey();
                        return 2;
                    }

                }
                else
                {
                    return 3;
                }
                

            }
            return 1;


        }
        




    }

}
