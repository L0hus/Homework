import random

###############################################
print("1 Задание")

words = []

for i in range(1,6):
    words.append(input("Введите {} слово : ".format(i)))
for word in words:
    print(word, end = ", ")
print()
###############################################
print("2 Задание")

numbers = []

for i in range(1,6):
    numbers.append(int(input("Введите {} число : ".format(i))))
for number in numbers:
    print(number, end = ", ")
print()
###############################################
print("Задание 3")

random_numbers = []

for i in range(0,10):
    random_numbers.append(random.randint(-30,30))
for number in random_numbers:
    print(number, end = ", ")
print()
###############################################
print("Задание 4")

print("Обратный порядок чисел")
reverse_numbers = random_numbers[:]
reverse_numbers.reverse()
for reverse in reverse_numbers:
    print(reverse, end = ", ")
print()

print("Числа в порядке возрастания")
sort_numbers = random_numbers[:]
sort_numbers.sort()
for sort in sort_numbers:
    print(sort, end = ", ")
print()

print("Числа в порядке убывания")
sort_reverse_numbers = random_numbers[:]
sort_reverse_numbers.sort()
sort_reverse_numbers.reverse()
for rev_sort in sort_reverse_numbers:
    print(rev_sort, end = ", ")
print()
###############################################
print("Задание 5")

n = int(input("Введите первое число среза : "))
m = int(input("Введите второе число среза : "))

for cut in random_numbers[n:m]:
    print(cut, end = ", ")
print()
###############################################
print("Задание 6")

for positive in random_numbers:
    if positive >= 0:
        print(positive, end = ", ")
print()
###############################################
print("Задание 7")

positive_numbers = [num for num in random_numbers[::2] if num >= 0]
print(positive_numbers)

for positive2 in random_numbers[ : : 2]:
    if positive2 >= 0:
        print(positive2, end = ", ")
print()
###############################################
print("Задание 8")

for parity in random_numbers:
    if parity >= 0:
        parity % 2 == 0
        print(parity, end = ", ")
print()
###############################################
print("Задание 9")

search = int(input("Введите искомое число : "))
if random_numbers.count(search) > 0:
    print("Порядковый номер искомого числа = ",random_numbers.index(search)+1)
else :
    print("Нет искомого числа")       
###############################################
print("Задание 10")

without_zero = []

for i in range(0,20):
    without_zero.append(random.randint(-3,3))
print()

print("До")
for zero in without_zero:
    print(zero, end = ", ")
print()

print("После")
for zero in without_zero:
    if zero != 0:
        print(zero, end = ", ")
print()
###############################################
print("Задание 11")

without_minus  = []

for i in range(0,20):
    without_minus.append(random.randint(-3,3))
print()

print("До")
for minus in without_minus:
    print(minus, end = ", ")
print()

print("После")
a = 0
while a < len(without_minus):
    if without_minus[a] < 0:
        del without_minus[a]
    else:
        a += 1
print(without_minus)