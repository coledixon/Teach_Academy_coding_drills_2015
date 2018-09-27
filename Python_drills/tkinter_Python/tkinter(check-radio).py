from tkinter import *
from tkinter import ttk

root = Tk()
checkbutton = ttk.Checkbutton(root, text = 'SPAM')
checkbutton.pack()
spam = StringVar()
spam.set('SPAM!')
spam.get()

checkbutton.config(variable = spam, onvalue = 'SPAM PLEASE!', offvalue = 'BOO< SPAM!')
spam.get()

breakfast = StringVar()
ttk.Radiobutton(root, text = 'SPAM', variable = breakfast, value = 'SPAM').pack()
ttk.Radiobutton(root, text = 'EGGS', variable = breakfast, value = 'EGGS').pack()
ttk.Radiobutton(root, text = 'AVOCADO', variable = breakfast, value = 'AVOCADO').pack()
ttk.Radiobutton(root, text = 'BACON', variable = breakfast, value = 'BACON').pack()
ttk.Radiobutton(root, text = 'TOAST', variable = breakfast, value = 'TOAST').pack()
ttk.Radiobutton(root, text = 'SPAM', variable = breakfast, value = 'SPAM').pack()

root.mainloop()