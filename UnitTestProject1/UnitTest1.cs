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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void Expected_StringValueAt_IndexAdd_Location()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string word = "word";
            string expected = "word";
            string actual;

            //Act
            myList.Add(word);
            actual = myList[0];
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void Location_Of_Fifth_Added_Value()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

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
        [TestMethod]
        public void Location_Of_3rd_Of_FiveAddedValues()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

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
        [TestMethod]
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

        [TestMethod]
        public void Remove_OneInt_placement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();

            
            //Act
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);


            myList2.Add(5);
            myList2.Add(7);
            myList2.Add(8);
            myList2.Add(9);
            myList2.Add(10);

            myList.Remove(6);

            CustomList<int> actual = myList;
            CustomList<int> expected = myList2;
            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod]
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
        [TestMethod]
        public void Expected_IntValueAt_IndexRemove_Location()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 4;
            int number2 = 5;
            
            int expected = 5;
            int actual;


            //Act
            myList.Add(number1);
            myList.Add(number2);
            myList.Remove(myList[0]);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
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
        [TestMethod]
        public void Remove_Nonexistent_Int()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
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

            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Expected_ListCapacity_of_5_Object_List()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
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

            int actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Adding_5_Numbers_To_List_Placement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;

            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 3;
            int expected4 = 4;
            int expected5 = 5;

            //Act
            myList.Add(one);
            myList.Add(two);
            myList.Add(three);
            myList.Add(four);
            myList.Add(five);

            int actual1 = myList[0];
            int actual2 = myList[1];
            int actual3 = myList[2];
            int actual4 = myList[3];
            int actual5 = myList[4];

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);


        }
        //Override ToString Method Unit Test////////////////////////
        [TestMethod]
        public void ToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            string expected = "12345";
            string actual;

            //Act
            myList.Add(number1);
            myList.Add(number2);
            myList.Add(number3);
            myList.Add(number4);
            myList.Add(number5);
            actual = myList.ToString(); 

                        
            //Assert
            Assert.AreEqual(expected, actual);

        }
        //Overload the + Operator Tests
        [TestMethod]
        public void Plus_Operator_Test_Add_2Lists()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>() {};
            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            int number4 = 2;
            int number5 = 4;
            int number6 = 6;
            
            CustomList <int> actual;

            //Act
            myList1.Add(number1);
            myList1.Add(number2);
            myList1.Add(number3);

            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);

            myList3.Add(number1);
            myList3.Add(number2);
            myList3.Add(number3);
            myList3.Add(number4);
            myList3.Add(number5);
            myList3.Add(number6);


            actual = myList1 + myList2;
            
            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        [TestMethod]
        //Overload the - operator unit test
        public void Minus_Operator_Test_Add_1()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            int number4 = 2;
            int number5 = 1;
            int number6 = 6;

            CustomList<int> actual;

            //Act
            myList1.Add(number1);
            myList1.Add(number2);
            myList1.Add(number3);
            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);

            myList3.Add(number2);
            myList3.Add(number3);
            


            actual = myList1 - myList2;

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        [TestMethod]
        //Overload the - operator unit test
        public void Minus_Operator_Test_2()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;

            CustomList<int> actual;

            //Act
            myList1.Add(number1);
            myList1.Add(number1);
            myList1.Add(number3);
            myList1.Add(number4);
            myList1.Add(number5);

            myList2.Add(number1);
            myList2.Add(number5);
            myList2.Add(number6);
            myList2.Add(number3);

            myList3.Add(number1);
            myList3.Add(number4);
            



            actual = myList1 - myList2;

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod]
        //Overload the - operator unit test
        public void Minus_Operator_Test_3()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int number6 = 6;
            int number7 = 7;

            CustomList<int> actual;

            //Act
            myList1.Add(number2);
            myList1.Add(number4);
            myList1.Add(number7);
            myList1.Add(number4);
            myList1.Add(number5);

            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);
            myList2.Add(number3);

            myList3.Add(number2);
            myList3.Add(number7);
            myList3.Add(number4);



            actual = myList1 - myList2;

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }


        [TestMethod]
        //Zip Two Custom List Instances Unit Test
        public void Zip_Test_Lists_Same_Length()  //testing example in user stories
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            int number4 = 2;
            int number5 = 4;
            int number6 = 6;

            CustomList<int> actual;

            //Act
            myList1.Add(number1);
            myList1.Add(number2);
            myList1.Add(number3);

            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);

            myList3.Add(number1);
            myList3.Add(number4);
            myList3.Add(number2);
            myList3.Add(number5);
            myList3.Add(number3);
            myList3.Add(number6);



            actual = myList1.ZipTowCustomListInstances(myList1, myList2);

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        [TestMethod]
        
        public void Zip_Test_Lists_Different_Length()  //listTwo linger
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            int number4 = 2;
            int number5 = 4;
            int number6 = 6;
            int number7 = 7;
            int number8 = 7;
            int number9 = 7;

            CustomList<int> actual;

            //Act
            myList1.Add(number1);
            myList1.Add(number2);
            myList1.Add(number3);
            

            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);
            myList2.Add(number7);
            myList2.Add(number8);
            myList2.Add(number9);

            myList3.Add(number1);
            myList3.Add(number4);
            myList3.Add(number2);
            myList3.Add(number5);
            myList3.Add(number3);
            myList3.Add(number6);
            myList3.Add(number7);
            myList3.Add(number8);
            myList3.Add(number9);



            actual = myList1.ZipTowCustomListInstances(myList1, myList2);

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        [TestMethod]

        public void Zip_Test_Lists_Different_Length_2()  //listOne Longer
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();

            int number1 = 1;
            int number2 = 3;
            int number3 = 5;
            int number4 = 2;
            int number5 = 4;
            int number6 = 6;
            int number7 = 7;
            int number8 = 7;
            int number9 = 7;

            CustomList<int> actual;

            //Act
            myList2.Add(number4);
            myList2.Add(number5);
            myList2.Add(number6);


            myList1.Add(number1);
            myList1.Add(number2);
            myList1.Add(number3);
            myList1.Add(number7);
            myList1.Add(number8);
            myList1.Add(number9);

            myList3.Add(number1);
            myList3.Add(number4);
            myList3.Add(number2);
            myList3.Add(number5);
            myList3.Add(number3);
            myList3.Add(number6);
            myList3.Add(number7);
            myList3.Add(number8);
            myList3.Add(number9);



            actual = myList1.ZipTowCustomListInstances(myList1, myList2);

            CustomList<int> expected = myList3;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }


    }
}
