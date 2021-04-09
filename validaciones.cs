using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;

namespace validaciones
{
    class Validaciones
    {
        public Boolean Vacio(string texto)
        {
            if (texto.Equals(""))
            {
                Console.WriteLine("La entrada no puede ser vacia        ");
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Boolean TipoNumero(string texto)
        {
            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$"); //regla valida si es texto

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine("La entrada debe ser numerica         ");
                return false;
            }
        }

        public Boolean TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");

            if (regla.IsMatch(texto))
                return true;
            else
            {
                Console.WriteLine("La entrada debe ser tipo texto");
                return false;
            }
        }

        public Boolean emailValido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Email no valido                     ");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Email no valido                        ");
                return false;
            }
        }

        public bool SiNo(string texto)
        {
            texto.ToLower(); // convertimos la entra en minuscula 

            if (texto.Equals("s") || texto.Equals("n"))
                return true;
            else
            {
                Console.WriteLine("La entrada debe ser S o N                ");
                return false;
            }
        }
    }
}


