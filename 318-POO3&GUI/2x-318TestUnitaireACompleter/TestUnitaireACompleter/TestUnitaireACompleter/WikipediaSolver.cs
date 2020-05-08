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
            return equation.B * equation.B - (4 * equation.A * equation.C);
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
        /// <returns>La solution (0,1 ou 2 solutions)</returns>
        public double[] solve()
        {
            int discriminant = computeDiscriminant();

            if (discriminant >= 0)
            {
                double x1;
                double x2;
                double sqrDiscriminant = Math.Sqrt(discriminant);
                int _2a = 2 * equation.A;

                x1 = (-equation.B + sqrDiscriminant) / _2a;

                //solution unique
                if (discriminant == 0)
                {
                    return new double[] { x1 };
                }
                else
                {
                    x2 = (-equation.B - sqrDiscriminant) / _2a;
                    return new double[] { x1, x2 };
                }
            }
            else
            {
                //pas de solution dans l'espace réel
                //TODO: version avec nombres complexes
                return new double[] {};
            }
        }
    }
}
