using System.Security.Cryptography.X509Certificates;

namespace TextRpg1
{
    internal class Program
    {
        public class Character()
        {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public virtual string Job => "전사";
        public int Atk { get; set; } = 10;
        public int Dfs { get; set; } = 5;
        public int Hp { get; set; } = 100;
        public int Gold { get; set; } = 1500;
        public string inventory { get; set; }
        }
        public void First()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전에 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1.상태 보기");
            Console.WriteLine("2.인벤토리");
            Console.WriteLine("3.상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 선택해주세요.");
            Console.Write(">> ");
        }
        public void Main(string[] args)
        {
            Console.WriteLine("이름을 입력해주세요.");
            Character(Console.ReadLine());
        }
    }
}
