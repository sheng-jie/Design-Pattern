using System;

namespace FacadePattern
{
    public class ATM
    {
        public void DisplayUi()
        {
            var facade = new AtmFacade();

            while (true)
                try
                {
                    if (!facade.IsLogin())
                    {
                        Console.WriteLine("请输入银行卡号：");
                        var bkNo = Console.ReadLine();
                        Console.WriteLine("请输入密码：");
                        var pwd = Console.ReadLine();
                        facade.Login(bkNo, pwd);
                    }
                    else
                    {
                        ShowBusiness(facade);
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
        }


        private static void ShowBusiness(AtmFacade facade)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("欢迎你！请选择服务项目：");
            Console.WriteLine("1、取款");
            Console.WriteLine("2、存款");
            Console.WriteLine("3、转账");
            Console.WriteLine("4、查询余额");
            Console.WriteLine("5、清屏");
            Console.WriteLine("==========================================");

            var pressKey = Console.ReadKey();

            switch (pressKey.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    Console.WriteLine("请输入取款金额：");
                    var money = Convert.ToInt32(Console.ReadLine());
                    facade.WithdrewCash(money);
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine("请输入存款金额：");
                    var depositNum = Convert.ToInt32(Console.ReadLine());
                    facade.DepositCash(depositNum);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine("请输入目标账号：");
                    var targetNo = Console.ReadLine();
                    Console.WriteLine("请输入转账金额：");
                    var transferNum = Convert.ToInt32(Console.ReadLine());
                    facade.TransferMoney(targetNo, transferNum);
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine();
                    facade.QueryBalance();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("输入有误，请重新输入");
                    Console.ResetColor();
                    break;
            }
        }
    }
}