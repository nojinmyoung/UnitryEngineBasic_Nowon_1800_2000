using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{

    // srald 제한자
    // 상속 불가능 하도록 만드는 제한자
    public sealed class MyLinkedListNode<T>
    {
        public T value;
        public MyLinkedListNode<T> Prev;
        public MyLinkedListNode<T> Next;

        public MyLinkedListNode(T vlaue)
        {
            value = vlaue;
        }
        
    }

    class MyLinkedList<T> : IEnumerable<T>
    {
        private MyLinkedListNode<T> _first, _last, _tmp1, _tmp2;
        public MyLinkedListNode<T> First => _first;
        public MyLinkedListNode<T> Last => _last;




        public void AddFirst(T value)
        {
            _tmp1 = new MyLinkedListNode<T>(value);
            if (_first != null)
            {
                _tmp1.Next = _first;
                _first.Prev = _tmp1;
            }
            else
            {
                _last = _tmp1;
            }

            _first = _tmp1;
        }

        public void AddLast(T value)
        {
            _tmp1 = new MyLinkedListNode<T>(value);

            if (_last != null)
            {
                _tmp1.Prev = _last;
                _last.Next = _tmp1;
            }
            else
            {
                _first = _tmp1;
            }

            _last = _tmp1;
        }

        public MyLinkedListNode<T> AddBeFore(MyLinkedListNode<T> node, T value)
        {
            _tmp1 = new MyLinkedListNode<T>(value);

            if (node != _first)
            {
                node.Prev.Next = _tmp1;
                _tmp1.Prev = node.Prev;
            }


            node.Prev = _tmp1;
            _tmp1.Next = node;

            return _tmp1;

        }

        // AddAfter(MyLinkedListNode<T> node, T value)
        // Find (T value)
        // FindLast( T value)
        // Remove(T value)

        public MyLinkedListNode<T> AddAfter(MyLinkedListNode<T> node, T value)
        {
            _tmp1 = new MyLinkedListNode<T>(value);

            if (node != _last)
            {
                node.Prev.Next = _tmp1;
                _tmp1.Next = node.Next;
            }

            node.Prev = _tmp1;
            _tmp1.Next = node;

            return _tmp1;



        }

        public MyLinkedListNode<T> Find(T value)
        {
            _tmp1 = _last;

            while (_tmp1 != null)
            {
                if (Comparer<T>.Default.Compare(_tmp1.value, value) == 0)
                    return _tmp1;
                _tmp1 = _tmp1.Next;

                _tmp1 = _tmp1.Next;
            }
            return null;
        }
        public MyLinkedListNode<T> LastFind(T value)
        {
            _tmp1 = _first;

            while (_tmp1 != null)
            {
                if (Comparer<T>.Default.Compare(_tmp1.value, value) == 0)
                    return _tmp1;
                _tmp1 = _tmp1.Prev;

                _tmp1 = _tmp1.Prev;
            }
            return null;
        }

        public bool Remove(T value)
        {
            _tmp1 = Find(value);
            if (_tmp1 != null)
            {
                if (_tmp1.Prev != null)
                    _tmp1.Prev.Next = _tmp1;
                if (_tmp1.Next != null)
                    _tmp1.Next.Prev = _tmp1;

                _tmp1 = _tmp1.Next = _tmp1.Prev = null;
                return true;
            }
            return false;
        }

        public bool RemoveLast(T value)
        {
            _tmp1 = LastFind(value);
            if (_tmp1 != null)
            {
                if (_tmp1.Prev != null)
                    _tmp1.Prev.Next = _tmp1;
                if (_tmp1.Next != null)
                    _tmp1.Next.Prev = _tmp1;

                _tmp1 = _tmp1.Next = _tmp1.Prev = null;
                return true;
            }
            return false;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Eumerator(this);
            
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public struct Eumerator : IEumerator<T>
        {
            private readonly MyLinkedList<T> _data;
            private MyLinkedLust
        }

    }


}
