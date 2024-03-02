password = 1234
num = int(input("Введите пароль: "))

while password != num :
    num = int(input("Неверный пароль, повторите попытку :"))
    continue
print("Пароль верный")