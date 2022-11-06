
using System;
using System.Collections.Generic;

namespace MDPTP3
{
//	TP3- 11) Implemente la clase Gerente. Un Gerente tiene una colección con sus vendedores.
	public class Gerente : IObservador
	{
		List<Vendedor> mejores= new List <Vendedor>();
		double ultimaVenta=0;
		
		
		public Gerente()
		{
		}

		#region IObservador implementation
		public void actualizar(IObservado O)
		{
			ultimaVenta= ((Vendedor)O).getUltimaVenta();
			venta(ultimaVenta,(Vendedor)O);
		}
		#endregion	
		
		public void cerrar()
		{
			foreach( var elem in mejores)
			{
				Console.WriteLine("Nombre: {0}",elem.getNombre());
				Console.WriteLine("Bonus Acumulado: {0}",elem.getBonus());
				
			}
		}
		
		public void venta(double monto,Vendedor vendedor)
		{
			if(monto > 5000)
			{
				if(!mejores.Contains(vendedor))
					mejores.Add(vendedor);
				vendedor.aumentaBonus();
			}
		}
	}
}
