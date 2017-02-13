using System;

namespace FacadePattern
{
    public class Bank : IBank
    {
        /// <summary>
        ///     查询余额
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <returns></returns>
        public int CheckBalance(BankAccount account)
        {
            throw new NotImplementedException();
        }

        public int WithdrewMoney(BankAccount account, int money)
        {
            throw new NotImplementedException();
        }

        public int DepositMoney(BankAccount account, int money)
        {
            throw new NotImplementedException();
        }

        public int TransferMoney(BankAccount account, BankAccount targetAccount, int money)
        {
            throw new NotImplementedException();
        }
    }
}