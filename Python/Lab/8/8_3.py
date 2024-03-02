list = []
f = open("/Path/To/Text/File.txt", "r")

for i in f:
    if i.strip():
        list.append(i.strip())
print(list)
f.close()