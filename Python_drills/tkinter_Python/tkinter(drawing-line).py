from tkinter import *

root = Tk()
canvas = Canvas(root)
canvas.pack()
canvas.config(width = 640, height = 480)

'''DRAW A LINE'''
line = canvas.create_line(160, 360, 480, 120, fill = 'black', width = 5)

'''COORDINATES OF LINE'''
canvas.itemconfigure(line, fill = 'green')
canvas.coords(line)
canvas.coords(line, 0, 0, 320, 240, 640, 0)

'''SMOOTHING LINE'''
canvas.itemconfigure(line, smooth = True)
canvas.itemconfigure(line, splinesteps = 5)
canvas.itemconfigure(line, splinesteps = 100)

'''DELETING LINE'''
canvas.delete(line)

root.mainloop()
