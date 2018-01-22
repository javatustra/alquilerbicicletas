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
            double  descuento = 0;
            int precio = this.alquiler.calcularPrecio(fechaalquiler.Value, horaAlquilertxt.Text, minutoAlquilertxt.Text, fechadevolucion.Value, Horadevoluciontxt.Text, minutoDevoluciontxt.Text);            
            tipolabel.Text=this.alquiler.getTipo();
            tiempotxt.Text = this.alquiler.getTiempo().ToString();
            bikestxt.Text = bicicletas.CheckedItems.Count.ToString();
            preciotxt.Text = (bicicletas.CheckedItems.Count * precio).ToString();
            if (bicicletas.CheckedItems.Count >= 3 && bicicletas.CheckedItems.Count <= 5)
            {


                descuento =0.3 * Int16.Parse(preciotxt.Text);

            }
            descuentotxt.Text = descuento.ToString();
            totaltxt.Text = (Int16.Parse(preciotxt.Text) - descuento).ToString();

           
        }

        private void preciotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmRentBike_Load(object sender, EventArgs e)
        {

        }

    }
}
