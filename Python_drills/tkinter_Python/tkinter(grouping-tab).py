from tkinter import *
from tkinter import ttk

root = Tk()
notebook = ttk.Notebook(root)
notebook.pack()
frame1 = ttk.Frame(notebook)
frame2 = ttk.Frame(notebook)
notebook.add(frame1, text = 'ONE')
notebook.add(frame2, text = 'TWO')
ttk.Button(frame1, text = 'CLICK').pack()
frame3 = ttk.Frame(notebook)
notebook.insert(1, frame3, text = 'THREE')
notebook.forget(1)
notebook.add(frame3, text = 'THREE')

notebook.select()
notebook.index(notebook.select())
notebook.select(2)

notebook.tab(1, state = 'disabled')



root.mainloop()
