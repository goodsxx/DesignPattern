using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式实现方式二：
    /// 延迟初始化
    /// </summary>
    public class Singleton2
    {
        /// <summary>
        /// 定义为静态变量，由所有对象共享
        /// </summary>
        private static Singleton2 _instance;

        /// <summary>
        /// 构造函数私有化，禁止外部类实例化该类对象
        /// </summary>
        private Singleton2()
        {
            Console.WriteLine("Singleton2 被实例化");
        }

        public static Singleton2 GetInstance()
        {
            return _instance ??= new Singleton2();
        }
    }
}
