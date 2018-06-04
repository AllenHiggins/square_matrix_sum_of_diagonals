using System;

/*
    Program:
    Get the Abs difference of an nxn square matrix sum of diagonals
 */
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // example matrix and values
            int[,] myArray = new int[5,5];
            
            myArray[0,0] = 9;
            myArray[0,1] = 1;
            myArray[0,2] = 1;
            myArray[0,3] = 1;
            myArray[0,4] = 10;

            myArray[1,0] = 1;
            myArray[1,1] = 10;
            myArray[1,2] = 1;
            myArray[1,3] = 12;
            myArray[1,4] = 1;

            myArray[2,0] = 1;
            myArray[2,1] = 1;
            myArray[2,2] = 6;
            myArray[2,3] = 1;
            myArray[2,4] = 1;
           
            myArray[3,0] = 1;
            myArray[3,1] = 99;
            myArray[3,2] = 1;
            myArray[3,3] = 9;
            myArray[3,4] = 1;

            myArray[4,0] = 4;
            myArray[4,1] = 1;
            myArray[4,2] = 1;
            myArray[4,3] = 1;
            myArray[4,4] = 90;
 
            int result = getAbsMatrixSumOfDiagonals(myArray);
            Console.WriteLine(result);
            
        } 

        /*
            Returns the Abs of the matrix.
                --> Get the length of the matrix
                --> Get the left diagonal
                --> Get the right diagonal
                --> return the abs by subtracting right from left
         */
        public static int getAbsMatrixSumOfDiagonals(int [,] myArray){
            int martixSize = myArray.GetLength(0);
            int leftToRightTotal = stepLeftThroghMatrix(myArray,martixSize);
            int rightToLeftTotal = stepRightThroghMatrix(myArray,martixSize);
            return Math.Abs(leftToRightTotal - rightToLeftTotal);
        }

        /* 
            Returns the total right to left diagonal sum.
                --> Increment 0 and decrement n from start of matrix at [0,n] to end [n,0]
                --> while calculating the running total 
                --> in this case [n,0] = the length of the matrix - 1 = [4,0]
        */
        public static int stepRightThroghMatrix(int[,] a, int martixSize){
            int rightDownStep = martixSize-1, rightDownStepCross = 0, rightTotal = 0;

            while(rightDownStepCross < martixSize){
                rightTotal += a[rightDownStepCross,rightDownStep];
                rightDownStepCross++;
                rightDownStep--;    
            }  

            return rightTotal;
        }

        /* 
            Returns the total left to right diagonal sum.
                --> Increment from start of matrix at [0,0] to end [n,n]
                --> while calculating the running total 
        */
        public static int stepLeftThroghMatrix(int[,] a, int martixSize){
            int leftDownStep = 0;
            int leftTotal = 0;

            while(leftDownStep < martixSize){
                leftTotal += a[leftDownStep,leftDownStep];
                leftDownStep++;
            }  

            return leftTotal;     
        }

    }
}
