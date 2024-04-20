grammar Math;

// Definiujemy reguły gramatyczne dla prostego kalkulatora
start: expression EOF;
expression: term (('+' | '-') term)*;
term: factor (('*' | '/') factor)*;
factor: NUMBER | '(' expression ')';
NUMBER: ('0' ..'9')+ ('.' ('0' ..'9')*)?;
WS: [ \t\r\n]+ -> skip; // Pomijamy bi=