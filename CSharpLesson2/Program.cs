using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson2 {
	class Program {

		static int Add(int nbr,int inc) {
			return nbr + inc;
		}

		static int Add(int nbr) {
			return Add(nbr, 1);
		}
		static void Main(string[] args) {
			int nbr = 12;
			int inc = 3;
			int result = Add(nbr);
			Console.WriteLine("{0} Add1 is {1}",nbr, result);

			result = Add(nbr, inc);
			Console.WriteLine("{0} Add1 is {1}", nbr, result);

		}
	}
}
