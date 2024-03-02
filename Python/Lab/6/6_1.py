def sqrt(x,y,n):
    while x <= n:
        y += x**2
        x += 1
    return y
print(sqrt(1,0,n = int(input("n = "))))