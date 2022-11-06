
using System;

namespace MDPTP3
{
	class Program
	{
		public static void Main(string[] args)
		{
            
//            GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
//            Console.WriteLine(g.numeroAleatorio(5));
//            
//            Console.WriteLine(g.stringAleatorio(5));

//TP3 -6) Adapte, modifique y compruebe el correcto funcionamiento de los métodos main de los
//	ejercicios 9 y 17 de la práctica 1. Unifique ambos métodos en un único main.

//			Pila pila = new Pila();
//			Cola cola = new Cola();
//		
//			llenar(pila,1);
//			llenar(cola,2);
//			
//			Console.WriteLine("*****Pila*****");
//			informar(pila,1);
//			Console.WriteLine("");
//			
//			Console.WriteLine("*****Cola*****");
//			informar(cola,2);
//			Console.WriteLine("");

			
//          TP3- 1)  Recordamos: ¿Cuál es la única diferencia entre los métodos llenar, llenarPersonas y
//			llenarAlumnos implementados en la práctica 1 (ejercicios 5, 12 y 16)? ¿Qué tuvo que hacer con
//			el método informar (ejercicio 6) a medida que ejecutaba los métodos main (ejercicios 13 y 17)?
//			¿Qué sucedería con todos estos métodos si apareciera una nueva clase Vendedor la cual se
//			desea comparar por cantidad de ventas realizadas?

//			La unica diferencia entre llenar, llenarPersonas y llenarAlumnos es que se llenan de diferentes objetos como: numero, persona, alumno.
//			En el metodo informar (ejercicio 6) tuve que ir modificando el objeto de comparacion, cambie de numero, persona o alumno segun lo que se iba a ejecutar.
//			No servirian, Deberia crear un nuevo metodo llenarVendedor y cambiar en informar por el objeto vendedor.


//			tp3- 7)¿Qué  debería  hacer  si  se  quiere  tener  en  el método  main la  opción  de almacenar los comparables en una pila,
//			en una cola, en una colección múltiple, en un conjunto o en un diccionario?

//			Pediría que se ingrese una opcion y luego con esa opcion (segun lo que se haya ingresado) crearia la coleccion que se desee. Una coleccion por cada opcion.


//			TP3- 14) Implemente la siguiente función main.
			
			Pila pila = new Pila();
			llenar(pila, 3);
			Gerente gerente=new Gerente();
			registrarObservador(pila,gerente);
			jornadaDeVentas(pila);
			gerente.cerrar();
			
			
            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
//		TP3 -6)
		public static void llenar(Icoleccionable c, int opcion)
		{	
			for (int x = 1; x <= 3; x++) 
			{
				c.agregar(FabricaDeComparables.crearAleatorio(opcion));
			}
		}
		
//		TP3 - 6)	
		public static void informar(Icoleccionable c, int opcion)
		{

			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
			Console.WriteLine("Valor minimo: {0}",c.minimo());
			Console.WriteLine("Valor maximo: {0}",c.maximo());
			
			Console.WriteLine("");
			Console.WriteLine("Ingrese datos para comparar en la coleccion: ");
			Icomparable elemento=FabricaDeComparables.crearPorTeclado(opcion);
	
			if(c.contiene(elemento))
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido no esta en la coleccion");
			}
	
		}

		
//		7)Implemente una función imprimirElementos que reciba un coleccionable y usando el iterador del coleccionable imprima todos los elementos del coleccionable
		public static void imprimirElementos(Icoleccionable c)
		{
			Iterator iterador=c.crearIterador();
			
			while(!iterador.fin())
			{
				Console.WriteLine(iterador.actual());
				iterador.siguiente();
			}
		
		}
		
//		9)Implemente una función cambiarEstrategia que reciba un coleccionable y una estrategia de comparación (implementada en el ejercicio 1)
//		y asigne esa estrategia a todos los elementos del coleccionable
		public static void cambiarEstrategias(Icoleccionable c, Istrategy estrategia)
        {
            Iterator iteradorEstrategia=c.crearIterador();
            
            while(!iteradorEstrategia.fin())
            {
                Icomparable elemento=iteradorEstrategia.actual();
                ((Alumno)elemento).cambiarEstrategia(estrategia);
                
                iteradorEstrategia.siguiente();
            }
            
        }
		
		//a cada vendedor se le agrega el observador
		public static void registrarObservador(Icoleccionable c,IObservador o)
        {
            Iterator iterador = c.crearIterador();
            
            while (!iterador.fin())
            {
                Vendedor vendedorActual = (Vendedor)iterador.actual();
                vendedorActual.agregarObservador(o);
                iterador.siguiente();
            }

        }
		
//		TP3 -13) Implemente la función jornadaDeVentas.
		
		public static void jornadaDeVentas(Icoleccionable c)
		{
			Iterator iterador=c.crearIterador();
	
			while(!iterador.fin())
			{
				Vendedor vendedorActual = (Vendedor)iterador.actual();
				for(int i=0; i < 20; i++)
				{
					int monto=new Random().Next(1,7000);
					vendedorActual.venta(monto);
				}
				
				iterador.siguiente();
			}
		}
	}
}