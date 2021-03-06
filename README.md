# Dictionary Notes
A dictionary in C# is a generic collection type in the System.Collection.Generics namespace that contains Keys and Values. Dictionary is a generic collection. So it can store key-value pairs of specific data types.

**Declaring a Dictionary**
-------------------
```cs
//A dictionary takes in a key type and value type
Dictionary<TKey, TValue> = new();
//Here we say that the key will be integers while the values will be of type string
Dictionary<int, string> myDictionary = new Dictionary<int, string>();
//Declare a dictionary with values
Dictionary<int, string> myDict = new Dictionary<int, string>(){
    {1, "one"},
    {2, "two"},
    {3, "three"}};
```

**Adding/Fetching Data to a Dictionary**
-------------------
We can add a key-value pair to an existing dictionary. We can also fetch data from a dictionary.
```cs
Dictionary<int, string> myDict = new Dictionary<int, string>();
myDict.Add(4, "four"); //Add a key-value pair
string myNum = myDict[4]; //Get the value at key 4
myDict[4] = "invalid"; //Reassign the value at key 4
```

**Check if Key Exists**
----------
```cs
Dictionary<int, string> myDict = new Dictionary<int, string>();
int key = 5;
//Method one
if(myDict.ContainsKey(key))
{
    //Do something if Key Exists
}
//Method Two (If the result exists, assign it to result)
string result;
if(myDict.TryGetValue(key, out result))
{
    //Do something if Key Exists
}
```

**ElementAt**
--------
ElementAt returns the key-value pair in a dictionary. We need the System.Linq namespace for this.
```cs
Dictionary<int, string> myDict = new Dictionary<int, string>(){
    {1, "one"},
    {2, "two"},
    {3, "three"}};
//We get the key-value pair {1, "one"}
KeyValuePair<int,string> result = myDict.ElementAt(1);
int key = result.Key;
string value = result.Value;
```

**Remove Key**
----
```cs
Dictionary<int, string> myDict = new Dictionary<int, string>(){
    {1, "one"},
    {2, "two"},
    {3, "three"}};
int keyToRemove = 3;
if(myDict.Remove(keyToRemove))
{
    //Key has been removed
}
myDict.Remove(3); //Doesn't have to be used in an if statement
```

# Hashtable Notes
A hash table (hash map) is a data structure that implements a set abstract data type, a structure that can map keys to values. Hashtable is a loosely typed (non-generic) collection, this means it stores key-value pairs of any data types. The hashtable is in the System.Collections namespace.

**Creating a Hashtable**
-------------
```cs
//Key - Value
//integer  - string for example
Hashtable myTable = new Hashtable();

//Add elements to our hashtable
myTable.Add(1, "one");
myTable.Add(2, "two");
myTable.Add("three", 3);
```

**Accessing Elements in a Hashtable**
-----
```cs
foreach(DictionaryEntry element in myTable)
{
    Console.WriteLine(element.Value); //Can use element.Key if you want the key instead
}
foreach(var element in myTable.Values) //Can use "myTable.Keys" if you want to access the keys
{
    Console.WriteLine(element);
}
/*  Both will Output:
    3
    two
    one
*/
```

**Other Hashtable Methods**
-----
Some other important methods for hashtables include the ContainsKey and Remove methods. We can also modify existing key values.
```cs
//Removing element 0 from hashtable
//First check if the key exists
if (myTable.ContainsKey(1))
{
    myTable.Remove(1); //Remove key 1
}

//Modifying a key
if (myTable.ContainsKey(1))
{
    myTable[1] = "newUser";
}
```