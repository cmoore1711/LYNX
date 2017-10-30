from tkinter import *
import mysql.connector

from tkinter import messagebox

window = Tk()
window.geometry("500x600")

utilizationQuestions = ["Form","Finish", "Utilization Q3","Utilization Q4","Utilization Q5"]
# questionCt
questionCt = 0
maxLen = len(utilizationQuestions)


answers = [None]*maxLen
#answers.clear()

def good():
   # questionCt = btnClick(questionCt)
    btnClick();
    global questionCt
    global answers
    answers[questionCt]="Good"
    
    
def bad():
    btnClick();
    global questionCt
    global answers
    answers[questionCt]="Bad"
    
   # questionCt =  btnClick(questionCt)
     
   # messagebox.showinfo("Bye", "Bye bye!")
def btnClick():
    global questionCt
    global answers
    global maxLen
    global utilizationQuestions
    if questionCt < maxLen:
        promptText.set("Utilization: How was the " + utilizationQuestions[questionCt] +"?")
        questionCt +=1
    else:
        questionCt = maxLen
        ansString = ""
        for a,b in zip(utilizationQuestions,answers):
   
            ansString += a +": " +b + "\n" 
        messagebox.showinfo("Data ready", "Please review your entries: \n" +ansString)
        if messagebox.askyesno("Submit", "If all entries are correct, publish to server"):
    
            
            messagebox.showinfo("Submitted", "Thank you!")
            
        else:
            print(" :) \n")
            del answers[:]
            startOver()
     
    print(questionCt)
def startOver():
    global answers
    answers.clear()
    answers = [None]*maxLen
    global questionCt
    #questionCt =0
    promptText.set("Utilization: How was the " + utilizationQuestions[0] +"?")
    questionCt=0
    print(questionCt)
    #return questionCt
    
    
    
   ### GUI STUFF 
promptText = StringVar()
title = Label( window, textvariable = promptText,  font=(None, 20))
promptText.set("Utilization: How was the " + utilizationQuestions[0] +"?")
title.place( x = 10, y = 10)

goodBtn= Button(window, text = "Good",bg = "green",command = good, font=(None, 20),height = 5, width =25)
goodBtn.place(x = 35,y = 75)
badBtn = Button(window, text = "Bad",bg = "red", command = bad  ,font=(None, 20), height = 5, width =25)
badBtn.place(x = 35,y = 300)

startOverBtn = Button(window, text = "Start Over", command = startOver,font=(None, 15))
startOverBtn.place(x = 35,y = 500)
#####


    
    





window.mainloop()
