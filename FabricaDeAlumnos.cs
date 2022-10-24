/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 20/10/2022
 * Hora: 23:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP3
{
//	TP3 -5)
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		override public Icomparable crearPorTeclado()
		{
			 Console.WriteLine("ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese dni");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese legajo");
            int legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese promedio");
            int promedio = int.Parse(Console.ReadLine());

            return new Alumno( nombre,dni,legajo,promedio);
		}
		
	 	override public Icomparable crearAleatorio( )
        {
           string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel", "Dante","milena","giovanni","luciano","mauro","stefania","catalina","milton"};
			Random random = new Random();

            string auxNombre = listaNombres[random.Next(0, listaNombres.Length)];
           
            return new Alumno(auxNombre,new Random().Next(50000000), new Random().Next(listaNombres.Length),new Random().Next(10));
        }
	}
}
