@str.Function = private unnamed_addr constant [9 x i8] c"Function\00"

declare void @Console.WriteLine(i8*)

; Class declaration
%Functions = type { }

; Method declaration for Count
define dso_local void @Count() {
entry:
call void @Console.WriteLine(i8* getelementptr inbounds ([9 x i8], [9 x i8]* @str.Function, i32 0, i32 0))
ret void
}

; Method declaration for main
define dso_local void @main() {
entry:
call void @Count()
ret void
}
