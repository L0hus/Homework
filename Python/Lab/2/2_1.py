
length = int(input("Введите длину помещения"))
width = int(input("Введите ширину помещения"))
height = int(input("Введите высоту помещения"))

floor = length * width
wall = ((length*height)*2)+((width*height)*2)
room = length * width * height

print("Площадь пола = ",floor)
print("Площадь стен = ",wall)
print("Объем помещения = ",room)