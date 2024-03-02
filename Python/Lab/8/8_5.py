f = open("/Path/To/Text/File.txt", "r")
lines = f.readlines()
f.close()

a = 1

for i in lines:
    if i.strip().isdigit():
        a *= int(i.strip())
        continue
print(a)