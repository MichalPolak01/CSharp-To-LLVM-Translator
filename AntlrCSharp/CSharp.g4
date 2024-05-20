grammar CSharp;

// Parser Rules
compilationUnit : (usingDirective | globalAttribute | namespaceDeclaration | typeDeclaration)* EOF ;

usingDirective : 'using' (IDENTIFIER ('.' IDENTIFIER)* ';' | 'static' 'void' IDENTIFIER '(' parameterList? ')' block) ;

globalAttribute : '[' 'assembly' ':' attributeList ']' ;

namespaceDeclaration : 'namespace' qualifiedIdentifier '{' (usingDirective | typeDeclaration)* '}' ;

typeDeclaration : classDeclaration
                | interfaceDeclaration
                | structDeclaration
                | enumDeclaration ;

classDeclaration : 'partial'? 'class' IDENTIFIER ('<' typeParameterList '>')? ('base' baseList)? '{' classBody '}' ;

interfaceDeclaration : 'interface' IDENTIFIER ('<' typeParameterList '>')? ('base' baseList)? '{' interfaceBody '}' ;

structDeclaration : 'struct' IDENTIFIER ('<' typeParameterList '>')? ('base' baseList)? '{' structBody '}' ;

enumDeclaration : 'enum' IDENTIFIER '{' enumBody '}' ;

baseList : ':' type (',' type)* ;

classBody : (classMemberDeclaration)* ;

interfaceBody : (interfaceMemberDeclaration)* ;

structBody : (structMemberDeclaration)* ;

enumBody : enumMember (',' enumMember)* ;

classMemberDeclaration : methodDeclaration | fieldDeclaration ;

interfaceMemberDeclaration : methodDeclaration ;

structMemberDeclaration : methodDeclaration | fieldDeclaration ;

methodDeclaration : modifiers? returnType IDENTIFIER '(' parameterList? ')' block ;

modifiers : 'static' ;

fieldDeclaration : type IDENTIFIER ('=' expression)? ';' ;

enumMember : IDENTIFIER ('=' expression)? ;

returnType : type | 'void' ;

type : qualifiedIdentifier ;

qualifiedIdentifier : IDENTIFIER ('.' IDENTIFIER)* ;

typeParameterList : IDENTIFIER (',' IDENTIFIER)* ;

parameterList : parameter (',' parameter)* ;

parameter : type IDENTIFIER
          | type '[' ']' IDENTIFIER; // Poprawna obsługa typu tablicowego

block : '{' statement* '}' ;

statement : localVariableDeclaration
          | expressionStatement
          | returnStatement ;

localVariableDeclaration : type IDENTIFIER ('=' expression)? ';' ;

expressionStatement : expression ';' ;

returnStatement : 'return' expression? ';' ;

expression : assignmentExpression 
           | methodCall // Dodana reguła dla wywołań metod
           ;

assignmentExpression : IDENTIFIER '=' expression
                     | additiveExpression ;

additiveExpression : multiplicativeExpression (('+'|'-') multiplicativeExpression)* ;

multiplicativeExpression : primaryExpression (('*'|'/') primaryExpression)* ;

primaryExpression : IDENTIFIER
                  | LITERAL
                  | '[' .*? ']' // '[' and ']' treated as part of literal
                  | '(' expression ')'
                  ;

methodCall : memberAccess '(' (expression (',' expression)*)? ')' ; // Reguła dla wywołań metod

memberAccess : IDENTIFIER ('.' IDENTIFIER)* ; // Dodana reguła dla dostępu do członków

attributeList : '[' (attribute (',' attribute)*)? ']' ;

attribute : IDENTIFIER ('.' IDENTIFIER)* ('(' attributeArgumentList? ')')? ;

attributeArgumentList : attributeArgument (',' attributeArgument)* ;

attributeArgument : IDENTIFIER '=' (IDENTIFIER | LITERAL) ;

IDENTIFIER : [a-zA-Z_][a-zA-Z_0-9]* ;
LITERAL : [0-9]+ | '"' .*? '"' | '\'' . '\'' ;
WS : [ \t\r\n]+ -> skip ;
