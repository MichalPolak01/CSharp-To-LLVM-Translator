grammar Math;

// Parser Rules
expression : term (('+'|'-') term)* ;

term : factor (('*'|'/') factor)* ;

factor : NUMBER | '(' expression ')' ;

// Lexer Rules
NUMBER : [0-9]+ ;
WS : [ \t\r\n]+ -> skip ;