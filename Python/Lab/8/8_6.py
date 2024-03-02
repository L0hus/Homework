f = open("/Path/To/Text/File.txt", "r")
lines =  f.readlines()
f.close()

list=[]

for i in lines:
    if i.strip().isdigit():
        list.append(str(i.strip()))

min = int(min(list))
max = int(max(list))

print("max = ", max, "\nmin = ", min,"\nsum = ", min + max)