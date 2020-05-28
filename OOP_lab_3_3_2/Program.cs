using System;
using System.IO;

namespace OOP_lab_3_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("code.js");

            string code = file.ReadToEnd();

            int roundCount = 0;
            int figureCount = 0;

            for (int i = 1; i < code.Length; ++i)
            {
                switch (code[i])
                {
                    case '(':
                        ++roundCount;
                        break;

                    case ')':
                        --roundCount;
                        break;

                    case '{':
                        ++figureCount;
                        break;

                    case '}':
                        --figureCount;
                        break;
                }
            }

            if ((roundCount == 0) && (figureCount == 0))
            {
                Console.WriteLine("Кiлькiсть вiдкритих та закритих дужок спiвпадає.");
            }
            else
            {
                Console.WriteLine("Кiлькiсть вiдкритих та закритих дужок не спiвпадає.");
            }
        }
    }
}
