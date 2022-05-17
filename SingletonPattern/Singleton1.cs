using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式实现方式一：
    /// 静态变量初始化
    /// </summary>
    public class Singleton1
    {
        /// <summary>
        /// 定义为静态变量，由所有对象共享
        /// </summary>
        private static Singleton1 instance = new Singleton1();

        /// <summary>
        /// 构造函数私有化，禁止外部类实例化该类对象
        /// </summary>
        private Singleton1()
        {
            Console.WriteLine("Singleton1 被实例化");
        }

        public static Singleton1 GetInstance()
        {
            return instance;
        }
    }
}
