import math

num1 = int(input("Введите первое число "))
num2 = int(input("Введите второе число "))
calc = num1 % num2

if calc == 0:
    print("Сисла делятся нацело")
else :
    print("Числа не деляться нацело")