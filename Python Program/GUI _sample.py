from tkinter import *

window=Tk()
window.geometry("500x500")
window.title("Tkinter")
window.configure(bg="blue")

Label=Label(window,text="Welcome")



def hello():
    print("Button is clicked")


button=Button(window,text="Ok", width=2,height=1 ,command=hello)


button.pack()
Label.pack()

window.mainloop()