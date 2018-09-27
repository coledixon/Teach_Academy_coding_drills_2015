from tkinter import *
from tkinter import ttk

root = Tk()

'''CREATE METHOD'''
def callback(number):
    print(number)

'''CREATE BUTTON / ADD METHOD'''
ttk.Button(root, text = '1', command = lambda: callback(1)).pack()
ttk.Button(root, text = '2', command = lambda: callback(2)).pack()
ttk.Button(root, text = '3', command = lambda: callback(3)).pack()



root.mainloop()
