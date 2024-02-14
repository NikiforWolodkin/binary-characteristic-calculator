Console.Write("Enter a string: ");
var input = Console.ReadLine();
input = input.Replace(" ", "");

var totalZeros = 0;
var totalOnes = 0;

foreach (char c in input)
{
    var binary = Convert.ToString(c, 2).PadLeft(7, '0');
    var zeros = binary.Count(b => b == '0');
    var ones = binary.Count(b => b == '1');

    totalZeros += zeros;
    totalOnes += ones;

    Console.WriteLine($"Character: {c} - ASCII: {((int)c).ToString().PadRight(3)} - Binary code: {binary}, Zeros: {zeros}, Ones: {ones}");
}

var totalBits = totalZeros + totalOnes;
var zeroProbability = (double)totalZeros / totalBits;
var oneProbability = (double)totalOnes / totalBits;

Console.WriteLine($"Total number of bits: {totalBits}");
Console.WriteLine($"Total number of zeros: {totalZeros}, Total number of ones: {totalOnes}");
Console.WriteLine($"Probability of zero: {totalZeros} / {totalBits} = {zeroProbability}");
Console.WriteLine($"Probability of one: {totalOnes} / {totalBits} = {oneProbability}");