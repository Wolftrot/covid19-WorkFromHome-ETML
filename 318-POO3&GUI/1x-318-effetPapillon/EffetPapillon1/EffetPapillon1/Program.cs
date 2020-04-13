//ETML
//Auteur : JMY
//Date : 2017
//Description : Mystère

using System;

namespace EffetPapillon1
{
    /// <summary>
    /// Que se passe-t-il ici ?
    /// --> This program operates the max int trying falling in a roll-back of the int.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 12;
            uint b = 2147483647;

            //petite addition
            //TODO c'est quoi le problème ? --> bad data type 
            uint c = a + b;
            System.Console.WriteLine(a + "+" + b + "=" + (c));

            System.Console.WriteLine(b + "+" + b + "=" + (c));

            System.Console.WriteLine(b + "²"+ "=" + (Math.Pow(b,2)));

            //Petit tour de boucle
            //TODO pourquoi ça ne tourne pas ? --> bad data type 

            //--> Then without providing enough allocation for the operations to store the full value,
            //handling the roll-back of the value or other: it will stop the parts of our program 
            //requiring of it as a condition.

            //Historicaly, trying to store 64bit number into 32 made a rocket fail, change it course 
            //to the opposite pole and explode by pressure exerciced in the manouver
            for (uint i = 0; i < b + 1; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
