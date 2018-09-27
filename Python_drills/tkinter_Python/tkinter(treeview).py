from tkinter import *
from tkinter import ttk

root = Tk()
tree = ttk.Treeview(root)
tree.pack()
tree.insert('', '0', 'item1', text = 'FIRST')
tree.insert('', '1', 'item2', text = 'SECOND')
tree.insert('', 'end', 'item3', text = 'LAST')
logo = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif').subsample(10,10)
tree.insert('item2', 'end', 'kitty', text = 'KITTY', image = logo)
tree.config(height = 5)
tree.move('item2', 'item1', 'end')
tree.item('item1', open = True)
tree.item('item1', 'open')
tree.detach('item3')
tree.move('item3', 'item2', '0')


root.mainloop()
