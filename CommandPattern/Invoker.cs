using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 调用者角色
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// 申明调用的命令，并用构造函数注入
        /// </summary>
        private readonly Command command;

        public string InovkerName { get; set; }

        public Invoker(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// 调用以执行具体命令
        /// </summary>
        public void Invoke()
        {
            Console.WriteLine(string.Format("『{0}』下达命令：{1}", this.InovkerName, this.command.CommandName));
            this.command.Execute();
        }
    }

    /// <summary>
    /// 命令者角色
    /// </summary>
    public abstract class Command
    {
        protected readonly Receiver receiver;

        public string CommandName { get; set; }

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        /// <summary>
        /// 抽象执行具体命令方法
        /// 由之类实现
        /// </summary>
        public abstract void Execute();
    }

    /// <summary>
    /// 武力收复台湾命令
    /// </summary>
    public class RecaptureTaiwanByFocusCommand : Command
    {
        string commandName = "武力收复台湾！";

        /// <summary>
        /// 重写默认构造函数，指定默认接收者
        /// 以降低高层模块对底层模块的依赖
        /// </summary>
        public RecaptureTaiwanByFocusCommand() :
            base(new OperationCenter())
        {
            base.CommandName = commandName;
        }

        /// <summary>
        /// 也可通过构造函数重新指定接收者
        /// </summary>
        /// <param name="receiver"></param>
        public RecaptureTaiwanByFocusCommand(Receiver receiver)
            : base(receiver)
        {
            base.CommandName = commandName;
        }

        public override void Execute()
        {
            this.receiver.Plan();
            this.receiver.Action();
        }
    }

    /// <summary>
    /// 和平方式收复台湾命令
    /// </summary>
    public class RecaptureTaiwanByPeaceCommand : Command
    {
        string commandName = "和平收复台湾！";
        /// <summary>
        /// 重写默认构造函数，指定默认接收者
        /// 以降低高层模块对底层模块的依赖
        /// </summary>
        public RecaptureTaiwanByPeaceCommand() :
            base(new NegotiationCenter())
        {
            base.CommandName = commandName;
        }

        /// <summary>
        /// 也可通过构造函数重新指定接收者
        /// </summary>
        /// <param name="receiver"></param>
        public RecaptureTaiwanByPeaceCommand(Receiver receiver)
            : base(receiver)
        {
            base.CommandName = commandName;
        }

        public override void Execute()
        {
            this.receiver.Plan();
            this.receiver.Action();
        }
    }


    /// <summary>
    /// 接收者角色
    /// </summary>
    public abstract class Receiver
    {
        protected string ReceiverName { get; set; }

        //定义每个执行者都必须处理的业务逻辑
        public abstract void Plan();
        public abstract void Action();
    }


    /// <summary>
    /// 作战中心
    /// </summary>
    public class OperationCenter : Receiver
    {
        public OperationCenter()
        {
            this.ReceiverName = "作战中心";
        }
        public override void Plan()
        {
            Console.WriteLine(string.Format("{0}:制定作战计划。", this.ReceiverName));
        }

        public override void Action()
        {
            Console.WriteLine(string.Format("{0}:海陆空按照即定作战计划作战，收复台湾！", this.ReceiverName));
        }
    }

    /// <summary>
    /// 谈判中心
    /// </summary>
    public class NegotiationCenter : Receiver
    {
        public NegotiationCenter()
        {
            this.ReceiverName = "谈判中心";
        }
        public override void Plan()
        {
            Console.WriteLine(string.Format("{0}:制定谈判计划。", this.ReceiverName));
        }

        public override void Action()
        {
            Console.WriteLine(string.Format("{0}:落实谈判结果，收复台湾！", this.ReceiverName));
        }
    }

}
