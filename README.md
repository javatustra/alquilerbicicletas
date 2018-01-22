#Visual Studio c#- programaing and testing

Este material contiene .
"codigo fuente de alquiler de bicicletas"
"Pruebas unitarias en visual studio net"
"covertura de codigo con opencover y reportgenerator"


Para utilizar los ejemplos son necesarias algunas herramientas, en particular yo utilizo Visual studio.net y:

1.-Opencover
2.-reportGenerator

##Clases
esta en la carpeta negocio
	Alquiler.cs
	Bike.cs
	Cliente.cs
	PuestoBike.cs

##Presentación
esta en la carpeta presentacion
	fmRentBike.cs
##Pruebas unitarias
	esta en la carpeta TestRentBike
##Covertura de codigo
	Esta en la carpeta Report

##funciones importantes para calcular alquiler de biciletas.
	 public String alquilarBike(String placa, DateTime fecha, String hora, String minuto, String tipo, bool familyrent, String cliente)
         public String devolverBicicleta(String placa, DateTime fecha,String hora, String minutos)
         public int calcularPrecio(DateTime fechaAlquiler, String horaAlquiler, String minutoAlquiler, DateTime fechaDevolucion, String 						   horaDevolcuion, String minutoDevolucion)
      



##la programacion y las pruebas se hace respecto a esta logica
A company rents bikes under following options:


1. Rental by hour, charging $5 per hour

2. Rental by day, charging $20 a day

3. Rental by week, changing $60 a week

4. Family Rental, is a promotion that can include from 3 to 5 Rentals (of any type) with a discount of 30% of the total price

