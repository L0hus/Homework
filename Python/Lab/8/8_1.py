f = open("/Path/To/Text/File.txt", "r+")
a = f.read()
for word in range(0,5):
    f.write(input('Введите строку: ')+"\n")

print(a)
f.close()