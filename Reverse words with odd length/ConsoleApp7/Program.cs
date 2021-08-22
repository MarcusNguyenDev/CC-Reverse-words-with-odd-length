using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {

    //Given a string, reverse all the words which have odd length. The even length words are not changed.
    class Program {
        static void Main(string[] args) {
            string inputString;
            string output;
            Console.WriteLine("Please insert the string");
            inputString = Console.ReadLine();
            output = ReverseString(inputString);
            Console.WriteLine("This is your reverse string: ");
            Console.WriteLine(output);
            Console.ReadLine();
        }

        /// <summary>
        /// input string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(string str) {
            string outputString = "";
            //Split the input string into words
            string[] words = str.Split(' ');
            int numberofwords = words.Count();

            //for each word, check the length of that word
            //if the leng is odd, reverse the word
            //Reversing the word by split the word into characters
            //put character in the back to the front
            //then combine all words into new string
            //then return the output string
            for (int i = 0; i < numberofwords; i++) {
                if (!(words[i].Length % 2 == 0)) {
                    string Reversedword = "";
                    for (int a = 0; a < words[i].Length; a++) {
                        Reversedword = Reversedword + (words[i])[words[i].Length-(a+1)];
                    }
                    words[i] = Reversedword;
                }
                outputString = outputString+words[i]+" ";
            }
            
            str = outputString;

            return str;
        }
    }
}
