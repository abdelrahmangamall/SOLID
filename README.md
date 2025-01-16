# SOLID

![image](https://github.com/user-attachments/assets/888a9d61-ca48-4dd0-9003-198bf2073fa4)
<br>
## 1) Single Responsibility Principle...(S)OLID
*his Idea: Every class or function should have a single job*<br>
![image](https://github.com/user-attachments/assets/a7bc6fd6-f5d5-43f4-998f-4158ebb09ba0)
<br>**We have two models in pattern**<br>
*1. Reach domain model: our domain logic is a part of our domain entities.*<br>
Full Encapsulation دا بيكون <br>
attributes(data) and operation together in the same class.<br>
![image](https://github.com/user-attachments/assets/f60f32cb-e17a-4e12-802a-413649c72f2b)
<br>
*1. Anemic domain model: a model that separates data and operation.*<br>
![image](https://github.com/user-attachments/assets/8e4dc8c2-d513-4a97-b5a4-c2fb2af6f98e)
<br>
## 2) Open/Close Principle...S(O)LID
*His idea: The code should be addable without modifying the base code.*
![image](https://github.com/user-attachments/assets/091291e1-59c7-457c-9233-85e267632e26)<br>
![image](https://github.com/user-attachments/assets/e3911204-9a05-45e4-b7da-556adbba0f60)
<br>
## 3) Liskov Subsitution Princilpe...SO(L)ID.
*His Idea: subtype must be a Substitution for their base type.*<br>
*The problem that has been solved: A subclass can not apply a method in the base class.*
![image](https://github.com/user-attachments/assets/f63e1c74-89e2-4f12-9d62-045611e83d3b)
<br>
## 4) Interface Segregation Principle...SOL(I)D.
*His Idea: Don't force classes to implement Methods they don't use.*
![image](https://github.com/user-attachments/assets/aebc3cec-cfe7-4a3d-93d2-bff57a9e9a38)

- An Example of this problem to solve:<br>
![](https://github.com/user-attachments/assets/e1ccbb8f-bad5-4a04-ad49-b4e2d8a13d9e)
- Before And After Applying the Interface segregation principle:
![image](https://github.com/user-attachments/assets/30c0c259-b240-4c6d-992f-1076606e7334)


## 5) Dependency Inversion Principles...SOLI(D).
*Transfer of credentials-تحويل الاعتمادية*<br>
*His Idea: classes must depend on the abstractions or Interfaces, not on subclasses* 
![image](https://github.com/user-attachments/assets/37eb7234-6454-4b8c-9a83-72fab3450ce7)



