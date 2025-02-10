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


    public class Usuario:Biblioteca
    {
        public string NombreCompleto { get; set; }
        public string Correo {  get; set; }
        public int Contraseña {  get; set; }
        public int CodigoUsuario {  get; set; }


        public Usuario()
        {
            NombreCompleto = "";
            Correo = "";
            Contraseña = 0;
            CodigoUsuario = 0;

        }

        public Usuario(string nombreCompleto,string correo,int contraseña,int codigousuario)
        {
            NombreCompleto=nombreCompleto;
            Correo = correo;
            Contraseña=contraseña;
            CodigoUsuario=codigousuario;



        }

        public override string ToString()
        {
            return $"Nombre Completo:{NombreCompleto} Correo:{Correo} Contraseña:{Contraseña} Codigo Usuario:{CodigoUsuario}";

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
            lista_biblioteca.Add(new Biblioteca("Orgullo y Prejuicio", "Jane Austen", 434, 564));
            lista_biblioteca.Add(new Biblioteca("1984", "George Orwell", 610, 895));
            lista_biblioteca.Add(new Biblioteca("Crónica de una Muerte Anunciada", "Gabriel García Márquez", 1010, 326));
            lista_biblioteca.Add(new Biblioteca("Matar a un Ruiseñor", "Harper Lee", 700, 897));
            lista_biblioteca.Add(new Biblioteca("La Odisea", "Homero", 378, 548));
            lista_biblioteca.Add(new Biblioteca("Fahrenheit 451", "Ray Bradbury", 978, 499));
            lista_biblioteca.Add(new Biblioteca("El Alquimista", "Paulo Coelho", 1174, 710));

            Console.Clear();
            List<Usuario> lista_Usuario = new List<Usuario>();
            Console.Clear();
            lista_Usuario.Add(new Usuario("Juan Pérez", "juan@Empleado.com", 303991, 203920));
            lista_Usuario.Add(new Usuario("María González", "maria@Admin.com", 409812, 203921));
            lista_Usuario.Add(new Usuario("Carlos Ramírez", "carlos@Cliente.com", 578123, 203922));
            lista_Usuario.Add(new Usuario("Ana Torres", "ana@Empleado.com", 674923, 203923));
            lista_Usuario.Add(new Usuario("Pedro Mejía", "pedro@Admin.com", 234789, 203924));
            lista_Usuario.Add(new Usuario("Laura Sánchez", "laura@Cliente.com", 987654, 203925));
            lista_Usuario.Add(new Usuario("José Medina", "jose@Empleado.com", 543216, 203926));
            lista_Usuario.Add(new Usuario("Camila Rojas", "camila@Admin.com", 678345, 203927));
            lista_Usuario.Add(new Usuario("Daniel Herrera", "daniel@Cliente.com", 890432, 203928));
            lista_Usuario.Add(new Usuario("Sofía Castro", "sofia@Empleado.com", 112233, 203929));



            while (true)
            {
                Console.WriteLine("1.Modulo Biblioteca\n2.Modulo Usuarios\n3.\n4.");
                string OpcionModulo = Console.ReadLine();
                switch (OpcionModulo)
                {
                    case "1":
                        ModuloBiblioteca(lista_biblioteca);
                        break;

                    case "2":
                        ModuloUsuario(lista_Usuario);
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

            static void ModuloBiblioteca(List<Biblioteca> Lista_biblioteca)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Agregar libro\n2.Buscar libro\n3.Modificar libro\n4.Eliminar libro\n5.Mostrar libro\n6.Salir");
                    string OpcionModuloBiblioteca = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (OpcionModuloBiblioteca)
                    {
                        case "1":
                            AgregarLibro(Lista_biblioteca);
                            break;

                        case "2":
                            BuscarLibro(Lista_biblioteca);
                            break;

                        case "3":
                            ModificarLibro(Lista_biblioteca);
                            break;

                        case "4":
                            EliminarLibro(Lista_biblioteca);
                            break;

                        case "5":
                            MostrarLibro(Lista_biblioteca);
                            break;

                        case "6":

                            break;

                        default:
                            Console.WriteLine("Operacion no valida");
                            break;
                    }

                }
            }

            static void AgregarLibro(List<Biblioteca> Lista_biblioteca)
            {
                string Agregar;
                do
                {
                    Console.WriteLine("Quieres agregar un libro SI/NO?");
                    Agregar = Console.ReadLine().ToUpper();
                    if (Agregar == "SI")
                    {
                        Console.WriteLine("Ingresa el nombre del libro");
                        string NombreLibro = Console.ReadLine();
                        Console.WriteLine("Ingresa el autor del libro");
                        string AutorLibro = Console.ReadLine();
                        Console.WriteLine("Ingresa la cantidad que tenes del libro");
                        int CantidadLibro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el codigo del libro");
                        int Codigo;
                        while (!int.TryParse(Console.ReadLine(), out Codigo))
                        {
                            Console.WriteLine("Operacion Invalida pon un codigo correcto");

                        }
                        Biblioteca biblioteca = new Biblioteca(NombreLibro, AutorLibro, CantidadLibro, Codigo);
                        Lista_biblioteca.Add(biblioteca);

                        Console.WriteLine("Libro creado Exitosamente");
                        Console.WriteLine(biblioteca);

                    }
                    else if (Agregar == "NO")
                    {
                        Console.WriteLine("Operacion cancelada");
                    }
                    Console.ReadKey();

                } while (Agregar == "SI");

            }

            static void BuscarLibro(List<Biblioteca> Lista_biblioteca)
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
                    Console.ReadKey();

                } while (Opcion == "SI");
            }


            static void ModificarLibro(List<Biblioteca> Lista_biblioteca)
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

                } while (OpcionUltra == "SI");
            }



            static void EliminarLibro(List<Biblioteca> Lista_biblioteca)
            {
                string opcion;

                do
                {
                    Console.WriteLine("Quieres eliminar un libro SI/NO?");
                    opcion = Console.ReadLine();

                    if (opcion == "SI")
                    {

                        Console.WriteLine("Ingresa el codigo del libro");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        Biblioteca biblioteca = Lista_biblioteca.Find(c => c.Codigo == codigo);
                        if (biblioteca != null)
                        {
                            Console.WriteLine($"Libro encontrado:{biblioteca}");

                            Console.WriteLine("Quieres eliminar este libro SI/NO?");
                            string OpcionMultiple = Console.ReadLine();

                            if (OpcionMultiple == "SI")
                            {
                                Lista_biblioteca.Remove(biblioteca);
                                Console.WriteLine("Libro eliminado exitosamente");

                            }

                            else
                            {
                                Console.WriteLine("Operacion cancelada");
                            }

                        }

                        else
                        {
                            Console.WriteLine("ERROR");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Operacion cancelada");
                    }
                    Console.ReadKey();

                } while (opcion == "SI");
            }


            static void MostrarLibro(List<Biblioteca> Lista_biblioteca)
            {
                Console.WriteLine("Lista de los libros");

                foreach (var biblioteca in Lista_biblioteca)
                {
                    Console.WriteLine(biblioteca);
                }
                Console.ReadKey();
            }


        static void ModuloUsuario(List<Usuario> Lista_Usuario)
         {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Iniciar sesion\n2.Registrarse");
                    string OpcionModuloUsuario = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (OpcionModuloUsuario)
                    {
                        case "1":
                         IniciarSesion(Lista_Usuario);
                        break;

                        case "2":

                        break;

                        default:
                            Console.WriteLine("Opcion no valida");
                        break;
                    }
                }

         }


            static void IniciarSesion(List<Usuario> Lista_Usuario)
            {
                Console.WriteLine("Ingresa su correo");
                string correo = Console.ReadLine();
                Console.WriteLine("Ingresa su contraseña");
                int contraseña = Convert.ToInt32(Console.ReadLine());

                Usuario usuario = Lista_Usuario.Find(c => c.Correo == correo);

                if (usuario != null && usuario.Contraseña==contraseña)
                {
                    Console.WriteLine($"Usuario Encontrado: {usuario}");

                    if (usuario.Correo.EndsWith("@Empleado.com"))
                    {
                        Console.WriteLine($"Bienvenido Empleado {usuario.NombreCompleto}");
                    }

                    else if (usuario.Correo.EndsWith("@Cliente.com"))
                    {
                        Console.WriteLine($"Bienvenido Cliente {usuario.NombreCompleto}");
                    }

                    else if (usuario.Correo.EndsWith("@Admin.com"))
                    {
                        Console.WriteLine($"Bienvenido Administrador {usuario.NombreCompleto}");
                    }

                    else
                    {
                        Console.WriteLine("Operacion invalida");
                    }
                    Console.ReadKey();

                }
            }


        }

    }

}
