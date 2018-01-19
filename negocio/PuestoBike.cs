using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fmrent
{
    class PuestoBike
    {
        private DateTime fecha_alquiler;
        private DateTime fecha_devolucion;
        private String hora_alquiler;
        private String minuto_alquiler;
        private String hora_devolucion;
        private String minuto_devolucion;
      
        private int numero;
        private String estado;
        private Bike bike;
        private Cliente cliente;

        public PuestoBike(int numero)
        {
            this.numero = numero;
            this.estado = "Libre";

        }
        public void asignarPuesto(Bike bike)
        {
            this.bike = bike;
        }

      

        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public Bike getBike()
        {
            return bike;
        }

        public void setBike(Bike bike)
        {
            this.bike = bike;
        }

        public Cliente  getCliente()
        {
            return this.cliente;
        }
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }


        public String libreString()
        {
            return "Puesto: " + this.getNumero()
                + "\nEstado: " + this.getEstado();
        }

        public String toString()
        {
            return "\n[Puesto: " + this.getNumero()
             + "\n Estado: " + this.getEstado()
             + "\n Placa: " + this.getBike().getPlaca()
               + "\n Cliente: " + this.getCliente().getDni()+"]";
           

           /*     return "\nPuesto: " + this.getNumero()
              + "\nEstado: " + this.getEstado()
              + "\nPlaca del bike: " + this.getBike().getPlaca()
              + "\nHora: " + this.getBike().getHora() + ":" + this.getBike().getMinuto()
              + "\nTipo: " + this.getBike().getTipo()
              + "\nFamilyrent: " + "SI";
            */

        }

        
        public String getHora_alquiler_()
        {
            return hora_alquiler;
        }

        public void setHora_alquiler(String hora)
        {
            this.hora_alquiler = hora;
        }

        public String getMinuto_alquiler()
        {
            return minuto_alquiler;
        }

        public void setMinuto_alquiler(String minuto)
        {
            this.minuto_alquiler = minuto;
        }


        public String getHora_devolucion_()
        {
            return hora_devolucion;
        }

        public void setHora_devolucion(String hora)
        {
            this.hora_devolucion = hora;
        }

        public String getMinuto_devolucion()
        {
            return minuto_devolucion;
        }

        public void setMinuto_devolucion(String minuto)
        {
            this.minuto_devolucion = minuto;
        }

        public DateTime getFecha_devolucion()
        {
            return fecha_devolucion;
        }

        public void setFecha_devolucion(DateTime fecha_devolucion)
        {
            this.fecha_devolucion = fecha_devolucion;
        }

        public DateTime getFecha_alquiler()
        {
            return fecha_devolucion;
        }

        public void setFecha_alquiler(DateTime fecha_alquiler)
        {
            this.fecha_alquiler = fecha_alquiler;
        }
      
      
        
    }
}