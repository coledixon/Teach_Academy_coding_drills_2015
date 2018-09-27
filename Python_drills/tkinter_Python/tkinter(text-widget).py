from tkinter import *

root = Tk()
text = Text(root, width = 40, height = 15)
text.pack()
text.config(wrap = 'word')
text.get('1.0', 'end')
text.get('1.0', '1.end')
text.insert('1.4 + 2 lines', 'INSERTED MESSAGE')
text.insert('1.0 + 2 lines lineend', ' and\n more and\n more...')
text.delete('1.0', '1.0 lineend')
text.replace('1.0','1.0 lineend', 'NEW TEXT')

root.mainloop()
