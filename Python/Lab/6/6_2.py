import math

def sqrt(a,b,c):
    D = b**2 - 4*a*c
    if D > 0:
        x1 = (-b -math.sqrt(D))/2*a
        x2 = (-b +math.sqrt(D))/2*a
        return print("x1 = ",int(x1)," x2 = ",int(x2))
    elif D == 0:
        x = -b/(2*a)
        return print("x = ",int(x))
    else :
        return None
print(sqrt(a = int(input("a = ")), b = int(input("b = ")), c = int(input("c = "))))