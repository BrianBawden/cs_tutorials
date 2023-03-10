using System;

// start the class CardHolder.
public class CardHolder
{
    string fName;
    string lName;
    int pin;
    string cardNum;
    double balance;


    // this is the constructor for the class CardHolder
    public CardHolder(string fName, string lName, string cardNum, int pin, double balance)
    {
        this.fName = fName; 
        this.lName = lName;
        this.cardNum = cardNum;
        this.pin = pin;
        this.balance = balance;
    }

    
    public string getFName() //getter for first name
    {
        return fName;
    }

    public void setFName(string newFName) => fName = newFName;

    public string getLName() //getter for last name
    {
        return lName;
    }

    public void setLName(string newLName) => lName = newLName;

    public string getCardNum() //getter for card number
    {
        return cardNum;
    }

    public void setCardNum(string newCardNum) => cardNum = newCardNum;

    public int getPin() //getter for pin
    {
        return pin;
    }

    public void setPin(int newPin) => pin = newPin;

    public double getBalance() //getter for balance
    {
        return balance;
    }

    public void setBalance(double newBalance) => balance = newBalance;
}
