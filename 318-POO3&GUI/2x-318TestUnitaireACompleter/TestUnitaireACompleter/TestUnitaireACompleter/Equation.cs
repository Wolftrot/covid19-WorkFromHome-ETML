//ETML
//Auteur : JMY
//Date : 2017
//Description : Modèle pour une équation
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TestUnitaireACompleter
{
    /// <summary>
    /// Permet de porter les données d'une équation dans un objet
    /// </summary>
    public class Equation
    {
        private int a;
        private int b;
        private int c;

        /// <summary>
        /// TODO : implémenter un parsing
        /// </summary>
        /// <param name="equation">l'équation sous forme textuelle Ax²+Bx+C (exemple : 5x²+3x-8)</param>
        public Equation(string equation)
        {
            //TODO extraire A,B,C et le setter
            string equationString = equation;

            //replace signs, keep minus
            string toReplace = @"x2|x²|x";
            string replacement = @"";
            equationString = Regex.Replace(equation, toReplace, replacement);

            //replace signs, keep minus
            toReplace = @"\+";
            replacement = @",";
            equationString = Regex.Replace(equationString, toReplace, replacement);

            //replace signs, keep minus
            toReplace = @"\-";
            replacement = @",-";
            equationString = Regex.Replace(equationString, toReplace, replacement);

            //remove spaces
            toReplace = @" ";
            replacement = @"";
            equationString = Regex.Replace(equationString, toReplace, replacement);

            string[] temp = equationString.Split(',');



            try
            {
                a = Convert.ToInt32(temp[0]);
                b = Convert.ToInt32(temp[1]);
                c = Convert.ToInt32(temp[2]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("INCORRECT CHAIN FORMAT");
            }
        }


        /// <summary>
        /// Constructeur élémentaire
        /// </summary>
        /// <param name="a">x²</param>
        /// <param name="b">x</param>
        /// <param name="c">constante</param>
        public Equation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Getters

        /// <summary>
        /// Composante A de l'équation
        /// </summary>
        public int A
        {
            get { return a; }
        }

        /// <summary>
        /// Composante B de l'équation
        /// </summary>
        public int B
        {
            get { return b; }
        }

        /// <summary>
        /// Composante C de l'équation
        /// </summary>
        public int C
        {
            get { return c; }
        }
    }
}
