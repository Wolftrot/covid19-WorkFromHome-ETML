//ETML
//Auteur : JMY  
//Date : 2017
//Description : Résolution d'équation du 2ème degré
namespace TestUnitaireACompleter
{
    /// <summary>
    /// Contrat pour un résolveur d'équation du 2ème degré
    /// </summary>
    interface ISecondDegreeSolver
    {
        /// <summary>
        /// Calcule la valeur B²-4ac
        /// </summary>
        /// <returns>B²-4ac</returns>
        int computeDiscriminant();

        /// <summary>
        /// Regarde si l'équation est résolvable sans nombre complexe
        /// </summary>
        /// <returns>vrai s'il y a une solution dans l'espace des nombres réels</returns>
        bool isSolvable();

        /// <summary>
        /// Résout l'équation
        /// </summary>
        /// <returns>La solution (0,1 ou 2 solutions)</returns>
        double[] solve();
    }
}
