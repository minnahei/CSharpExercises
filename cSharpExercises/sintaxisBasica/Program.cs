using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////// EJERCICIO 1 /////////////////////////////////////
            ///Escribe un programa que muestre en pantalla “Hola” seguido de tu nombre
            ///

            // creamos una variable de tipo string llamada nombre
            string nombre = "Arrate";
            // escribimos "Hola" seguido del valor que hemos dado a la variable 'nombre'
            Console.WriteLine("Hola " + nombre);
            Console.ReadLine();


            ////////////////////// Ejercicio 2 /////////////////////////////////////////
            ///Escribe un programa que muestre la suma de dos números
            ///

            //creamos dos variables de tipo double llamadas numero1 y numero2
            double numero1, numero2;
            //damos un valor a cada una de las variables;                       
            numero1 = 3;
            numero2 = 5;
            //realizamos la suma y escribimos el resultado
            Console.WriteLine(numero1 + numero2);
            Console.ReadLine();

            ///////////////////////////// Ejercicio 3 ///////////////////////////////////
            ///Escribe un programa que calcule la división de dos números y lo muestre en pantalla

            //creamos dos variables de tipo double llamadas numero1 y numero2
            double numero1, numero2;
            //damos un valor a cada una de las variables
            numero1 = 8;
            numero2 = 4;
            //mostramos por pantalla el resultado de la operación
            Console.WriteLine(numero1 / numero2);
            Console.ReadLine();

            ////////////////////////////// Ejercicio 4 /////////////////////////////////////
            //////Escribe un programa que muestre el resultado de las siguientes operaciones:
            //            -5 + 8 * 6
            //            (55 + 9) % 6
            //             20 + -3 * 5 / 8
            //             5 + 15 / 3 * 2 - 8 % 3


            Console.WriteLine(-5 + (8 * 6));
            Console.WriteLine((55 + 9) % 6);
            Console.WriteLine(20 + -3 * 5 / 8);
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);



            /////////////////////////////// Ejercicio 5 ///////////////////////////////////////
            ///Escribe un programa que pida dos números al usuario y muestre el resultado de multiplicar los dos
            ///

            int valorusario1;
            int valorusario2;

            Console.WriteLine("Elige un numero");
            valorusario1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Elige otro numero");
            valorusario2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(valorusario1 * valorusario2);

            ///////////////////////////////// Ejercicio 6 ////////////////////////////////////////
            ///Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división
            //more correct to use double instead of int but use Convert.ToDouble instead of Parse

            int valorusario1;
            int valorusario2;

            Console.WriteLine("Elige un numero");
            valorusario1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Elige otro numero");
            valorusario2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Resultado de sumarlos: " + (valorusario1 + valorusario2));
            Console.WriteLine("Resultado de multiplicarlos: " + (valorusario1 * valorusario2));
            Console.WriteLine("Resultado de restarlos: " + (valorusario1 - valorusario2));
            Console.WriteLine("Resultado de dividirlos: " + (valorusario1 / valorusario2));
            Console.WriteLine("Resultado del resto de la division: " + (valorusario1 % valorusario2));

            ///////////////////////////////// Ejercisio 7 ///////////////////////////////////////////
            ///Escribe un programa que pida un número al usuario y muestre la tabla de multiplicar hasta 10 de ese número. Por ejemplo si metemos un 8 que muestre:
            //8 x 1 = 8
            //8 x 2 = 16
            //8 x 3 = 24

            int numeroMulti;

            Console.WriteLine("Elige un numero");
            numeroMulti = Int32.Parse(Console.ReadLine());

            Console.WriteLine("*1= " + numeroMulti * 1);
            Console.WriteLine("*2= " + numeroMulti * 2);
            Console.WriteLine("*3= " + numeroMulti * 3);
            Console.WriteLine("*4= " + numeroMulti * 4);
            Console.WriteLine("*5= " + numeroMulti * 5);
            Console.WriteLine("*6= " + numeroMulti * 6);
            Console.WriteLine("*7= " + numeroMulti * 7);
            Console.WriteLine("*8= " + numeroMulti * 8);
            Console.WriteLine("*9= " + numeroMulti * 9);
            Console.WriteLine("*10= " + numeroMulti * 10);


            /////////////////////////// Ejercicio 8 ///////////////////////////////////////
            ///Escribe un programa que calcule el resultado de la siguiente operación:
            //     ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5))

            Console.WriteLine((25.5 * 3.5) - (3.5 * 3.5) / (40.5 - 4.5));


            //////////////////////////// Ejercicio 9 //////////////////////////////////////
            ///Escribe un programa que calcule el resultado de la siguiente operación:
            //      4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 1))

            Console.WriteLine((4.0 * (1 - (1.0 / 3)) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 1)));


            /////////////////////////// Ejercicio 10 /////////////////////////////////////
            ///Escribe un programa que pida al usuario el radio de un círculo y que calcule y muestre el área y el perímetro (el área de un círculo es PI por radio cuadrado y el perímetro es 2 por radio por PI). PI es = 3.141593

            int radio;

            Console.WriteLine("Introduce el radio del circulo");
            radio = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El area es: " + 3.141593 * (radio * 2));
            Console.WriteLine("El perimetro es: " + 2 * radio * 3.141593);


            /////////////////////////// Ejercicio 11 ///////////////////////////////////////
            ///Escribe un programa que pida tres números al usuario y que calcule y muestre su media.
            ///

            Console.WriteLine("Introduzca 3 numeros");
            int nr1 = Int32.Parse(Console.ReadLine()); //tiene valor!!
            int nr2 = Int32.Parse(Console.ReadLine());
            int nr3 = Int32.Parse(Console.ReadLine());
            int suma;
            suma = nr1 + nr2 + nr3;


            Console.WriteLine("La suma: " + (nr1 + nr2 + nr3));
            Console.WriteLine("La media: " + (suma / 2));


            //////////////////////////// Ejercicio 12 //////////////////////////////////////
            ///Escribe un programa que pida al usuario la anchura y altura de un rectángulo y que calcule y muestre su área y su perímetro (el área es la altura por la anchura y el perímetro es 2 por la suma de la altura y la anchura).

            Console.WriteLine("Introduzca altura del rectangulo");
            int altura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca anchura del rectangulo");
            int anchura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("La area del rectangulo es: " + (altura * anchura));

            int suma = altura * anchura;

            Console.WriteLine("El perimetro del rectangulo es: " + (2 * suma));


            //////////////////////////// Ejercicio 13 //////////////////////////////////////////
            ///Escribe un programa que pida dos variables, y después intercambie sus valores (si por ejemplo ponemos 8 en la variable a y 5 en la variable b, que al final del programa la variable a tenga el valor 5 y la variable b el valor 8).
            // A)
            int variableA;
            int variableB;

            Console.WriteLine("Introduzca un variable");
            variableA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("A= " + (variableA));

            Console.WriteLine("Introduzca otro variable");
            variableB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("B= " + (variableB));

            int variableC;
            variableC = variableA;

            Console.WriteLine("A= " + (variableB));

            int variableD;
            variableD = variableB;

            Console.WriteLine("B= " + (variableA));

            // B) creamos las variables de tipo int llamadas 'a' y 'b'
            int a, b;
            //creamos una tercera variable de tipo int llamada 'c' para poder realizar
            //el intercambio de valores
            int c;
            //pedimos al usuario que escriba un número y asignamos el valor a la 
            //variable 'a'
            Console.WriteLine("Escribe un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            //asignamos el valor de la variable 'a' a la variable 'c'
            c = a;
            //pedimos al usuario que escriba otro número y asignamos su valor a la 
            //variable 'b'
            Console.WriteLine("Escribe un número");
            b = Convert.ToInt32(Console.ReadLine());
            //asignamos el valor de la variable 'b' a la variable 'a'
            a = b;
            //asignamos el valor de la variable 'c' a la variable 'b'
            b = c;
            //mostramos por pantalla los valores de las variables
            Console.WriteLine("a: " + a + " y b: " + b);
            Console.ReadLine();


            //////////////////////////////////// Ejercicio 14 //////////////////////////////////
            ///Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
            ///

            Console.WriteLine("Introduce a 3 digit number");
            int number = Int32.Parse(Console.ReadLine());

            int D0, D1, D2, D3;

            D3 = number % 10;
            D0 = number / 10;
            D2 = D0 % 10;
            D1 = number / 100;

            number = D1 + D2 + D3;

            Console.WriteLine("The sum of the digits is: " + number);


            ///////////////////////////////// ejercicio 15 //////////////////////////////////////
            ///Escribe un programa que pida al usuario un dígito (n) y calcule y muestre el valor de n+nn+nnn. Por ejemplo si el usuario introduce 5 el programa calcularía 5 + 55 + 555

            // pedimos al usuario que escriba un número y lo almacenamos en la variable
            //de tipo int llamada num. como todo lo que se lee por pantalla es de tipo
            //string, hay que hacer conversión al tipo de dato con el que queremos
            //trabajar
            Console.WriteLine("Escribe un número de 1 dígito: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // multiplicamos por 11 y 111 la variable 'num' y guardamos los valores en
            // en las variables 'num2' y 'num3' respectivamente
            int num2 = num * 11;
            int num3 = num * 111;
            // escribimos en pantalla el resultado de la suma
            Console.WriteLine(num + num2 + num3);
            Console.ReadLine();
            //para que se vea más claro, podemos mostrar por pantalla los valores de
            //las variables num2 y num3:
            //    Console.WriteLine(num2);
            //    Console.WriteLine(num3); 



            /////////////////////////////// Ejercicio 16 ////////////////////////////////////////
            ///Escribe un programa que pida al usuario un número y convierta el string a un int y lo muestre en pantalla.
            ///
            /// 
            //pedimos al usuario que escriba un número
            Console.WriteLine("Escribe un número");
            //creamos una variable de tipo string llamda 'numero' en la que guardamos el valor de lo que hemos leido
            string numero = Console.ReadLine();
            //creamos una variable de tipo int llamada 'num' usaremos Convert.X() para convertir 
            //de string al tipo de dato que queramos. en este caso utilizaremos Convert.ToInt32() para convertir de 
            //string a int. entre paréntesis se indica el string que queremos convertir
            int num = Convert.ToInt32(numero);
            Console.WriteLine(num);



            ////////////////////////////// Ejercicio 17 //////////////////////////////////////
            ///Escribe un programa que calcule el resto de dividir dos números sin utilizar el operador de división de resto (%)
            ///
            ///

            //pedimos al usuario que escriba un número y lo almacenamos en la variable
            //de tipo int llamada 'primerNum'
            Console.WriteLine("Introduce el primer número");
            int primerNum = Convert.ToInt32(Console.ReadLine());
            //pedimos al suario que escriba un número y lo guardamos en la variable
            //de tipo int llamda 'segundoNum'
            Console.WriteLine("Introduce el segundo número");
            int segundoNum = Convert.ToInt32(Console.ReadLine());
            //calculamos la división entre los dos números y lo guardamos en la variable
            //llamada 'division'. al ser de tipo int no guarda los decimales, únicamente
            //números enteros
            int division = primerNum / segundoNum;
            //creamos una variable de tipo int llamad 'resto' que utilizaremos para
            //guardar el resto de la división
            int resto;
            //realizamos la operación y guardamos el resultado en la variable 'resto'
            resto = primerNum - (segundoNum * division);
            //mostramos por pantalla el resto de la división
            Console.WriteLine("El resto es: " + resto);
            Console.ReadLine();


            ////////////////////////////// Ejercicio 18 /////////////////////////////////////
            ///Escribe un programa que pida la temperatura en celsius y te la calcule en fahrenheit.
            ///
            /// 
            //creamos una variable de tipo double llamada 'celsius'
            double celsius;
            //creamos una constante de tipo double llamada 'FARENHEIT' y le asignamos un
            //valor de 32
            const double FARENHEIT = 32;
            //creamos una variable de tipo double llamada 'gradosFarenheit'
            double gradosFarenheit;
            //pedimos al usuario que escriba la temperatura
            Console.WriteLine("Escribe la temperatura en grados Celsius:");
            //guardamos en la variable 'celsius' el número escrito por el usuario
            celsius = Convert.ToDouble(Console.ReadLine());
            //realizamos la operación de conversión de celsius a farenheit. para ello
            //utilizamos la fórmula siguiente: celsius*9/5 + 32. tenemos los grados
            //celsius guardados en la variable 'celsius' y el 32 que hay que sumar en
            //la constante 'FARENHEIT'. el resultado de la operación lo guardamos en la
            //variable 'gradosFarenheit'
            gradosFarenheit = (celsius * 9) / 5 + FARENHEIT;
            //escribimos en pantalla los grados Celsius y su conversión a Farenheit
            Console.WriteLine(celsius + " grados Celsius son " + gradosFarenheit + " grados Farenheit.");
            Console.ReadLine();

            //////////////////////////////// Ejercicio 19 //////////////////////////////////////
            ///Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a metros (una pulgada son 0.0254 metros)
            ///
            /// 
            //creamos dos variables de tipo double llamdas 'pulgadas' y 'metros'
            double pulgadas, metros;
            //creamos una constante de tipo double llamada 'distanciaPulgadas' y le 
            //asignamos un valor
            const double distanciaPulgadas = 0.0254;
            //pedimos al usuario que escriba una distancia en pulgadas y guardamos el
            //valor en la variable pulgadas
            Console.WriteLine("Escribe una distancia en pulgadas");
            pulgadas = Convert.ToDouble(Console.ReadLine());
            //hacemos la conversión a metros utilizando  la fórmula siguiente: 
            //metros = pulgadas * 0.0254
            metros = pulgadas * distanciaPulgadas;
            //mostramos por pantalla el resultado
            Console.WriteLine(pulgadas + " pulgadas son " + metros + " metros");



            //////////////////////////// Ejercicio 20 ////////////////////////////////////////
            ///Escribe un programa que pida un número de minutos y muestre cuantos años y días son.
            ///

            //pedimos al usuario un número y guardamos el valor en la variable de tipo 
            //int llamada 'minutos'
            Console.WriteLine("Escribe un numero de minutos para convertirlos a años y dias");
            int minutos = Convert.ToInt32(Console.ReadLine());
            //creamos la variable de tipo int llamda 'dias' y le asignamos un valor en
            //función del valor de la variable 'minutos'. hemos calculado el número de
            //horas que se corresponde al número de minutos y también cuántos días hay
            //en ese número de horas
            int dias = (minutos / 60) / 24;
            //creamos una variable de tipo int llamada 'anos' (si utilizamos la ñ puede
            //haber problemas al ejecutar el programa) y calculamos cuantos años hay 
            //en el número de días calculado previamente.
            int anos = dias / 365;
            //mostramos por pantalla el resultado. teniendo en cuenta que 365 días hacen
            //un año, calculamos el resto de la división de la variable 'dias' entre 365
            //para calcular el número de días
            Console.Write("Esos minutos son " + anos + " años y " + (dias % 365) + " días ");
            Console.ReadLine();


            //////////////////////////////// Ejercicio 21 /////////////////////////////////////
            ///Escribe un programa que pida una distancia (en metros), y el tiempo tardado (como tres números: horas, minutos y segundos) y que muestre la velocidad en metros por segundo y kilómetros por hora.
            ///
            ///

            //creamos variables de tipo double llamadas 'metros', 'km', 'segundos',
            //'minutos', 'horas', y 'segTotal'
            double metros, km, segundos, minutos, horas, segTotal;
            //pedimos al usuario un número que guardaremos en la variable 'metros'
            Console.WriteLine("Introduce una distancia en metros.");
            metros = Convert.ToDouble(Console.ReadLine());
            //hacemos la conversión de metros a kilómetros y guardamos en la variable 'km'
            km = metros / 1000;
            //pedimos al usario un número que serán las horas y guardamos el valor en 
            //la variable 'horas'
            Console.WriteLine("Introduce un tiempo en horas.");
            horas = Convert.ToDouble(Console.ReadLine());
            //pedimos al usuario un número que serán los minutos y guardamos el valor
            //en la variable 'minutos'
            Console.WriteLine("Introduce un tiempo en minutos.");
            minutos = Convert.ToDouble(Console.ReadLine());
            //pedimos al usuario un número que serán los segundos y guardamos el valor
            //en la variable 'segundos'
            Console.WriteLine("Introduce un tiempo en segundos.");
            segundos = Convert.ToDouble(Console.ReadLine());
            //hacemos la conversión de horas, minutos y segundos a segundos y guardamos
            //el valor en la variable 'segTotal'
            segTotal = segundos + (minutos * 60) + (horas * 3600);
            //escribimos el resultado
            Console.WriteLine("La velocidad son " + (metros / segTotal) + " m/seg y " + (km / (segTotal / 3600) + " km/h"));
            Console.ReadLine();

            ///////////////////////////// Ejercicio 22 /////////////////////////////////
            ///Escribe un programa que convierta los segundos a horas, minutos y segundos.
            ///
            ///
            
            //creamos 3 variables de tipo int en las que guardaremos las horas, los minutos
            //y los segundos
            int horas, minutos, segundos;
            //pedimos al usuario que escriba el tiempo en segundos que vamos a calcular
            //y guardamos el valor en la variable 'segundos'
            Console.WriteLine("Escribe los segundos que vamos a pasar a horas, minutos y segundos");
            segundos = Convert.ToInt32(Console.ReadLine());
            //convertimos los segundos en horas y guardamos el valor en la variable
            //'horas'
            horas = segundos / 3600;
            //convertimos los segundos en minutos y guardamos el valor en la variable
            //'minutos'
            minutos = segundos / 60;
            //mostramos por pantalla el resultado. como cada 60 minutos son una hora, calculamos
            //el resto de la divisón del número de minutos (guardado en la variable 'minutos')
            //entre 60 y hacemos los mismo con los segundos.
            Console.WriteLine(segundos + " segundos son: " + horas + " horas, " + minutos % 60 + " minutos y " + segundos % 60 + " segundos");

            /////////////////////////////// Ejercicio 23 ////////////////////////////////////
            ///Escribe un programa que genere un número aleatorio entre el 1 y el 100 (pista: hay que utilizar una función).
            ///

            //creamos un objeto de la clase 'Random' llamado 'aleatorio'
            Random aleatorio = new Random();
            //creamos una variable de tipo int llamada 'numerAleatorio'.para asignarle
           //un valor utilizamos la función 'Next(int, int)'.esta función crea un
          //número aleatorio que se encuentre entre los dos valores que le decimos
          //nosotros, en este caso entre 1 y 100.
            int numeroAleatorio = aleatorio.Next(1, 100);
            //mostramos por pantalla el número aleatorio generado y guardado en la
            //variable 'numeroAleatorio'
            Console.WriteLine(numeroAleatorio);
            Console.ReadLine();


            ///////////////////////////////// FUNCIONES STRING /////////////////////////////////
            ///
            //////////////////////////////// ejercicio 1 ////////////////////////////////////////
            //Escribe un programa que te calcule la largura de un string que pides por consola.

            Console.WriteLine("Quantos characters tiene PERRO?");

            string cadena = "PERRO";
            int length = cadena.Length;

            Console.WriteLine(length);

            /////////////////////////////// ejercicio 2 //////////////////////////////////////////
            //Escribe un programa que cambie a minúsculas una frase en mayúsculas.

            Console.WriteLine("minna");

            string cadena = "minna";
            string name = cadena.ToUpper();

            Console.WriteLine(name);

            ////////////////////////////// Ejercicio 3 ////////////////////////////////////////
            //Escribe un programa que escriba en mayúscula una frase en minúscula.

            Console.WriteLine("PALABRA");

            string cadena = "PALABRA";
            string word = cadena.ToLower();

            Console.WriteLine(word);

            /////////////////////////////// ejercicio 4 ///////////////////////////////////////
            //Escribe un programa que copie una cadena en otra variable usando una función.

            Console.WriteLine("Escribe una frase");
            //declaramos una variable tipo string en la que almacenamos lo que leemos por pantalla
            string frase = Console.ReadLine();
            //declaramos una variable de tipo string en la que almacenamos una copia del string 'frase'
            //usando el método string.Copy();
            string copia = string.Copy(frase);
            //escribimos el resultado
            Console.WriteLine(copia);

            ///////////////////////////////// ejercicio 5 ////////////////////////////////////
            //Escribe un programa que reemplace  una cadena por otra (Por ejemplo “Hola Arrate” por “Hola Iker”).

            Console.WriteLine("Hola Arrate");

            string cadena = "Arrate";
            string cambio = cadena.Replace("Arrate", "Iker");

            Console.WriteLine("Hola " + cambio);

            //////////////////////////////// Ejercicio 6 ///////////////////////////////////////
            //Escribe un programa que dada una cadena identifique los caracteres del 5 al 10.

            Console.WriteLine("Hello, how are you?");

            String cadena = "Hello, how are you";
            string subCadena = cadena.Substring(5, 10);

            Console.WriteLine(subCadena);













        }
    }
}
