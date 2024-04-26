using Ejemplo_ventas;
using System;
// Ventas de la semana, cada venta tiene: 
// Codigo articulo, codigo cliente y cantidad vendida.
// El lote corta con codigo cliente = 0.


Telefono t1 = new Telefono("S21", "Samsung");
t1.numeroTelefonico = "3534188541";
Console.WriteLine("Escriba el codigo de operador: ");
t1.CodigoOperador = int.Parse(Console.ReadLine());
Console.WriteLine("El numero telefonico de su linea es: " + t1.numeroTelefonico + " Y el codigo de operador: " + t1.CodigoOperador);
Console.WriteLine("La marca del celular es: " + t1.marca + " Y el modelo: " + t1.modelo);

t1.Llamar("Maxi");

