using System.Collections.Generic;

namespace Banking;

public class Account {

    //data member
    private float balance=5000;

    //getter setter
    public void SetBalance(float amount){
        this.balance=amount;
    }

    public float GetBalance(){
        return this.balance;
    }

    //constructor overloading
    public Account(){
        this.balance=10000;
    }

    public Account(float amount){
        this.balance=amount;
    }

    public void Withdraw(float amount){

        if(amount==0){
            throw new Exception("Amount can not be zero");
        }
        this.balance-=amount;
    }

    public void Deposit(float amount){
        this.balance+=amount;
    }

    ~Account(){

    }

}