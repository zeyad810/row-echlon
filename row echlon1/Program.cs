namespace row_echlon1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A; // المصفوفه 
            double[] b; // ناتج المصفوفه
            int s; // عدد المصفوفه

            Console.WriteLine("Enter Side : ");
            s = Int32.Parse(Console.ReadLine()); // نستقبل قيمه من المستخدم لحجم المصفوفه
            A = new double[s,s]; // هناخد اوبجيكت من الاى نستقبل فيها عناصر المصفوفه  
            b = new double[s];
            for (int row = 0; row < s; row++) // لووب لل صفوف 
            {
                for (int col = 0; col < s;col++) // لووب لل اعمده
                {
                    Console.Write($"A[{row},{col}]: "); // نطبع الصفوف و الاعمده 
                    A[row,col] = double.Parse(Console.ReadLine()); // نستقبل قيم الصفوف و الاعمده
                }
                Console.Write($"b[{row}]: ");
                b[row] = double.Parse(Console.ReadLine()); // نستقبل قيمه ناتج المصفوفه 
                Console.WriteLine();
            }
            Display(A,b); // نستدعى الداله لعرض المصفوفه كامله

            Console.WriteLine("___________________________");

            // solve with preformed opretions

            for (int p = 0; p < s; p++)
            {
                for (int row = p+1; row < s; row++)
                {
                    double m = A[row,p] / A[p,p];
                    for (int col = 0; col < s; col++)
                    {
                        A[row,col] = A[row,col] -(m* A[p,col]); // row operation
                    }
                    b[row] = b[row] - (m * b[p]);
                     
                }
            }

            Display(A, b);
            Console.WriteLine("___________________________");
        }
        static void Display(double[,] Matrix ,double[] b)
        {
            int s;
            s = Convert.ToInt32(Math.Sqrt(Matrix.Length)); // تاخد الجزر التربعى لنتاج ضرب الصفوف و الاعمده لحساب حجم ةالمصفوفه  

            for (int row = 0; row < s; row++) // لووب لل صفوف 
            {
                for (int col = 0; col < s; col++) // لووب لل اعمده
                {
                    Console.Write($"{Matrix [row,col]} \t "); //نطبع صوفوف و اعمده المصفوفه  
                    
                }
                Console.Write($"| {b[row]}");
                Console.WriteLine();
            }

         

           

        }
    }
}