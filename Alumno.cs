
using System;

namespace MDPTP3
{
	public class Alumno : Persona
	{
		int legajo;
		int promedio;
		Istrategy comparoAlumno; //Tp2 - lo agrego para hacer uso del strategy
		
		public Alumno(string n, int d, int l, int p) : base(n,d)
		{
			this.legajo=l;
			this.promedio=p;
			comparoAlumno=new PorNombre(); //elijo una comparacion por defecto
		}
		
		public void cambiarEstrategia(Istrategy c)
		{
			this.comparoAlumno=c;
		}
		
		public int getLegajo()
		{
			return this.legajo;
		}
		
		public int getPromedio()
		{
			return this.promedio;
		}
		
		//18) Reimplemente los métodos de comparable en Alumno para que se compare por legajo o promedio, a elección.
		
		public override bool sosIgual(Icomparable c)
		{	
			return comparoAlumno.sosIgual(this, c); //Delego a la estrategia como comparar.
		}

		public override bool sosMenor(Icomparable c)
		{		
			return comparoAlumno.sosMenor(this, (Alumno)c);
		}

		public override bool sosMayor(Icomparable c)
		{
			return comparoAlumno.sosMayor(this, c);
		}
		
		public override string ToString()
		{
			return string.Format("nombre: {0} - Dni: {1} - Legajo: {2}, promedio: {3}", this.getNombre(),this.getDni(),this.getLegajo(),this.getPromedio());
		}
	}
}
