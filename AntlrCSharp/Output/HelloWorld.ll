; ModuleID = 'my_module'
declare i32 @printf(i8*, ...)
@format_str = constant [15 x i8] c"Hello, World!\0A\00"
define i32 @main() {
entry:
  %0 = call i32 (i8*, ...) @printf(i8* getelementptr ([15 x i8], [15 x i8]* @format_str, i32 0, i32 0))
  ret i32 0
}
