using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace Universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var uni = new UniverdidadEntity())
            {
               var x = uni.Students.ToList();
            }
        }
    }
}
