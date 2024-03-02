d = {"ИБ-111": 32, 
     "ИБ-121": 28, 
     "ИБ-131": 25, 
     "ИБ-210": 30,
     "ИБ-220": 28,
     "ИБ-230": 17,
     "ИБ-319": 24,
     "ИБ-329": 20,
     "ИБ-339": 14,
     "ИБ-418": 20,
     "ИБ-428": 25,
     "ИБ-438": 13,}

print("Старый список групп:")
for key, value in d.items():
    print(key, " - ", value)


new_st = int(input("Введите количество новый студентов: "))
new_st_gr = input("Введите группу с новыми студентами: ")

d[new_st_gr] = d[new_st_gr] + new_st

d["ИТ-112"] = 20

del d["ИБ-339"]

sum = 0

for key, value in d.items():
    sum += value
print("Сумма студентов = ",sum)


for key, value in d.items():
    print(key, " - ", value)
    
