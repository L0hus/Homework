import math
from tkinter import *

m = 100
x0 = 250
y0 = 300

def func(x):
    x_e = x0 + x*m
    y = math.sin(x) + (2 * math.cos(x))
    y_e = y0 -y*m
    return [x_e, y_e]

window = Tk()
window.title('График функции')
H = 600
W =700
canv = Canvas(window, width= W, height= H, bg = "black")
canv.pack()
canv.create_text (350, 20,
                 text = "Функция y = sin(x) + 2cos(x) на отрезке [0,1]",
                 font = "bold 14")
canv.create_line(0, y0, W, y0, width=2, fill = "blue")
canv.create_line(x0, 50, x0, H, width=2, fill = "blue")

a = -2
b = 3
step = (b - a)/m

x = a
while x <= b:
    x_e, y_e = func(x) [0], func(x) [1]
    canv.create_line(x_e, y_e, x_e+1, y_e+1, width=2)
    x += step
    
canv.pack()
window.mainloop()