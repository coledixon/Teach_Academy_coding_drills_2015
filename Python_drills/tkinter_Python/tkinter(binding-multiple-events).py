from tkinter import *
from tkinter import ttk

root = Tk()

'''CREATE LABEL(S)'''
label1 = ttk.Label(root, text = 'LABEL ONE')
label2 = ttk.Label(root, text = 'LABEL TWO')
label1.pack()
label2.pack()

'''BIND EVENTS label1'''
label1.bind('<ButtonPress>', lambda e: print('<ButtonPress> Label'))
label1.bind('<1>', lambda e: print('<1> Label'))

'''BIND EVENTS label2'''
label2.bind('<ButtonPress>', lambda e: print('<ButtonPress> Label'))

'''BIND EVENT root'''
root.bind('<1>', lambda e: print('<1> Root'))

'''DELETE BIND label1'''
label1.unbind('<1>')
label1.unbind('<ButtonPress>')

'''BIND TO ALL'''
root.bind_all('<Escape>', lambda e: print('ESCAPE'))

root.mainloop()
