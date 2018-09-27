from tkinter import *
from tkinter import ttk

win = Tk()
f = ttk.Frame(win)

v = StringVar()

def button1():
    print('nazhatii knopki')


'''CREATE ENTRY'''
e = ttk.Entry(win, textvariable = v)

'''CREATE BUTTONS'''
b1 = Button(f, text = 'odin')
b2 = Button(f, text = 'dva')
b3 = Button(f, text = 'trii')

'''CREATE LABEL'''
l = ttk.Label(win, text = 'Tekst na knopke')

'''CREATE LISTBOX'''
lb = Listbox(win, height = 3)

'''CREATE SCROLLBAR'''
sb = ttk.Scrollbar(win, orient = VERTICAL)


'''PACK GEOMETRY MANAGER'''
b1.pack(side = LEFT, padx = 10)
b2.pack(side = LEFT, padx = 10)
b3.pack(side = LEFT, padx = 10)
l.pack()
f.pack()
e.pack()
lb.pack()
sb.pack(side = LEFT, fill = Y)

'''LISTBOX INSERT'''
lb.insert(END, 'ODIN')
lb.insert(END, 'DVA')
lb.insert(END, 'TRII')
lb.insert(END, 'CHETYRE')


b1.config(command = button1)
sb.config(command = lb.yview)
lb.config(yscrollcommand = sb.set)



win.mainloop()
