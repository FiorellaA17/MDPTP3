
using System;

namespace MDPTP3
{
	public interface Iterator
	{
		void primero();
        void siguiente();
        bool fin();
        Icomparable actual();
	}
}
