
using ConsoleApp20.Models;

User user = new("Fidan Suleymanli","Fidants@code.edu.az","Fidants");
user.InfoShow();
user.checkPssword("Fidants1k");
user.checkPssword("Fidants");
User user1 = new("Nihad Ibadzade", "Nihadi@code.edu.az", "Nihadi99");
user1.InfoShow(); 
user.checkPssword("Nihadi99");
user.checkPssword("Nihadi9");
User user2= new("Teymur Suleymanov", "Teymurs@code.edu.az","Teymurst");
user2.InfoShow();
user.checkPssword("Teymurst");
user.checkPssword("Teymurst25");

Student student1 = new("Fidan Suleymanli", 10.9);
student1.StudentInfo();
Student student2 = new("Nihad Ibadzade", 11);
student2.StudentInfo();
Student student3 = new("Teymur Suleymanov", 11);
Student student4 = new("Islam Adisirinli", 10);
student3.StudentInfo();








