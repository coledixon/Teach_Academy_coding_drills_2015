from tkinter import *
from tkinter import ttk

root = Tk()
ttk.Label(root, text = 'Hello, World.', background = 'green').pack(fill = BOTH, expand = True)
ttk.Label(root, text = 'tkinter', background = 'blue').pack(fill = BOTH)
ttk.Label(root, text = 'Python 3.4', background = 'grey').pack(side = LEFT, padx = 10, pady = 10)
ttk.Label(root, text = 'YEAH!', background = 'black', foreground = 'green').pack(side = LEFT, anchor = 'nw',
                                                                                 ipadx = 11, ipady = 14)

for widget in root.pack_slaves():
    widget.pack_configure(fill = BOTH, expand = True)



root.mainloop()
