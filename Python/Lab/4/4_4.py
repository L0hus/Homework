n = int(input("n = "))
num = 1
sum = 0

while num <= n :
    sum += num**2
    num += 1
print("Первая сумма квадратов",sum)

for i in range(num,n-1) :
    num += 1
    sum += num **2
print("Вторая сумма квадратов ", sum)