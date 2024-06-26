//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dwini\Desktop\CSharpToLLVM\AntlrCSharp\CSharp.g4 by ANTLR 4.6.6

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
/// <see cref="CSharpParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ICSharpListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] CSharpParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] CSharpParser.CompilationUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingDirective([NotNull] CSharpParser.UsingDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.usingDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingDirective([NotNull] CSharpParser.UsingDirectiveContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.globalAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalAttribute([NotNull] CSharpParser.GlobalAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.globalAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalAttribute([NotNull] CSharpParser.GlobalAttributeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceDeclaration([NotNull] CSharpParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceDeclaration([NotNull] CSharpParser.NamespaceDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDeclaration([NotNull] CSharpParser.TypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDeclaration([NotNull] CSharpParser.TypeDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] CSharpParser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] CSharpParser.ClassDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDeclaration([NotNull] CSharpParser.InterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDeclaration([NotNull] CSharpParser.InterfaceDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclaration([NotNull] CSharpParser.StructDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclaration([NotNull] CSharpParser.StructDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumDeclaration([NotNull] CSharpParser.EnumDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumDeclaration([NotNull] CSharpParser.EnumDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.baseList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseList([NotNull] CSharpParser.BaseListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.baseList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseList([NotNull] CSharpParser.BaseListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBody([NotNull] CSharpParser.ClassBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBody([NotNull] CSharpParser.ClassBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceBody([NotNull] CSharpParser.InterfaceBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceBody([NotNull] CSharpParser.InterfaceBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.structBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructBody([NotNull] CSharpParser.StructBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.structBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructBody([NotNull] CSharpParser.StructBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBody([NotNull] CSharpParser.EnumBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBody([NotNull] CSharpParser.EnumBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassMemberDeclaration([NotNull] CSharpParser.ClassMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassMemberDeclaration([NotNull] CSharpParser.ClassMemberDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMemberDeclaration([NotNull] CSharpParser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMemberDeclaration([NotNull] CSharpParser.InterfaceMemberDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.structMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructMemberDeclaration([NotNull] CSharpParser.StructMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.structMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructMemberDeclaration([NotNull] CSharpParser.StructMemberDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclaration([NotNull] CSharpParser.MethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclaration([NotNull] CSharpParser.MethodDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.methodModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodModifiers([NotNull] CSharpParser.MethodModifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.methodModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodModifiers([NotNull] CSharpParser.MethodModifiersContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessModifier([NotNull] CSharpParser.AccessModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessModifier([NotNull] CSharpParser.AccessModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.otherModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOtherModifier([NotNull] CSharpParser.OtherModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.otherModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOtherModifier([NotNull] CSharpParser.OtherModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldDeclaration([NotNull] CSharpParser.FieldDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldDeclaration([NotNull] CSharpParser.FieldDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enumMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumMember([NotNull] CSharpParser.EnumMemberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enumMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumMember([NotNull] CSharpParser.EnumMemberContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnType([NotNull] CSharpParser.ReturnTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.returnType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnType([NotNull] CSharpParser.ReturnTypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] CSharpParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] CSharpParser.TypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedIdentifier([NotNull] CSharpParser.QualifiedIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedIdentifier([NotNull] CSharpParser.QualifiedIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterList([NotNull] CSharpParser.TypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterList([NotNull] CSharpParser.TypeParameterListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] CSharpParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] CSharpParser.ParameterListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] CSharpParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] CSharpParser.ParameterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] CSharpParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] CSharpParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CSharpParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CSharpParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclaration([NotNull] CSharpParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclaration([NotNull] CSharpParser.LocalVariableDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] CSharpParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] CSharpParser.ReturnStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] CSharpParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] CSharpParser.IfStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.elseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseClause([NotNull] CSharpParser.ElseClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.elseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseClause([NotNull] CSharpParser.ElseClauseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] CSharpParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] CSharpParser.WhileStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] CSharpParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] CSharpParser.ForStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CSharpParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CSharpParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] CSharpParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] CSharpParser.AssignmentExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalExpression([NotNull] CSharpParser.ConditionalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalExpression([NotNull] CSharpParser.ConditionalExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOrExpression([NotNull] CSharpParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOrExpression([NotNull] CSharpParser.LogicalOrExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalAndExpression([NotNull] CSharpParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalAndExpression([NotNull] CSharpParser.LogicalAndExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] CSharpParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] CSharpParser.EqualityExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] CSharpParser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] CSharpParser.RelationalExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] CSharpParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] CSharpParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] CSharpParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] CSharpParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] CSharpParser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] CSharpParser.UnaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixExpression([NotNull] CSharpParser.PostfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixExpression([NotNull] CSharpParser.PostfixExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] CSharpParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] CSharpParser.PrimaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodCall([NotNull] CSharpParser.MethodCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodCall([NotNull] CSharpParser.MethodCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.memberAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberAccess([NotNull] CSharpParser.MemberAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.memberAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberAccess([NotNull] CSharpParser.MemberAccessContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.functionCallStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallStatement([NotNull] CSharpParser.FunctionCallStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.functionCallStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallStatement([NotNull] CSharpParser.FunctionCallStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attributeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeList([NotNull] CSharpParser.AttributeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attributeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeList([NotNull] CSharpParser.AttributeListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] CSharpParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] CSharpParser.AttributeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attributeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeArgumentList([NotNull] CSharpParser.AttributeArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attributeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeArgumentList([NotNull] CSharpParser.AttributeArgumentListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attributeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeArgument([NotNull] CSharpParser.AttributeArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attributeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeArgument([NotNull] CSharpParser.AttributeArgumentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.comparisonOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonOperator([NotNull] CSharpParser.ComparisonOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.comparisonOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonOperator([NotNull] CSharpParser.ComparisonOperatorContext context);
}
} // namespace AntlrCSharp
