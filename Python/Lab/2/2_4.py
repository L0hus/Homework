m = int(input("Введите минуты"))

min = m % 60
h = (m - min)/60

print(int(h)," часов" ,int(min)," минут ")