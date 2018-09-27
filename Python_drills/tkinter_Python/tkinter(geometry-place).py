from tkinter import *
from tkinter import ttk

root = Tk()

root.geometry('640x480+200+200')

ttk.Label(root, text = 'YELLOW', background ='yellow').place(x = 100, y = 50,
                                                             width = 100, height = 50)
ttk.Label(root, text = 'GREEN', background = 'green').place(relx = 0.5, rely = 0.5, anchor = CENTER,
                                                            relwidth = 0.5, relheight = 0.5)
ttk.Label(root, text = 'BLUE', background = 'blue').place(relx = 1.0, x = -5, y = 5, anchor = 'ne')
ttk.Label(root, text = 'GREY', background = 'grey').place(relx = 0.5, x = 100, rely = 0.5, y = 50)

root.mainloop()
