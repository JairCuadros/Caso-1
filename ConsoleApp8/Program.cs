Console.WriteLine("Por favor ingrese número de personas");
int numeroP = int.Parse(Console.ReadLine());
float TOT = 0f;
if (numeroP > 300)
{
    TOT = numeroP * 75;
}
else
{
    if (numeroP > 200)
    {
        TOT = numeroP * 85;
    }
    else
    {
        TOT = numeroP * 95;
    }
}
Console.WriteLine("El total vendría a ser : " + TOT);