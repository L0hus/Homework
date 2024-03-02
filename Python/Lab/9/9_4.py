path = "/Path/To/Text/File.txt"
f = open(path, "r+")

d = {}

for i in f:
    key, value = i.strip().split(":")
    d[key] = value
    
f.close()


def prety_print(d):
    for key, value in d.items():
        print(f"{key}:{value}")
        
def change_group():
    new_st = input("Введите количество новый студентов: ")
    new_st_gr = input("Введите группу с новыми студентами: ")
    d[new_st_gr] = int(d[new_st_gr]) + int(new_st)
    return d  
def add_group():
    add_gr = input("Введите новую группу: ")
    add_gr_st = input("Введите количество студентов для новой группы: ")    
    d[add_gr] = add_gr_st
    return d
def delete_group():
    group_name = input("Введите название группы: ")
    del d[group_name]
    return d

while True:
    prety_print(d)
    option = input("""
                   Выберите действие:
                   1) Изменить группу
                   2) Добавить группу
                   3) Удалить группу
                   4) Завершить работу
                   """)
    match option:
        case "1":
            d = change_group()
        case "2":
            d = add_group()
        case "3":
            d = delete_group()
        case _:
            f = open(path, "w")
            for key, value in d.items():
                f.write(f"{key} : {value}\n")
            break
        
f.close()