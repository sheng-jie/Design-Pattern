using System;
using System.Collections.Generic;
using System.Linq;

namespace FacadePattern
{
    /// <summary>
    /// 账户管理子系统
    /// </summary>
    public static class AccountSubsystem
    {
        private static readonly List<BankAccount> Accounts = new List<BankAccount>
        {
            new BankAccount("123455", "555555", "圣杰", "138****9309", 1000000),
            new BankAccount("123454", "444444", "产品汪", "157****9309", 2000000),
            new BankAccount("123453", "333333", "运营喵", "154****9309", 3000000),
            new BankAccount("123452", "222222", "程序猿", "187****9309", 4000000),
            new BankAccount("123451", "111111", "设计狮", "189****9309", 5000000)
        };

        public static BankAccount Login(string bankNo, string password)
        {
            var bankAccount = Accounts.FirstOrDefault(a => a.BankNo == bankNo);
            if (bankAccount == null)
                throw new Exception("无效卡号！！！");

            if (bankAccount.Password != password)
                throw new Exception("密码错误！！！");

            return bankAccount;
        }

        public static BankAccount GetAccount(string bankNo)
        {
            var bankAccount = Accounts.FirstOrDefault(a => a.BankNo == bankNo);
            if (bankAccount == null)
                throw new Exception("无效卡号！！！");


            return bankAccount;
        }

        public static void Display(BankAccount account)
        {
            Console.WriteLine("卡号：{0}，持卡人姓名：{1}，手机号：{2}，余额：{3}", account.BankNo, account.Name, account.Phone,
                account.TotalMoney);
        }


        public static bool ChangePassword()
        {
            throw new NotImplementedException();
        }
    }
}