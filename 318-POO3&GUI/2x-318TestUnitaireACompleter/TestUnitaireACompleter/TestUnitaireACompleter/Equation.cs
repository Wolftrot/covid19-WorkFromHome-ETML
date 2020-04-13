//ETML
//Auteur : JMY
//Date : 2017
//Description : Modèle pour une équation
using System;
using System.Collections.Generic;

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
            string equationString = a + "x² + " + b + "x +" + c;

            Stack<int> temp = new Stack<int>();

            foreach (char c in equation) 
            {
                decimal i = 0;
                if (Decimal.TryParse(c, out i)) { }
            }

            throw new NotImplementedException();
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
