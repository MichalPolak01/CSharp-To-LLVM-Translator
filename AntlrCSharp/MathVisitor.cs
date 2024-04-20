using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrCSharp
{
    public class MathVisitor : MathBaseVisitor<double>
    {
        public override double VisitExpression(MathParser.ExpressionContext context)
        {
            double result = Visit(context.term(0));
            for (int i = 1; i < context.ChildCount; i += 2)
            {
                var operatorToken = context.GetChild(i).GetText();
                var nextTerm = context.GetChild(i + 1);

                if (nextTerm != null && nextTerm is MathParser.TermContext)
                {
                    double right = Visit((MathParser.TermContext)nextTerm);
                    Console.WriteLine($"Operator: {operatorToken}, Next term: {right}");
                    if (operatorToken == "+")
                    {
                        result += right;
                    }
                    else
                    {
                        result -= right;
                    }
                }
            }
            return result;
        }

        public override double VisitTerm(MathParser.TermContext context)
        {
            double result = Visit(context.factor(0));
            for (int i = 1; i < context.ChildCount; i += 2)
            {
                var operatorToken = context.GetChild(i).GetText();
                var nextFactor = context.GetChild(i + 1) as MathParser.FactorContext;
                if (nextFactor != null)
                {
                    double right = Visit(nextFactor);
                    Console.WriteLine($"Operator: {operatorToken}, Next term: {right}");
                    if (operatorToken == "*")
                    {
                        result *= right;
                    }
                    else if (operatorToken == "/")
                    {
                        result /= right;
                    }
                }
            }
            return result;
        }


        public override double VisitFactor(MathParser.FactorContext context)
        {
            if (context.NUMBER() != null)
            {
                return double.Parse(context.NUMBER().GetText());
            }
            else
            {
                return Visit(context.expression());
            }
        }
    }
}