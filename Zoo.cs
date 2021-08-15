using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domo_Polymorphism
{
    class Zoo
    {
        private int runIndexAnimal = 0;
        //private int runIndexDog = 0;//เก็บตัว index
        //private int runIndexCat = 0;

        public Animal[] Animals { get; set; }//เขียนแบบนี้จะทำงานได้คลอบคลุมดีกว่า

        //public Dog[] Dogs { get; private set; }//เก็บข้อมูลที่เป็น array
        //public Cat[] Cats { get; private set; }//set ค่าได้ภายใน class นี้


        public Zoo()
        {
             Animals = new Animal[5];

            //Dogs = new Dog[5];//เก็บให้เก็บข้อมูลได้ 5 index
            //Cats = new Cat[5];
        }

        public void AddAnimal(Animal animal)
        {
            Animals[runIndexAnimal++] = animal;
        }

        public void ShowDataAnimal()
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i] == null) break;//ถ้า index ตำแหน่งที่ i ยังไม่ถูกกำหนดค่าให้ ให้หยุดการทำงานทันที

                Animals[i].Goes();//เรียกใช้งาน method
            }
        }

        /*public void AddDog(Dog dog)
        {
            Dogs[runIndexDog++] = dog;//ค่อยเพิ่มจำนวน index ขึ้นไปทีล่ะ 1 (runIndexDog++) แล้วไปเก็บไว้ใน dog
        }

        public void AddCat(Cat cat)
        {
            Cats[runIndexCat++] = cat;
        }*/
    }
}
