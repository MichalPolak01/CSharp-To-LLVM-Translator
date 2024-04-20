using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using AntlrCSharp;

string input = Console.ReadLine();

AntlrInputStream inputStream = new AntlrInputStream(input);
MathLexer lexer = new MathLexer(inputStream);
CommonTokenStream tokenStream = new CommonTokenStream(lexer);
MathParser parser = new MathParser(tokenStream);

IParseTree tree = parser.start();

ParseTreeWalker walker = new ParseTreeWalker();
CalculatorVisitor visitor = new CalculatorVisitor();
int result = visitor.Visit(tree);

Console.WriteLine("Result: " + result);