using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using AntlrCSharp;

Console.WriteLine("Podaj wyrażenie matematyczne:");
string input = Console.ReadLine();

// Tworzymy obiekt analizatora i leksera
var lexer = new MathLexer(new Antlr4.Runtime.AntlrInputStream(input));
var tokens = new Antlr4.Runtime.CommonTokenStream(lexer);
var parser = new MathParser(tokens);

// Pobieramy korzeń drzewa składniowego
var expressionContext = parser.expression();

// Wyświetlamy drzewo parsowania
Console.WriteLine(expressionContext.ToStringTree(parser));

// Tworzymy obiekt wizytora i odwiedzamy korzeń drzewa składniowego
var visitor = new MathVisitor();
double result = visitor.Visit(expressionContext);

Console.WriteLine($"Wynik: {result}");