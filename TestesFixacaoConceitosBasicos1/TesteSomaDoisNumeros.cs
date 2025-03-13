using FixacaoConceitosBasicos1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesFixacaoConceitosBasicos1
{
    [TestClass]
    public class TesteSomaDoisNumeros
    {
        [TestMethod]
        public int Somar(int num1,int num2) {
            return num1 + num2;
        }
    }
}
