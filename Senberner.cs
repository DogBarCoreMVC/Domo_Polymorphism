using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domo_Polymorphism
{
    class Senberner : Dog
    {
        public override void Goes()//"override" key word เขียนทับ method จาก method Dog (method ใน SuperClass)
        {
            //base.Goes();ไม่ให้กลับไปทำงานใน method Dog (method ใน SuperClass)
            Console.WriteLine("Senberner Wooooof!!!");//แสดงผล
        }
    }
}
