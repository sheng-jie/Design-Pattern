using System;

namespace FacadePattern
{
    /// <summary>
    ///     ATM机专属门面
    /// </summary>
    public class AtmFacade
    {
        private readonly IBankSubsystem _bankSubsystem = new BankSubsystem();
        private BankAccount _account;

        public void Login(string no, string pwd)
        {
            _account = AccountSubsystem.Login(no, pwd);
        }

        public bool IsLogin()
        {
            return _account != null;
        }

        /// <summary>
        ///     取款
        /// </summary>
        /// <param name="money"></param>
        public void WithdrewCash(int money)
        {
            if (_bankSubsystem.WithdrewMoney(_account, money))
            {
                Console.WriteLine("取款成功！");
                AccountSubsystem.Display(_account);
            }
        }

        /// <summary>
        ///     存款
        /// </summary>
        /// <param name="money"></param>
        public void DepositCash(int money)
        {
            if (_bankSubsystem.DepositMoney(_account, money))
            {
                Console.WriteLine("存款成功！");
                AccountSubsystem.Display(_account);
            }
        }

        /// <summary>
        ///     查余额
        /// </summary>
        public void QueryBalance()
        {
            if (_bankSubsystem.CheckBalance(_account) > 0)
                AccountSubsystem.Display(_account);
        }

        /// <summary>
        ///     转账
        /// </summary>
        /// <param name="targetNo"></param>
        /// <param name="money"></param>
        public void TransferMoney(string targetNo, int money)
        {
            if (_bankSubsystem.TransferMoney(_account, targetNo, money))
            {
                Console.WriteLine("转账成功！");
                AccountSubsystem.Display(_account);
            }
        }
    }
}