//A switch statement is similar to an If Else statement. 
//However, Switch statements can take on several lines and make code more managable.
//If or Else If statements can become cumbersome if it grows in size
// Else If statements get unrully at around three statements
//Switch statements can handle severeal!

public int mana = 5;

void fixMagicBall(){
    switch (mana){
        case 5:
            Debug.Log("You quickly fix the magic ball with ease. It is functioning at maximum power");
            break;
        case 4:
            Debug.Log("You run into a few issues while fixing the ball, but you still get it to work like a charm");
            break;
        case 3:
            Debug.Log("You struggle to fix the ball. After several hours of study you finally get the ball to work at half charge");
            break;
        case 2: 
            Debug.Log("You try very hard to figure out the magic ball. Unfortunately you are not skilled enough, and the ball is now unable to hold magic");
            break;
        case 1:
            Debug.Log("You tinker with the ball for severeal hours, frusterated, you throw the ball across the room. Breaking it.");
        default:
            Debug.Log("Wrong input");
            break;
    }
}
//If statements can be pretty confusing logic
public int eggs = 3;

if(eggs == 3){
    Debug.Log("You have all the eggs!");
        }if(eggs == 2) { 
            Debug.Log("You have one more egg left");
            }if(eggs == 1){
                Debug.Log("You have one egg");
            }else{
                Debug.Log("You have no eggs");
         }
//Switch statements can help make sense of them better
//The Switch statement even saves memory!
//The Else If has to check each condition
//Whereas the switch statement will find it's condition, and break, only running that specific code

public int eggs = 3;

void eggCounter(){
    switch(eggs){
        case 3: 
            Debug.Log("You have all the eggs!");
            break;
        case 2: 
            Debug.Log("You have one more egg left");
            break;
        case 1: 
            Debug.Log("You have one egg");
            break;
        default:
            Debug.Log("You have no eggs");
            break;
    }
}
//Let's breakdown the idea of how a switch statement works
public int nameOfVariable = 1
void exampleSwitch(){
switch(nameOfVariable){ //Switch must be named after the variable 
    case 1:
        //Run this code
        break; //This breaks out of the code and only runs the code above if it's condition is met above
    default: //This is ran if no conditions are met
        //Run this code, possibly an error message for the user
        break;
    }
}

     
