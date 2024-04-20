using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using AntlrCSharp;

string input = "2-5*5";
AntlrInputStream inputStream = new AntlrInputStream(input);
MathLexer lexer = new MathLexer(inputStream);
CommonTokenStream tokenStream = new CommonTokenStream(lexer);
MathParser parser = new MathParser(tokenStream);

IParseTree tree = parser.expression();
MathVisitor visitor = new MathVisitor();
double result = visitor.Visit(tree);
Console.WriteLine($"Result: {result}");