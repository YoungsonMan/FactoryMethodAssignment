# 디자인패턴 과제1: 팩토리 메소드 패턴 활용하기

---

이번 강의에선 팩토리 메소드 패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 배웠습다. 

해당 개념을 참고하여, ItemFactory 클래스를 만들고, 팩토리 메소드를 통해서 다양한 Item을 생성해봅니다.

### Goal 학습목표

---

- Item은 ItemFactory를 통해서 생성하도록 한다.
- ItemFactory는 Create(ItemType type) 함수를 가진다.
- ItemType은 열거형으로 Potion, Weapon, Armor, Food 항목을 가진다
- ItemFactory는 Create 함수에 매개변수로 받은 열거형의 유형을 기준으로 각 항목에 맞는 아이템 인스턴스를 생성하여 준다.


### Built with

---

Visual Studio 2022 v17.10.3

Laguage used - C#

### Explanation

---

가독성을 위해서 클래스파일을 따로 빼서 작성.

![FacotryPattern01](https://github.com/user-attachments/assets/a623a785-d50b-488f-9d84-29635ff8c9f7)


![FacotryPattern00](https://github.com/user-attachments/assets/a206fe65-3768-4ccb-b3ee-5fd612f15073)



## Comments

---

개인적으로 가독성, 디자인, 편의성, 이해도 부분에서 팩토리 패턴을 사용해서 작성을 하는게 훨씬 수월하였다.

좋다...
