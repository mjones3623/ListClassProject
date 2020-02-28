using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        //Variables
        
        

        T[] array = new T[4];

        private int count;
        private int capacity;
        private int index;
        string listString;

        
        
        //Count property, Capacity property and Indexer

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
                if(i < 0 || i > count)
                {
                    throw new System.IndexOutOfRangeException();
                }
                else
                {
                    return array[i];
                }
                
                
            }
            set
            {
                if (i < 0 || i > count)
                {
                    throw new System.IndexOutOfRangeException();
                }
                else
                {
                    array[i] = value;
                }
                
            }
        }

                     
        //Constructor
        
        public CustomList()
        {
            count = 0;
            capacity = 4;

            
            
        }

               
        
        //Methods

        //Add method for custom list class
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
        //Remove method for custom list class
        public void Remove(T item)
        {
            
            T[] tempArray = new T[capacity];
            for (int i = 0; i <= count-1; i++)
            {
                if (!array[i].Equals(item))
                {
                    tempArray[i] = array[i];
                }
                
                else if (array[i].Equals(item))
                {
                    i++;

                    for (int j = i; j <= count-1; j++)
                    {
                        tempArray[j - 1] = array[j];
                    }
                    count--;
                    break;
                    
                }
               

            }
            
            array = tempArray;

        }
        //Overriding ToString Method
        public override string ToString()
        {
            listString = "";

            for (int i = 0; i < count; i++)
            {
                listString += (array[i].ToString());

            }
            
            return listString;
            
        }
         //Overload the + operator method       
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
        //Overload the - operator method       
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            int k = 0;
            foreach(int i in listOne)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if (listOne[k].Equals(listTwo[j]))
                    {
                        listOne.Remove(listOne[k]);
                        listTwo.Remove(listTwo[j]);
                        k++;
                        break;
                    }
                    else if(j == (listTwo.Count -1))
                    {
                        k++;
                        break;
                    }
                }
            }
            return listOne;

                                          
        }
        //Zip two custom list class instances
        //listOne includes the index that contains the first index postion the user wants to begin with
        public CustomList<T> ZipTowCustomListInstances(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            int listOneCountLarger = listOne.Count - listTwo.Count;
            int listTwoCountLarger = listTwo.Count - listOne.Count;

            if (listOne.count == listTwo.count)                    //If list lengths are equal
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    listResult.Add(listOne[i]);
                    listResult.Add(listTwo[i]);
                }

            }
            else if (listOneCountLarger > 0)                       //If list One is larger  
            {
                for (int j = 0; j <= listTwo.Count-1; j++)
                {
                    listResult.Add(listOne[j]);
                    listResult.Add(listTwo[j]);
                }
                for (int k = listTwo.Count; k < listOne.Count; k++)
                {
                    listResult.Add(listOne[k]);
                }

            }
            else if (listTwoCountLarger > 0)                        //If list Two is larger
            {
                for (int k = 0; k <= listOne.Count-1; k++)
                {
                    listResult.Add(listOne[k]);
                    listResult.Add(listTwo[k]);
                }
                for (int l = listOne.Count; l < listTwo.Count; l++)
                {
                    listResult.Add(listTwo[l]);
                }
                
            }
            return listResult;

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }
}
