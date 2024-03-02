f = open("/Path/To/Text/File.txt", "r")
list = []
list_num = 0
lines = f.readlines()
f.close()

for words in lines:
    list.append(words.strip())
    
a = len(list)

def check_word(word):
    base_word = "правительство"
    base_letter_count = {letter: base_word.count(letter) for letter in set(base_word)}
    word_count = {letter: word.count(letter) for letter in set(word)}
    for letter, count in word_count.items():
        if letter not in base_letter_count or count > base_letter_count[letter]:
            return False
        return True
for i in range(0,a-1):
    list_num += 1
    if check_word(list[list_num]):
        print(list[list_num],"Correct")
    else:
        print(list[list_num],"Nope") 