import wx

class MainWindow(wx.Frame):

    def __init__(self, parent, title):
        wx.Frame.__init__(self, parent, title=title, size=(400,550))
        self.control = wx.TextCtrl(self, style=wx.TE_MULTILINE)
        self.CreateStatusBar()

        """BUTTONS"""
        fileMenu = wx.Menu()

        menuAbout = fileMenu.Append(wx.ID_ABOUT, 'ABOUT', 'This is a simple practice text editor.')
        menuExit = fileMenu.Append(wx.ID_EXIT, 'EXIT', 'Terminate the program.')

        """MENU BAR"""
        menuBar = wx.MenuBar()
        menuBar.Append(fileMenu,'FILE')
        self.SetMenuBar(menuBar)

        """SET EVENTS"""
        self.Bind(wx.EVT_MENU, self.OnAbout, menuAbout)
        self.Bind(wx.EVT_MENU, self.OnExit, menuExit)

        self.Show(True)

    def OnAbout(self, e):
        dlg = wx.MessageDialog(self, 'Practice', wx.OK)
        dlg.ShowModal()
        dlg.Destroy()
        
    def OnExit(self, e):
        self.Close(True)
        



app = wx.App(False)
frame = MainWindow(None, 'WIN-D\'oH!')
app.MainLoop()

