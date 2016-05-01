using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Person
    {
        public string name;
        public int age;

        const int UNKNOWN = -1;
        const string DEFAULT_NAME = "デフォルトの名無しさん";

        /// <summary>
        /// 年齢と名前を初期化
        /// 与えられた年齢が負の時は年齢不詳とみなす
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age > 0 ? age : UNKNOWN;
        }

        /// <summary>
        /// 名前のみを初期化
        /// 年齢は不詳とする
        /// </summary>
        /// <param name="name"></param>
        public Person(string name) : this(name, UNKNOWN)
        {
        }

        /// <summary>
        /// デフォルトコンストラクタ
        /// 氏名、年齢ともに不詳
        /// </summary>
        public Person() : this(null, UNKNOWN)
        {
        }

        /// <summary>
        /// 文字列化
        /// 氏名が不詳のときは NONAME に設定された名前を返す
        /// 年齢が不詳の時には名前のみを返す
        /// 氏名、年齢がわかっている時には「名前(xx歳)」という形の文字列を返す
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (name == null)
                return DEFAULT_NAME;
            if (age == UNKNOWN)
                return name;
            return name + "(" + age + "歳)";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Steven", 64);
            Person p2 = new Person("Linda");
            Person p3 = new Person();

            Console.WriteLine("{0}\n{1}\n{2}", p1, p2, p3);
        }
    }
}
