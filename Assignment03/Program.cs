namespace Assignment03
{

    class program   
    { 
        static void Main(string[]args)
        {

            #region Q1
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($" Identity matrix of size {n} x {n}: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write(" 1 ");
                    else
                        Console.Write(" 0 ");
                }
                Console.WriteLine();
            }


            #endregion

            #region Q2

            #endregion
        }

    }
}


           