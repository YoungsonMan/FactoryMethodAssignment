using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodAssignment
{
    public class ItemFactory
    {
        public static T Instantiate<T>(string name) where T : Item
        {
            #region 포션
            if (name == "포션")
            {
                Potion potion = new Potion();
                potion.name = "빨간물약";
                potion.hp = 50;
                potion.type = Item.ItemType.Potion;
                potion.description = "피는 얼마안차지만 맛있다!";
                return potion as T;
            }
            else if (name == "더큰포션")
            {
                Potion potion = new Potion();
                potion.name = "왕빨간물약";
                potion.hp = 100;
                potion.type = Item.ItemType.Potion;
                potion.description = "왕 빨갛당";
                return potion as T;
            }
            else if (name == "활력포션")
            {
                Potion potion = new Potion();
                potion.name = "활력포션";
                potion.hp = 1000;
                potion.type = Item.ItemType.Potion;
                potion.description = "몸에 호랑이 기운이...!";
                return potion as T;
            }
            else if (name == "엘릭서")
            {
                Potion potion = new Potion();
                potion.name = "엘릭서";
                potion.hp = 10000;
                potion.type = Item.ItemType.Potion;
                potion.description = "체력이 넘친다..!";
                return potion as T;
            }
            else if (name == "보라포션")
            {
                Potion potion = new Potion();
                potion.name = "독약";
                potion.hp = -100;
                potion.type = Item.ItemType.Potion;
                potion.description = "포션을 나만 먹으란법 없잖아..!?";
                return potion as T;
            }
            else if (name == "랜덤포션")
            {
                Potion potion = new Potion();
                potion.name = "랜덤포션";
                Random random = new Random();
                potion.hp = random.Next(-10000,10000);
                potion.type = Item.ItemType.Potion;
                potion.description = "먹고 죽을수도 체력이 넘칠수도...!";
                return potion as T;
            }
            #endregion

            #region 무기
            else if (name == "무기")
            {
                Weapon weapon = new Weapon();
                weapon.name = "단검";
                weapon.damage = 25;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "기본으로 주어지는 단검이다.";
                return weapon as T;
            }
            else if (name == "대검")
            {
                Weapon weapon = new Weapon();
                weapon.name = "킹왕짱큰검";
                weapon.damage = 100;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "크다고 했지 쎄다곤 안했다.";
                return weapon as T;
            }
            else if (name == "도검")
            {
                Weapon weapon = new Weapon();
                weapon.name = "칠지도 ";
                weapon.damage = 777;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "Seven Map";
                return weapon as T;
            }
            else if (name == "방망이")
            {
                Weapon weapon = new Weapon();
                weapon.name = "도깨비방망이";
                weapon.damage = 200;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "또깨비 방망이는 빨게";
                return weapon as T;
            }
            else if (name == "장미칼")
            {
                Weapon weapon = new Weapon();
                weapon.name = "장미칼";
                weapon.damage = 55;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "모든걸 썰어버릴 수 있다는 칼";
                return weapon as T;
            }
            else if (name == "최강의검")
            {
                Weapon weapon = new Weapon();
                weapon.name = "서버정검";
                weapon.damage = 1000;
                weapon.type = Item.ItemType.Weapon;
                weapon.description = "서버정검 앞에는 모두가 평등하지";
                return weapon as T;
            }
            #endregion

            #region 음식
            else if (name == "음식")
            {
                Food food = new Food();
                food.name = "왕주먹밥";
                food.function = 100;
                food.type = Item.ItemType.Food; 
                food.description = "안에 들은 맛은 랜덤이다";
                return food as T;
            }
            else if (name == "짜장면")
            {
                Food food = new Food();
                food.name = "짜장면";
                food.function = 1000;
                food.type = Item.ItemType.Food;
                food.description = "여러분 짜장 좋아해~? 아뉘. 그럼 모조아해? 짬뽕! ";
                return food as T;
            }
            else if (name == "고추")
            {
                Food food = new Food();
                food.name = "할라피뇨";
                food.function = 100;
                food.type = Item.ItemType.Food;
                food.description = "매운맛에 이동속도가 오른다!";
                return food as T;
            }
            else if (name == "빅맥")
            {
                Food food = new Food();
                food.name = "빅맥";
                food.function = 1000;
                food.type = Item.ItemType.Food;
                food.description = "참깨빵 위에 순쇠고기패티 두장 특별한소스 양상추 치즈피클양파까아지~~빠빠빠라빠";
                return food as T;
            }
            else if (name == "랍스터")
            {
                Food food = new Food();
                food.name = "랍슽터";
                food.function = 15000;
                food.type = Item.ItemType.Food;
                food.description = "맛있겠다 바닷가제";
                return food as T;
            }
            else if (name == "연어초밥")
            {
                Food food = new Food();
                food.name = "연어초밥";
                food.function = 10000;
                food.type = Item.ItemType.Food;
                food.description = "저..절대 제가 먹고싶은걸 적고있는게 아닙니다1";
                return food as T;
            }
            #endregion

            #region 방어구
            else if (name == "방어구")
            {
                Armor armor = new Armor();
                armor.name = "나시티";
                armor.defense = 1;
                armor.type = Item.ItemType.Armor;
                armor.description = "";
                return armor as T;
            }

            #endregion

            else
            {
                Console.WriteLine("해당 이름의 아이템이 없습니다.");
                return null;
            }
        }
    }

    
}
