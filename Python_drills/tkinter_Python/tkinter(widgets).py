from tkinter import *
from tkinter import ttk


class HelloApp:

    def __init__(self, master):

        self.label = ttk.Label(master, text = 'Hello, World')
        self.label.grid(row = 0, column = 0, columnspan = 2)

        ttk.Button(master, text = 'Portland', command = self.portland_hello).grid(row = 1, column = 0)
        ttk.Button(master, text = 'London', command = self.london_hello).grid(row = 1, column = 1)

    def portland_hello(self):
            self.label.config(text = 'Hey, Gaya')

    def london_hello(self):
        self.label.config(text = '\'ello, World')

def main():

    root = Tk()
    app = HelloApp(root)
    root.mainloop()

if __name__ == "__main__": main()