using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment-1
            //char[] digits = { '1', '2', '3', '4', '5', '6', '7' , '8', '9', '0' };
            //bool hasChar = false;

            //Console.WriteLine("Yazi daxil edin:");
            //string enterString = Console.ReadLine();

            //for(int i = 0; i < enterString.Length; i++)
            //{
            //    var letter = enterString[i];
            //    for(int j = 0; j < digits.Length; j++)
            //    {
            //        if (letter == digits[j])
            //        {
            //            hasChar = true;
            //            break;
            //        }


            //        else
            //            hasChar = false;

            //    }
            //}

            //if (hasChar == false)
            //    Console.WriteLine(enterString + " stringinin icinde reqem YOXDUR!");
            //else
            //    Console.WriteLine(enterString + " stringinin icinde reqem VAR!");
            #endregion

            #region Assignment-2
            //Console.WriteLine("String daxil edin:");
            //string enterString = Console.ReadLine();
            //bool hasChar = false;


            //for(int i = 0; i < enterString.Length; i++)
            //{
            //    if (enterString[i] == 'a' && enterString[i + 1] == 'l')
            //    {
            //        hasChar = true;
            //        break;
            //    }

            //    else
            //        hasChar = false;
            //}

            //if (hasChar == true)
            //    Console.WriteLine("Stringin icinde 'al' herf birlesmesi VAR!");

            //else
            //    Console.WriteLine("Stringin icinde 'al' herf birlesmesi YOXDUR!");
            #endregion

            #region Assignment-3
            Console.WriteLine("String daxil edin:");
            string enterString = Console.ReadLine();
            bool hasChar = false;


            for (int i = 0; i < enterString.Length; i++)
            {
                int k = i + 1;

                if (k < enterString.Length)
                {
                    if (enterString[i] == 'a' && enterString[i + 1] == 'l')
                    {
                        hasChar = true;
                        break;
                    }

                    else
                        hasChar = false;
                }
                
            }

            if (hasChar == true)
                Console.WriteLine("Stringin icinde 'al' herf birlesmesi VAR!");

            else
                Console.WriteLine("Stringin icinde 'al' herf birlesmesi YOXDUR!");
            #endregion
        }
    }
}
