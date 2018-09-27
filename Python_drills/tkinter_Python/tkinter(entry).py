from tkinter import *
from tkinter import ttk

root = Tk()
entry = ttk.Entry(root, width = 30)
entry.pack()

entry.delete(0, 1)
entry.delete(4, END)

entry.insert(2, 'ENTER TEXT')
entry.config(show = '*')

entry.state(['disabled'])
entry.state(['!disabled'])
entry.state(['readonly'])

root.mainloop()
