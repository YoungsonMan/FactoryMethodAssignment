namespace FactoryMethodAssignment
{
    /**************************************************************************
    * 디자인 패턴 과제
    * YC
    * 과제 1. 팩토리 메소드 패턴 활용하기
    * ItemFactory 클래스를 만들고, 팩토리 메소드를 통해서 다양한 Item을 생성해보기
    *      - item은 ItemFactory를 통해서 생성
    *      - ItemFactory는 Create(ItemType tpye) 함수를 가진다.
    *      - ItemType은 열거형으로 Potion, Weapon, Armor, Food 항목을 가진다.
    *      - ItemFactory는 Create 함수에 매개변수로 받은 열거형의 유형을 기준으로
    *        각 항목에 맞는 아이템 인스턴스를 생성하여 준다.
    **************************************************************************/
    public class Program
    {
        static void Main(string[] args)
        {
            #region 포션
            Potion potion = ItemFactory.Instantiate<Potion>("포션");
            Potion[] potions = new Potion[5];
            potions[0] = ItemFactory.Instantiate<Potion>("더큰포션");
            potions[1] = ItemFactory.Instantiate<Potion>("활력포션");
            potions[2] = ItemFactory.Instantiate<Potion>("엘릭서");
            potions[3] = ItemFactory.Instantiate<Potion>("보라포션");
            potions[4] = ItemFactory.Instantiate<Potion>("랜덤포션");
            #endregion

            #region 무기
            Weapon weapon = ItemFactory.Instantiate<Weapon>("무기");
            Weapon[] weapons = new Weapon[5];
            weapons[0] = ItemFactory.Instantiate<Weapon>("대검"); 
            weapons[1] = ItemFactory.Instantiate<Weapon>("도검"); 
            weapons[2] = ItemFactory.Instantiate<Weapon>("방망이"); 
            weapons[3] = ItemFactory.Instantiate<Weapon>("장미칼"); 
            weapons[4] = ItemFactory.Instantiate<Weapon>("최강의검");
            #endregion

            #region 음식
            Food food = ItemFactory.Instantiate<Food>("음식");
            Food[] foods = new Food[5];
            foods[0] = ItemFactory.Instantiate<Food>("짜장면");
            foods[1] = ItemFactory.Instantiate<Food>("고추");
            foods[2] = ItemFactory.Instantiate<Food>("빅맥");
            foods[3] = ItemFactory.Instantiate<Food>("랍스터");
            foods[4] = ItemFactory.Instantiate<Food>("연어초밥");

            #endregion

            #region 방어구
            Armor armor = ItemFactory.Instantiate<Armor>("방어구");
            #endregion

            #region Print
            Console.WriteLine("=============================================== 아이템 정보 ===============================================");

            // 포션
            Console.WriteLine($"아이템이름: {potion.name}\t\t타입: {potion.type}\t회복량: {potion.hp} \t설명: {potion.description}");                       // 포션
            Console.WriteLine($"아이템이름: {potions[0].name}\t\t타입: {potions[0].type}\t회복량: {potions[0].hp} \t설명: {potions[0].description} ");      // 더큰포션
            Console.WriteLine($"아이템이름: {potions[1].name}\t\t타입: {potions[1].type}\t회복량: {potions[1].hp} \t설명: {potions[1].description} ");      // 활력포션
            Console.WriteLine($"아이템이름: {potions[2].name}\t\t타입: {potions[2].type}\t회복량: {potions[2].hp} \t설명: {potions[2].description} ");      // 엘릭서
            Console.WriteLine($"아이템이름: {potions[3].name}\t\t타입: {potions[3].type}\t회복량: {potions[3].hp} \t설명: {potions[3].description} ");      // 보라포션
            Console.WriteLine($"아이템이름: {potions[4].name}\t\t타입: {potions[4].type}\t회복량: {potions[4].hp} \t설명: {potions[4].description} ");      // 랜덤포션
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            // 무기
            Console.WriteLine($"아이템이름: {weapon.name}\t\t타입: {weapon.type}\t데미지: {weapon.damage} \t설명: {weapon.description}");                       // 기본 단검
            Console.WriteLine($"아이템이름: {weapons[0].name}\t\t타입: {weapons[0].type}\t데미지: {weapons[0].damage} \t설명: {weapons[0].description} ");      // 대검
            Console.WriteLine($"아이템이름: {weapons[1].name}\t\t타입: {weapons[1].type}\t데미지: {weapons[1].damage} \t설명: {weapons[1].description} ");      // 도검
            Console.WriteLine($"아이템이름: {weapons[2].name}\t타입: {weapons[2].type}\t데미지: {weapons[2].damage} \t설명: {weapons[2].description} ");        // 방망이
            Console.WriteLine($"아이템이름: {weapons[3].name}\t\t타입: {weapons[3].type}\t데미지: {weapons[3].damage} \t설명: {weapons[3].description} ");      // 장미칼
            Console.WriteLine($"아이템이름: {weapons[4].name}\t\t타입: {weapons[4].type}\t데미지: {weapons[4].damage} \t설명: {weapons[4].description} ");      // 최강의검
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            // 음식
            Console.WriteLine($"아이템이름: {food.name}\t\t타입: {food.type}\t배부름: {food.function} \t설명: {food.description}");                       // 음식
            Console.WriteLine($"아이템이름: {foods[0].name}\t\t타입: {foods[0].type}\t맛있음: {foods[0].function} \t설명: {foods[0].description} ");      // 짜장면
            Console.WriteLine($"아이템이름: {foods[1].name}\t\t타입: {foods[1].type}\t속도업: {foods[1].function} \t설명: {foods[1].description} ");      // 고추
            Console.WriteLine($"아이템이름: {foods[2].name}\t\t타입: {foods[2].type}\t맛있음: {foods[2].function} \t설명: {foods[2].description} ");      // 빅맥
            Console.WriteLine($"아이템이름: {foods[3].name}\t\t타입: {foods[3].type}\t맛있음: {foods[3].function} \t설명: {foods[3].description} ");      // 랍스터
            Console.WriteLine($"아이템이름: {foods[4].name}\t\t타입: {foods[4].type}\t맛있음: {foods[4].function} \t설명: {foods[4].description} ");      // 연어초밥
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            // 방어구
            Console.WriteLine($"아이템이름: {armor.name}\t\t타입: {armor.type}\t방어력: {armor.defense}  \t설명: {armor.description}");

            Console.WriteLine("==========================================================================================================");
            #endregion


        }
    }
    

}
