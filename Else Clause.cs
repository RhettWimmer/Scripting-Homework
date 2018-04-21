//The else clause apart of the conditional known as the If statement
//The if statement works like this
if (condition){
    do this
}
//The else is what happens if the condition in the if is not met
if (condition){
   Debug.Log("do this");
} else {
   Debug.Log("do this instead");
}
//Conditionals are very helpful ways of organizing behaviors
if (playerHealth <= 0){
    playerHealth = 0;
    Debug.Log("The player is dead! You have " + playerHealth + "Health");
    }else{
        Debug.Log("The player is fine. You have" + playerHealth + "Health remaining");
    }
}
//Another Example
public bool sprint = true;

if (sprint == true){
    moveSpeed *= 1.5f;
    }else{
        moveSpeed == 1f;
    }
}

//We can even go deeper and use an else if
public bool pinapplePizza = true;
public bool chickenPizza = false;
public bool pepperoniPizza = false;

void pizzaStatus(){
	if (pinapplePizza == true){
		Debug.Log("This pizza is inedible. Throw it away.");
			} else if (pepperoniPizza == true){
			Debug.Log("This pizza is okay, I guess");
				}else{
				Debug.Log("This pizza is perfect!");
		}
	}
}


