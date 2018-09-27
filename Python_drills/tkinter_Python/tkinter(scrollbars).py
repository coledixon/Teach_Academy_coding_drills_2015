from tkinter import *
from tkinter import ttk

root = Tk()
text = Text(root, width = 40, height = 10, wrap = 'word')
text.grid(row = 0, column = 0)
scroll = ttk.Scrollbar(root, orient = VERTICAL, command = text.yview)
scroll.grid(row = 0, column = 1, sticky = 'ns')
text.config(yscrollcommand = scroll.set)


root.mainloop()
