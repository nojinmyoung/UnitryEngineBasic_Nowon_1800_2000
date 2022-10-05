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
        public int Capacity => _data.Length;    // get 접근자의 람다식 표현, 람다식 : 익명함수 표현방법 
       

        public void Add(int item)
        {
            // 배열의 크키가 모자라면
            if (Count >= Capacity)
            {
                
                // 2배짜리 새로운 배열 생성
                int[] tmp = new int[Capacity * 2];

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


        /// <summary>
        /// 특정 인덱스에 있는 데이터를 지우고
        /// 그 뒤 모든 인덱스 데이터들을 한칸씩 앞으로 당겨줌
        /// </summary>
        /// <param name="index">지우고싶은 데이터의 인덱스</param>
        /// <returns>ture : 삭제됨, false : 삭제안됨 </returns>
        public bool RemoveAt(int index)
        {
            if(index < 0  || index > Count -1)
                return false;

            for (int i = index; i < Count - 1; i++)
            {
                _data[i] = _data[i + 1];
            }

            Count--;
            _data[Count] = 0;
            return true;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_data[i] == item)
                    return RemoveAt(i);
            }
            return false;
        }

       // public IEnumerator<int GetEnumerator()
       // {
       //     
       // }
       
    }
}






















//프로퍼티 ?

//private int _hp;
//
//public int Hp
//{
//    get
//    {
//        return _hp;
//    }
//
//    private set
//    {
//        if (value < 0)
//            value = 0;
//
//        _hp = value;
//        _hpBar.value = _hp / _hpMax;
//    }
//}
//
//public int Mp { get; private set; }
//
//
//private UISlider _hpBar;
//private int _hpMax;
//
//public int GetHp()
//{
//    return _hp;
//}
//
//public void SetHp(int value)
//{
//    if (value < 0)
//        value = 0;
//
//    _hp = value;
//    _hpBar.value = _hp / _hpMax;
//}
//
//class UISlider { public float value; }
