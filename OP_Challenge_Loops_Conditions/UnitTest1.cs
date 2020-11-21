using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OP_Challenge_Loops_Conditions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //1 print every letter of this word to the console one at a time
            //Could also set this up as 2 below(minus the if else statements
             string value = "Supercalifragilisticexpialidocious";
             for (int i =0; i <value.Length; i++)
             {
                 Console.WriteLine(value[i]);
             }  
             

             //2 now only print the letter if its an 'i', if its any other letter print 'not an i'
            string word = "Supercalifragilisticexpialidocious";
            foreach (char c in word)
                if (c == 'i')
                { Console.WriteLine(c); }
                else if (c == 'l')      //another bonus print letter if it is L
                { Console.WriteLine(c); }
                else
                { Console.WriteLine("Not an I"); }

            //bonus: print num of letters in the word
            int count = word.Length;
            Console.WriteLine(count);
            
                


           
        
        }
    }
}
