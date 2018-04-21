//Math operators are how we do computations in the code
//They are very similar to how we write traditional code. 
//Addition:
Debug.Log(5 + 5); //Console returns 10
//The use of + is also used to concat things together like strings and numbers
Debug.Log("There are about " + 600000 + " Squid in the sea");
//Subtraction
Debug.Log(5 - 5); //Console returns 0
//Multiplication 
Debug.Log(5*5); //Console returns 25
//Division
Debug.Log(5/5); //Console returns 1
//This gives the remainder after division
Debug.Log(5%5); //Console returns 25

//Be aware there is a difference between = and ==
//= is for assiging things 
public int speed = 5000;
//Whereas == checks to see if values are the same
(4 == 5) //is false 
(5 == 5) //is true 
//Similar to math, we can define if something is greater than, lessthan or equal to
public int squid = 1000;
public int cats = 4;
//Greater than
Debug.Log(squid > cats); //Console returns true
//Less than
Debug.Log(cats < squid); //Console returns true
//Greater than or equal
Debug.Log(cats >= squid); //Returns false because squid is more
//Less than or equal 
public int squid = 4;
public int cats = 4;

Debug.Log(cats <= squid); //Returns true because variables are now equal
//!= means is not! 
Debug.Log(6 != 6); //Returns false because they are the same

//Finally we have "and", "or" and "not"
&& //is and
|| //is or
! //is not

