using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClassProject
{
    public class CustomList<T>
    {
        //Variables


        T[] array = new T[4];
        private int count;
        private int capacity;
        private int index;
        

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this [int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }

                     
        //Constructor
        
        public CustomList()
        {
            count = 0;
            capacity = 4;
            
        }

               
        
        //Methods
        public void Add(T item)
        {
            
            if(capacity == count)
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];
                for (int i = 0; i < count -1; i++)
                {
                    tempArray[i] = array[i];

                }
                array = tempArray;

            }
            array[count] = item;
            count++;

        }
        public void Remove(T item)
        {
            
            T[] tempArray = new T[capacity];
            for (int i = 0; i <= count - 1; i++)
            {
                if (!array[i].Equals(item))
                {
                    tempArray[i] = array[i];
                }
                
                else if (array[i].Equals(item))
                {
                        i++;  
                                        
                    for (int j = i; j <= count -1; j++)
                    {
                        tempArray[j-1] = array[j];
                    }
                    count--;
                }
               

            }
            
            array = tempArray;

        }
        public string ConvertToString(T[] arrayToString)
        {

            string listString = "";
            
            for (int i = 0; i < count; i++)
            {
                listString += (arrayToString[i].ToString()+",");
                
            }

            return listString;
            
        }

    }
}
