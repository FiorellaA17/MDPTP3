
using System;

namespace MDPTP3
{
	
//1)Implemente cuatro estrategias de comparación para la clase Alumno definida en la práctica anterior. 
//	Realice  una  estrategia  para  que  compare  alumnos  por  nombre,
//	otra  para  que compare por DNI, otra para que compare por promedio y una última estrategia que compare por legajo. 
//  (realice las clases PorPromedio,PorDni,PorLegajo y PorNombre)
	public interface Istrategy
	{
		bool sosIgual (Icomparable c, Icomparable o);
		bool sosMenor (Icomparable c, Icomparable o);
		bool sosMayor (Icomparable c, Icomparable o);
	}
}
