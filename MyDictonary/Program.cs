using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictenory<int,string> myDictenory = new MyDictenory<int,string>();

            myDictenory.Add(1, "meryem");
            myDictenory.Add(2, "fatma");
        }
    }

    class MyDictenory<K, V>
    {
        K[] k_;
        V[] v_;


        public MyDictenory()
        {
            k_ = new K[0];
            v_ = new V[0];
        }


        public void Add(K key, V value)
        {
            K[] tempKey = k_;
            V[] tempValue = v_;

            k_ = new K[k_.Length + 1];
            v_ = new V[k_.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                k_[i] = tempKey[i];
                v_[i] = tempValue[i];

            }

            k_[k_.Length - 1] = key;
            v_[v_.Length - 1] = value;
        }


    }




}
