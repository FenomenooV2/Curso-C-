using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejemplo_ventas
{
    class Telefono
    {
        public string numeroTelefonico {  get; set; }
        public string modelo { get; }
        public string marca { get; }

        private int codigoOperador;

        public int CodigoOperador { 
            get { return codigoOperador; } 
            set {if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public void Llamar(string Contacto)
        {
            Console.WriteLine("Llamando a " + Contacto + "...");
        }

        public void Llamar() 
        {
            Console.WriteLine("Llamando...");
        }
        
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
    }
}

