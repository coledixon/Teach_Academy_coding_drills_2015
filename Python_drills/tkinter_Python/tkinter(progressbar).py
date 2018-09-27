from tkinter import *
from tkinter import ttk

root = Tk()
prog = ttk.Progressbar(root, orient = HORIZONTAL, length = 200)
prog.pack()
prog.config(mode = 'indeterminate')
prog.start()
prog.stop()

prog.config(mode = 'determinate', maximum = 11.0, value = 4.2)
prog.config(value = 7.7)
prog.step()
prog.step(1.3)

value = DoubleVar()
prog.config(variable = value)
scale = ttk.Scale(root, orient = HORIZONTAL, length = 400, variable = value, from_ = 0.0, to = 11.0)
scale.pack()
scale.set(2.9)

root.mainloop()