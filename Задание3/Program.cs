int a;
int b;
int c;

while (true)
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    if (a<100000 && b < 100000 && c < 100000)
    {
        if ((a +b > c) && (b + c > a) && (a + c > b) )
        {
            Console.WriteLine("Треугольник существует");
        }

        else { Console.WriteLine("Треугольник не существует");
        }
            
    }

}
