import math

def V(figure,H = 0, R = 0):
    if figure == "cube":
        return print("Cube V = ", H**3)
    elif figure == "ball":
        return print("Ball V =", (4/3)*math.pi*R**3)
    elif figure == "cone":
        return print("Cone V = ", (1/3)*math.pi*R**2*H)
    else :
        return None
print(V("cube", H = int(input("Cube H = "))))
print(V("ball", H = 0, R = int(input("Ball R = "))))
print(V("cone",H = int(input("Cone H = ")), R = int(input("Cone R = "))))