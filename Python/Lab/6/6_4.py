def fib(n):
    a = 0
    b = 1
    for i in range(n):
        a, b = b, a + b
    return a
print(fib(n = int(input("n = "))))