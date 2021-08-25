using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGreivin.Models
{
    class Moto : Vehiculo
    {
        public Moto(int id, string marca, string modelo, float km, float precio, bool sider) : base(id, marca, modelo, km, precio)
        {
            this.Sidecar = sider; 
        }

        private bool Sidecar { get; set; }
        protected override float Precio {
            set
            {
                if (this.Sidecar)
                {
                    this.Precio += 50;
                }
            }
        }
    }
}
