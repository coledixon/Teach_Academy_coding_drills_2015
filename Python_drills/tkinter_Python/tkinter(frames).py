from tkinter import *
from tkinter import ttk

root = Tk()
frame = ttk.Frame(root)
frame.pack()
frame.config(height = 100, width = 200)
frame.config(relief = RIDGE)
ttk.Button(frame, text = 'CLICK').grid()
frame.config(padding = (30, 15))
ttk.LabelFrame(root, height = 100, width = 200, text = 'FRAME PRACTICE').pack()

root.mainloop()
