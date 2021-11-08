using System;

namespace _4X4_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = {
                {4, 3, 2, 2},
                {0, 1, -3, 3},
                {0, -1, 3, 3},
                {0, 3, 1, 1}
            };

            void get4by4MatrixDeterminant(int[,] matrix)
            {
                // Check if matrix provided is 4 by 4
                if ((matrix.GetLength(0) != 4) || (matrix.GetLength(1) != 4))
                {
                    Console.WriteLine("Invalid matrix:- Matrix Provided is not a 4*4 matrix");
                }
                else
                {
                    //Get each element of the matrix
                    int matrix11 = matrix[0, 0], matrix12 = matrix[0, 1], matrix13 = matrix[0, 2], matrix14 = matrix[0, 3];
                    int matrix21 = matrix[1, 0], matrix22 = matrix[1, 1], matrix23 = matrix[1, 2], matrix24 = matrix[1, 3];
                    int matrix31 = matrix[2, 0], matrix32 = matrix[2, 1], matrix33 = matrix[2, 2], matrix34 = matrix[2, 3];
                    int matrix41 = matrix[3, 0], matrix42 = matrix[3, 1], matrix43 = matrix[3, 2], matrix44 = matrix[3, 3];
                    int determinant;

                    //Resolve each section of the matrix
                    int resolveMatrix11 = matrix11 * (matrix22 * ((matrix44 * matrix33) - (matrix43 * matrix34)) - (matrix23 * ((matrix44 * matrix32) - (matrix34 * matrix42))) + (matrix24 * ((matrix43 * matrix32) - (matrix42 * matrix33))));
                    int resolveMatrix12 = matrix12 * (matrix21 * ((matrix44 * matrix33) - (matrix43 * matrix34)) - (matrix23 * ((matrix44 * matrix31) - (matrix41 * matrix34))) + (matrix24 * ((matrix43 * matrix31) - (matrix41 * matrix33))));
                    int resolveMatrix13 = matrix13 * (matrix21 * ((matrix44 * matrix32) - (matrix42 * matrix34)) - (matrix22 * ((matrix44 * matrix31) - (matrix41 * matrix34))) + (matrix24 * ((matrix42 * matrix31) - (matrix41 * matrix32))));
                    int resolveMatrix14 = matrix14 * (matrix21 * ((matrix43 * matrix32) - (matrix42 * matrix33)) - (matrix22 * ((matrix43 * matrix31) - (matrix41 * matrix33))) + (matrix23 * ((matrix42 * matrix31) - (matrix41 * matrix32))));

                    //Calculate the determinant
                    determinant = resolveMatrix11 - resolveMatrix12 + resolveMatrix13 - resolveMatrix14;
                    Console.WriteLine("The Determinant is: " + determinant);
                }
            }

            //Call the get4by4MatrixDeterminant function with the matrix to whose determinant is to be gotten
            get4by4MatrixDeterminant(matrix);
        }
    }
    
}
