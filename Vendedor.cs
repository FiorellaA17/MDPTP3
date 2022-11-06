
using System;
using System.Collections.Generic;

namespace MDPTP3
{
	
//	Tp3- 8) Implemente la clase Vendedor que sea subclase de Persona:
	
	public class Vendedor : Persona , IObservado
	{
		int sueldoBasico;
		double bonus;
		Istrategy comparoVendedor;
		public List<IObservador> listaObservadores = new List<IObservador>();
		double ultimaVenta;

		public int getSueldoBasico()
		{
			return this.sueldoBasico;
		}

		public double getBonus ()
		{
			return this.bonus;
		}

		public double getUltimaVenta() 
		{
			return this.ultimaVenta;
		}
		
		#region IObservado implementation
		public void agregarObservador(IObservador O)
		{
			listaObservadores.Add(O);
		}
		public void quitarObservador(IObservador O)
		{
			listaObservadores.Remove(O);
		}
		public void notificar()
		{
			foreach(IObservador O in listaObservadores)
			{
				O.actualizar(this);
			}
		}
		#endregion
		public Vendedor(string n,int d, int s): base(n,d)
		{
			this.sueldoBasico=s;
			bonus=1;
			comparoVendedor=new PorBonus();
			
		}
		
		public void venta(int monto)
		{
			ultimaVenta=monto;
			Console.WriteLine("Monto de la venta concretada es: {0}",monto);
			notificar();
		}
		
		public void aumentaBonus()
		{
			bonus=bonus + 0.1;
		}
		
		
		public override bool sosIgual(Icomparable c)
		{	
			return comparoVendedor.sosIgual(this, c); 
		}

		public override bool sosMenor(Icomparable c)
		{		
			return comparoVendedor.sosMenor(this, c);
		}

		public override bool sosMayor(Icomparable c)
		{
			return comparoVendedor.sosMayor(this, c);
		}
		
		public override string ToString()
		{
			return string.Format("nombre: {0} - Dni: {1} - Sueldo basico: {2}", this.getNombre(),this.getDni(),this.getSueldoBasico());
		}
	}
}
