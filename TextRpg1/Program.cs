using System;

namespace TextRpg1
{
    internal class Program
    {
        static public void First()
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

        public class Character
        {
            public string Name { get; set; }
            public int Level { get; set; } = 1;
            public virtual string Job => "전사";
            public int Atk { get; set; } = 10;
            public int Dfs { get; set; } = 5;
            public int Hp { get; set; } = 100;
            public int Gold { get; set; } = 1500;

            public string CharacterStats()
            {
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine($"LV. {Level}");
                Console.WriteLine($"{Name} ( {Job} )");
                Console.WriteLine($"공격력 : {Atk}");
                Console.WriteLine($"방어력 : {Dfs}");
                Console.WriteLine($"체력  : {Hp}");
                Console.WriteLine($"Gold   :  {Gold}G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 선택해주세요.");
                Console.Write(">> ");
                return Console.ReadLine();
            }
        }

        public class Item
        {
            static public string item()
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("아이템 목록");
                Console.WriteLine();
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 선택해주세요.");
                Console.Write(">> ");
                return Console.ReadLine();
            }

            static public string itemSetting()
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("아이템 목록");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 선택해주세요.");
                Console.Write(">> ");
                return Console.ReadLine();
            }
        }

        public class Store
        {
            public int Gold { get; set; }

            public Store(int gold)
            {
                Gold = gold;
            }

            static public string store(int gold)
            {
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{gold}G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷 |방어력 +5| 수련에 도움을 주는 갑옷입니다. | 1000 G");
                Console.WriteLine("- 무쇠 갑옷 |방어력 +9| 무쇠로 만들어져 튼튼한 갑옷입니다. | 1800 G");
                Console.WriteLine("- 스파르타의 갑옷 |방어력 +15| 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
                Console.WriteLine("- 낡은 검 |공격력 +2| 쉽게 볼 수 있는 낡은 검 입니다. | 600 G");
                Console.WriteLine("- 청동 도끼 |공격력 +5| 어디선가 사용됐던거 같은 도끼입니다. | 1500 G");
                Console.WriteLine("- 스파르타의 창 |공격력 +7| 스파르타의 전사들이 사용했다는 전설의 창입니다. | 2100 G");
                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 선택해주세요.");
                Console.Write(">> ");
                return Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("이름을 입력해주세요: ");
            Character character = new Character { Name = Console.ReadLine() };
            Console.WriteLine();
            First();
            string choice = Console.ReadLine();

            while (true)
            {
                if (choice == "1")
                {
                    string nextChoice = character.CharacterStats();
                    if (nextChoice == "0")
                    {
                        First();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                else if (choice == "2")
                {
                    string nextChoice2 = Item.item();
                    if (nextChoice2 == "0")
                    {
                        First();
                    }
                    else if (nextChoice2 == "1")
                    {
                        string nextChoice3 = Item.itemSetting();
                        if (nextChoice3 == "0")
                        {
                            Item.item();
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                else if (choice == "3")
                {
                    string storeChoice = Store.store(character.Gold);
                    if (storeChoice == "0")
                    {
                        First();
                    }
                    else if (storeChoice == "1")
                    {
                        Console.WriteLine("구매할 아이템을 선택하세요.");
                        // 구매 로직 추가 가능
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }

                choice = Console.ReadLine();
            }
        }
    }
}