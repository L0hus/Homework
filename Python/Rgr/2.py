import time
from tkinter import Canvas, Tk, messagebox

W = 800
H = 600
window = Tk()
window.title('Шар')
canv = Canvas(window, width=W, height=H)
canv.pack()

ball_W = 50
ball_H = 50
x_b = 300
y_b = 120
ball = canv.create_oval (x_b, y_b, 
                        x_b + ball_W, y_b + ball_H, 
                        fill = "green") 

v_x = 5
v_y = 5

trap_W = 300
trap_H = 10
x_t = 300
y_t = 3
trap = canv.create_rectangle (x_t, y_t, 
                             x_t + trap_W, y_t + trap_H, 
                             fill = "red")
mb = messagebox.Message(message="Шар в ловушке!")
while True:
    time.sleep(0.02)
    window.update()
    x_b = x_b + v_x
    y_b = y_b + v_y
    canv.move(ball, v_x, v_y)
    if x_b + ball_W > W or x_b < 0:
        v_x = -v_x
    if y_b + ball_H > H or y_b < 0:
        v_y = -v_y
    if y_b + ball_H < y_t + trap_H + ball_H and x_t < x_b < x_t + trap_W:
        mb.show()
        break
    
canv.pack()
window.mainloop()