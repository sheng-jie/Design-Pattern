using System.Collections.Generic;

namespace FacadePattern
{
    /// <summary>
    ///     银行账户验证中心
    /// </summary>
    public class AccountVerificationCenter
    {
        private readonly List<BankAccount> accounts = new List<BankAccount>
        {
            new BankAccount("123456789012345", "555555", "圣杰", "135****9309", 1000000),
            new BankAccount("123456789012346", "222222", "Jeffrey", "135****9309", 2000000),
            new BankAccount("123456789012347", "333333", "Shengjie", "135****9309", 3000000),
            new BankAccount("123456789012348", "777777", "程序猿", "135****9309", 4000000),
            new BankAccount("123456789012349", "888888", "设计狮", "135****9309", 5000000)
        };

        public void Verify(string bankNo, string password)
        {
        }
    }
}