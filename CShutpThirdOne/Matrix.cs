using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShutpThirdOne
{


    class Matrix
    {
        Random rnd = new Random();

        private int[,] Amassive = { { 5, 1, 7 }, { 10, -2, 1 }, { 0, 1, 2 } };
        private int[,] Bmassive = { { 2, 4, 1 }, { 2, 1, 0 }, { 7, 2, 1 } };

        private int[,] resultPro = new int[3, 3];
        private int[,] Cmassive = new int[3, 3];

        private int numberPro;
        private int resOp, resOpB;

        public void setNumberPro()
        {
            numberPro = rnd.Next(5, 20);
        }
        public int getNumberPro()
        {
            return numberPro;
        }
       public void setResPro()
       {
            resOp = Amassive[0, 0] * (Amassive[2, 2] - Amassive[1, 2]);
       }
       public int getResPro()
       {
           return resOp;
       }

        public void setResProB()
        {
            resOpB = Bmassive[0, 0] * (Bmassive[2, 2] - Bmassive[1, 2]);
        }
        public int getResProB()
        {
            return resOpB;
        }

      public void messageProA()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    setNumberPro();
                    resultPro[i, j] = getNumberPro() * Amassive[i, j];
                    Console.WriteLine(resultPro[i, j]);
                }
                Console.WriteLine();
            }
        }

      public void messageProB()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    setNumberPro();
                    resultPro[i, j] = getNumberPro() * Bmassive[i, j];
                    Console.WriteLine(resultPro[i, j]);
                }
                Console.WriteLine();
            }
        }

      public void messageSum()
        {
         for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) {
                    resultPro[i, j] = Bmassive[i, j] + Amassive[i, j];
                    Console.WriteLine(resultPro[i, j]);
            }
          }
        }

      public void messageMin()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultPro[i, j] = Bmassive[i, j] - Amassive[i, j];
                    Console.WriteLine(resultPro[i, j]);
                }
                Console.WriteLine();
            }
        }

      public void messageOp()
      {
            setResPro();
            Console.WriteLine( "Op = " + resOp);
      }
        public void mesageOpB()
        {
            setResProB();
            Console.WriteLine("Op B = " + resOpB);
        }
      public void messageFinalResult()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Cmassive[i, j] = 2 * (Amassive[i, j] + Bmassive[i, j]) * (Amassive[i, j] * Amassive[i, j] + Bmassive[i,j]);
                    if(Cmassive[i,j] < 0)
                    {
                        Cmassive[i, j] = Cmassive[i, j] * (-1);
                    }
                    Console.WriteLine(Cmassive[i, j]);
                }
                Console.WriteLine();
            }
        }
    } 
 }


