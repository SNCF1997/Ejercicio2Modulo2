using System;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true},
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25, 10, 99, 105, 1, 84, 22 };

            Console.WriteLine("Ejercicio 1: ");
            int maximoLstNum = lstNumeros.Max();
            Console.WriteLine(maximoLstNum.ToString());
            Console.WriteLine();
            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };
            
            Console.WriteLine("Ejercicio2: ");
            var nombrOrdenados = lstNombres.Order();
            foreach ( var item in nombrOrdenados ) {  Console.WriteLine(item.ToString()); }
            Console.WriteLine();
            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola

            Console.WriteLine("Ejercicio 3: ");
            var clientesVip = from vipcliente in lstClientes
                              where vipcliente.Vip == true
                              select vipcliente.Nombre;
                              

            foreach (var clientes in clientesVip ) { Console.WriteLine(clientes.ToString()); };
            Console.WriteLine();
            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres
            Console.WriteLine("Ejercicio 4: ");
            var NombresClientes = from nombreCliente in lstClientes
                                  select nombreCliente.Nombre;
            foreach (var name in NombresClientes) { Console.WriteLine(name.ToString()); };

            Console.WriteLine();

            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            Console.WriteLine("Ejercicio 5: ");
            var nuevaLstClientes = lstClientes.Select( info => new
            {
                ApellidoCliente = info.Apellido.ToUpper(),
                NombreCliente = info.Nombre.ToUpper(),
                CodigoCliente = info.CodCliente,
                tipoCliente = info.Vip ? "Premium":"Normal"
            }).ToList();

            foreach(var clientes in nuevaLstClientes) { Console.WriteLine($"Apellido: {clientes.ApellidoCliente}, Nombre: {clientes.NombreCliente}, Codigo de cliente: {clientes.CodigoCliente}, Clasificacion del cliente: {clientes.tipoCliente}"); };
            Console.WriteLine();
            #endregion
        }
    }
}