using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGreivin.Models
{
    class Concesionario
    {
        public Concesionario()
        {
            this.coches = new List<Vehiculo>();
        }

        private List<Vehiculo> coches;

        public void aniadirCoche(Vehiculo c)
        {
            this.coches.Add(c);
        }
        public void mostrarCoches()
        {
            Console.WriteLine(this.coches);
        }
       public void vaciarCoches()
        {
            this.coches.Clear();
        }
       public void eliminarCoche(Vehiculo c)
        {
            this.coches.Remove(c);
        }

    }
}
