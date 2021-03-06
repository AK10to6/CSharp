using System;
using System.Threading;

namespace Deadlock{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Main Started");
            Account acA = new Account(1, 5000);
            Account acB = new Account(2, 8000);

            AccountManager accountManagerA = new AccountManager(acA, acB, 2500);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(acB, acA, 1000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start(); T2.Start();
            T1.Join(); T2.Join();
            Console.WriteLine("Main Completed");
        }
    }
    public class Account                            //This class stores account holder details 
    {
        double _balance; int _id;
        public Account(int id, double balance) { 
            this._id = id;
            this._balance = balance;
        }
        public int ID { get { return _id; } }

        public void Withdraw(double amount) { 
            _balance -= amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }

    public class AccountManager {                   //This class process the transfer of funds from one a/c to another 

        Account _fromAccount; Account _toAccount; double _amounttoTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amounttoTransfer) { 
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amounttoTransfer = amounttoTransfer;
        }
        public void Transfer() {
            Console.WriteLine("{0} trying to acquire lock on ID: {1}", Thread.CurrentThread.Name, _fromAccount.ID.ToString());
            lock (_fromAccount) {
                Console.WriteLine("{0} acquired lock on ID: {1}", Thread.CurrentThread.Name, _fromAccount.ID.ToString());
                Console.WriteLine("{0} Suspended for one Second", Thread.CurrentThread.Name);
                
                Thread.Sleep(1000);
                Console.WriteLine("{0} Back in action & trying to acquire lock on ID: {1}", Thread.CurrentThread.Name, _toAccount.ID.ToString());
                lock (_toAccount) {                                     //Here a deadlock will occur as multiple threads are trying to access this resource at same time
                    Console.WriteLine("{0} acquired lock on ID: {1}", Thread.CurrentThread.Name, _toAccount.ID.ToString());
                    _fromAccount.Withdraw(_amounttoTransfer);
                    _toAccount.Deposit(_amounttoTransfer);
                }
            }
        }
    }

}