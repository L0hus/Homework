string = str(input("Введите слова с буквой 'ф' : "))

lower = string.count("ф")
upper = string.count("Ф")

print("Количество заглавных букв в строке: ",upper)
print("Количество строчных букв в строке: ",lower)