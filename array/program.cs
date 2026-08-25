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
