import math

R1 = int(input("Введите сопротивление первого резостора"))
R2 = int(input("Введите сопротивление второго резостора"))
R3 = int(input("Введите сопротивление третьего резостора"))

R123 = R1 + R2 + R3
R321 = 1/(1/R1+1/R2+1/R3)

print("При последовательном = ",R123," Ом")
print("При параллельном = ",R321," Ом")