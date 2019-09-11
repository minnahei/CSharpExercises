using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {


            /////////////////////////// EJERCICIO 1 ///////////////////////////////////////
            //////Escribe un programa que pida dos números y que muestre la suma, la resta, la multiplicación, la media, el más grande y el más pequeño.
            ///


            Console.WriteLine("introduce un numero");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("introduce otro numero ");
            int numero2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("la suma de los numeros es: " + (numero1 + numero2));

            Console.WriteLine("La resta de los numeros es: " + (numero1 - numero2));

            Console.WriteLine("La multiplication de los numeros es:" + (numero1 * numero2));

            Console.WriteLine("La media de la suma es: " + (numero1 + numero2) / 2);

            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero es mas grande que el segundo");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("el primer numero es mas pequeno que el segundo");
            }



            /////////////////////////// EJERCICIO 2 ///////////////////////////////////////
            //Escribe un programa que pida al usuario 3 números. Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, sino mostrar que el tercero no es la suma de los dos anteriores.

            Console.WriteLine("Introduce un numero");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un segundo numero");
            int numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un tercero numero");
            int numero3 = Int32.Parse(Console.ReadLine());

            if (numero1 + numero2 == numero3)
            {
                Console.WriteLine("El primer y segundo numero es igual al tercer numero");
            }
            else
            {
                Console.WriteLine("El tercer numero no es la suma del primero y segundo");
            }
            Console.ReadKey();


            /////////////////////////// EJERCICIO 3 ///////////////////////////////////////
            //Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos (exactamente) que uno de los otros.

            Console.WriteLine("Introduce tres numero");
            int numero1 = Int32.Parse(Console.ReadLine());
            int numero2 = Int32.Parse(Console.ReadLine());
            int numero3 = Int32.Parse(Console.ReadLine());

            if (numero2 - 20 == numero1 || numero3 - 20 == numero1)
            {
                Console.WriteLine("El primer numero tiene 20 menos que otro numero");
            }
            else if (numero1 - 20 == numero2 || numero3 - 20 == numero2)
            {
                Console.WriteLine("el segundo numero tiene 20 menos que otro numero");
            }
            else if (numero2 - 20 == numero3 || numero1 - 20 == numero3)
            {
                Console.WriteLine("el tercer numero tiene 20 menos que otro numero");
            }

            /////////////////////////// EJERCICIO 4 ///////////////////////////////////////
            //Vamos a escribir varios programas que saludan al usuario al iniciar. El usuario tiene asociadas 3 variables, una que indica si ha pagado la entrada, una que indica si es cliente VIP y la otro el saldo que tiene (positivo para saldo de más, negativo para deuda). Haz un programa por cada punto:

            //            Comprobar si se ha pagado la entrada.Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

            //            A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" también se le dice "Que pase un buen día"

            //            Si no tiene deudas, le damos la bienvenida.En caso contrario no hacemos nada.

            //            Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0

            Console.WriteLine("¿Has pagado la entrada? (S/N)");
            //creamos una variable de tipo string llamada 'respuesta' en la que guardamos
            //la respuesta dada por el usuario. usamos ToUpper() para convertir la
            //respuesta a mayúscula aunque el usuario la haya escrito en minúscula
            string respuesta = Console.ReadLine().ToUpper();
            //usamos un condicional para comprobar que se cumple la condición:
            if (respuesta == "S")
            {
                //si el usuario ha indicado que ha pagado la entrada, mostraremos el siguiente
                //mensaje:
                Console.WriteLine("Bienvenido.");
            }
            //si no se cumple la condición, mostraremos el siguiente mensaje:
            else
            {
                Console.WriteLine("Tienes que pagar la entrada.");
            }
            Console.ReadLine();
            Console.WriteLine("¿Eres VIP? (S/N)");
            //creamos una variable llamada 'string' en la que almacenamos la respuesta
            //del usuario

            string vip = Console.ReadLine().ToUpper();
            //comprobamos la validez de la condición
            if (vip == "S")
            {
                //si el usuario es VIP, mostraremos el siguiente mensaje
                Console.WriteLine("Bienvenido, que pase un buen día.");
            }
            //si no se cumple la condición, mostraremos el siguiente mensaje
            else
            {
                Console.WriteLine("Bienvenido.");
            }
            Console.ReadLine();
            Console.WriteLine("¿De cuanto saldo dispones?");
            //creamos una variable de tipo double llamada 'saldo' en la que guardaremos
            //la respuesta del usuario
            double saldo = Convert.ToDouble(Console.ReadLine());
            //comprobamos si se cumple la condición
            if (saldo >= 0)
            {
                //si el usuario tiene un saldo mayor o igual a 0, mostraremos el siguiente 
                //mensaje
                Console.WriteLine("Bienvenido.");
            }
            //comprobamos si se cumple la condición siguiente
            if (vip == "S" && saldo > 0)
            {
                //si el usuario es VIP y tiene un saldo mayor que 0, mostraremos el siguiente
                //mensaje
                Console.WriteLine("Bienvenido.");
            }
            Console.ReadLine();


            /////////////////////////// EJERCICIO 5 ///////////////////////////////////////
            //Escribe un programa que evalúe si un string contiene la letra ‘r’ (pista: usar función de string).


            //using "contains" (bool, indexOf??)

            // A)
            Console.WriteLine("Write a word");
            string stri = Console.ReadLine();   //set the string
            stri = stri.ToLower();

            if (stri.Contains("r") == true)    //find out if any R //if (frase.IndexOf("r") == -1) boolean expression if true not necessary put ==true frase.tolower(). to indexof
            {
                Console.WriteLine("The text contains an R");
            }
            else
            {
                Console.WriteLine("No R found");
            }

            // B)
            Console.WriteLine("Introduce una frase");
            //creamos una variable de tipo string llamada 'frase' en la que guardamos
            //la frase escrita por el usuario. usamos ToUpper() para pasar el string
            //a mayúsculas aunque esté escrito en minúsculas
            string frase = Console.ReadLine().ToUpper();
            //comprobamos si se cumple la condición.
            if (frase.Contains("R"))
            {
                //usamos Contains() para comprobar si el string 'frase' contiene la R. si la
                //frase contiene R, mostraremos el siguiente mensaje:
                Console.WriteLine("Contiene la letra r");
            }
            //si no se cumple la condición anterior mostraremos el siguiente mensaje:
            else
            {
                Console.WriteLine("No contiene la letra r");
            }
            Console.ReadLine();


            /////////////////////////// EJERCICIO 6 ///////////////////////////////////////
            // Escribe un programa que pida dos valores al usuario y 
            //            Si los dos valores son iguales muestre 0
            //Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            //Si no que muestre el más grande de los dos

            Console.WriteLine("Introduce dos valores");
            int valor1 = Int32.Parse(Console.ReadLine());
            int valor2 = Int32.Parse(Console.ReadLine());

            if (valor1 % 6 == 0 && valor2 % 6 == 0)
            {
                if (valor1 < valor2)
                {
                    Console.WriteLine("El primer valor es mas pequeno que el segundo");
                }
                else
                {
                    Console.WriteLine("El otro valor es mas grande que el primero");
                }
            }
            if (valor2 < valor1)
            {
                Console.WriteLine("El segundo valor es mas grande que el primero");
            }
            else
            {
                Console.WriteLine("El segundo valor es mas pequeno que el primero");
            }
            if (valor1 == valor2)
            {
                Console.WriteLine("0");
            }
            if (valor1 > valor2)
            {
                Console.WriteLine("El valor mas grande es: " + valor1);
            }
            else
            {
                Console.WriteLine("El valor mas grande es:" + valor2);
            }



            //////////////////////////// EJERCICIO 7 ///////////////////////////////////////
            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.

            // You can do a string too and use substring (1,1)

            Console.WriteLine("Introduce 2 numbers between 25 - 75");
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());

            int number1digit1 = number1 / 10; //you get the first digit
            int number1digit2 = number1 % 10; // you get the second digit
            int number2digit1 = number2 / 10;
            int number2digit2 = number2 % 10;

            if (number1digit1 == number2digit2 && number1 > 25 && number1 < 75)
            {
                Console.WriteLine("there's a common digit between the 2 numbers");
            }
            else if (number1digit2 == number2digit2 && number2 > 25 && number2 < 75)
            {
                Console.WriteLine("there's a common digit between the 2 numbers");
            }
            else
            {
                Console.WriteLine("Theres no common digit between the numbers");
            }

            //////////////////////////// EJERCICIO 8.A ///////////////////////////////////////
            //Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó. Después:
            //Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.

            Console.WriteLine("In what place did you finish the race?");
            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Congratulations!");
            }
            else if (answer != 1)
            {
                Console.WriteLine("The important thing is to participate");
            }

            //////////////////////////// EJERCICIO 8.B ///////////////////////////////////////
            //Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.

            int answer = Int32.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Gold medal!");
            }
            else if (answer == 2)
            {
                Console.WriteLine("Silver medal");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Bronze medal");
            }
            else
            {
                Console.WriteLine("The important thing is to participate");
            }

            //////////////////////////// EJERCICIO 8.C ///////////////////////////////////////
            //Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.

            Console.WriteLine("In what place did you finish the race?");
            int answer = Int32.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("Gold medal");
                    break;

                case 2:
                    Console.WriteLine("Silver medal!");
                    break;

                case 3:
                    Console.WriteLine("Bronze medal");
                    break;

                default:
                    Console.WriteLine("The important thing is to participate");
                    break;
            }

            //////////////////////////// EJERCICIO 8.D ///////////////////////////////////////
            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".Hazlo usando un if/else y usando switch

            Console.WriteLine("In what place did you finish the race?");
            int answer = Int32.Parse(Console.ReadLine());

            switch (answer) // (answer == 1 || answer == 2 || answer || 3)
            {
                        if (answer >= 1 && <= 3)
            {
                Console.WriteLine("Go up to the podium");
            }
            else
            {
                default:
                        Console.WriteLine("Race over, go home");
                break;
            }
        }






        //////////////////////////// EJERCICIO 10 ///////////////////////////////////////
        // Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán".


        int edad = Convert.ToInt32(Console.ReadLine()); //creamos una variable de tipo int y le asignamos el valor que leemos por pantalla
            if (edad <= 8) //si la condición se cumple entramos aquí
            {
                Console.WriteLine("Pasa al tobogán");
            }
            else //si la condición no se cumple entramos aquí
            {
                Console.WriteLine("Eres demasiado mayor para usar el tobogán");
            }
        }

        //////////////////////////// EJERCICIO 11 ///////////////////////////////////////
        //Escribe un programa el que dada una frase sacará su carácter central. Nota:
        //Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
        //Si es impar deberá sacar su único carácter central.

            Console.WriteLine("Write any word");

            string word = Console.ReadLine();

            int wordLength = wordLength.Length;

            if (word.Length % 2 == 0)
            {
            Console.WriteLine(word.Substring (/ 2 - 1), 2)); // -1 because it counts from 0, 2 is because we need 2 characters
            }
            else if (word.Length % 2 == 1)
            {
                Console.WriteLine(word.Substring ((wordlength/ 2), 1));
            }

    //////////////////////////// EJERCICIO 12 ///////////////////////////////////////
    //Comprobar un string que tenga el valor del día de la semana (lunes, martes, ...). Mostrar en pantalla el día que dice que es si es entre lunes y viernes (Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.


    //Console.WriteLine("Escribe una día de la semana:"); //pedimos al usuario que escriba un día

            string dia = Console.ReadLine().ToUpper(); //guardamos en la variable dia. usamos el método ToUpper() para pasar a mayúscula y evitarnos problemas



            switch (dia) //usamos switch y comparamos la variable dia
            {
                case "LUNES":
                    Console.WriteLine("Hoy es lunes"); //si es LUNES, escribimos esto
                    break;
                case "MARTES":
                    Console.WriteLine("Hoy es martes"); //si es MARTES, escribimos esto
                    break;
                case "MIERCOLES":
                    Console.WriteLine("Hoy es miércoles"); //si es MIERCOLES, escribimos esto
                    break;
                case "JUEVES":
                    Console.WriteLine("Hoy es jueves"); //si es JUEVES, escribimos esto
                    break;
                case "VIERNES":
                    Console.WriteLine("Hoy es viernes"); //si es VIERNES, escribimos esto
                    break;
                case "SABADO":
                    Console.WriteLine("Hoy es sábado"); //si es SABADO, escribimos esto
                    break;
                case "DOMINGO":
                    Console.WriteLine("Hoy es domingo"); //si es DOMINGO, escribimos esto
                    break;
                default:
                    Console.WriteLine("El día introducido no existe"); //si ningún resultado coincide, escribimos esto
                    break;
            }

            //////////////////////////// EJERCICIO 13 ///////////////////////////////////////
            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. Para que la contraseña sea correcta deberá cumplir estas directivas:
            //Debe tener 8 caracteres como mínimo.
            //    La contraseña deberá contener números.
            //    Deberá contener al menos dos dígitos.


            Console.WriteLine("Introduce 8 characters");
            string password = Console.ReadLine();

            if (password.Length == 8) // && text.any(char.Isdigit) && 
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("error");
            }

            //////////////////////////// EJERCICIO 14 ///////////////////////////////////////
            /// Escribe un programa que muestre la fecha de hoy (pista1: hay una función, pista2: no hay que usar condicionales)

            DateTime now = DateTime.Now; //different ways
            Console.WriteLine(now);

            Console.ReadKey();



            //////////////////////////// EJERCICIO 15 ///////////////////////////////////////
            // A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7". Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.

            Console.WriteLine("Introduce un número entero:"); //pedimos un número
            double num = Convert.ToDouble(Console.ReadLine()); // almacenamos el número en la variable num
            if (num< 0) //hacemos una comprobación. si se cumple, entramos aquí
            {
                Console.WriteLine("El valor absoluto de " + num + " es " + (num* -1));
                //escribimos el resultado. para pasar de negativo a positivo, multiplicamos el número por -1
            }
            else //si no se cumple la condición, entramos aquí
            {
                Console.WriteLine(num);
            }

            //////////////////////////// EJERCICIO 16 ///////////////////////////////////////
            //  Decir el número de helados que queremos comprar. Cada helado vale 2 euros. Si compramos más de 10 helados, nos regalan uno gratis. Mostrar en pantalla el número de helados que nos dan y cuánto hemos pagado por ellos.

            Console.WriteLine("¿Cuántos helados quieres?");
            int helados = Convert.ToInt32(Console.ReadLine()); //declaramos la variable helados y almacenamos el numero de helados
            int valor = 2; //declaramos la variable valor, que es lo que cuesta cada helado
            int total = helados * valor; //declaramos la variable total, que será el coste total de todos los helados
            if (helados > 10) //hacemos una comprobación. si se cumple la condicion, entramos aquí
            {
                total = total - valor; //si tenemos más de 10 helados, el coste será el total menos el valor (1 helado gratis)
                Console.WriteLine("Tenemos " + helados + " helados y nos han costado " + total + " euros");
            }
            else //si no se cumple la condición, entramos aquí
            {
                Console.WriteLine("Tenemos " + helados + " helados y nos han costado " + total + " euros");
            }


            //////////////////////////// EJERCICIO 17 ///////////////////////////////////////
            // Tenemos dos números, un numerador y un denominador. Si el denominador no es cero, mostramos el resultado de dividir el numerador por el denominador. Si el denominador es cero, mostramos el mensaje "No se puede dividir por cero" 

            int numerador, denominador; //declaramos dos variables de tipo int
            Console.WriteLine("Escribe dos números");
            numerador = Convert.ToInt32(Console.ReadLine()); //asignamos a cada variable el valor que leemos por pantalla
            denominador = Convert.ToInt32(Console.ReadLine());
            if (denominador != 0) //si se cumple la condición, entramos aquí
            {
                Console.WriteLine("El resultado de la división es " + numerador / denominador);
            }
            else //si no se cumple la condición anterior, entramos aquí
            {
                Console.WriteLine("No se puede dividir entre 0");
            }


            //////////////////////////// EJERCICIO 18 ///////////////////////////////////////
            //  Un año es bisiesto si se puede dividir por 4. Pero un año que se pueda dividir por 100 NO es bisiesto a no ser que se pueda dividir por 400. A partir de un año, mostrar en pantalla si es bisiesto o no.

            Console.WriteLine("Introduce el año:"); //pedimos al usuario que ponga un año
            int ano = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(ano)) //usamos el método IsLeapYear de la clase DateTime para calcular si es bisiesto. si se cumple la condición, entramos aquí
            {
                Console.WriteLine("Es bisiesto.");
            }
            else //si no se cumple la condición anterior, entramos aquí
            {
                Console.WriteLine("No es bisiesto.");
            }


            //////////////////////////// EJERCICIO 19 ///////////////////////////////////////
            ///Con if else if: Mostrar en pantalla un menú con varias opciones. Dependiendo de lo que el usuario elija, mostrar en pantalla la selección. Hacerlo tanto con if else como con switch.

            Console.WriteLine("Welcome");
            Console.WriteLine();
            Console.WriteLine("1 = curry");
            Console.WriteLine("2 = salad");
            Console.WriteLine("3 = soup");
            Console.WriteLine();
            Console.WriteLine("Introduce the number");
            int option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("You have chosen curry");
                    break;

                case 2:
                    Console.WriteLine("You have chosen salad");
                    break;

                case 3:
                    Console.WriteLine("You have chosen soup");
                    break;
            }

            //////////////////////////// EJERCICIO 20 ///////////////////////////////////////
            ///Mostrar el mayor de tres valores

            Console.WriteLine("Introduce 3 numbers");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3);
            }

            //////////////////////////// EJERCICIO 20 ///////////////////////////////////////
            /Mostrar el menor de tres valores

            Console.WriteLine("Introduce 3 numbers");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1<num2 && num1<num2)
            {
                Console.WriteLine(num1);
            }
            else if (num2<num1 && num2<num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3<num1 && num3<num2)
            {
                Console.WriteLine(num3);
            }

           







        }
    }

}
