using Antlr4.Runtime;
using AntlrCSharp;

Console.WriteLine("Podaj kod C#:");
string input = Console.ReadLine();

// Tworzymy obiekt analizatora i leksera
var lexer = new CSharpLexer(new AntlrInputStream(input));
var tokens = new CommonTokenStream(lexer);
var parser = new CSharpParser(tokens);

// Pobieramy korzeń drzewa składniowego
var tree = parser.compilationUnit();

// Wyświetlamy drzewo parsowania
Console.WriteLine(tree.ToStringTree(parser));