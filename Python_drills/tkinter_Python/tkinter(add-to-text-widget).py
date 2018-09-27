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

text.tag_add('my_tag','1.0','1.0 wordend')
text.tag_configure('my_tag', background = 'light blue')
text.tag_remove('my_tag','1.0','1.3')
text.tag_names()

text.mark_names()

text.insert('insert', '__')
text.mark_set('my_mark', 'end')
text.mark_gravity('my_mark', 'left')
image = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif')
text.image_create('insert', image =image)

button = Button(text, text = 'CLICK')
text.window_create('insert', window = button)

root.mainloop()
