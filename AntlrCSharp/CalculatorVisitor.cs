using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrCSharp
{
    public class CalculatorVisitor : MathBaseVisitor<int>
    {
        public override int VisitExpr(MathParser.ExprContext context)
        {
            int left = Visit(context.term(0));
            for (int i = 1; i < context.term().Length; i++)
            {
                int right = Visit(context.term(i));
                if (context.GetChild(i).GetText() == "+")
                {
                    left += right;
                }
                else
                {
                    left -= right;
                }
            }
            return left;
        }

        public override int VisitTerm(MathParser.TermContext context)
        {
            int result = Visit(context.factor(0));
            for (int i = 1; i < context.factor().Length; i++)
            {
                int right = Visit(context.factor(i));
                if (context.GetChild(i).GetText() == "*")
                {
                    result *= right;
                }
                else
                {
                    result /= right;
                }
            }
            return result;
        }

        public override int VisitFactor(MathParser.FactorContext context)
        {
            if (context.INT() != null)
            {
                return int.Parse(context.INT().GetText());
            }
            else
            {
                return Visit(context.expr());
            }
        }
    }
}
