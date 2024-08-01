
FileStream file = null;
try
{
    file = File.Open("archivo.txt", FileMode.Open);
    double n1, n2, division;

    Console.WriteLine("Ingrese primer número:");
    n1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo número:");
    n2 = double.Parse(Console.ReadLine());

    division = n1 / n2;

    Console.WriteLine($"La división es: {division}");
} catch(FormatException e)
{
    Console.WriteLine(e.ToString());
} catch(Exception e)
{
    Console.WriteLine(e.ToString()); 
}
finally
{
    file?.Close();
    Console.WriteLine("Archivo cerrado...");
}
