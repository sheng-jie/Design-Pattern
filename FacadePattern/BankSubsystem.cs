using System;

namespace FacadePattern
{
    public class BankSubsystem : IBankSubsystem
    {
        /// <summary>
        ///     查询余额
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <returns></returns>
        public int CheckBalance(BankAccount account)
        {
            return account.TotalMoney;
        }

        /// <summary>
        ///     取款
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <param name="money">取多少钱</param>
        /// <returns>余额</returns>
        public bool WithdrewMoney(BankAccount account, int money)
        {
            if (account.TotalMoney >= money)
                account.TotalMoney -= money;
            else
                throw new Exception("余额不足！");

            return true;
        }

        /// <summary>
        ///     转账
        /// </summary>
        /// <param name="account">转出账户</param>
        /// <param name="targetNo">目标账户</param>
        /// <param name="money">转多少钱</param>
        /// <returns></returns>
        public bool TransferMoney(BankAccount account, string targetNo, int money)
        {
            var targetAccount = AccountSubsystem.GetAccount(targetNo);

            if (targetAccount == null)
                throw new Exception("目标账户不存在！");

            if (account.TotalMoney < money)
                throw new Exception("余额不足！");

            account.TotalMoney -= money;
            targetAccount.TotalMoney += money;

            return true;
        }

        /// <summary>
        ///     存款
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <param name="money">存多少钱</param>
        /// <returns></returns>
        public bool DepositMoney(BankAccount account, int money)
        {
            account.TotalMoney += money;
            return true;
        }

        /// <summary>
        ///     充值话费
        /// </summary>
        /// <param name="phoneNumber">手机号</param>
        /// <param name="account">银行账户</param>
        /// <param name="money">充值多少</param>
        /// <returns></returns>
        public bool RechargeMobilePhone(BankAccount account, string phoneNumber, int money)
        {
            throw new NotImplementedException();
        }
    }
}