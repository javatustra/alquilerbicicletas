using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fmrent
{
    class Alquiler
    {
      
        List<PuestoBike> Puestos;
      //  List<Bike> Bikes;
       // List<Cliente> Clientes;
        private int tarifaHora;
        private int tarifaFraccion;
        private int tarifaDia;
        private int tarifaDiaFraccion;
        private int tarifaSemana;
        private int tarifaSemanaFraccion;
        private int totalRecaudado;
        const String ALQUILADO = "Alquilado";
        const String LIBRE = "Libre"; //cuando no esta alquilado
        private String tipo;
        private int tiempo;
        public Alquiler()
        {
            this.Puestos = new List<PuestoBike>();
            this.tarifaHora = 5;
            this.tarifaFraccion = 5;
            this.tarifaDia =20;
            this.tarifaDiaFraccion = 20;
            this.tarifaSemana = 60;
            this.tarifaSemanaFraccion = 60;
            this.crearPuestos();

         }
        //crear puestos y las bicicletas a alquilar.
        private void crearPuestos()
        {
           
            for (int i = 0; i < 8; i++)
            {

                PuestoBike puesto = new PuestoBike(i + 1);
                Bike bike = new Bike("BICICLETA" + (i + 1).ToString());
                puesto.asignarPuesto(bike);
                puesto.setEstado(LIBRE);
                this.Puestos.Add(puesto);
            }
            

        }
             /**
          * Método para alquilar  una bicileta.
          * Se busca una bicicleta disponible 
          * la bicileta y se retorna true, indicando que se pude alquilar
          * Si no se encuentra ninguna libre se retorna mensaje ,
          * indicado que no se pudo alquilar.
          * @param  la bicileta que se desea parquear
          * @return  true si se pudo parquear o false en caso contrario
          */
        public String alquilarBike(String placa, DateTime fecha, String hora, String minuto, String tipo, bool familyrent, String cliente)
        {
            String men = "No hay disponibles para alquilar bicicletas";

            if (this.buscarBicicleta(placa) == null)
                return "La bicicleta ya esta Alquilado a un cliente";

            if (this.posision_aAlquilar(placa) >=0) //1,2,3,4
            {
                Bike Bike = new Bike(placa);//,fecha.Year,fecha.Month,fecha.Day, hora, minuto, tipo, familyrent,cliente);
                int pos=this.posision_aAlquilar(placa);
                this.Puestos[pos].setEstado(ALQUILADO);
                this.Puestos[pos].setCliente(new Cliente(cliente, ""));
                return "Bike Alquilado  con exito";
            }
            
            return men;
        }

        /**
          * Método para devolver una bicicleta al parqueadero, dada su placa.
          * se retorna true, indicando que si se pudo sacar la bicileta.
          * Si  no se encuentra la bicicleta, se retorna false.
          * @param placa la placa de la bicicleta que se desea devolver al paqueadero
          * @return  true si se pudo devolver la bicileta o false en caso contrario
          */ 
        public String devolverBicicleta(String placa, DateTime fecha,String hora, String minutos)
        {
            String mensaje = "No existe ninguna bicicleta con ese codigo";


                for (int i = 0; i < this.Puestos.Count; i++)
                    if (this.Puestos[i].getEstado().Equals(ALQUILADO) &&
                            this.Puestos[i].getBike().getPlaca().Equals(placa))
                    {
                        //this.Puestos[i].setBike(null);
                        this.Puestos[i].setEstado("Libre");
                        this.Puestos[i].setCliente(null);
                        return "Se ha devuelto correctamente ";
                    }
           
            return mensaje;
        }

       
        public String InfoPuestosLibres(){
        String libres = "";
        
        foreach(PuestoBike  p in Puestos)
           if(p!=null && p.getEstado().Equals("Libre"))
               libres += p.libreString()+"\n\n";
                
        return libres;
    }

        //----------------------REQUERIMIENTOS OPERACIONALES----------------------//
        public Bike buscarBicicleta(String placa){
        Bike  bike = null;
        
       foreach(PuestoBike p in Puestos)
            if(p.getEstado().Equals(LIBRE) &&
                    p.getBike().getPlaca().Equals(placa))
               bike = p.getBike();
      
        return bike;
    }

        public int posision_aAlquilar(String placa ){


            foreach (PuestoBike p in Puestos)
            
            if(p.getEstado().Equals("Libre")&&
                    p.getBike().getPlaca().Equals(placa))
                return (p.getNumero()-1);
        
        return -1;
    }

        public int calcularPrecio(DateTime fechaAlquiler, String horaAlquiler, String minutoAlquiler, DateTime fechaDevolucion, String horaDevolcuion, String minutoDevolucion)
        {
             this.tipo = "Hora";
            int costo = 0;
            int cantHoras = Int32.Parse(horaDevolcuion) - Int32.Parse(horaAlquiler);
            int cantMinutos = Int32.Parse(minutoDevolucion) - Int32.Parse(minutoAlquiler);
            //calcular 
         
            TimeSpan ts = fechaDevolucion.Date  - fechaAlquiler.Date ;
            int cantDias = ts.Days;
            int cantSemanas = cantDias / 7;
         
            if (cantSemanas >= 1) this.tipo = "Semana";
            else if (cantDias >= 1) this.tipo = "Dia";
            

            switch (this.tipo)
            {
                case "Hora":
                    
                   costo = cantHoras * this.getTarifaHora();
                   tiempo = cantHoras;
                   
                    break;
                case "Dia":
                     costo = cantDias * this.getTarifaDia();
                     tiempo = cantDias;

                    break;
                case "Semana":
                     costo = cantSemanas * this.getTarifaSemana();
                     tiempo = cantSemanas;
                    break;
            }

            this.setTotalRecaudado(this.getTotalRecaudado() + costo);

            return costo;
           
        }

        
        public String concatenarPlacasBicicletas()
        {
            String carros = "";

            for (int i = 0; i < this.Puestos.Count ; i++)
                if (this.Puestos[i].getEstado().Equals(ALQUILADO))
                    carros += this.Puestos[i].getBike().getPlaca() + "~";

            return carros;
        }

        public String concatenarInfoBicicletas(){
        String info = "";
        
        foreach(PuestoBike p in Puestos)
            if (p.getEstado().Equals(ALQUILADO))
                info += p.toString()+"\n\n";
        
        return info;
    }

        //------------------------Getter's y Setter's-----------------------------//
        public int getTarifaHora()
        {
            return tarifaHora;
        }

        public void setTarifaHora(int tarifaHora)
        {
            this.tarifaHora = tarifaHora;
        }

        public int getTarifaFraccion()
        {
            return tarifaFraccion;
        }

        public void setTarifaFraccion(int tarifaFraccion)
        {
            this.tarifaFraccion = tarifaFraccion;
        }

        public int getTarifaDia()
        {
            return tarifaDia;
        }

        public void setTarifaDia(int tarifaDia)
        {
            this.tarifaDia = tarifaDia;
        }

        public int getTarifaDiaFraccion()
        {
            return tarifaDiaFraccion;
        }

        public void setTarifaDiaFraccion(int tarifaDiaFraccion)
        {
            this.tarifaDiaFraccion = tarifaDiaFraccion;
        }

        public int getTarifaSemana()
        {
            return tarifaSemana;
        }

        public void setTarifaSemana(int tarifaSemana)
        {
            this.tarifaSemana = tarifaSemana;
        }

        public int getTarifaSemanaFraccion()
        {
            return tarifaSemanaFraccion;
        }

        public void setTarifaSemanaFraccion(int tarifaSemanaFraccion)
        {
            this.tarifaSemanaFraccion = tarifaSemanaFraccion;
        }

        public int getTotalRecaudado()
        {
            return totalRecaudado;
        }

        public void setTotalRecaudado(int totalRecaudado)
        {
            this.totalRecaudado = totalRecaudado;
        }
        public String getTipo()
        {
            return tipo;
        }

        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public int  getTiempo()
        {
            return tiempo ;
        }

        public void setTiempo(int tiempo)
        {
            this.tiempo = tiempo ;
        }

    }

      
    
}
