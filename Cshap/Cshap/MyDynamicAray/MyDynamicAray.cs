using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDynamicAray
{
    internal class MyDynamicAray
    {
        private const int DEFAULT_SIZE = 1;
        private int[] _data = new int[DEFAULT_SIZE];
        public int this[int index]
        {
            get
            {
                return _data[index];
            }

            private set
            {
                _data[index] = value;
            }
        }

        public int Count;
        public int Capacity;

        public void Add(int item)
        {
            // 배열의 크키가 모자라면
            if (Count >= Capacity)
            {
                Capacity * = 2;
                // 2배짜리 새로운 배열 생성
                int[] tmp = new int[Capacity];

                // 기존 데이터를 새로운 배열에 복제          
                for (int i = 0; i < Count; i++)
                {
                    tmp[i] = _data[i];
                }

                // 새로운 배열로 참조 변경
                _data = tmp;
            } 

            _data[Count] = item;
            Count++;

        }

        P


























       //public int Mp { get; private set; }
       //
       //
       //public int Count;
       //public int Capacity;
       //
       //private int _hp;
       //
       //public int Hp
       //{
       //    get
       //    {
       //        return _hp;
       //    }
       //
       //    set
       //    {
       //        if (value < 0)
       //            value = 0;
       //
       //        _hp = value;
       //        _hpBar.value = _hp / _hpMax;
       //    }
       //}
       //
       //
       //private UISlider _hpBar;
       //public int _hpMax;
       //
       //public int GetHp()
       //{
       //    return _hp;
       //}
       // 
       //public void SetHp(int value)
       //{
       //    if(value < 0)
       //       value = 0;
       //
       //    _hp = value;
       //    _hpBar.value = _hp / _hpMax;
       //}
       //
       //
   // class UISlider { public float value;  }

    }
}
