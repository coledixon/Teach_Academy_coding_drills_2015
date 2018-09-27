from tkinter import *

root = Tk()
root.option_add('*tearOff', False)
menubar = Menu(root)
root.config(menu = menubar)
file = Menu (menubar)
edit = Menu(menubar)
help_ = Menu(menubar)
menubar.add_cascade(menu = file, label = 'FILE')
menubar.add_cascade(menu = edit, label = 'EDIT')
menubar.add_cascade(menu = help_, label = 'HELP')
file.add_command(label = 'NEW', command = lambda: print('NEW FILE'))

file.add_separator()
file.add_command(label = 'OPEN', command = lambda: print('OPENING FILE...'))
file.add_command(label = 'SAVE', command = lambda: print('SAVING FILE...'))

file.entryconfig('NEW', accelerator = 'Ctrl + N')

logo = PhotoImage(file = 'C:\\Users\\Dell 0381\\Desktop\\anigif_cat-got-neck-30467-1310595819-68_preview.gif').subsample(10,10)

file.entryconfig('SAVE', image = logo, compound = 'left')
file.entryconfig('OPEN', state = 'disabled')

'''CASCADING SAVE SUB-MENU'''
file.delete('SAVE')
save = Menu(file)
file.add_cascade(menu = save, label = 'SAVE')
save.add_command(label = 'SAVE AS', command = lambda : print('SAVING AS...'))
save.add_command(label = 'SAVE ALL', command  = lambda: print('SAVING ALL..'))


'''ADD RADIO BUTTONS'''
choice = IntVar()
edit.add_radiobutton(label = 'one', variable = choice, value = 1)
edit.add_radiobutton(label = 'two', variable = choice, value = 2)
edit.add_radiobutton(label = 'three', variable = choice, value = 3)

'''POP-UP MENU (BASIC)'''
file.post(400, 300)


root.mainloop()