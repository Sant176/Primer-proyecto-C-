namespace Biblioteca
{
    public class Biblioteca
    {
        public string NombreLibro { get; set; }
        public string Autor {  get; set; }
        public int CantidadLibros { get; set; }
        public int Codigo {  get; set; }

        public Biblioteca()
        {
            NombreLibro = "";
            Autor = "";
            CantidadLibros = 0;
            Codigo = 0; 

        }

        public Biblioteca(string nombreLibro,string autor,int cantidadlibros,int codigo)
        {
            NombreLibro=nombreLibro;
            Autor = autor;
            CantidadLibros = cantidadlibros;
            Codigo=codigo;


        }

        public override string ToString()
        {
            return $"Nombre libro:{NombreLibro} Autor:{Autor} Cantidad libro:{CantidadLibros} Codigo:{Codigo}";
        }


    }


    class Bibliotec
    {
        static void Main()
        {
         Console.Clear();
         List<Biblioteca> lista_biblioteca = new List<Biblioteca>();
         Console.Clear();

         lista_biblioteca.Add(new Biblioteca("Cien Años de Soledad", " Gabriel García Márquez", 1425, 431));
         lista_biblioteca.Add(new Biblioteca(" Don Quijote de la Mancha", "Miguel de Cervantes", 875, 322));
         lista_biblioteca.Add(new Biblioteca("El Principito", "Antoine de Saint-Exupéry", 1287, 123));
         lista_biblioteca.Add(new Biblioteca("Orgullo y Prejuicio","Jane Austen", 434, 564));
         lista_biblioteca.Add(new Biblioteca("1984", "George Orwell", 610, 895));
         lista_biblioteca.Add(new Biblioteca("Crónica de una Muerte Anunciada", "Gabriel García Márquez", 1010, 326));
         lista_biblioteca.Add(new Biblioteca("Matar a un Ruiseñor", "Harper Lee", 700, 897));
         lista_biblioteca.Add(new Biblioteca("La Odisea", "Homero", 378, 548));
         lista_biblioteca.Add(new Biblioteca("Fahrenheit 451", "Ray Bradbury", 978, 499));
         lista_biblioteca.Add(new Biblioteca("El Alquimista", "Paulo Coelho", 1174, 710));




            while (true)
            {
                Console.WriteLine("1.Modulo Biblioteca\n2.\n3.\n4.");
                string OpcionModulo=Console.ReadLine();
                switch (OpcionModulo)
                {
                    case "1":
                     ModuloBiblioteca(lista_biblioteca);
                    break;

                    case "2": 

                    break;

                    case "3":

                    break;

                    case "4":
                        
                    break;

                    default:
                        Console.WriteLine("Operacion no valida");
                    break;


                }


            }

            static void ModuloBiblioteca(List<Biblioteca> lista_biblioteca)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Agregar libro\n2.Buscar libro\n3.Modificar libro\n4.Eliminar libro\n5.Mostrar libro\n6.Salir");
                    string OpcionModuloBiblioteca = Console.ReadLine().ToUpper();
                    Console.Clear() ;   

                    switch (OpcionModuloBiblioteca)
                    {
                        case "1":
                            AgregarLibro(lista_biblioteca);
                            break;

                        case "2":
                            BuscarLibro(lista_biblioteca);
                            break;

                        case "3":
                            ModificarLibro(lista_biblioteca);
                            break;

                         case"4":

                           break;

                        case "5":
                            MostrarLibro(lista_biblioteca);
                            break;

                        case "6":

                           break;

                        default:
                            Console.WriteLine("Operacion no valida");
                            break;
                    }

                }
            }

            static void AgregarLibro(List<Biblioteca>Lista_biblioteca)
            {
                string Agregar;
                do { 
                Console.WriteLine("Quieres agregar un libro SI/NO?");
                 Agregar = Console.ReadLine().ToUpper();
                if (Agregar == "SI")
                {
                 Console.WriteLine("Ingresa el nombre del libro");
                 string NombreLibro = Console.ReadLine();
                 Console.WriteLine("Ingresa el autor del libro");
                 string AutorLibro= Console.ReadLine();
                 Console.WriteLine("Ingresa la cantidad que tenes del libro");
                 int CantidadLibro= Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Ingresa el codigo del libro");
                  int Codigo;
                   while (!int.TryParse(Console.ReadLine(), out Codigo))
                   {
                      Console.WriteLine("Operacion Invalida pon un codigo correcto");

                   }
                   Biblioteca biblioteca = new Biblioteca(NombreLibro,AutorLibro,CantidadLibro,Codigo);    
                   Lista_biblioteca.Add(biblioteca);

                        Console.WriteLine("Libro creado Exitosamente");
                        Console.WriteLine(biblioteca);

                }
                else if (Agregar == "NO")
                {
                    Console.WriteLine("Operacion cancelada");
                }
                Console.ReadKey();

              }while (Agregar== "SI");

            }

            static void BuscarLibro (List<Biblioteca>Lista_biblioteca)
            {
                string Opcion;
                do
                {

                    Console.WriteLine("Quieres buscar un libro SI/NO?");
                    Opcion = Console.ReadLine().ToUpper();

                    if (Opcion == "SI")
                    {

                        Console.WriteLine("Ingresa el codigo del libro");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        Biblioteca biblioteca = Lista_biblioteca.Find(c => c.Codigo == codigo);
                        if (biblioteca != null)
                        {
                            Console.WriteLine($"libro encontrado: {biblioteca}");

                        }

                        else
                        {
                            Console.WriteLine("Cliente no encontrado intentelo de nuevo");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada");
                    }
                    Console.ReadKey ();

                } while (Opcion == "SI");
            }
             

            static void ModificarLibro(List<Biblioteca>Lista_biblioteca)
            {
                string OpcionUltra;

                do
                {
                    Console.WriteLine("Quieres modifcar un libro SI/NO?");
                    OpcionUltra = Console.ReadLine();
                    if (OpcionUltra == "SI")
                    {
                        Console.WriteLine("Ingresa el codigo del libro");
                        int Codigo = Convert.ToInt32(Console.ReadLine());

                        Biblioteca biblioteca = Lista_biblioteca.Find(c => c.Codigo == Codigo);
                        if (biblioteca != null)
                        {
                            Console.WriteLine($"Libro Encontrado:{biblioteca}");


                            Console.WriteLine("Quieres modificar el libro SI/NO?");
                            string opcion = Console.ReadLine();

                            if (opcion == "SI")
                            {

                                Console.WriteLine("1.Modificar nombre libro\n2.Modificar autor\n3.Modificar Cantidad de libros");
                                int OpcionMod = Convert.ToInt32(Console.ReadLine());

                                switch (OpcionMod)
                                {
                                    case 1:
                                        Console.WriteLine("Ingresa el nuevo nombre del libro:");
                                        string NuevoNombre = Console.ReadLine();
                                        biblioteca.NombreLibro = NuevoNombre;

                                        break;

                                    case 2:
                                        Console.WriteLine("Ingresa el nuevo autor del libro");
                                        string NuevoAutor = Console.ReadLine();
                                        biblioteca.Autor = NuevoAutor;
                                        break;

                                    case 3:
                                        Console.WriteLine("Ingresa la nueva cantidad de libros");
                                        int NuevaCantidad;
                                        while (!int.TryParse(Console.ReadLine(), out NuevaCantidad))
                                        {
                                            Console.WriteLine("Pon una cantidad correcta");
                                        }
                                        biblioteca.CantidadLibros = NuevaCantidad;
                                        break;

                                }
                            }

                            else
                            {
                                Console.WriteLine("Operacion cancelada");
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada volviendo al menu...");
                    }
                    Console.ReadKey();

                }while (OpcionUltra=="SI");
            }




            static void MostrarLibro(List<Biblioteca>Lista_biblioteca)
            {
                Console.WriteLine("Lista de los libros");

                foreach (var biblioteca in Lista_biblioteca)
                {
                    Console.WriteLine(biblioteca);
                }
                Console.ReadKey();
            }



        }

    }

}
