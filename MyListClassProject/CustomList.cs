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
        string listString;
        

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
                for (int i = 0; i < count; i++)
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
       
        public override string ToString()
        {
            listString = "";

            for (int i = 0; i < count; i++)
            {
                listString += (array[i].ToString());

            }
            
            return listString;
            
        }
                
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T>  listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();
            
            for (int i = 0; i < listOne.Count; i++)
            {
                listResult.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                listResult.Add(listTwo[i]);
            }


            return listResult;


        }



    }
}
