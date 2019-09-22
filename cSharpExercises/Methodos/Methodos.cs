using System;
namespace cSharpExercises.Methodos
{
    public class Methodos
    {
        ///////////////////// EJERCICIO 1 Y 2 ///////////////////////////////////////////

        // Escribe una función que escriba “Hola” 3 veces.Llámala desde el programa principal.
        //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro.
        // Llámala desde el programa principal dos veces, primero con 5 y después con 3.

        static void Main(string[] args)
        {
            //RepeatHola();
            //Console.WriteLine(" Introduce los  numeros 5 y 3 ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            EscribeHola(3);
            Console.WriteLine("");
            EscribeHola(5);

        }
        public static void RepeatHola()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hola");
            }
        }
        public static void EscribeHola(int veces)
        {

            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine("Hola");
            }
        }




        ///////////////////// EJERCICIO 3 ///////////////////////////////////////////
        ///
        //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
        // Asigna el valor de la llamada a la función en una variable en el programa principal y muestra el resultado en la pantalla.

        static void Main(string[] args)
        {
            int resultado = Suma(5, 9);
            Console.WriteLine(resultado);
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }





        ///////////////////// EJERCICIO 4 ///////////////////////////////////////////
        ///Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. En el programa principal, pide al usuario 2 números. Usa esos 2 números como parámetros de la función y después asigna el valor que devuelve la función a una tercera variable en el programa.
        ///Finalmente, muestra el valor de la variable en la pantalla.
        ///
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Suma(num1, num2);

            Console.WriteLine(resultado);

        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }





        ///////////////////// EJERCICIO 5 ///////////////////////////////////////////
        ///Escribe un programa que pida al usuario dos números. Usa esos 2 números en una función que divide el primero por el segundo y devuelve el resultado.
        ///Muestra el resultado que devuelve la función en pantalla.
        ///Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.

        static void Main(string[] args)
        {
            double num1;
            double num2;

            //////VERSIÓN 1

            //do
            //{
            //    Console.WriteLine("Introduce un número:");
            //    num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Introduce otro número:");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    if (num2 != 0)
            //    {
            //        double resultado = Division(num1, num2);
            //        Console.WriteLine(resultado);
            //    }

            //} while (num2 != 0);

            //////VERSIÓN 2

            Console.WriteLine("Introduce un número:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            while (num2 != 0)
            {
                double resultado = Division(num1, num2);
                Console.WriteLine(resultado);

                Console.WriteLine("Introduce un número:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }


        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }





        ///////////////////// EJERCICIO 6 ///////////////////////////////////////////
        ///Escribe una función a la que le damos dos números y que devuelva true si el primer número es más grande que el segundo número y false en el caso contrario.
        ///En el programa principal, pide dos números al usuario, y pasalos a la función.
        ///Muestra en pantalla “El primer número es más grande” o “El primer número no es más grande”.

        static void Main(string[] args)
        {
            //ejercicio 6
            Console.WriteLine("Introduzca 1 numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //bool resultado;
            //resultado = Bool(num1, num2);

            if (Bool(num1, num2))
            {
                Console.WriteLine("El primer numero es más grande");
            }
            else
            {
                Console.WriteLine("El segundo numero es más grande");
            }
        }
        public static bool Bool(int num1, int num2)
        {
            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }







        ///////////////////// EJERCICIO 7 ///////////////////////////////////////////
        ///Escribe una función a la que le pasamos un año y devuelve true si es bisiesto.
        ///En el programa principal, pídele al usuario un número y muestra en pantalla “El año … es bisiesto” o “El año … no es bisiesto”
        ///y sigue pidiendo números y diciendo si es o no bisiesto hasta que introduzca un 0.

        static void Main(string[] args)
        {
            int years;

            do
            {
                Console.WriteLine("Escribe un año");
                years = Convert.ToInt32(Console.ReadLine());

                //bool bisiesto = Year(years);

                if (Year(years))
                {
                    Console.WriteLine("El año es bisiesto");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto");
                }

            } while (years != 0);
        }
        public static bool Year(int num1)
        {
            //if (DateTime.IsLeapYear(num1))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return DateTime.IsLeapYear(num1);
        }








        ///////////////////// EJERCICIO 8 ///////////////////////////////////////////
        ///Diseña un método EsPar() que reciba como parámetro un entero y devuelva si ese número es par o no.
        ///Utilízalo en un programa que lea un número por teclado y determine si es par o no.


        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero cualquiera");
            int num = Convert.ToInt32(Console.ReadLine());

            //if (ParImpar(num))
            //{
            //    Console.WriteLine("El numero es par");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es impar");
            //}
            Console.WriteLine(ParImpar(num));
        }


        public static string ParImpar(int num)
        {
            if (num % 2 == 0)
            {
                return "Es par";
            }

            else
            {
                return "Es impar";
            }

        }







        ///////////////////// EJERCICIO 9 ///////////////////////////////////////////
        ///Escribe un programa que cuente las vocales de un string pasado por parámetro.

        static void Main(string[] args)
        {
            //Escribe un programa que cuente las vocales de un string pasado por parámetro.
            Console.WriteLine("Introduce tu frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Numero de vocales es: " + NumeroDeVocales(frase));
        }

        public static int NumeroDeVocales(string frase)
        {
            int numeroDeVocales = 0;
            //string[] vocales = { "a", "e", "i", "o", "u" };

            frase = frase.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                //Sacar caracter específico de un string opción 1
                //char letra = frase[i];

                //Sacar caracter específico de un string opción 2
                string letra = frase.Substring(i, 1);

                //Comparar chars
                //if(letra == 'a' ||letra == 'e' || letra =='i' || letra == 'o' || letra == 'u')

                //Comparar strings
                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                    numeroDeVocales++;
                }

                //Versión con las letras en un array

                //for (int j = 0; j < vocales.Length; j++)
                //{
                //    if (frase.Substring(i, 1).Contains(vocales[j]))
                //    {
                //        numeroDeVocales++;
                //    }
                //}
            }
            return numeroDeVocales;
        }






        ///////////////////// EJERCICIO 10 ///////////////////////////////////////////
        ///Escribe un programa que cuente las palabras en un string pasado por parámetro.
        ///
        static void Main(string[] args)
        {
            Console.WriteLine("Dime una palabra");
            string p1 = Console.ReadLine();
            Console.WriteLine("Tu palabra contiene " + Computo(p1));
        }
        public static int Computo(string pal1)
        {
            int palabras = 0;
            for (int i = 0; i < pal1.Length; i++)
            {
                string letra = pal1.Substring(i, 1);
                //char caracter = pal1[i];
                if (letra == " ")
                {
                    palabras++;
                }
            }
            palabras++;
            return palabras;
        }





        ///////////////////// EJERCICIO 11 ///////////////////////////////////////////
        ///Escribe un programa que dé la vuelta a un string pasado por parámetro y lo devuelva.
        ///

        static void Main(string[] args)
        {
            // Escribe un programa que dé la vuelta a un 
            // string pasado por parámetro y lo devuelva.
            Console.WriteLine("Escribe una palabra:");
            string frase = Console.ReadLine();
            string invertido = Program.Invertir(frase);
            Console.WriteLine(invertido);
            //Console.WriteLine(Invertir(Console.ReadLine()));
        }

        //public static string Invertir(string frase)
        //{
        //    string total = "";
        //    for (int i = frase.Length - 1; i >= 0; i--)
        //    {
        //        string letra = frase.Substring(i, 1);
        //        //char letra = frase[i];
        //        total = total + letra;
        //    }
        //    return total;
        //}

        public static string Invertir(string frase)
        {
            string total = "";
            for (int i = 0; i < frase.Length; i++)
            {
                string letra = frase.Substring(i, 1);
                //char letra = frase[i];
                total = letra + total;
            }
            return total;

        }





        ///////////////////// EJERCICIO 12 ///////////////////////////////////////////
        ///Escribe un método que reciba un array de ints y lo muestre en pantalla desde la primera posición hasta la última.
        ///Después escribe otra función que reciba un array de ints y lo muestre en pantalla desde la última posición a la primera.
        ///Crea un array en el programa principal y pásalo a cada una de las funciones.
        ///
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 5 };

            //MostrarArray(numeros);
            MostrarArrayInvertido(numeros);

        }


        public static void MostrarArray(int[] cadena)

        {
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }

        }

        public static void MostrarArrayInvertido(int[] cadena)

        {
            for (int i = cadena.Length; i > 0; i--)
            {
                Console.WriteLine(cadena[i - 1]);
            }


        }





        ///////////////////// EJERCICIO 13 ///////////////////////////////////////////
        ///Escriba una función que reciba un array y un valor booleano. Si el booleano es true, mostrar el array de modo ascendente, si es false, mostrarlo de modo descendente.
        ///En el programa principal, crear un array y hacer que la función lo muestre primero en modo ascendente y después en modo descendente.
        ///
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 5 };

            bool alto = true;

            MostrarArray(numeros, alto);

            alto = false;
            Console.WriteLine("");

            MostrarArray(numeros, alto);
        }

        public static void MostrarArray(int[] cadena, bool verdad)

        {
            if (verdad)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    Console.WriteLine(cadena[i]);
                }
            }

            else
            {
                for (int i = cadena.Length; i > 0; i--)
                {
                    Console.WriteLine(cadena[i - 1]);
                }
            }


        }




        ///////////////////// EJERCICIO 14 ///////////////////////////////////////////
        ///Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo.
        ///Pediremos de qué figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área.
        ///Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla
        ///      a. Circulo: (radio^2)*PI
        ///      b. Triángulo: (base * altura) / 2
        ///      c. Cuadrado: lado* lado

        static void Main(string[] args)
        {
            Console.WriteLine("1- Círculo");
            Console.WriteLine("2- Triángulo");
            Console.WriteLine("3- Cuadrado");
            Console.WriteLine("¿De qué figura quieres calcular el área (1, 2 o 3)?");

            int numeroFigura = Convert.ToInt32(Console.ReadLine());

            if (numeroFigura == 1)
            {
                Console.WriteLine("Introduce el radio del círculo:");
                int radioCirculo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El área del círculo es: " + AreaCirculo(radioCirculo));
            }

            else if (numeroFigura == 2)
            {
                Console.WriteLine("Introduce la base del triángulo:");
                int baseTriangulo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la altura del triángulo:");
                int alturaTriangulo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El área del triángulo es " + AreaTriangulo(baseTriangulo, alturaTriangulo));
            }

            else if (numeroFigura == 3)
            {
                Console.WriteLine("Introduce la longitud del primer lado del cuadrado:");
                int lado1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce la longitud del segundo lado del cuadrado:");
                int lado2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El área del cuadrado es: " + AreaCuadrado(lado1, lado2));

            }


        }

        public static double AreaCirculo(double radio)

        {
            double resultado;

            resultado = (Math.Pow(radio, 2) * Math.PI);

            return resultado;
        }


        public static double AreaTriangulo(double bas, double altura)

        {
            double resultado;

            resultado = (bas * altura) / 2;

            return resultado;

        }

        public static double AreaCuadrado(double lado1, double lado2)

        {
            double resultado;

            resultado = (lado1 * lado2);

            return resultado;

        }




        ///////////////////// EJERCICIO 15 ///////////////////////////////////////////
        ///Crea una aplicación que nos genere una cantidad de números enteros aleatorios (preguntar cuántos quiere generar).
        ///Crea un método donde pasamos como parámetros entre qué números queremos que los genere (preguntamos al usuario los límites).
        ///Este método devolverá un número entero aleatorio entre ese rango. Muestra estos números por pantalla.
        ///
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números quieres generar?");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidadNumeros; i++)
            {

                Console.WriteLine("Introduce el límite mínimo");
                int rangoMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el límite máximo");
                int rangoMax = Convert.ToInt32(Console.ReadLine());

                int numeroAleatorio = Aleatorio(rangoMin, rangoMax);
                Console.WriteLine(numeroAleatorio);
            }
        }



        public static int Aleatorio(int rangoMin, int rangoMax)

        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(rangoMin, rangoMax);

            return numeroAleatorio;


        }





        ///////////////////// EJERCICIO 16 ///////////////////////////////////////////
        ///Crea una aplicación que nos calcule el factorial de un número pedido por teclado, lo realizará mediante un método al que le pasamos el número como parámetro.
        ///Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno.
        ///Por ejemplo, si introducimos un 5, realizará esta operación 5*4*3*2*1=120.
        ///
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para calcular su factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(number));


        }

        public static int Factorial(int numero)

        {
            int siguienteNumero = numero - 1;

            for (int i = 0; i < numero - 1; i++)
            {
                numero *= siguienteNumero;
            }

            return numero;
        }
    }
}
