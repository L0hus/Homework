import math

num1 = int(input("Введите первое число"))
num2 = int(input("Введите второе число"))
num3 = int(input("Введите третье число"))

if num1 >= num2 and num1 >= num3:
    print("Максимальное число ",num1)
elif num2 >= num1 and num2 >= num3:
    print("Максимальное число ",num2)
else :
    print("Максимальное число ",num3)