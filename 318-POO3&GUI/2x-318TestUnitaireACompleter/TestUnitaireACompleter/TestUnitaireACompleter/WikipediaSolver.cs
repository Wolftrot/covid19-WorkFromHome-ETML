//ETML
//Auteur : JMY
//Date : 2017
//Description : Solveur d'équation du 2ème degré basé sur les informations trouvées sur wikipédia

using System;

namespace TestUnitaireACompleter
{
    /// <summary>
    /// Résout une équation du 2ème degré sans conserver d'état (autre que l'équation initiale fournie)
    /// réf : https://fr.wikipedia.org/wiki/%C3%89quation_du_second_degr%C3%A9
    /// </summary>
    public class WikipediaSolver : ISecondDegreeSolver
    {
        private Equation equation;

        /// <summary>
        /// Constructeur élémentaire
        /// </summary>
        /// <param name="equation"></param>
        public WikipediaSolver(Equation equation)
        {
            this.equation = equation;
        }

        /// <summary>
        /// Calcule la valeur B²-4ac
        /// </summary>
        /// <returns>B²-4ac</returns>
        public int computeDiscriminant()
        {
            return (equation.B * equation.B) - (4 * equation.A * equation.C);
        }

        /// <summary>
        /// Regarde si l'équation est résolvable sans nombre complexe
        /// </summary>
        /// <returns>vrai s'il y a une solution dans l'espace des nombres réels</returns>
        public bool isSolvable()
        {
            return computeDiscriminant() >= 0;
        }

        /// <summary>
        /// Calcule les possibilités de résolution dans l'espace réel
        /// </summary>
        /// <returns>La solution (0, 1 ou 2 solutions)</returns>
        public double[] solve()
        {


            //returns b^2-4ac
            int discriminant = computeDiscriminant();

            if (discriminant >= 0)
            {
                double x1;
                double x2;
                double sqrDiscriminant = Math.Sqrt(discriminant);

                // = (b + Sqrt(Delta))
                //  -------------------
                //    2 * a
                int _2a = 2 * equation.A;
                x1 = (-equation.B + sqrDiscriminant) / _2a;

                //solution unique
                //Si Delta = 0 A ou B et réel
                if (discriminant == 0)
                {
                    return new double[] { x1 };
                }
                //Si Delta > 0 A et B sont réels
                else
                {
                    // = (b - Sqrt(Delta))
                    //  -------------------
                    //    2 * a
                    x2 = (-equation.B - sqrDiscriminant) / _2a;
                    return new double[] { x1, x2 };
                }
            }
            //Si Delta < 0 l'équation n'apas de solution dans l'espace réel 
            //a deux solutions complexes conjugées distinctes
            else
            {
                GetComplexSolution(discriminant);
                return new double[] {};
            }
        }

        public string[] GetComplexSolution(int discriminant)
        {
            //pas de solution dans l'espace réel
            //Solutions complexes du deuxieme degrée

            //Dans ce cas Delta = (ir2)
            //z1 = -b+i Sqrt(Delta)  
            //      --------------- 
            //      2*a             
            //z2 = -b-i Sqrt(Delta) 
            //      ---------------
            //      2*a           

            double sqrDiscriminant = Math.Sqrt(discriminant);
            string z1 = $"z1 = -{equation.B} + i * {sqrDiscriminant} / 2 * {equation.A}";
            string z2 = $"z2 = -{equation.B} - i * {sqrDiscriminant} / 2 * {equation.A}";
            
            return new string[] { z1, z2 };
        }
    }

    

    
}
