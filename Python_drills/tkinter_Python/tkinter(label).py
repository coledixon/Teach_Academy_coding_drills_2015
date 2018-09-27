from tkinter import *
from tkinter import ttk

root = Tk()
label = ttk.Label(root, text = 'Hello, World')
label.pack()
label.config(justify = CENTER)
label.config(foreground = 'green', background = 'black')
label.config(font = ('Courier', 17, 'bold'))
logo = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif')
label.img = logo
label.config(image = label.img)
label.config(compound = 'text')
label.config(compound = 'bottom')


root.mainloop()
