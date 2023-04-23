using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL5.Domain.Item_2.Animal
{
    public class Cachorro : Animal.Core.Animal
    {
        public override void FazerBarulho()
        {
            Console.WriteLine("auau");
        }
    }
}
