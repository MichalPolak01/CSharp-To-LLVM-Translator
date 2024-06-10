; Class declaration
%Functions = type { }

; External declaration of the Console.WriteLine method
declare void @Console.WriteLine(i8*)

; Method declaration for Main
define void @Main() {
entry:
    call void @Count()
    ret void
}

; Method declaration for Count
define void @Count() {
entry:
    %str = alloca i8*, align 8
    store i8* getelementptr ([9 x i8], [9 x i8]* @str.Function, i32 0, i32 0), i8** %str, align 8
    %0 = load i8*, i8** %str, align 8
    call void @Console.WriteLine(i8* %0)
    ret void
}

; Constant string "Function"
@str.Function = private unnamed_addr constant [9 x i8] c"Function\00"
