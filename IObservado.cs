
using System;

namespace MDPTP3
{
	
	public interface IObservado
	{
		void agregarObservador(IObservador O);
		void quitarObservador(IObservador O);
		void notificar();
	}
}
