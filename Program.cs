using System;
using System.Collections.Generic;
using validaciones;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using notas;

namespace notas
{
    class Program
    {   
        static Pantallas screen = new Pantallas();
        static Validaciones Validar = new Validaciones();
        static void Main(string[] args)
        {
            int opc;
            string aux;

            do
            {
                bool seguir = false;
                Console.Clear();
                screen.Menu();
                Console.SetCursorPosition(40, 3); Console.Write("Menú principal");
                Console.SetCursorPosition(40, 6); Console.Write("1. Agregar estudiantes");
                Console.SetCursorPosition(40, 8); Console.Write("2. Listar estudiantes");
                Console.SetCursorPosition(40, 10); Console.Write("3. Buscar estudiantes");
                Console.SetCursorPosition(40, 12); Console.Write("4. actualizar estudiante");
                Console.SetCursorPosition(40, 14); Console.Write("5. borrar estudiante");
                Console.SetCursorPosition(40, 16); Console.Write("0. salir de la aplicación");

                do
                {
                    Console.SetCursorPosition(40, 18); Console.Write("Digite una opción: ");
                    aux = Console.ReadLine();
                    Console.SetCursorPosition(40, 20);
                    if (!Validar.Vacio(aux))
                        if (Validar.TipoNumero(aux))
                            seguir = true;
                } while (!seguir);

                opc = Convert.ToInt32(aux);

                switch (opc)
                {
                    case 1:
                        InsertarAlumno();
                        break;
                    case 2:
                        ListarAlumnos();
                        break;
                    case 3:
                        BuscarAlumnos();
                        break;
                    case 4:
                        ActualizarAlumnos();
                        break;
                    case 5:
                        BorrarAlumnos();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.SetCursorPosition(40, 20); Console.Write("opción no válida              ");
                        break;

                }

                Console.ReadKey();

            } while (opc != 0);

        }
        static void InsertarAlumno()
        {
            var db = new proyecto_sena_t2Context();
            var estudiantesagr = db.Estudiantes.ToList();
            string nombre, idaux, email, not1, not2, not3;
            bool correoValido = false;
            bool nombrevalido = false;
            bool idvalido = false;
            bool nota1valido = false;
            bool nota2valido = false;
            bool nota3valido = false;
            bool entradaValida = false;
            string continuar = "s";


            do
            {
                Console.Clear();
                screen.Pagregar();
                Console.SetCursorPosition(35, 3); Console.WriteLine("Agregando Estudiante... ");

                do
                {
                    Console.SetCursorPosition(25, 6); Console.Write("Inserte el id del estudiante: ");
                    idaux = Console.ReadLine();
                    if (!Validar.Vacio(idaux))
                        if (Validar.TipoNumero(idaux))
                            idvalido = true;
                } while (!idvalido);

                    if (Existe(Convert.ToInt32(idaux)))
                    {
                    Console.SetCursorPosition(23, 20); 
                    Console.Write("El id " + idaux + " Ya existe en el sistema. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    }
                    else
                    {
                        do
                        {
                            Console.SetCursorPosition(25, 8); Console.Write("Digite nombre estudiante: ");
                            nombre = Console.ReadLine();
                            Console.SetCursorPosition(25, 20);
                            if (!Validar.Vacio(nombre))
                                if (Validar.TipoTexto(nombre))
                                    nombrevalido = true;
                        } while (!nombrevalido);


                        do
                        {
                            Console.SetCursorPosition(25, 10); Console.Write("Digite correo estudiante: ");
                            email = Console.ReadLine();
                            Console.SetCursorPosition(25, 20);
                            if (!Validar.Vacio(email))
                                if (Validar.emailValido(email))
                                    correoValido = true;
                        } while (!correoValido);

                        do
                        {
                            Console.SetCursorPosition(25, 12); Console.Write("Digite la nota 1 del estudiante: ");
                            not1 = Console.ReadLine();
                            Console.SetCursorPosition(25, 20);
                            if (!Validar.Vacio(not1))
                                if (Validar.TipoNumero(not1))
                                    nota1valido = true;

                        } while (!nota1valido);

                        do
                        {
                            Console.SetCursorPosition(25, 14); Console.Write("Digite la nota 2 del estudiante: ");
                            not2 = Console.ReadLine();
                            Console.SetCursorPosition(25, 20);
                            if (!Validar.Vacio(not2))
                                if (Validar.TipoNumero(not2))
                                    nota2valido = true;

                        } while (!nota2valido);

                        do
                        {
                            Console.SetCursorPosition(25, 16); Console.Write("Digite la nota 3 del estudiante: ");
                            not3 = Console.ReadLine();
                             Console.SetCursorPosition(25, 20);
                            if (!Validar.Vacio(not3))
                                if (Validar.TipoNumero(not3))
                                    nota3valido = true;

                        } while (!nota3valido);
                        
                        Estudiantes itemEstudiante = new Estudiantes();
                        itemEstudiante.Codigo = Convert.ToUInt32(idaux);
                        itemEstudiante.Nombre = nombre;
                        itemEstudiante.Correo = email;
                        itemEstudiante.Nota1 = (double)Convert.ToDecimal(not1);
                        itemEstudiante.Nota2 = (double)Convert.ToDecimal(not2);
                        itemEstudiante.Nota3 = (double)Convert.ToDecimal(not3);

                        db.Estudiantes.Add(itemEstudiante);
                        db.SaveChanges();

                             do
                             {
                                Console.SetCursorPosition(25, 18); Console.Write("Desea agregar otro estudiante? S/N: ");
                                continuar = (Console.ReadLine());
                                Console.SetCursorPosition(25, 20);
                                 if (!Validar.Vacio(continuar))
                                    if (Validar.SiNo(continuar))
                                 entradaValida = true;
                             } while (!entradaValida);
                    }
                

            } while ((continuar == "s") || (continuar == "S"));
            Console.WriteLine("Saliendo al menú principal, por favor digite una tecla cualquiera.");
        }
        static void ListarAlumnos()
            {
            var db = new proyecto_sena_t2Context();
            var estudiantes = db.Estudiantes.ToList();
            double notafinal = 0;

            int y = 10;
            Console.Clear();
            screen.PListar();

            Console.SetCursorPosition(5, y); Console.Write("ID");
            Console.SetCursorPosition(15, y); Console.Write("Nombre");
            Console.SetCursorPosition(35, y); Console.Write("correo");
            Console.SetCursorPosition(50, y); Console.Write("nota 1");
            Console.SetCursorPosition(65, y); Console.Write("nota 2");
            Console.SetCursorPosition(80, y); Console.Write("nota 3");
            Console.SetCursorPosition(90, y); Console.Write("nota final");
            Console.SetCursorPosition(105, y); Console.Write("Estado");
            Console.Write("\n");
            y = 11;
            foreach (var itemEstudiante in estudiantes)
            {
                y++;

                notafinal = (double)((itemEstudiante.Nota1 + itemEstudiante.Nota2 + itemEstudiante.Nota3) / 3);
                notafinal = Math.Round(notafinal, 1);
                if (notafinal >= Convert.ToDouble(3.5))
                {
                    Console.SetCursorPosition(105, y); Console.Write("aprobado");
                }
                else
                {
                    Console.SetCursorPosition(105, y); Console.Write("reprobado");
                }

                Console.SetCursorPosition(5, y); Console.Write(itemEstudiante.Codigo);
                Console.SetCursorPosition(15, y); Console.Write(itemEstudiante.Nombre);
                Console.SetCursorPosition(35, y); Console.Write(itemEstudiante.Correo);
                Console.SetCursorPosition(50, y); Console.Write(itemEstudiante.Nota1);
                Console.SetCursorPosition(65, y); Console.Write(itemEstudiante.Nota2);
                Console.SetCursorPosition(80, y); Console.Write(itemEstudiante.Nota3);
                Console.SetCursorPosition(95, y); Console.Write(notafinal);
            }

            Console.SetCursorPosition(5, 7); Console.Write("Pulse cualquier tecla para volver al menu principal: ");

        }
        static void BuscarAlumnos()
        {
            string cod;
            bool CodigoValido = false;

            Console.Clear();
            screen.PBuscar();
            do
            {
                Console.SetCursorPosition(5, 7); Console.Write("Digite el código del estudiante que desea buscar: ");
                cod = Console.ReadLine();
                if (!Validar.Vacio(cod))
                    if (Validar.TipoNumero(cod))
                        CodigoValido = true;
            } while (!CodigoValido);

            if (Existe(Convert.ToInt32(cod)))
            {
                Estudiantes itemEstudiante = ObtenerDatos(Convert.ToInt32(cod));
                Console.SetCursorPosition(5, 10); Console.Write("Codigo: " + itemEstudiante.Codigo + "\t Nombre: " + itemEstudiante.Nombre + "\t  correo " + itemEstudiante.Correo + "\t  nota 1: " + itemEstudiante.Nota1 + "\t  nota 2: " + itemEstudiante.Nota2 + "\t  nota 3: " + itemEstudiante.Nota3);
                Console.SetCursorPosition(5, 12); Console.Write("Presione cualquier tecla para volver al menú principal...");
            }
            else
            {
                Console.SetCursorPosition(5, 10); Console.Write("El usuario " + cod + " no existe en el sistema.");
                Console.SetCursorPosition(5, 12); Console.Write("Presione cualquier tecla para volver al menú principal...");
            }
        }
        static void ActualizarAlumnos()
        {
            Console.Clear();
            screen.PActualizar();
            var db = new proyecto_sena_t2Context();
            string cod, aux, nom, email;
            bool CodigoValido = false, NombreValido = false, CorreoValido = false;
            int opc;

            do
            {
                Console.SetCursorPosition(5, 7); Console.Write("Digite Codigo estudiante que desea actualizar: ");
                cod = Console.ReadLine();
                if (!Validar.Vacio(cod))
                    if (Validar.TipoNumero(cod))
                        CodigoValido = true;
            } while (!CodigoValido);

            if (Existe(Convert.ToInt32(cod)))
            {
                do
                {
                    Console.Clear();
                    screen.PActualizar2();
                    bool seguir = false;
                    Estudiantes itemEstudiante = db.Estudiantes.Find(Convert.ToUInt32(cod));
                    Console.SetCursorPosition(30, 2); Console.Write("Codigo: " + itemEstudiante.Codigo + "\t Nombre: " + itemEstudiante.Nombre + "\t Correo: " + itemEstudiante.Correo);
                    Console.SetCursorPosition(30, 4); Console.Write("Digite el número del atributo que desea cambiar del estudiante:");
                    Console.SetCursorPosition(30, 6); Console.Write("1. Nombre");
                    Console.SetCursorPosition(30, 8); Console.Write("2. Correo");
                    Console.SetCursorPosition(30, 10); Console.Write("3. Nota 1");
                    Console.SetCursorPosition(30, 12); Console.Write("4. Nota 2");
                    Console.SetCursorPosition(30, 14); Console.Write("5. Nota 3");
                    Console.SetCursorPosition(30, 16); Console.Write("0. Cancelar - Volver al menú principal");
                    do
                    {
                        Console.SetCursorPosition(30, 18); Console.Write("Digite una opción: ");
                        aux = Console.ReadLine();
                        Console.SetCursorPosition(30, 20);
                        if (!Validar.Vacio(aux))
                            if (Validar.TipoNumero(aux))
                                seguir = true;
                    } while (!seguir);
                    opc = Convert.ToInt32(aux);
                    switch (opc)
                    {

                        case 1:
                            do
                            {
                                Console.Write("Digite nuevo nombre del estudiante: ");
                                nom = Console.ReadLine();
                                if (!Validar.Vacio(nom))
                                    if (Validar.TipoTexto(nom))
                                        NombreValido = true;
                                itemEstudiante.Nombre = nom;
                                Console.SetCursorPosition(30, 25); Console.Write("Nombre actualizado con éxito.");
                            } while (!NombreValido);
                            break;
                        case 2:
                            do
                            {
                                Console.Write("Digite nuevo correo del estudiante: ");
                                email = Console.ReadLine();
                                if (!Validar.Vacio(email))
                                    if (Validar.emailValido(email))
                                        CorreoValido = true;
                                itemEstudiante.Correo = email;
                                Console.SetCursorPosition(30, 25); Console.Write("Correo actualizado con éxito.");
                            } while (!CorreoValido);
                            break;
                        case 3:
                            Console.Write("Digite la nueva nota 1: ");
                            double not1 = double.Parse(Console.ReadLine());
                            itemEstudiante.Nota1 = not1;
                            Console.SetCursorPosition(30, 25); Console.Write("Nota 1 actualizada con éxito.");
                            break;
                        case 4:
                            Console.Write("Digite la nueva nota 2: ");
                            double not2 = double.Parse(Console.ReadLine());
                            itemEstudiante.Nota2 = not2;
                            Console.SetCursorPosition(30, 25); Console.Write("Nota 2 actualizada con éxito.");
                            break;
                        case 5:
                            Console.Write("Digite la nueva nota 3: ");
                            double not3 = double.Parse(Console.ReadLine());
                            itemEstudiante.Nota3 = not3;
                            Console.SetCursorPosition(30, 25); Console.Write("Nota 3 actualizada con éxito.");
                            break;
                        case 0:
                            Console.WriteLine("Volviendo al menu principal...");
                            break;
                        default:
                            Console.SetCursorPosition(30, 20); Console.Write("Opción no válida, pulse una tecla para continuar...");
                            Console.ReadKey();
                            break;

                    }
                    Console.SetCursorPosition(30, 26); Console.Write("Pulse cualquier tecla para continuar");
                    Console.ReadKey();

                    db.Estudiantes.Update(itemEstudiante);
                    db.SaveChanges();
                
                } while (opc != 0);   
            }
            else
            {
                Console.WriteLine("El Usuario " + cod + " NO  existe en el sistema");
            }
        }
        static void BorrarAlumnos()
        {
            var db = new proyecto_sena_t2Context();
            var estudiantes = db.Estudiantes.ToList();
            string cod, continuar;
            bool CodigoValido = false, entradaValida = false;

            Console.Clear();
            screen.PBorrar();
            do
            {
                Console.SetCursorPosition(7, 6); Console.Write("Digite el código del estudiante que desea borrar: ");
                cod = Console.ReadLine();
                if (!Validar.Vacio(cod))
                    if (Validar.TipoNumero(cod))
                        CodigoValido = true;
            } while (!CodigoValido);

            if (Existe(Convert.ToInt32(cod)))
            {
                foreach (var itemEstudiante in estudiantes)
                {
                    if (itemEstudiante.Codigo == (Convert.ToInt32(cod)))
                    {
                        do
                        {
                            Console.SetCursorPosition(7, 7); Console.Write("Estás seguro que deseas eliminar al estudiante "+ itemEstudiante.Nombre +" con el código "+ itemEstudiante.Codigo+" ? S / N");
                            continuar = (Console.ReadLine());
                            Console.SetCursorPosition(7, 8);
                            if (!Validar.Vacio(continuar))
                                if (Validar.SiNo(continuar))
                                    entradaValida = true;
                        } while (!entradaValida);

                        if (continuar == "s")
                        {
                            db.Estudiantes.Remove(itemEstudiante);
                            db.SaveChanges();
                            Console.WriteLine("Alumno eliminado con éxito");
                            Console.SetCursorPosition(7, 9); Console.Write("Presione ENTER para volver al menú principal...");
                        }
                        else
                        {
                            Console.SetCursorPosition(7, 8); Console.Write("Presione ENTER para volver al menú principal...");
                            break;
                        }
                    }
                }              
            }
            else
            {
                Console.SetCursorPosition(7, 7); Console.Write("El Usuario " + cod + " no existe en el sistema");
                Console.SetCursorPosition(7, 8); Console.Write("Presione ENTER para volver al menú principal...");
            }

        }
        static bool Existe(int number)
        {
            var db = new proyecto_sena_t2Context();
            var estudiantes = db.Estudiantes.ToList();
            bool aux = false;
            foreach (var itemEstudiante in estudiantes)
            {
                if (itemEstudiante.Codigo == number)
                    aux = true;
            }
            return aux;
        }
        static Estudiantes ObtenerDatos(int cod)
        {
            var db = new proyecto_sena_t2Context();
            var estudiantes = db.Estudiantes.ToList();
            foreach (var itemEstudiante in estudiantes)
            {
                if (itemEstudiante.Codigo == cod)
                    return itemEstudiante;
            }
            return null;
        }
    }
}