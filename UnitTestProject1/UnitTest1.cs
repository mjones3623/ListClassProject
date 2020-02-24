using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListClassProject;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        //Add Method Unit Tests/////////////////////////////////////////////////////
        public void Add_OneInt_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;
            int actual;
            //Act
            myList.Add(5);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
                                   
        }
        public void Add_OneString_CountIncrement()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            int expected = 1;
            int actual;
            string word = "word";

            //Act
            myList.Add(word);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void Expected_IntValueAt_IndexAdd_Location()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int expected = 5;
            int actual;
            //Act
            myList.Add(value1);
            actual = myList[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Expected_StringValueAt_IndexAdd_Location()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "word";
            string actual;

            //Act
            actual = myList[0];
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Expected_LocationOf_AddedInt()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Expected_LocationOf_AddedString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "word2";
            string value1 = "word1";
            string value2 = "word2";
            string actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Location_Of_Fifth_Added_Value()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            int value1 = 0;
            int value2 = 1;
            int value3 = 2;
            int value4 = 3;
            int value5 = 4;

            int expected = 4;
            
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            int actual = myList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Location_Of_3rd_Of_FiveAddedValues()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            int value1 = 0;
            int value2 = 1;
            int value3 = 2;
            int value4 = 3;
            int value5 = 4;

            int expected = 2;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            int actual = myList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //Remove Method Unit Tests///////////////////////////////////////////////
        public void Remove_OneInt_CountReduction()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            
            int expected = 1;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(6);
            myList.Remove(5);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void Remove_OneString_CountReduction()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            int expected = 1;
            string word1 = "word1";
            string word2 = "word2";
            int actual;

            //Act
            myList.Add(word1);
            myList.Add(word2);
            myList.Remove("word2");
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void Expected_IntValueAt_IndexRemove_Location()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 4;
            int number2 = 5;
            
            int expected = 5;
            int actaul;


            //Act
            myList.Add(number1);
            myList.Add(number2);
            myList.Remove(myList[0]);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Expected_StringValueAt_IndexRemove_Location()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string word1 = "word1";
            string word2 = "word2";
            
            string expected = "word2";
            string actual;

            //Act
            myList.Add(word1);
            myList.Add(word2);
            myList.Remove(myList[0]);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Remove_Nonexistent_Int()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 7;
            int expected = 4;
            int actual;

            //Act
            myList.Add(number1);
            myList.Add(number2);
            myList.Add(number3);
            myList.Add(number4);
                
            myList.Remove(number5);

            actaul = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void Expected_ListCapacity_of_5_Object_List()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;

            int expected = 8;
            

            //Act
            myList.Add(one);
            myList.Add(two);
            myList.Add(three);
            myList.Add(four);
            myList.Add(five);

            string actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
