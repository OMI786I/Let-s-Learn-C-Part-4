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