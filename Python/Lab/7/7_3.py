def check_password(password):
    if len(password) < 5:
        return "Пароль слишком короткий"
    elif not password.isalnum():
        return "Пароль должен состоять только из букв латинского алфавита и цифр"
    elif not any(char.isdigit() for char in password) or not any(char.isalpha() for char in password):
        return "Пароль должен содержать и буквы, и цифры"
    elif not any(char.isupper() for char in password):
        return "Пароль должен содержать как буквы в верхнем регистре, так и цифры"
    elif any(ord(char) > 128 for char in password):
        return "Пароль не должен содержать кириллические символы"
    elif any(not char.isalnum() for char in password):
        return "Пароль не должен содержать символы"
    else:
        return "Пароль соответствует требованиям"

password = input("Введите пароль для проверки: ")
print(check_password(password))