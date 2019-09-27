using System;
namespace cSharpExercises.lists
{
    public class lists
    {

        //// ARRAY vs. LIST
        ///  array = you have to define the number of elements beforehand, you know how big the array is going to be.
        ///          And you use less memory
        ///  lists = You dont need to define the size in beforehand. Elements can be added or removed at any time.
        ///
        /// private Employee[] employees = new employee [10];
        /// private List<Employee> employeesList = new list<Employee>;



        //////////////
        ///1.Hay que crear 5 funciones:
        //        - Método CreaLista:
        //          Esta función recibirá por parámetro la lista que crearemos en el programa y la devolverá con datos.
        //        - Método MostrarLista:
        //          Esta función simplemente recibirá la lista por parámetro y la mostrará en pantalla.
        //        - Crea un método OrdenarLista:
        //          Ordena alfabéticamente la lista que reciba por parámetro.
        //        - Crea un método BorrarDeLaLista:
        //          Recibirá un elemento y una lista por parámetro. Si encuentra el
        //            elemento en la lista lo borrara.
        //        - Crea un método ContarElementos:
        //          Recibe una lista por parámetro y devuelve la cantidad de elementos en ella.


        static void Main(string[] args)
        {
            List<string> listaCompra = new List<string>();
            listaCompra = CrearLista(listaCompra);

            MostrarLista(listaCompra);
            OrdenarLista(listaCompra);
            BorrarDeLista(listaCompra, "Pera");
            Console.WriteLine("Cantidad de elementos: " + ContarElementos(listaCompra));
        }

        public static List<string> CrearLista(List<string> listaCompra)
        {
            listaCompra.Add("Peras");
            listaCompra.Add("Manzanas");
            listaCompra.Add("Arroz");



            return listaCompra;
        }

        public static void MostrarLista(List<string> lista)
        {
            foreach (string producto in lista)
            {
                Console.WriteLine(producto);
            }
        }

        public static void OrdenarLista(List<string> lista)
        {
            lista.Sort();
            MostrarLista(lista);
        }

        public static void BorrarDeLista(List<string> lista, string producto)
        {

            if (lista.Remove(producto))
            {
                Console.WriteLine(producto + " se ha borrado.");
            }
            else
            {

                Console.WriteLine(producto + " no se encuentra en la lista");
            }

            MostrarLista(lista);
        }

        public static int ContarElementos(List<string> lista)
        {
            return lista.Count;
        }





        //        Lee por consola los números que introduzca el usuario.
        // Si el número introducido es decimal lo guardará en una lista de números decimales,.
        // Si no es decimal entonces los guardará en una lista de ints.

        //        El programa seguirá pidiendo al usuario que introduzca números hasta que introduzca un número negativo.
        // Una vez haya introducido un número negativo: 
        // Muestra cuántos números decimales y cuantos enteros ha creado.
        // Haz la suma de todos los números enteros introducidos.
        // Saca la media de todos los números, tanto enteros como decimales JUNTOS.
        // Controla las posibles excepciones que se puedan dar, como por ejemplo introducir una letra en una variable double.


        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            double num;

            do
            {
                Console.WriteLine("Introduce un número");
                num = Convert.ToDouble(Console.ReadLine());

                //if (num % 1 == 0)
                //{
                //    ints.Add(Convert.ToInt32(num));
                //}
                //else
                //{
                //    doubles.Add(num);
                //}

                if (num >= 0)
                {

                    if (Convert.ToString(num).Contains(","))
                    {
                        doubles.Add(num);
                    }
                    else
                    {
                        ints.Add(Convert.ToInt32(num));
                    }
                }

            } while (num >= 0);

            Console.WriteLine("Cantidad de números decimales: " + doubles.Count);
            Console.WriteLine("Cantidad de números enteros: " + ints.Count);

            SumarEnteros(ints);
            SacarMedia(ints, doubles);
        }

        public static int SumarEnteros(List<int> ints)
        {
            int suma = 0;

            foreach (int entero in ints)
            {
                suma += entero;
            }
            Console.WriteLine("La suma de los números enteros es: " + suma);

            return suma;

        }

        public static void SacarMedia(List<int> ints, List<double> doubles)
        {
            int sumaEnteros = SumarEnteros(ints);
            double sumaDoubles = 0;
            double media;

            foreach (double deci in doubles)
            {
                sumaDoubles += deci;
            }

            media = (sumaEnteros + sumaDoubles) / (ints.Count + doubles.Count);
            Console.WriteLine("La media es: " + media);
        }

        //Crea una Lista denominada ListaCantantesFamosos que disponga de objetos de la clase CantanteFamoso.
        // Debemos crear un método que permita añadir objetos de tipo CantanteFamoso a la lista.
        //    Un objeto de tipo CantanteFamoso tendrá como atributos nombre (String) y discoConMasVentas (String), y los métodos para obtener y establecer los atributos.
        //    Desde el main que inicializa la lista ListaCantantesFamosos y añade manualmente dos objetos de tipo CantanteFamoso a la la lista.
        //    Usando iterator muestra los nombres de cada cantante y su disco con más ventas por pantalla.
        //    Se debe pedir al usuario un nombre y disco con más ventas de otro cantante famoso, y una vez introducidos los datos mostrar la lista actualizada usando iterator.
        //    Una vez mostrada la lista actualizada, se debe dar opción a elegir entre volver a introducir los datos de otro cantante o salir del programa.

        static void Main(string[] args)
        {
            //OPCION 1
            //List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>()
            //{
            //    new CantanteFamoso("Ed Sheeran","Happier"),
            //    new CantanteFamoso("Rihanna","Umbrella")
            //};

            //OPCION 2
            //List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>();
            //CantanteFamoso c1 = new CantanteFamoso("Ed Sheeran", "Happier");
            //CantanteFamoso c2 = new CantanteFamoso("Rihanna", "Umbrella");
            //listaCantantesFamosos.Add(c1);
            //listaCantantesFamosos.Add(c2);

            //OPCION 3
            CantanteFamoso c1 = new CantanteFamoso("Ed Sheeran", "Happier");
            CantanteFamoso c2 = new CantanteFamoso("Rihanna", "Umbrella");
            List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>()
            {
                c1,c2
            };

            AnadirCantante(listaCantantesFamosos);
            MostrarLista(listaCantantesFamosos);

        }

        public static void AnadirCantante(List<CantanteFamoso> cantantes)
        {
            string respuesta;
            do
            {
                Console.WriteLine("Nombre del artista:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Disco del artista:");
                string disco = Console.ReadLine();

                CantanteFamoso c1 = new CantanteFamoso(nombre, disco);
                cantantes.Add(c1);

                MostrarLista(cantantes);

                Console.WriteLine("¿Quieres añadir otro (s/n)?");
                respuesta = Console.ReadLine().ToLower();


            } while (respuesta == "s");

        }

        public static void MostrarLista(List<CantanteFamoso> cantantes)
        {
            foreach (CantanteFamoso cantante in cantantes)
            {
                cantante.MostrarDatos();
            }
        }

    //    namespace Ejercicio4
    //{
    //    class CantanteFamoso
    //    {
    //        public string Nombre { get; set; }
    //        public string Disco { get; set; }

    //        public CantanteFamoso(string nombre, string disco)
    //        {
    //            Nombre = nombre;
    //            Disco = disco;
    //        }

    //        public CantanteFamoso()
    //        {
    //        }

    //        public void MostrarDatos()
    //        {
    //            Console.WriteLine("Nombre: " + Nombre + " Disco con más ventas: " + Disco);
    //        }
    //    }
    //}

}
}
