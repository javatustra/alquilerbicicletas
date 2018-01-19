using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fmrent
{
    class Bike
    {
        private String placa;
        public Bike(String placa){
        
            this.placa = placa;
           

        }
        public String getPlaca()
        {
            return placa;
        }

        public void setPlaca(String placa)
        {
            this.placa = placa;
        }

    }
}
