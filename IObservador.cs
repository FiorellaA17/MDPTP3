
using System;

namespace MDPTP3
{
//	TP3- 12) Implemente el patrón Observer haciendo que los vendedores sean los observables y el gerente el observador de todos los vendedores. 
	
	public interface IObservador
	{
		void actualizar(IObservado O);
	}
}
