grammar Math;

// Regu³y leksykalne
INT: [0-9]+;
WS: [ \t\r\n]+ -> skip;

// Regu³y gramatyczne
start: expr EOF;

expr: term (('+'|'-') term)*;

term: factor (('*'|'/') factor)*;

factor: INT | '(' expr ')';