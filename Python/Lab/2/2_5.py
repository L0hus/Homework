import random

m = int(random.randint(100,1000))

min = m % 60
h = (m - min) / 60

print(int(h)," Часов ",int(min)," Минут ")
print("Сгенерированно ",m," минут")