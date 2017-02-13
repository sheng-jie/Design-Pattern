namespace FacadePattern
{
    public class BankAccount
    {
        public BankAccount(string bankNo, string password, string name, string phone, int totalMoney)
        {
            BankNo = bankNo;
            Password = password;
            Name = name;
            Phone = phone;
            TotalMoney = totalMoney;
        }

        /// <summary>
        ///     银行卡号
        /// </summary>
        public string BankNo { get; set; }

        /// <summary>
        ///     取款密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///     持卡人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     手机
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     总金额
        /// </summary>
        public int TotalMoney { get; set; }
    }
}