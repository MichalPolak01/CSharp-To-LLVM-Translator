using Antlr4.Runtime;
using AntlrCSharp;

string inputDirectory = @"C:\Users\dwini\Desktop\CSharpToLLVM\AntlrCSharp\Input";
string outputDirectory = @"C:\Users\dwini\Desktop\CSharpToLLVM\AntlrCSharp\Output";
string[] fileNames = { "HelloWorld.cs", "Functions.cs", "Loops.cs" };

Console.WriteLine("Podaj input:");
Console.WriteLine("1. Hello World");
Console.WriteLine("2. Functions");
Console.WriteLine("3. Loops");
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

// Generujemy plik .ll
string outputFileName = Path.ChangeExtension(selectedFileName, "ll");
string outputFilePath = Path.Combine(outputDirectory, outputFileName);
File.WriteAllText(outputFilePath, tree.ToStringTree(parser));
Console.WriteLine($"Wygenerowano plik {outputFileName}");

// Generujemy plik wsadowy .bat
string batFileName = Path.ChangeExtension(selectedFileName, "bat");
string batFilePath = Path.Combine(outputDirectory, batFileName);
string batContent = $"@echo off\nllvm-as {outputFilePath}\npause";
File.WriteAllText(batFilePath, batContent);
Console.WriteLine($"Wygenerowano plik wsadowy {batFileName}");