from tasknine import d
d_old = d
d_new = {}
for key, value in d_old.items():
    d_new[value]=key
    
print("Новый словарь:")   
for key, value in d_new.items():
    print(key," - ", value)