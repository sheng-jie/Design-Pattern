namespace FacadePattern
{
    /// <summary>
    ///     银行现金业务子系统
    /// </summary>
    public interface IBankSubsystem
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
        bool WithdrewMoney(BankAccount account, int money);

        /// <summary>
        ///     存款
        /// </summary>
        /// <param name="account">银行账户</param>
        /// <param name="money">存多少钱</param>
        /// <returns></returns>
        bool DepositMoney(BankAccount account, int money);

        /// <summary>
        ///     转账
        /// </summary>
        /// <param name="account">转出账户</param>
        /// <param name="targetNo">目标账户</param>
        /// <param name="money">转多少钱</param>
        /// <returns></returns>
        bool TransferMoney(BankAccount account, string targetNo, int money);

        /// <summary>
        ///     充值话费
        /// </summary>
        /// <param name="phoneNumber">手机号</param>
        /// <param name="account">银行账户</param>
        /// <param name="money">充值多少</param>
        /// <returns></returns>
        bool RechargeMobilePhone(BankAccount account, string phoneNumber, int money);
    }
}