using System;
using TriangulationSysteme;
using InputOutputMatrice;

namespace Matrices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Probleme du cours de Ramadane
            double[,] A = { { 2, 3, -1 }, { 4, 4, -3 }, { -2, 3, -1 } };
            double[] B = { 5, 3, 1 };

            //Probleme trouver sur internet
            //double[,] A = { { 2, 1, -4 }, {3 , 3, -5 }, { 4, 5, -2 } };
            //double[] B = { 8, 14, 16};

            Console.WriteLine("La matrice avant changement: ");
            Input.OutputMatrice(A);

            Console.WriteLine("La matrice U apres changement: ");
            Input.OutputMatrice(ClassPivotGauss.TriangulaireSuperieur(A));

            Console.WriteLine("La matrice L apres changement: ");
            Input.OutputMatrice(ClassPivotGauss.TriangulaireInferieur(A));

            //Input.OutputMatriceB((ClassPivotGauss.PivotGaussA(A, B)));
        }
    }
}
