from tkinter import *

root = Tk()

'''INFO ON KEY EVENT'''
def key_press(event):
    print('type: {}'. format(event.type))
    print('widget: {}'.format(event.widget))
    print('char: {}'.format(event.char))
    print('keysym: {}'.format(event.keysym))
    print('keycode: {}'.format(event.keycode))

'''BIND EVENT'''
root.bind('<KeyPress>', key_press)

'''DEFINE SHORTCUT'''
def shortcut(action):
    print(action)

'''BIND SHORTCUT EVENT'''
root.bind('<Control-c>', lambda e: shortcut('Copy'))
root.bind('<Control-v>', lambda e: shortcut('Paste'))


root.mainloop()
