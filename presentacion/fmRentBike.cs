using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fmrent
{
    public partial class fmRentBike : Form
    {

     
        Alquiler alquiler;
        public fmRentBike()
        {
            InitializeComponent();
            alquiler = new Alquiler();
          
            clientecbo.SelectedIndex = 0;
            horaAlquilertxt.Text = DateTime.Now.Hour.ToString();
            Horadevoluciontxt.Text = (DateTime.Now.Hour + 1).ToString();



        }

        

        private void Rentarbtn_Click(object sender, EventArgs e)
        {
            for (int i=0; i<bicicletas.CheckedItems.Count; i++)
           
            {
            
                string msg = this.alquiler.alquilarBike(bicicletas.CheckedItems[i].ToString(), fechaalquiler.Value, horaAlquilertxt.Text, minutoAlquilertxt.Text, "Hour", true, clientecbo.Text);
                registradosconfitxt.Text = msg;
                registradostxt.Text = this.alquiler.concatenarInfoBicicletas();
                ponerprecio();
            }

            laTotalRecaudado.Text="Total recaudado: "+this.alquiler.getTotalRecaudado().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagolabel.Text = "";

            pagolabel.Text = this.alquiler.devolverBicicleta(placadevoluciontxt.Text, fechadevolucion.Value, Horadevoluciontxt.Text, minutoDevoluciontxt .Text);
            registradostxt.Text = alquiler.concatenarInfoBicicletas();
               
        }

        private void ponerprecio()
        {

          double c=  this.alquiler.calcularPrecio_rentafamiliar("Hora", 3, 0);

          totaltxt.Text = c.ToString();
              ;
            /*
            double total = this.alquiler.calcularPrecio_rentafamiliar(bicicletas.CheckedItems.Count,fechaalquiler.Value, horaAlquilertxt.Text, minutoAlquilertxt.Text, fechadevolucion.Value, Horadevoluciontxt.Text, minutoDevoluciontxt.Text);            
            tipolabel.Text=this.alquiler.getTipo();
            tiempotxt.Text = this.alquiler.getTiempo().ToString();
            bikestxt.Text = bicicletas.CheckedItems.Count.ToString();

            subtotaltxt.Text = this.alquiler.calcularPrecio(fechaalquiler.Value, horaAlquilertxt.Text, minutoAlquilertxt.Text, fechadevolucion.Value, Horadevoluciontxt.Text, minutoDevoluciontxt.Text).ToString();

            

            descuentotxt.Text = this.alquiler.getDescuento().ToString();
            totaltxt.Text = total.ToString();
             * */

           
        }

        private void preciotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmRentBike_Load(object sender, EventArgs e)
        {

        }

    }
}
