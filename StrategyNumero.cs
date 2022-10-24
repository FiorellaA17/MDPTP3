/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 24/10/2022
 * Hora: 17:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace MDPTP3
{
	/// <summary>
	/// Description of StrategyNumero.
	/// </summary>
	public class StrategyNumero : Istrategy
	{
		public StrategyNumero()
		{
		}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() == ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
			
		}

		public bool sosMenor(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() < ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool sosMayor(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() > ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion
	}
}
