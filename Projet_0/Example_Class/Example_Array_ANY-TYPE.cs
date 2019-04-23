using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_0
{
    public class Enumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public object Current
        {
            get { return null; }
        }
    }
    class Example_Array_ANY_TYPE<T>
    {
        T[] ExampleArray;
        public T j = default(T);
        public Example_Array_ANY_TYPE(){
            ExampleArray = new T[0];
            
        }
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public void add_in_array(T item){
            T[] newExampleArray = new T[ExampleArray.Length + 1];
            Array.Copy(ExampleArray, newExampleArray, ExampleArray.Length);
            newExampleArray[ExampleArray.Length] = item;
            ExampleArray = newExampleArray;
        }
        public void Reverse()
        {
            
            Array.Reverse(ExampleArray);
            
        }

        public void delete_from_array(T item){
            var temp = -1;
            for (int i = 0; i < ExampleArray.Length; i++)
            {
                if (ExampleArray[i].Equals(item))
                {
                    temp = i;
                    break;
                }
            }

            if (temp > -1)
            {
                T[] newExampleArray = new T[ExampleArray.Length - 1];
                for (int i = 0, j = 0; i < ExampleArray.Length; i++)
                {
                    if (i == temp) continue;
                    newExampleArray[j] = ExampleArray[i];
                    j++;
                }

                ExampleArray = newExampleArray;
            }
        }

        public T get_element_from_array_index(int index){

            if (index < 0 || index > ExampleArray.Length)
                return j;
            else
            {
                return ExampleArray[index];
            }


        }

        public int get_lenght_array() => ExampleArray.Length;


        public void show_array(){
            foreach (var VARIABLE in ExampleArray)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        /*int[] mas1 = { 10, 20, 30 };
        Example_Array_ANY_TYPE<int> array = new Example_Array_ANY_TYPE<int>();
        array.show_array();
            
        for (int i = 0; i<mas1.Length; i++)
        {
            array.add_in_array(mas1[i]);
        }

        Console.WriteLine(array.get_element_from_array_index(100));

        Console.WriteLine(array.get_element_from_array_index(1));
        Console.WriteLine(array.get_element_from_array_index(-12));
        Console.WriteLine(array.get_lenght_array());*/

    }
}