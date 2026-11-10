using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerLinq
{
    internal class Program
    {
        public class Estudiante
        {
            public int ID {  get; set; }
            public string Nombre { get; set; }
            public int Edad {  get; set; }


            public Estudiante(int id, string nombre, int edad)
            {
                ID = id;
                Nombre = nombre;
                Edad = edad;
            }
        }
        static void Main(string[] args)
        {
            //Crear la lista de estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>() 
            {
                new Estudiante(1, "Luis", 18),
                new Estudiante(2, "Manuel", 20),
                new Estudiante(3, "Jhon", 19),
                new Estudiante(4, "Miguel", 23)
            };

            //Crear la lista de numeros
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPar = from numero in numeros where numero%2 == 0 select numero;
            var numerosImpar = from numero in numeros where numero%2!=0 select numero;

            Console.WriteLine("Numeros pares son: ");
            
            //Recorre la lista e imprime los numeros pares
            foreach(var numero in numerosPar)
            {
                Console.WriteLine(numero.ToString());
            }

            //Recorre la lista e imprime los numeros impares
            Console.WriteLine("\nLos numeros impares son: \n");
            foreach (var numero in numerosImpar)
            {
                Console.WriteLine(numero.ToString());
            }

            //Buscar los estudiantes mayores de 20
            var mayoresDe20 = from estudiante in listaEstudiantes where estudiante.Edad > 20 select estudiante;

            Console.WriteLine("\nLos estudiantes con edad mayor de 20 son: \n");

            foreach (var estudiante in mayoresDe20)
            {
                Console.WriteLine(estudiante.Nombre);
            }

            //Ordenar estudiantes por nombre
            var estudiantesOrdenadosPorNombre = from estudiante in listaEstudiantes orderby estudiante.Nombre select estudiante;

            Console.WriteLine("\nLos estudiantes ordenados por nombre son los siguientes: \n");

            foreach (var estudiante in estudiantesOrdenadosPorNombre)
            {
                Console.WriteLine(estudiante.Nombre);
            }

            //Proyectar los nombres de los estudiantes
            var estudiantesNombres = from estudiante in listaEstudiantes select estudiante;

            Console.WriteLine("\nLos nombres de los estudiantes son los siguientes: \n");

            foreach (var estudiante in estudiantesNombres)
            {
                Console.WriteLine(estudiante.Nombre);
            }
        }
    }
}
