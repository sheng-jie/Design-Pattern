using System.Collections.Concurrent;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public static class EmailTemplateFactory
    {
        /// <summary>
        /// 预置模板
        /// </summary>
        private static readonly Dictionary<string, string> SubjectAndContentMapping = new Dictionary<string, string>()
        {
            {
                "待修复漏洞通知",
                @"尊敬的用户：云盾检测到您的服务器存在phpwindv9任务中心GET型CSRF代码执行漏洞，
                  目前已为您研发了漏洞补丁，可在云盾控制台进行一键修复。为避免该漏洞被黑客利用，
                  建议您尽快修复该漏洞。您可以点击此处登录云盾 - 服务器安全(安骑士)控制台进行查看和修复"
            },
            {
                "阿里云ECS即将到期通知",
                @"您有1台云服务器ECS将于一周后正式到期。未续费的云服务器ECS实例到期后将停止服务，
                  到期后数据为您保留7天，逾期未续费实例与磁盘会被释放，数据不可恢复。
                  为了保证您的服务正常运行，请及时续费。"
            },
            {"阿里云故障通告", "您的服务器存在故障，请您了解！"},
            {"阿里云升级通知", "我们将对阿里云进行升级，会存在服务器短暂不可用情况，请知悉！"}
        };

        /// <summary>
        /// 定义对象池
        /// </summary>
        static readonly ConcurrentDictionary<string, Email> EmailTemplates = new ConcurrentDictionary<string, Email>();


        /// <summary>
        /// 根据主题获取模板
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static Email GetTemplate(string subject)
        {
            Email email = null;

            if (!EmailTemplates.ContainsKey(subject))
            {
                string template;
                SubjectAndContentMapping.TryGetValue(subject, out template);
                email = new Email("system@notice.aliyun.com", subject, string.IsNullOrWhiteSpace(template) ? subject : template, "阿里云计算公司");
                EmailTemplates.TryAdd(subject, email);
            }
            else
            {
                EmailTemplates.TryGetValue(subject, out email);
            }

            return email;

        }

    }
}