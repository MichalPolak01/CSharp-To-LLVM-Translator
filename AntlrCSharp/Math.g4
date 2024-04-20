grammar Math;

// Regu�y leksykalne
INT: [0-9]+;
WS: [ \t\r\n]+ -> skip;

// Regu�y gramatyczne
start: expr EOF;

expr: term (('+'|'-') term)*;

term: factor (('*'|'/') factor)*;

factor: INT | '(' expr ')';