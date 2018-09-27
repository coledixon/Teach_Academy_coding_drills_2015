from tkinter import *
from tkinter import ttk

root = Tk()

'''CREATE ENTRY WIDGET'''
entry = ttk.Entry(root)
entry.pack()

'''BIND VIRTUAL EVENT'''
entry.bind('<<Copy>>', lambda e: print('COPY'))
entry.bind('<<Paste>>', lambda e: print('PASTE'))

'''CREATE VIRTUAL EVENT'''
entry.event_add('<<OddNumber>>', '1', '3', '5', '7', '9')
entry.bind('<<OddNumber>>', lambda e: print('ODD NUMBER'))

'''PRINT INFO ABOUT VIRTUAL EVENT'''
print(entry.event_info('<<OddNumber>>'))

'''EXECUTE EVENT WITHIN CODE'''
entry.event_generate('<<OddNumber>>')
entry.event_generate('<<Paste>>')

'''DELETE EVENT'''
'''entry.event_delete('<<OddNumber>>')'''


root.mainloop()
