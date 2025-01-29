int[] a=new int[2];   //Array are declared with two size but 3 index
a[0]=1;
a[0]=2;
a[0]=55;

//Ya loop hud dekhti hai kitni array mn limit hai
foreach (var item in a)  //LOOP  collectiion=a(varaiable)
{
    Console.WriteLine(item);
}

// Array is limit that how many value on it
// to solve this in c# the list array is introduce
//Array list is a class
//In array you not put the string if declared with int
// but in array lit you put a data type as you need


Using System.collectiions;
ArrayList arr = new ArrayList();
arr.Add(1);
arr.Add(2);
arr.Add("Tanzeela");
foreach (var item in a)
{
    Console.WriteLine(item);
}


//To bond user that put a specific data tpe 
// two types gerneric and non-gerneraic

Using System.collectiions.Generic;
List<int> arr = new list<int>(); //To bond declrae int data <>
arr.Add(1);
arr.Add(2);
arr.Add("Tanzeela");
foreach (var item in a)
{
    Console.WriteLine(item);
}