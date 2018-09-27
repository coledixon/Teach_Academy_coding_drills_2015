from tkinter import *
from tkinter import ttk

root = Tk()
button = ttk.Button(root, text = 'CLICK')
button.pack()

def callback():
    print('clicked')

button.config(command = callback)
button.invoke()
button.state(['disabled'])
button.instate(['disabled'])
button.state(['!disabled'])

logo = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif')
button.config(image = logo, compound = LEFT)
small_logo = logo.subsample(5,5)
button.config(image = small_logo)

root.mainloop()
