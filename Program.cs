internal class Program
{
    static void Main(string[] args)
    {
        string selec;
        Console.WriteLine("OPCIONES");
        Console.WriteLine("SELECCIONE LA OPCION CORRESPONDIENTE AL TRABAJO QUE DESEA REALIZAR");
        Console.WriteLine("1: NOMBRES Y EDADES");
        Console.WriteLine("2: NOMBRES Y NOTAS DE CLASE ");
        Console.WriteLine("3: SALIR DEL PROGRAMA");
        selec = Console.ReadLine();
        switch (selec)
        {
            case "1":
                string[] nombre = new string[5];
                int[] edad = new int[5];
                string[] personamayor = new string[5];
               

                for (int i=0; i<5; i++)
                {
                    Console.WriteLine("Ingrese un nombre:");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad de esa persona");
                    edad[i] = int.Parse(Console.ReadLine());
                }



                double mayor = 0;
                int verdadero = 0;
                string grande = "";
                for (int i = 0; i < 5; i++)
                {
                    if (mayor < edad[i])
                    {
                        mayor = edad[i];
                        verdadero = i + 1;
                        grande = nombre[i];

                    }
                }
                
                Console.WriteLine("La persona de mayor edad es: " + grande);

                double prom = 0;
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum + edad[i];
                }

                prom = sum / 5;
                Console.WriteLine("El promedio de las edades que usted ha igresado es: " + prom);

                break;

                case "2":
                    string[] nameapellido = new string[5];
                    int[] notas = new int[5];
                    
                    for ( int i = 0; i < 5; i++)
                    {
                    Console.WriteLine("Ingrese un nombre y apellido:");
                    nameapellido[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota de programación:");
                    notas[i] = int.Parse(Console.ReadLine());
                    }


                for (int i = 0; i < 5; i++)
                {
                    if (notas[i] > 70)
                    {
                        Console.WriteLine("Ganó la clase " + nameapellido[i]);
                    }
                    else
                    {
                        Console.WriteLine("Perdió la clase " + nameapellido[i]);
                    }
                }

                double mayornota = 0;
                int real = 0;
                string alto = "";
                for (int i = 0; i < 5; i++)
                {
                    if (mayornota < notas[i])
                    {
                        mayornota = notas[i];
                        real = i + 1;
                        alto = nameapellido[i];

                    }
                }

                Console.WriteLine("La persona de mayor nota es: " + alto);

                double menornota = 0;
                int sireal = 0;
                string bajo = "";
                for (int i = 0; i < 5; i++)
                {
                    if (notas[i] < menornota)
                    {
                        mayor = notas[i];
                        sireal = i + 1;
                        bajo = nameapellido[i];

                    }
                }

                Console.WriteLine("La persona de menor nota es: " + bajo);

                double promedio = 0;
                    double suma= 0;
                    for (int i = 0; i < 5; i++)
                    {
                        suma = suma + notas[i];
                    }

                    promedio = suma / 5;
                    Console.WriteLine("El promedio de edades es " + promedio);
                    break;

            case "3":
                Console.WriteLine("SE HA CERRADO EL PROGRAMA");
                break;
        }
    }
}