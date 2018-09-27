from tkinter import messagebox
from tkinter import filedialog
from tkinter import colorchooser

messagebox.showinfo(title = 'MESSAGE', message = 'HELLO, WORLD')

messagebox.askyesno(title = 'Hungry?', message = 'SPAM?')

filename = filedialog.askopenfile()

colorchooser.askcolor(initialcolor = 'white')