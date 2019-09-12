using System;
namespace cSharpExercises.Arrays
{
    public class Arrays
    {
        public Arrays()
        {
			////////////////////////////////// EJERCICIO 1 A ///////////////////////////////////////////////
			/// Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

			Int32[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			for (int i = 0; i < positions.Length; i++)
			{
				Console.WriteLine(positions[i]);
			}


			////////////////////////////////// EJERCICIO 1 B ///////////////////////////////////////////////

			int[] pos = new int[11];

			for (int = 0; i < pos.Length; i++)
			{
				pos[i] = i;
				Console.WriteLine(pos[i]);
			}

			////////////////////////////////// EJERCICIO 2 ///////////////////////////////////////////////
			/// Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. Guardar cada uno de esos strings en la posición 0 , 1 y 2. Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posición 0.

			Console.WriteLine("Write 3 things");
			string[] words = new string[3];
			Console.ReadLine();

			Console.WriteLine(words[1],[2],[0]);

			string[] words = new string[3];

			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine("Enter 3 words");
				words[i] = Console.ReadLine();
			}
			Console.WriteLine(words[1] + ", " + words[2] + ", " + words[0]);


			////////////////////////////////// EJERCICIO 3 ///////////////////////////////////////////////
			///Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones (en orden descendente). Usar un for para mostrar los 10 valores en pantalla.
			///

			int[] numeros = new int[10];
			int j = 20;

			for (int i = 0; i < numeros.Length; i++)
			{
				numeros[i] = j;
				j--;
			}

			for (int i = 0; i < numeros.Length; i++)
			{
				Console.WriteLine(numeros[i]);
			}


			////////////////////////////////// EJERCICIO 4 ///////////////////////////////////////////////
			/// Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. Usar otro for para mostrarlos en pantalla.

			creado el array con 3 huecos
			int[] numeros = new int[2];

			// por cada valor en el array le pedimos un numero al usuario y guardarlo
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("Introduce un número:");
				numeros[i] = Convert.ToInt32(Console.ReadLine());
			}


			// por cada valor en el array mostralo en pantalla
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(numeros[i]);
			}


			////////////////////////////////// EJERCICIO 5 ///////////////////////////////////////////////
			/// Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.

			int[] numbers = new int[3]; //new int because we dont know what the user is going to put


			for (int i = 0; i < 3; i++) //better put numbers.Length, if someone changes this
			{
				Console.WriteLine("enter a number: ");
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}

			int smallestNumber = numbers[0];
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] < smallestNumber)
				{
					smallestNumber = numbers[i];
				}
			}
			Console.WriteLine("The smallest number is " + smallestNumber);

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			////////////////////////////////// EJERCICIO 6 ///////////////////////////////////////////////
			///Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.
			///
			//no need for loop, we dont have to ask which number all the time!!

			string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


			Console.WriteLine("Enter a number between 1 - 12");
			int answer = Convert.ToInt32(Console.ReadLine()); //we use convert to convert from string to int

			Console.WriteLine(months[answer - 1]);

			if (months >= 1 && months <= 12)
			{
				Console.WriteLine(months[answer - 1]);
			}
			else
			{
				Console.WriteLine("Number is not correct");
			}


			////////////////////////////////// EJERCICIO 7 ///////////////////////////////////////////////
			/// Hacer la media de 10 valores utilizando un array.

			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			double sum = 0; //double because we are dividing

			for (int i = 0; i < numbers.Length; i++) //10   , i you can only use inside the for unless you declare it outside
			{
				sum += numbers[i]; //is the same like: suma = suma + numbers[i]
			}

			Console.WriteLine("The sum is: " + sum / numbers.Length);




			////////////////////////////////// EJERCICIO 8 ///////////////////////////////////////////////
			// Crear un array de 11 ints.Pedir al usuario que introduzca valores entre 0 y 10.Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array.
			// Si por ejemplo introduce un 3, sumar uno a la posición 3.Mostrar en pantalla los valores. Si introduce un número mayor que 10, decir que ese número es incorrecto.
			// Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene.Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
			// 0
			// 1   0
			// 2   0
			// 3   0
			// 4   0
			// 5   2
			// 6   1
			// 7   3
			// 8   0
			// 9   2
			// 10  1

			int[] number = new int[11];
			int i = 0;

			do
			{
				Console.WriteLine("Introduce valores entre el 0 y 10, presione -1 para salir");
				i = Convert.ToInt32(Console.ReadLine());
				if (i >= 0 && i < number.Length)
				{
					number[i]++;

				}
				else
				{
					Console.WriteLine("El valor no es válido");
				}

			} while (i >= 0);

			for (int j = 0; j < number.Length; j++)
			{
				Console.WriteLine(j + "\t" + number[j]);
			}


			////////////////////////////////// EJERCICIO 9 ///////////////////////////////////////////////
			/// Crear un array de 10 valores. Poner el valor 1 en cada una de la posición.
			/// Pedir al usuario que introduzca un número entre 0 y 9. Cada vez que introduzca un valor entre 0 y 9, mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.


			int[] valores = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
			int numeroDelUsuario;

			do
			{
				Console.WriteLine("introduce un numero del 0 al 9");
				numeroDelUsuario = Convert.ToInt32(Console.ReadLine());

				if (numeroDelUsuario >= 0 && numeroDelUsuario <= 9)
				{
					valores[numeroDelUsuario] *= 2;
					Console.WriteLine(valores[numeroDelUsuario]);
				}
				else if (numeroDelUsuario > 9)
				{
					Console.WriteLine("número incorrecto!!!");
				}

			} while (numeroDelUsuario >= 0);

			for (int i = 0; i < valores.Length; i++)
			{
				Console.Write(i);
				Console.Write("   ");
				Console.WriteLine(valores[i]);
			}



			////////////////////////////////// EJERCICIO 10 ///////////////////////////////////////////////
			/// Programa que lee las edades de 20 alumnos (validado entre 18 y 35), las almacena en un array y calcula y escribe su media (para probar, se pueden generar aleatoriamente entre 18 y 35). 

			////////////////////// VERSION A
			///
			const int NUMALUMNOS = 20;
			int[] alumnos = new int[NUMALUMNOS];
			int identificador = 1;
			int edadTotal = 0;

			for (int i = 0; i < NUMALUMNOS; i++)
			{
				int edad = 0;
				do
				{
					Console.WriteLine("Introduce tu edad, alumno " + identificador);
					edad = Convert.ToInt32(Console.ReadLine());

					if (edad < 18 || edad > 35)
					{
						Console.WriteLine("Edad incorrecta");
					}

				} while (edad < 18 || edad > 35);


				alumnos[i] = edad;


				identificador++;
			}
			for (int i = 0; i < NUMALUMNOS; i++)
			{
				edadTotal += alumnos[i];
			}
			Console.WriteLine("La media de edad de la clase es igual a " + edadTotal / NUMALUMNOS);

			////////////// VERSION B
			///
			const int NUMALUMNOS = 20;
			int[] alumnos = new int[NUMALUMNOS];
			double edadTotal = 0;
			//Instanciar la clase Random 
			Random random = new Random();
			//
			for (int i = 0; i < NUMALUMNOS; i++)
			{
				int num = random.Next(18, 36);
				alumnos[i] = num;
			}

			for (int i = 0; i < NUMALUMNOS; i++)
			{
				edadTotal += alumnos[i];
			}
			Console.WriteLine("La media de edad de la clase es igual a " + edadTotal / NUMALUMNOS);



		}
    }
}
