import math

a = int(input("a = "))
b = int(input("b = "))
c = int(input("с = "))

D = b**2 - 4*a*c

if D > 0 :
    x1 = (-b -math.sqrt(D))/2*a
    x2 = (-b +math.sqrt(D))/2*a
    if x1 >= x2 :
        print("Максимальный корень = ",x1)
    else :
        print("Максимальный корень = ",x2)
elif D == 0 :
    x = -b/(2*a) 
    print("корень = ", x)
else :
    print("Корней нет")