using System;

namespace ClassInheritance
{
    internal class Student : Human
    {
        public int StudentNumvber;
        public float AverheMark;
        private string[] seminarsTaken = new string[3]
        {
            "Mathatics", 
            "Kinematics", 
            "Dynamics"
        };


        public bool IsEligibleToEnroll()
        {
            return AverheMark >= 3.5f;

        }
        public string[] GetSeminarsTaken()
        {
            return seminarsTaken;
        }

        public override void Breath()
        {
            Console.WriteLine($"학생이 숨을 쉰다");
        }

        public override void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} 이 주차권을 구매 했습니다, 학생할인 20% 적용 !! ");
        }
    }
}
