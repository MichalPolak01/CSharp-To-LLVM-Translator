//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dwini\Desktop\Test2\AntlrCSharp\Math.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrCSharp {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MathParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMathListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] MathParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] MathParser.StartContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] MathParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] MathParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] MathParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] MathParser.TermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MathParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] MathParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MathParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] MathParser.FactorContext context);
}
} // namespace AntlrCSharp
