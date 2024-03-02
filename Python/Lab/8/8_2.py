f = open("/Path/To/Text/File.txt", "r")
for i in f:
    if i.strip():
        print(i.strip())

f.close()