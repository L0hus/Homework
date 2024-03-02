d = {"Город": "City", "Я": "I","Ты": "You","Страна": "Country", "Язык": "Language", "Проверить": "Check", "Москва": "Moscow", "Россия": "Russia", "Правильно": "True", "Один": "One"} 

word = input("Введите русское слово для перевода: ")
eng_word = input("Введите английское слово для перевода: ")
rus = ""

if word in d:
    print("Английский перевод слова ", word,": ", d[word])
else:
    print("Такого слова нет в словаре")

for russian, english in d.items():
    if english == eng_word:
        rus = russian
        break
if rus:
    print("Перевод слова ", eng_word, ":", rus)
else:
    print("Такого слова нет в словаре")

print("Весь словарь:")
for key, value in d.items():
    print(key," - ", value)