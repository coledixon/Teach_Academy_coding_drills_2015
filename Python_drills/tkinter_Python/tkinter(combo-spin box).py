from tkinter import *
from tkinter import ttk

root = Tk()
month = StringVar()
combox = ttk.Combobox(root, textvariable = month)
combox.pack()

combox.config(values =('Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sept','Oct','Nov','Dec'))
month.set('Jul')

year = StringVar()
Spinbox(root, from_ = 1987, to = 2015, textvariable = year).pack()
year.get()
year.set(2015)

root.mainloop()
