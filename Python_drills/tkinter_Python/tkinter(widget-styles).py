from tkinter import *
from tkinter import ttk

root = Tk()
button1 = ttk.Button(root, text = 'ONE')
button2 = ttk.Button(root, text = 'TWO')
button1.pack()
button2.pack()

style = ttk.Style()
style.theme_names()

button1.winfo_class()

style.configure('TButton', foreground = 'blue')
style.configure('Alarm.TButton', foreground = 'orange', font = ('Arial', 24, 'bold'))
button2.config(style = 'Alarm.TButton')
style.map('Alarm.TButton', foreground = [('pressed', 'pink'), ('disabled', 'grey')])

'''VIEW STYLE LAYOUT'''
style.layout('TButton')

'''VIEW STYLE OPTIONS BY ELEMENT'''
style.element_options('Button.label')

'''VIEW INFO ABOUT CURRENT STYLE'''
style.lookup('TButton', 'foregorund')



root.mainloop()
