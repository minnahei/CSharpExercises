using System;
namespace cSharpExercises.Bucles
{
    public class Bucles
    {
        /////////////////////////////// EJERCICIO 1 ///////////////////////////////////////////////
        //Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.

    for (int i = 10; i <= 20; i++)
    {
        Console.WriteLine(i + "\n");
        //Console.WriteLine();
    }


    /////////////////////////////// EJERCICIO 2 ///////////////////////////////////////////////
    // Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.

    //VERSION 1
    int numero = 20;

            while (numero >= 10)
            {
            Console.WriteLine(numero);
            Console.WriteLine();
            numero--;
        }
            //VERSION 2
            for(int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i + "\n");

            }




/////////////////////////////// EJERCICIO 3 ///////////////////////////////////////////////
///Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.

double total = 0;
for (int i = 0; i< 10; i++)
{
    Console.WriteLine("Enter a number");
    double userinput = Int32.Parse(Console.ReadLine());
total = total + userinput;
}
total = total / 10;
Console.WriteLine("La media de la suma es " + total);



/////////////////////////////// EJERCICIO 4 ///////////////////////////////////////////////
///Escribe un programa que pida valores hasta que el usuario introduzca un 0. Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos. Mostrar la suma de los valores introducidos. 

 int total = 0;
 int numero;
            do
            {
                Console.WriteLine("introduce un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero< 0)
                {
                    Console.WriteLine("Se ignoran los valores negativos");
                }
                else
                {
                    total += numero;
                }
            }
            while (numero != 0);

            Console.WriteLine(total);


/////////////////////////////// EJERCICIO 5 ///////////////////////////////////////////////
///Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I . Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.

            string answer;
            do
            {
                Console.WriteLine("Pulse la tecla ``P´´ para explorar los valores pares del 1 al 100, e ``I´´ para los impares");
                answer = Console.ReadLine().ToUpper();

            } while (answer != "P" && answer != "I");

            if (answer == "P")
            {
                for (int i = 0; i <= 100; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            if (answer == "I")
            {
                for (int i = 1; i <= 100; i += 2)
                {
                    Console.WriteLine(i);
                }
            }




/////////////////////////////// EJERCICIO 6 ///////////////////////////////////////////////
///Escribe un programa que pregunte al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.

Console.WriteLine("Introduce tu edad");
int edad = Int32.Parse(Console.ReadLine());

for (int i = 0; i <= edad; i++)
{
    Console.WriteLine("Feliz cumpleaños!");
}



/////////////////////////////// EJERCICIO 7 ///////////////////////////////////////////////
///Pedir al usuario un número. Mostrar en pantalla el dibujo de abajo con tantas líneas como las que haya introducido:
//  *
//  ** 
//  ***

 Console.WriteLine("Introduce la cantidad de líneas:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= cantidad; i++)
            {
                for (int j = 0; j<i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            string asterisco = "*";

            for (int i = 0; i<cantidad; i++)
            {
                Console.WriteLine(asterisco);
                asterisco = asterisco + "*";
            }

            for (string asterisco = "*"; asterisco.Length <= cantidad; asterisco += "*")
            {
                Console.WriteLine(asterisco);
            }

/////////////////////////////// EJERCICIO 8 ///////////////////////////////////////////////
///Escribe un programa que muestre los números de 1 a 12 en una columna. En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.

for (int i = 0; i <= 12; i++) //12 loops
{
    if (i % 2 == 0)
    {
        Console.Write(i+" ");
        Console.Write(Math.Pow(i, 2));//el cuadrado
    }
    else if (i % 2 == 1)
    {
        Console.Write(i+ " ");
        Console.Write(Math.Pow(i, 3));//el cubo
    }
    Console.WriteLine();
}



/////////////////////////////// EJERCICIO 9 ///////////////////////////////////////////////
///Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior.

for (int i = 0; i <= 10; i++)
{
    for (int j = 1; j <= 1; j++)
    {
        Console.Write(i);
        Console.Write("+");
        Console.Write(j);
        Console.Write("= " + (i + j));
    }
    Console.WriteLine();
}

//ejercicio 9B

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + (i - 1));
}
1 the sum of the previous number
(2+1) 3
(3+2) 5
(4+3) 7
(5+4) 9
(6+5) 11
(7+6) 13
(8+7) 15
(9+8) 17
(10+9)19 

/////////////////////////////// EJERCICIO 10 ///////////////////////////////////////////////
///Crear un programa que muestre el valor de sumar todos los números desde 1 hasta el número que introduzca el usuario. Por ejemplo si introduce el 8 debería mostrar 36 (1 + 2+ 3+ 4+ 5+ 6+ 7+ 8)

int i, sum = 0;

Console.Write("Enter a positive integer: ");
int userinput = Int32.Parse(Console.ReadLine());

for (i = 1; i <= userinput; i++)
{
    sum = sum + i;
    Console.Write("{0} ",i);
}
Console.Write("The sum is: {0}", sum);

10 B - find the sum of first natural numbers(1+2+3+4+5+6+7+8 = 36)

int usernumber, sum = 0; //dotn understand why we have to put to 0

Console.Write("Enter a positive integer: ");
usernumber = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= usernumber; i++)
{
    sum += i; // sum = sum + 1
}
Console.WriteLine("Sum = " + sum);
Console.ReadKey();




/////////////////////////////// EJERCICIO 11 ///////////////////////////////////////////////
///. Escribe un programa que muestre el resultado de sumar todos los números del 1 hasta el número introducido y que vuelva a pedirle al usuario otro número hasta que el usuario introduzca un 0

double usernumber, sum = 0;

do
{
    Console.WriteLine("Enter a positive integer");
    usernumber = double.Parse(Console.ReadLine());
    if (usernumber >= 0)
    {
        for (int i = 1; i <= usernumber; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum = " + sum);
    }
    else
    {
        Console.WriteLine("Invalid number");
    }


}while (usernumber <= 0) ;


/////////////////////////////// EJERCICIO 12 ///////////////////////////////////////////////
///Escribe un programa el cual analizará si la contraseña introducida es correcta o no. Para que la contraseña sea correcta deberá cumplir estas directivas:
//     Debe tener 8 caracteres como mínimo.
//     La contraseña deberá contener números. (buscar una función)
//     La primera letra tiene que ser en mayúsculas.(buscar una función)
            //bool correcto = false;
            //bool numeroEncontrado = false;

            do
            {

                Console.WriteLine("Introduce una contraseña:");
                string pass = Console.ReadLine();

                if (pass.Length< 8)
                {
                    Console.WriteLine("La contraseña tiene que contener al menos 8 caracteres ");
                }
                else
                {
                    for(int i = 1; i<pass.Length; i++)
                    {
                        if (char.IsDigit(Convert.ToChar(pass.Substring(i, 1))))
                        {
                            numeroEncontrado = true;
                        }
                    }

                    if (numeroEncontrado)
                    {

                        if (char.IsUpper(Convert.ToChar(pass.Substring(0, 1))))
                        {
                            correcto = true;

                        }
                        else
                        {
                            Console.WriteLine("La primera letra de la contraseña debe estar en mayúsculas");
                        }

                    }
                    else
                    {
                        Console.WriteLine("La contraseña necesita un número");
                    }


                }
            } while (!correcto);

            Console.WriteLine("Contraseña correcta");


            /////////////////////////////// EJERCICIO 13 ///////////////////////////////////////////////
            /// Escribe un programa que muestre el número entero positivo que el usuario introduzca pero al revés (si introduce 1478 que muestre 8741), hasta que el usuario introduzca 0. Si introduce 0 la primera vez, debería mostrarlo al revés (es decir, mostrar 0) y acabar el programa.

            Console.WriteLine("Enter a nr");
            int number = Int32.Parse(Console.ReadLine());
            int reverse = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse* 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse nr is "+ reverse);


        

      }
}
