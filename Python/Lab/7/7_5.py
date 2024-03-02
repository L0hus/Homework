def check_word(word):
    base_word = "правительство"
    base_letter_count = {letter: base_word.count(letter) for letter in set(base_word)}
    word_count = {letter: word.count(letter) for letter in set(word)}
    for letter, count in word_count.items():
        if letter not in base_letter_count or count > base_letter_count[letter]:
            return False
        return True
input_word = input("Введите слово для проверки: ")
if check_word(input_word):
    print("Слово '", input_word,"' можно составить из букв слова 'правительство'")
else:
    print("Слово '", input_word,"' нельзя составить из букв слова 'правительство'")