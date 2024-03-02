import math
import random

# print("Нужный результат", 2.142639663747653, "\n")

# def sqr(a, b):
#     w = (b - a) / 100
#     s = 0
#     x = a + w/2
#     while x < b:
#         s += w*(math.sin(x) + (2 * math.cos(x)))
#         x += w
#     return s  
# print("Методом прямоугольноков: ",sqr(0, 1))


# exam = 2.142639663747653 / 100 * 10
# print('Минимальный результат с погрешностью: ', 2.142639663747653 - exam, "\nМаксимальный результат: 2.142639663747653")

# def Monte(a,b):
#     k = 0
#     h = 2
#     for i in range(10000):
#         x = random.uniform(a, b)
#         y = random.uniform(0, h)
#         if y < (math.sin(x) + (2 * math.cos(x))):
#             k += 1
#     s = h * (b - a) * k / 10000
#     return s
# print("Метод Монте Карло: ",Monte(0,1))

def f(x):
    if 1 <= x:
        return math.sin(x) + (2 * math.cos(x))
    elif 2 <= x:
        return (2 * math.sin(x)) + math.cos(x)
    elif 3 <= x and x < 4:
       return math.cos(2 * x)
    else:
        # print("функция не задана при данном X")
        return 0
    
step = 0.1
a = x = 0
b = 15

print("{:^19}|{:^19}".format("x", "f(x)"))
print("-----------------------------------------")

while x <= b:
    print(f"{x:^17.1f}  |  {f(x):^13.3f}")
    print("-----------------------------------------")
    x += step