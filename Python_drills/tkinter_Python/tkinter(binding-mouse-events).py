from tkinter import *
from tkinter import ttk

root = Tk()

'''CREATE CANVAS'''
canvas = Canvas(root, width = 640, height = 480, background = 'white')
canvas.pack()

'''INFO ABOUT EVENT'''
def mouse_click(event):
    global prev
    prev = event
    print('type: {}'.format(event.type))
    print('widget: {}'.format(event.widget))
    print('num: {}'.format(event.num))
    print('x: {}'.format(event.x))
    print('y: {}'.format(event.y))
    print('x_root: {}'.format(event.x_root))
    print('y_root: {}'.format(event.y_root))

'''DRAW WITH MOUSE'''
def draw(event):
    global prev
    canvas.create_line(prev.x, prev.y, event.x, event.y, width = 5)
    prev = event


'''BIND MOUSE_CLICK EVENT'''
canvas.bind('<ButtonPress>', mouse_click)
canvas.bind('<B1-Motion>', draw)


root.mainloop()
