from tkinter import *

root = Tk()
window = Toplevel(root)
window.title('NEW WINDOW')

window.lower()
window.lift(root)
window.iconify()
window.state('normal')

window.geometry('640x480+50+100')
window.resizable(False, True)

window.maxsize(640,480)
window.minsize(200,200)
window.resizable(True,True)
root.destroy()


root.mainloop()
