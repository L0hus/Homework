attempts = 1
password = 1234
num = int(input("Введите пароль: "))

while attempts != 6 :
    if password != num :
        attempts += 1
        num = int(input("Неверный пароль, повторите попытку: "))
    else :
        print("Пароль верный")
        break
    if attempts == 5 and password != num :
        print("У вас закончились попытки")
        break
    continue