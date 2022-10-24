
using System;

namespace MDPTP3
{
	class Program
	{
		public static void Main(string[] args)
		{
//			2) Use el método main del ejercicio 17 de la clase anterior
//			para comprobar el funcionamiento correcto de la estrategia seleccionada. Note que este método main NO debería ser modificado.
			
//			Pila pila = new Pila();
//			Cola cola = new Cola();
//			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			llenarAlumnos(pila);
//			llenarAlumnos(cola);
//			informar(multiple);
			
//			8)Implemente un módulo main para crear una pila, una cola, un conjunto y un diccionario de alumnos 
//			y luego invoque la función imprimirElementos para cada coleccionable.
			
//			Pila pila = new Pila();
//			Cola cola = new Cola();
//			Conjunto conjunto=new Conjunto();
//			Diccionario diccionario=new Diccionario();
//			llenarAlumnos(pila);
//			llenarAlumnos(cola);
//			llenarAlumnos(conjunto);
//			llenarAlumnos(diccionario);
//			imprimirElementos(pila);
//			imprimirElementos(cola);
//			imprimirElementos(conjunto);
//			imprimirElementos(diccionario);

//			10)Modifique el módulo main para que cambie la estrategia de comparación a los elementos de un coleccionable e informe minimo y máximo elemento:

			Pila pila = new Pila();
            llenarAlumnos(pila);
            
            Istrategy nombre=new PorNombre();
          	cambiarEstrategias(pila, nombre);
            Console.WriteLine("POR NOMBRE");
         	 informar(pila);
//			cambiarEstrategias(conjunto,nombre);
//			informar(conjunto);
//			cambiarEstrategias(diccionario,nombre);
//			informar(diccionario);
         	 Console.WriteLine("----------");
			
            
            Istrategy dni=new PorDni();
          	cambiarEstrategias(pila,dni);
            Console.WriteLine("POR DNI");
          	informar(pila);
//			cambiarEstrategias(conjunto,dni);
//          informar(conjunto);
//			cambiarEstrategias(diccionario,dni);
//			informar(diccionario);
			Console.WriteLine("----------");
            
            
            Istrategy legajo=new PorLegajo();
            cambiarEstrategias(pila,legajo);
            Console.WriteLine("POR LEGAJO");
            informar(pila);
//			cambiarEstrategias(conjunto,legajo);
//            informar(conjunto);
//			cambiarEstrategias(diccionario,legajo);
//			informar(diccionario);
 			Console.WriteLine("----------");
			
			
            Istrategy promedio=new PorPromedio();
            cambiarEstrategias(pila,promedio);
            Console.WriteLine("POR PROMEDIO");
            informar(pila);
//			cambiarEstrategias(conjunto,promedio);
//			informar(conjunto);
//			cambiarEstrategias(diccionario,promedio);
//			informar(diccionario);
            
            GeneradorDeDatosAleatorios g=new GeneradorDeDatosAleatorios();
            Console.WriteLine(g.numeroAleatorio(5));
            
            Console.WriteLine(g.stringAleatorio(5));

			
//          TP3- 1)  Recordamos: ¿Cuál es la única diferencia entre los métodos llenar, llenarPersonas y
//			llenarAlumnos implementados en la práctica 1 (ejercicios 5, 12 y 16)? ¿Qué tuvo que hacer con
//			el método informar (ejercicio 6) a medida que ejecutaba los métodos main (ejercicios 13 y 17)?
//			¿Qué sucedería con todos estos métodos si apareciera una nueva clase Vendedor la cual se
//			desea comparar por cantidad de ventas realizadas?

//			La unica diferencia entre llenar, llenarPersonas y llenarAlumnos es que se llenan de diferentes objetos como: numero, persona, alumno.
//			En el metodo informar (ejercicio 6) tuve que ir modificando el objeto de comparacion, cambie de numero, persona o alumno segun lo que se iba a ejecutar.
//			No servirian, Deberia crear un nuevo metodo llenarVendedor y cambiar en informar por el objeto vendedor.

            
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenar(Icoleccionable c)
		{		
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int numAleatorio=random.Next(100);
				Icomparable numero = new Numero(numAleatorio);
				c.agregar(numero);
			}
		}
		
		public static void informar(Icoleccionable c)
		{

			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
			Console.WriteLine("Valor minimo: {0}",c.minimo());
			Console.WriteLine("Valor maximo: {0}",c.maximo());
			
			
//			Console.Write("Ingrese un numero para comparar en la coleccion: ");
//			int num=int.Parse(Console.ReadLine());
//			//Icomparable elemento=new Alumno("aux",0,0,num);
//			Icomparable elemento=new Alumno("aux",0,num,0);
//			
//			
//			if(c.contiene(elemento))
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido esta en la coleccion");
//			}
//			else
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido no esta en la coleccion");
//			}
			
			
		}

		public static void llenarPersonas(Icoleccionable c)
		{

			string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel", "Dante","milena","giovanni","luciano","mauro","stefania","catalina","milton"};
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int indice=random.Next(listaNombres.Length);
				string nombre= listaNombres[indice];
				int dniAleatorio=random.Next(10000000,50000000);
				Icomparable persona = new Persona(nombre,dniAleatorio);
				c.agregar(persona);
			}
		}
		
		//16)Implemente  una  función  llenaAlumnos  que  reciba  un  Coleccionable  y  que  le  agregue  20 alumnos elegidos al azar. 
		//TP2- 2)Modifique  el  ejercicio  16  de  la  clase  anterior  para  crear  alumnos  con  alguna  estrategia implementada en el ejercicio anterior.
		public static void llenarAlumnos(Icoleccionable c)
		{

			string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel", "Dante","milena","giovanni","luciano","mauro","stefania","catalina","milton"};
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int indice=random.Next(listaNombres.Length);
				string nombre= listaNombres[indice];
				int dniAleatorio=random.Next(10000000,50000000);
				int legajoAleatio=x;
				int promedioAleatorio=random.Next(1,11);
				PorDni estrategia=new PorDni();
				
				
				Icomparable Alumno = new Alumno(nombre,dniAleatorio,legajoAleatio,promedioAleatorio);
				((Alumno)Alumno).cambiarEstrategia(estrategia); //cambio la estrategia para comparar por Dni, ya que habia elegido por defecto a comparar por nombre. 
				c.agregar(Alumno);
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
	}
}