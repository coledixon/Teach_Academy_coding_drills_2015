from tkinter import *
from tkinter import ttk

root = Tk()
paned = ttk.Panedwindow(root, orient = HORIZONTAL)
paned.pack(fill = BOTH, expand = True)
frame1 = ttk.Frame(paned, width = 100, height = 300, relief = SUNKEN)
frame2 = ttk.Frame(paned, width = 250, height = 400, relief = SUNKEN)
paned.add(frame1, weight = 1)
paned.add(frame2, weight = 4)
frame3 = ttk.Frame(paned, width = 50, height = 400, relief = SUNKEN)
paned.insert(1, frame3)
'''paned.forget(1)'''


root.mainloop()
