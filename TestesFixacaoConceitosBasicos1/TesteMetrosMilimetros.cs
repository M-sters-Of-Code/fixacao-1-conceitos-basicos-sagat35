using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos1.Model;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteMetrosMilimetros
    {
        [TestMethod]
        public static int Converter(int metros)

        {
return metros*1000;
        }
    }
}
