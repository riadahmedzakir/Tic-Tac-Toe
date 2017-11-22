using System;

namespace TicTacToe
{
    class TheGame
    {
        static void Main(string[] arg)
        {
            TheGame n = new TheGame();
            int[,] a = new int[3, 3] { { 10, 10, 10}, { 10, 10, 10 }, { 10, 10, 10 } };
            n.display(3, 3, a);

            //--------Player Selection-----------//
            Console.WriteLine(" X or O ");



                object b = (Console.ReadKey().Key);
                Char c = Convert.ToChar(b);

                if ((char)c == 'X' || (char)c == 'x')
                {
                for (int i = 0; i < 9; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("\nPlayer X, Please choose desired location for input (1-9): ");
                        object d = (Console.ReadLine());
                        int e = Convert.ToInt32(d);
                        Console.WriteLine("");
                        n.input(1, e, a);
                        Console.Clear();
                        n.display(3, 3, a);
                        if( n.checkWinnerX(a) == true ) { break; }
                    }
                    else
                    {
                        Console.Write("\nPlayer O, Please choose desired location for input (1-9): ");
                        object d = (Console.ReadLine());
                        int e = Convert.ToInt32(d);
                        Console.WriteLine("");
                        n.input(2, e, a);
                        Console.Clear();
                        n.display(3, 3, a);
                        if( n.checkWinnerO(a) == true ) { break; }
                    }
                }
                }


                else if ((char)c == 'O' || (char)c == 'o')
                {
                for (int i = 0; i < 9; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("\nPlayer O, Please choose desired location for input (1-9): ");
                        object d = (Console.ReadLine());
                        int e = Convert.ToInt32(d);
                        Console.WriteLine("");
                        n.input(2, e, a);
                        n.display(3, 3, a);
                        if (n.checkWinnerO(a) == true) { break; }
                    }
                    else
                    {
                        Console.Write("\nPlayer X, Please choose desired location for input (1-9): ");
                        object d = (Console.ReadLine());
                        int e = Convert.ToInt32(d);
                        Console.WriteLine("");
                        n.input(1, e, a);
                        n.display(3, 3, a);
                        if (n.checkWinnerX(a) == true) { break; }

                    }
                }
            }

                else
                {
                    Console.WriteLine("Wrong input, Enter Again");
                }
            
            Console.Read();
        }



            //-------------------------------------//
            //----------Functions-----------------//
            //-----------------------------------//
            public void display(int i, int j, int[,] arr)
            {
                int k = 1;

                for (i=0; i<3; i++)
                {
                    for( j=0; j<3; j++)
                    {
                    if (arr[i, j] == 10)
                    {
                        Console.Write("{0}  ", k++);
                    }
                    else
                    {
                        if (arr[i, j] == 1)
                        {
                            Console.Write("X  ");
                            k++;
                        }
                        else if(arr[i,j] == 2)
                        {
                            Console.Write("O  ");
                            k++;
                        }
                    }
                    }
                        Console.WriteLine("");
                }
            }


            public void input(int a, int b, int[,] arr)
            {
                if (b == 1 && arr[0, 0] == 10) { arr[0, 0] = a; }
                else if (b == 2 && arr[0, 1] == 10) { arr[0, 1] = a; }
                else if (b == 3 && arr[0, 2] == 10) { arr[0, 2] = a; }
                else if (b == 4 && arr[1, 0] == 10) { arr[1, 0] = a; }
                else if (b == 5 && arr[1, 1] == 10) { arr[1, 1] = a; }
                else if (b == 6 && arr[1, 2] == 10) { arr[1, 2] = a; }
                else if (b == 7 && arr[2, 0] == 10) { arr[2, 0] = a; }
                else if (b == 8 && arr[2, 1] == 10) { arr[2, 1] = a; }
                else if (b == 9 && arr[2, 2] == 10) { arr[2, 2] = a; }
                else { Console.WriteLine("Invalid Input/Already Used"); }

            }

            public Boolean checkWinnerX(int[,] arr)
            {
                if( (arr[0, 0] + arr[0, 1] + arr[0, 2]) == 3 ||
                    (arr[1, 0] + arr[1, 1] + arr[1, 2]) == 3 ||
                    (arr[2, 0] + arr[2, 1] + arr[2, 2]) == 3 ||
                    (arr[0, 0] + arr[1, 0] + arr[2, 0]) == 3 ||
                    (arr[0, 1] + arr[1, 1] + arr[2, 1]) == 3 ||
                    (arr[0, 2] + arr[1, 2] + arr[2, 2]) == 3 ||
                    (arr[0, 0] + arr[1, 1] + arr[2, 2]) == 3 ||
                    (arr[0, 2] + arr[1, 1] + arr[2, 0]) == 3 )
                {
                    Console.WriteLine("Player X WINS!");
                    return true;
                }


                else
                {
                    return false;
                }
             }
            
            public Boolean checkWinnerO(int[,] arr)
            {
                if ( (arr[0, 0] + arr[0, 1] + arr[0, 2]) == 6 ||
                     (arr[1, 0] + arr[1, 1] + arr[1, 2]) == 6 ||
                     (arr[2, 0] + arr[2, 1] + arr[2, 2]) == 6 ||
                     (arr[0, 0] + arr[1, 0] + arr[2, 0]) == 6 ||
                     (arr[0, 1] + arr[1, 1] + arr[2, 1]) == 6 ||
                     (arr[0, 2] + arr[1, 2] + arr[2, 2]) == 6 ||
                     (arr[0, 0] + arr[1, 1] + arr[2, 2]) == 6 ||
                     (arr[0, 2] + arr[1, 1] + arr[2, 0]) == 6 )
                {
                    Console.WriteLine("Player O WINS!");
                    return true;
                }
                else
                {
                    return false;
                }

            }

    }
}