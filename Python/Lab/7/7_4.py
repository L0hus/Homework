def create_word_list(sentence):
    word_list = sentence.split()
    return word_list

input_sentence = input("Введите строку из нескольких слов, разделенных пробелами: ")
print(create_word_list(input_sentence))