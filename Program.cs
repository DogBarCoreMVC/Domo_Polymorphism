using System;

namespace Domo_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();//create object dog from class Dog
            Cat cat = new Cat();
            Senberner senberner = new Senberner();

            Zoo addZoo = new Zoo();
            addZoo.AddAnimal(dog);//สร้าง method AddAnimal มาเก็บ object dog,cat ได้ภายในตัวเดียว เพราะว่า Animal เป็น SuperClass
            addZoo.AddAnimal(cat);
            addZoo.AddAnimal(senberner);

            addZoo.ShowDataAnimal();

            //addZoo.AddDog(dog);//สร้าง method AddDog and AddCat จะเก็บ Object ได้แต่ของตัวเอง ทำให้ต้องสร้าง method มาหลายตัวเพื่อเก็บ object 
            //addZoo.AddCat(cat);//Add Object at จาก Clas Dog
            
        }
    }
}
