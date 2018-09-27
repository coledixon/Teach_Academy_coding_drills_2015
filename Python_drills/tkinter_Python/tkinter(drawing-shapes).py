from tkinter import *

root = Tk()
canvas = Canvas(root)
canvas.pack()
canvas.config(width = 640, height = 480)

'''DRAW RECTANGLE'''
rect = canvas.create_rectangle(160, 120, 480, 360)
canvas.itemconfigure(rect, fill = 'yellow')

'''DRAW OVAL'''
oval = canvas.create_oval(160, 120, 480, 360)

'''DRAW ARC'''
arc = canvas.create_arc(160, 1, 480, 240)
canvas.itemconfigure(arc, start = 0, extent = 180, fill = 'pink')

'''DRAW POLYGON'''
poly = canvas.create_polygon(160, 360, 320, 480, 480, 360, fill = 'grey')

'''ADD TEXT/IMAGE'''
text = canvas.create_text(320, 240, text = 'PYTHON', font = ('Courier', 32, 'bold'))
img = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif')
logo = canvas.create_image(320, 240, image = img)
canvas.lift(text)

'''ADD BUTTON'''
button = Button(canvas, text = 'CLICK')
canvas.create_window(320, 60, window = button)

'''ADD TAGS'''
canvas.itemconfigure(rect, tag = ('shape'))
canvas.itemconfigure(oval, tag = ('shape', 'round'))
canvas.itemconfigure('shape', fill = 'black')

root.mainloop()