using System;
using System.Collections.Generic;
using System.Text;

namespace notas
{
    class Pantallas
    {
        public void Menu()
        {
            for (int i = 30; i <= 80; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
                Console.SetCursorPosition(i, 7); Console.Write("═");
                Console.SetCursorPosition(i, 9); Console.Write("═");
                Console.SetCursorPosition(i, 11); Console.Write("═");
                Console.SetCursorPosition(i, 13); Console.Write("═");
                Console.SetCursorPosition(i, 15); Console.Write("═");
                Console.SetCursorPosition(i, 17); Console.Write("═");
                Console.SetCursorPosition(i, 19); Console.Write("═");
                Console.SetCursorPosition(i, 21); Console.Write("═");

            }
            for (int i = 2; i <= 21; i++)
            {
                Console.SetCursorPosition(29, i); Console.Write("║");
                Console.SetCursorPosition(80, i); Console.Write("║");
            }
            Console.SetCursorPosition(29, 1); Console.Write("╔");
            Console.SetCursorPosition(29, 21); Console.Write("╚");
            Console.SetCursorPosition(29, 5); Console.Write("╠");
            Console.SetCursorPosition(29, 7); Console.Write("╠");
            Console.SetCursorPosition(29, 9); Console.Write("╠");
            Console.SetCursorPosition(29, 11); Console.Write("╠");
            Console.SetCursorPosition(29, 13); Console.Write("╠");
            Console.SetCursorPosition(29, 15); Console.Write("╠");
            Console.SetCursorPosition(29, 17); Console.Write("╠");
            Console.SetCursorPosition(29, 19); Console.Write("╠");

            Console.SetCursorPosition(80, 1); Console.Write("╗");
            Console.SetCursorPosition(80, 21); Console.Write("╝");
            Console.SetCursorPosition(80, 5); Console.Write("╣");
            Console.SetCursorPosition(80, 7); Console.Write("╣");
            Console.SetCursorPosition(80, 9); Console.Write("╣");
            Console.SetCursorPosition(80, 11); Console.Write("╣");
            Console.SetCursorPosition(80, 13); Console.Write("╣");
            Console.SetCursorPosition(80, 15); Console.Write("╣");
            Console.SetCursorPosition(80, 17); Console.Write("╣");
            Console.SetCursorPosition(80, 19); Console.Write("╣");

        }

        public void Pagregar()
        {
            for (int i = 23; i <= 100; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
                Console.SetCursorPosition(i, 7); Console.Write("═");
                Console.SetCursorPosition(i, 9); Console.Write("═");
                Console.SetCursorPosition(i, 11); Console.Write("═");
                Console.SetCursorPosition(i, 13); Console.Write("═");
                Console.SetCursorPosition(i, 15); Console.Write("═");
                Console.SetCursorPosition(i, 17); Console.Write("═");
                Console.SetCursorPosition(i, 19); Console.Write("═");
                Console.SetCursorPosition(i, 21); Console.Write("═");
            }
            for (int i = 2; i <= 21; i++)
            {
                Console.SetCursorPosition(22, i); Console.Write("║");
                Console.SetCursorPosition(100, i); Console.Write("║");
            }
            Console.SetCursorPosition(22, 1); Console.Write("╔");
            Console.SetCursorPosition(22, 21); Console.Write("╚");
            Console.SetCursorPosition(22, 5); Console.Write("╠");
            Console.SetCursorPosition(22, 7); Console.Write("╠");
            Console.SetCursorPosition(22, 9); Console.Write("╠");
            Console.SetCursorPosition(22, 11); Console.Write("╠");
            Console.SetCursorPosition(22, 13); Console.Write("╠");
            Console.SetCursorPosition(22, 15); Console.Write("╠");
            Console.SetCursorPosition(22, 17); Console.Write("╠");
            Console.SetCursorPosition(22, 19); Console.Write("╠");

            Console.SetCursorPosition(100, 1); Console.Write("╗");
            Console.SetCursorPosition(100, 21); Console.Write("╝");
            Console.SetCursorPosition(100, 5); Console.Write("╣");
            Console.SetCursorPosition(100, 7); Console.Write("╣");
            Console.SetCursorPosition(100, 9); Console.Write("╣");
            Console.SetCursorPosition(100, 11); Console.Write("╣");
            Console.SetCursorPosition(100, 13); Console.Write("╣");
            Console.SetCursorPosition(100, 15); Console.Write("╣");
            Console.SetCursorPosition(100, 17); Console.Write("╣");
            Console.SetCursorPosition(100, 19); Console.Write("╣");
        }

        public void PListar()
        {

            //esquinas 

            Console.SetCursorPosition(2, 1); Console.Write("╔");
            Console.SetCursorPosition(2, 5); Console.Write("╚");

            Console.SetCursorPosition(115, 1); Console.Write("╗");
            Console.SetCursorPosition(115, 5); Console.Write("╝");

            // bordes laterales

            for (int i = 2; i <= 4; i++)
            {
                Console.SetCursorPosition(2, i); Console.Write("║");
                Console.SetCursorPosition(115, i); Console.Write("║");
            }

            // bordes horizontales

            for (int i = 3; i <= 114; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
            }

            // mensaje principal 

            Console.SetCursorPosition(50, 3); Console.Write("LISTA DE ESTUDIANTES");
        }

