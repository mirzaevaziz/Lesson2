{
    decimal a, b;
    System.Console.Write("a = ");
    a = Convert.ToDecimal(Console.ReadLine());
    System.Console.Write("b = ");
    b = Convert.ToDecimal(Console.ReadLine());

    System.Console.WriteLine("a + b = {0}", a + b);
    System.Console.WriteLine("a - b = {0}", a - b);
    System.Console.WriteLine("a * b = {0}", a * b);
    System.Console.WriteLine($@"a * b = {a * b}");
}
