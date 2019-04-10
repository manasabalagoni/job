using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    class AndOperator
    {
       int varA= 5;
        int varB = 10;
        int varC = 20;
        public void result()
        {


            int result = ((varA & varB) | (varA & varC));

            Console.WriteLine("{0} AND {1} result:{2}", varA, varB, result);
        }
        //comment
        
      
    }
}