        public void PBuscar()
        {
            //esquinas 

            Console.SetCursorPosition(2, 1); Console.Write("╔");
            Console.SetCursorPosition(2, 5); Console.Write("╚");

            Console.SetCursorPosition(115, 1); Console.Write("╗");
            Console.SetCursorPosition(115, 5); Console.Write("╝");

            // bordes laterales

            for (int i = 2; i <= 4; i++)
            {
                Console.SetCursorPosition(2, i); Console.Write("║");
                Console.SetCursorPosition(115, i); Console.Write("║");
            }

            // mensaje principal 

            Console.SetCursorPosition(50, 3); Console.Write("BUSCAR ESTUDIANTES");

            // bordes horizontales

            for (int i = 3; i <= 114; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
            }
        }
        public void PActualizar()
        {
            //esquinas 

            Console.SetCursorPosition(2, 1); Console.Write("╔");
            Console.SetCursorPosition(2, 5); Console.Write("╚");

            Console.SetCursorPosition(115, 1); Console.Write("╗");
            Console.SetCursorPosition(115, 5); Console.Write("╝");

            // bordes laterales

            for (int i = 2; i <= 4; i++)
            {
                Console.SetCursorPosition(2, i); Console.Write("║");
                Console.SetCursorPosition(115, i); Console.Write("║");
            }

            // mensaje principal 

            Console.SetCursorPosition(50, 3); Console.Write("ACTUALIZAR ESTUDIANTES");

            // bordes horizontales

            for (int i = 3; i <= 114; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
            }
        }
        public void PActualizar2()
        {
            for (int i = 23; i <= 100; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
                Console.SetCursorPosition(i, 7); Console.Write("═");
                Console.SetCursorPosition(i, 9); Console.Write("═");
                Console.SetCursorPosition(i, 11); Console.Write("═");
                Console.SetCursorPosition(i, 13); Console.Write("═");
                Console.SetCursorPosition(i, 15); Console.Write("═");
                Console.SetCursorPosition(i, 17); Console.Write("═");
                Console.SetCursorPosition(i, 19); Console.Write("═");
                Console.SetCursorPosition(i, 21); Console.Write("═");
                Console.SetCursorPosition(i, 24); Console.Write("═");
                Console.SetCursorPosition(i, 27); Console.Write("═");
            }
            for (int i = 2; i <= 21; i++)
            {
                Console.SetCursorPosition(22, i); Console.Write("║");
                Console.SetCursorPosition(100, i); Console.Write("║");
            }

            for (int i = 24; i <= 27; i++)
            {
                Console.SetCursorPosition(22, i); Console.Write("║");
                Console.SetCursorPosition(100, i); Console.Write("║");
            }

            Console.SetCursorPosition(22, 24); Console.Write("╔");
            Console.SetCursorPosition(22, 27); Console.Write("╚");

            Console.SetCursorPosition(100, 24); Console.Write("╗");
            Console.SetCursorPosition(100, 27); Console.Write("╝");

            Console.SetCursorPosition(22, 1); Console.Write("╔");
            Console.SetCursorPosition(22, 21); Console.Write("╚");
            Console.SetCursorPosition(22, 5); Console.Write("╠");
            Console.SetCursorPosition(22, 7); Console.Write("╠");
            Console.SetCursorPosition(22, 9); Console.Write("╠");
            Console.SetCursorPosition(22, 11); Console.Write("╠");
            Console.SetCursorPosition(22, 13); Console.Write("╠");
            Console.SetCursorPosition(22, 15); Console.Write("╠");
            Console.SetCursorPosition(22, 17); Console.Write("╠");
            Console.SetCursorPosition(22, 19); Console.Write("╠");

            Console.SetCursorPosition(100, 1); Console.Write("╗");
            Console.SetCursorPosition(100, 21); Console.Write("╝");
            Console.SetCursorPosition(100, 5); Console.Write("╣");
            Console.SetCursorPosition(100, 7); Console.Write("╣");
            Console.SetCursorPosition(100, 9); Console.Write("╣");
            Console.SetCursorPosition(100, 11); Console.Write("╣");
            Console.SetCursorPosition(100, 13); Console.Write("╣");
            Console.SetCursorPosition(100, 15); Console.Write("╣");
            Console.SetCursorPosition(100, 17); Console.Write("╣");
            Console.SetCursorPosition(100, 19); Console.Write("╣");
        }

        public void PBorrar()
        {
            //esquinas 

            Console.SetCursorPosition(2, 1); Console.Write("╔");
            Console.SetCursorPosition(2, 5); Console.Write("╚");

            Console.SetCursorPosition(115, 1); Console.Write("╗");
            Console.SetCursorPosition(115, 5); Console.Write("╝");

            // bordes laterales

            for (int i = 2; i <= 4; i++)
            {
                Console.SetCursorPosition(2, i); Console.Write("║");
                Console.SetCursorPosition(115, i); Console.Write("║");
            }

            // mensaje principal 

            Console.SetCursorPosition(50, 3); Console.Write("BORRAR ESTUDIANTES");

            // bordes horizontales

            for (int i = 3; i <= 114; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 5); Console.Write("═");
            }
        }
    }
}
