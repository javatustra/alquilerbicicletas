using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fmrent
{
    class Cliente
    {
        private String codigo;
        private String nombre ;

        public Cliente(String codigo, String nombre)
        {
            this.codigo = codigo;
            this.nombre=nombre;
        }

        public String getDni()
        {
            return codigo;
        }

        public void setDni(String codigo)
        {
            this.codigo = codigo;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre= nombre ;
        }
       
    }
}
