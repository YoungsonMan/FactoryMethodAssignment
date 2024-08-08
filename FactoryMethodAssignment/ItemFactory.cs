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
                potion.description = "";
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
                food.description = "";
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
