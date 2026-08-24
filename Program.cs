int first = 4;
string second = "4";
string result = first + second;

Console.WriteLine(first + second);


//ways to change data types

// 1

int myint = 3;
Console.WriteLine($"{myint}");

decimal mydecimal = myint;
Console.WriteLine($"{mydecimal}");


// 2 performing a cast

decimal mydecimal2 = 3.24m;
Console.WriteLine($"{mydecimal2}");

int myint2 = (int) mydecimal2;
Console.WriteLine($"{myint2}");


// 3 using "Tostring()" method; to turn "int to string".


int first2 = 5;
int second2 = 7;

string message = first2.ToString() + second2.ToString();

Console.WriteLine(message);

// 4 using "Parse()" helper method to turn "string to int"


string myfirstString = "1";
string mySecondString = "2";

int sum = int.Parse(myfirstString) + int.Parse(mySecondString);

Console.WriteLine(sum);



// 5 Convert a string to a int using the Convert class


string value1 = "5";
string value2 = "7";
int result3 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result3);