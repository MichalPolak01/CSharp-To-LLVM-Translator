using Antlr4.Runtime;
using AntlrCSharp;

string inputDirectory = @"C:\Users\dwini\Desktop\Test2\AntlrCSharp\Input";
string outputDirectory = @"C:\Users\dwini\Desktop\Test2\AntlrCSharp\Output";
string[] fileNames = { "HelloWorld.cs", "Functions.cs", "Loops.cs" };

Console.WriteLine("Podaj input:");
Console.WriteLine("\n1. Hello World");
Console.WriteLine("\n2. Functions");
Console.WriteLine("\n3. Loops");
string input = Console.ReadLine();

int choice;
if (!int.TryParse(input, out choice) || choice < 1 || choice > fileNames.Length)
{
    Console.WriteLine("Nieprawidłowy wybór. Wybieram domyślny plik.");
    choice = 1;
}

string selectedFileName = fileNames[choice - 1];
string selectedFilePath = Path.Combine(inputDirectory, selectedFileName);

// Sprawdzenie czy plik istnieje
if (!File.Exists(selectedFilePath))
{
    Console.WriteLine("Wybrany plik nie istnieje. Wybieram domyślny plik.");
    selectedFilePath = Path.Combine(inputDirectory, fileNames[0]);
}

string sourceCode = File.ReadAllText(selectedFilePath);

// Tworzymy obiekt analizatora i leksera
var lexer = new CSharpLexer(new AntlrInputStream(sourceCode));
var tokens = new CommonTokenStream(lexer);
var parser = new CSharpParser(tokens);

// Pobieramy korzeń drzewa składniowego
var tree = parser.compilationUnit();

// Wyświetlamy drzewo parsowania
Console.WriteLine(tree.ToStringTree(parser));

// Generujemy plik .ir
string outputFileName = Path.ChangeExtension(selectedFileName, "ir");
string outputFilePath = Path.Combine(outputDirectory, outputFileName);
File.WriteAllText(outputFilePath, tree.ToStringTree(parser));
Console.WriteLine($"Wygenerowano plik {outputFileName}");