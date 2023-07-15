double Altura, Base, Area, Arista, Volumen;
int Contador;
bool Seguir;
Seguir = true;
Contador = 0;
Area = 0;
Arista = 0;
Volumen = 0;

do
{
    Console.WriteLine($"Ingrese la altura de la {Contador + 1}° piramide, ingrese 0 para terminar");
	var str = Console.ReadLine();
	if (double.TryParse(str, out Altura))
	{
		if (Altura>=0)
		{
			Console.WriteLine($"Ingrese la base de la {Contador + 1}° piramide, ingrese 0 para terminar");
			var str2 = Console.ReadLine();
			if (double.TryParse(str2, out Base))
			{
				if (Base>=0)
				{
					if (Altura>0 || Base>0)
					{
						Area = CalcularArea(Base, Altura);
						Volumen = CalcularVolumen(Base, Altura);
						Arista = CalcularArista(Base, Altura);
						Console.WriteLine($"El area es: {Area}");
						Console.WriteLine($"El volumen es: {Volumen}");
						Console.WriteLine($"La arista es: {Arista}");
						Contador++;
					}
					else
					{
						Console.WriteLine("Se termina la conversion");
						break;
					}
				}
				else
				{
					Console.WriteLine("La base debe ser mayor a 0");
				}
			}
			else
			{
				Console.WriteLine("Dato no valido, intente nuevamente");
			}
		}
		else
		{
			Console.WriteLine("La altura debe ser mayor a 0");
		}
	}
	else
	{
		Console.WriteLine("Dato no valido, intente de nuevo");
	}

} while (true);
Console.WriteLine($"Se ingresaron{Contador} piramides");

double CalcularArista(double @base, double altura)
{
    return Math.Round(Math.Sqrt(Math.Pow(Altura,2) + (Math.Pow(Base,2) / 2)));
}

double CalcularVolumen(double @base, double altura)
{
    return Math.Round((Math.Pow(Base,2) * Altura) / 3);
}

double CalcularArea(double @base, double altura)
{
	return Math.Round(Base * (Base + Math.Sqrt(4 * Math.Pow(Altura,2) + Math.Pow(Altura, 2))));
}