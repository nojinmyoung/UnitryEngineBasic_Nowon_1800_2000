using System;
using System.ComponentModel.DataAnnotations;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 추상화 클래스는 인스턴스화 할 수 없다
            //Creature creature = new Creature();

            Human human = new Human();
            human.Breath();
            human.PurchaseParkingPass();

            Human luke = new Human("Luke", 01012345678, "lukechodev@gmail.com");
            Console.WriteLine(luke.EMaillAddress);

            

            Student student = new Student();
            student.PurchaseParkingPass();
            student.StudentNumvber = 2020929;

            // Covariant 공변성
            Human human1 = new Student();
            Creature creature1 = new Student();
            creature1 = human1;

            creature1.Breath();
            human1.Breath();

            Professor professor = new Professor();
            professor.PurchaseParkingPass();
            professor.purchaseparkingpass(30.0f);


            Dog dog = new Dog();
            dog.Breath();

            Elephant elephant = new Elephant();

            dog.FourLedggedWalk();
            elephant.FourLedggedWalk();

            IFourLedggedWalker[] fourLedggedWalkers = new IFourLedggedWalker[]
            {
                dog,elephant
            };

            for (int i = 0; i < fourLedggedWalkers.Length; i++)
            {
                fourLedggedWalkers[i].FourLedggedWalk();
            }
        }
    }
}