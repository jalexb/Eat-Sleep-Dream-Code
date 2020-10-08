using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                printWord();
                printWord();
            }
            
        }

        static void printWord()
        {
            Console.CursorVisible = false;

            //EAT
            string[] letterE = ELetterArray();
            string[] letterA = ALetterArray();
            string[] letterT = TLetterArray();

            string[] wordArray = new string[5];

            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterE[j] + letterA[j] + letterT[j];

                Console.WriteLine(wordArray[j]);
            }

            Thread.Sleep(1000);
            Console.Clear();
            //SLEEP
            string[] letterS = SLetterArray();
            string[] letterL = LLetterArray();
            string[] letterP = PLetterArray();

            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterS[j] + letterL[j] + letterE[j] + letterE[j] + letterP[j];

                Console.WriteLine(wordArray[j]);
            }

            Thread.Sleep(1000);
            Console.Clear();
            //DREAM
            string[] letterD = DLetterArray();
            string[] letterR = RLetterArray();
            string[] letterM = MLetterArray();
            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterD[j] + letterR[j] + letterE[j] + letterA[j] + letterM[j];

                Console.WriteLine(wordArray[j]);
            }

            Thread.Sleep(1000);
            Console.Clear();
            //CODE
            string[] letterC = CLetterArray();
            string[] letterO = OLetterArray();

            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterC[j] + letterO[j] + letterD[j] + letterE[j];

                Console.WriteLine(wordArray[j]);
            }

            Thread.Sleep(300);
            Console.Clear();
            Thread.Sleep(300);
            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterC[j] + letterO[j] + letterD[j] + letterE[j];

                Console.WriteLine(wordArray[j]);
            }

            Thread.Sleep(300);
            Console.Clear();
            Thread.Sleep(300);
            for (int j = 4; j >= 0; j--)
            {
                wordArray[j] = letterC[j] + letterO[j] + letterD[j] + letterE[j];

                Console.WriteLine(wordArray[j]);
            }
        }

        static string[] ALetterArray()
        {
            //Constructs "A" with x's, and a 2d array
            //y coordinate will be the row, x coordinate will
            //height of 10
            string[] letterA = new string[5];
            letterA[4] = "     XX    ";
            letterA[3] = "    X  X   ";
            letterA[2] = "   XXXXXX  ";
            letterA[1] = "  X      X ";
            letterA[0] = " X        X";
            return letterA;
        }

        static string[] CLetterArray()
        {
            string[] letterC = new string[5];
            letterC[4] = "  XXXX";
            letterC[3] = " X    ";
            letterC[2] = " X    ";
            letterC[1] = " X    ";
            letterC[0] = "  XXXX";
            return letterC;
        }

        static string[] DLetterArray()
        {
            string[] letterD = new string[5];
            letterD[4] = " XXXXX  ";
            letterD[3] = " X    X ";
            letterD[2] = " X     X";
            letterD[1] = " X    X ";
            letterD[0] = " XXXXX  ";
            return letterD;
        }

        static string[] ELetterArray()
        {
            string[] letterE = new string[5];
            letterE[4] = " XXXXXX";
            letterE[3] = " X     ";
            letterE[2] = " XXXX  ";
            letterE[1] = " X     ";
            letterE[0] = " XXXXXX";
            return letterE;
        }

        static string[] LLetterArray()
        {
            string[] letterL = new string[5];
            letterL[4] = " X     ";
            letterL[3] = " X     ";
            letterL[2] = " X     ";
            letterL[1] = " X     ";
            letterL[0] = " XXXXXX";
            return letterL; 
        }

        static string[] MLetterArray()
        {
            string[] letterM = new string[5];
            letterM[4] = "    X   X   ";
            letterM[3] = "   X X X X  ";
            letterM[2] = "  X   X   X ";
            letterM[1] = " X         X";
            letterM[0] = " X         X";
            return letterM;
        }

        static string[] OLetterArray()
        {
            string[] letterO = new string[5];
            letterO[4] = "  XXXX ";
            letterO[3] = " X    X";
            letterO[2] = " X    X";
            letterO[1] = " X    X";
            letterO[0] = "  XXXX ";
            return letterO;
        }

        static string[] RLetterArray()
        {
            string[] letterR = new string[5];
            letterR[4] = " XXXXX  ";
            letterR[3] = " X    X ";
            letterR[2] = " XXXXX  ";
            letterR[1] = " X    X ";
            letterR[0] = " X     X";
            return letterR;
        }

        static string[] SLetterArray()
        {
            string[] letterS = new string[5];
            letterS[4] = "   XXXXX ";
            letterS[3] = "  XX    X";
            letterS[2] = "    XX   ";
            letterS[1] = " X    XX ";
            letterS[0] = "  XXXXX  ";
            return letterS;
        }

        static string[] PLetterArray()
        {
            string[] letterP = new string[5];
            letterP[4] = " XXXXX ";
            letterP[3] = " X    X";
            letterP[2] = " XXXXX ";
            letterP[1] = " X     ";
            letterP[0] = " X     ";

            return letterP;
        }

        static string[] TLetterArray()
        {
            string[] letterT = new string[5];
            letterT[4] = " XXXXXXX";
            letterT[3] = "    X   ";
            letterT[2] = "    X   ";
            letterT[1] = "    X   ";
            letterT[0] = "    X   ";

            return letterT;
        }


    }
}
