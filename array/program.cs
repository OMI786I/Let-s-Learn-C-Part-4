//using Sort() and Reverse() on an array

string [] pallets = [ "B14", "A11", "B12", "A13" ];

string [] pallets2 = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine(pallets);

Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Array.Reverse(pallets2);

foreach (var item in pallets2)
{
    Console.WriteLine($"{item}");
}






//using Clear() and Resize() on an array


string[] pallets3 =  ["B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets3, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets3.Length}");
foreach (var pallet in pallets3)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets3, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets3.Length}");

pallets3[4] = "C01";
pallets3[5] = "C02";

foreach (var pallet in pallets3)
{
    Console.WriteLine($"-- {pallet}");
}



// reverse a string

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);


// join

string value2 = "abc123";
char[] valueArray2 = value2.ToCharArray();
Array.Reverse(valueArray2);
// string result = new string(valueArray);
string result2 = String.Join(",", valueArray2);
Console.WriteLine(result2);


// split

string[] items = result2.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}




//exercsie: Complete a challenge to reverse words in a sentence

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result5 = String.Join(" ", newMessage);
Console.WriteLine(result5);



//Review a solution to parse a string of orders, sort orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] items3 = orderStream.Split(',');

Array.Sort(items3);

foreach (var item in items3)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }

    else
    {
        Console.WriteLine($"Error {item}");
    }
}