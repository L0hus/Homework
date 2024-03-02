import random

f = open("/Path/To/Text/File.txt", "r+")
for i in range (0,10): 
    f.write(str(random.randint(1,100))+'\n')
f.close()