namespace FacadePattern
{
    public interface IBank
    {
        /// <summary>
        ///     查询余额
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <returns></returns>
        int CheckBalance(BankAccount account);

        /// <summary>
        ///     取款
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <param name="money">取多少钱</param>
        /// <returns></returns>
        int WithdrewMoney(BankAccount account, int money);

        /// <summary>
        ///     存款
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <param name="money">存多少钱</param>
        /// <returns></returns>
        int DepositMoney(BankAccount account, int money);

        /// <summary>
        ///     转账
        /// </summary>
        /// <param name="account">转出账户</param>
        /// <param name="targetAccount">目标账户</param>
        /// <param name="money">转多少钱</param>
        /// <returns></returns>
        int TransferMoney(BankAccount account, BankAccount targetAccount, int money);
    }
}