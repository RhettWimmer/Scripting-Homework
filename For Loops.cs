//For loops use this bit of code
for(i = 1; i <= 10; i++)

//This line of code can be changed to do different things
//This code below counts up
for(int i = 0; i < cats; i++)

//This code will count down
for(int i = 5; i > cats; i--)

//Here is this code in action
public int problems = 0;

void Start(){
	for(int i = 99; i > problems; i--){
		print("I've got " + i + " problems");
		}
	}
}
//The output will count 99 problems down
//But wait! Let's be mean and start adding problems
public int problems = 0;
public int moreproblems = 99;

void Start(){
	for(int i = 99; i > problems; i--){
		print("I've got " + i + " problems");
		}
	for(int i = 0; i < moreproblems; i++){
	    print("I've got " + i + " problems")
		}
	}
}

//Here's an example of code that counts up
public int cakes = 21;

void Start(){
	for(int i = 0; i <= cakes; i++){
		print("Wow... You really ate " + i + " Cakes?");
		}
	}
}
//This code in Unity could help us track how many zombies we have to kill
public int zombies = 0;

void Start(){
	for(int i = 1000; i > zombies; i--){
		print("Zombie number " + i + " Down!");
		}
	}
}
//Another use would be to count XP
public int xPoints = 2500;

void Start(){
	for(int i = 0; i <= xPoints; i++){
		print("You have " + i + " Experience Points");
		}
	}
}
//Similar code could count down how much XP you have left to aquire
public int xPoints = 0;

void Start(){
	for(int i = 2500; i > xPoints; i--){
		print("You have " + i + " Experience Points until next level up");
		}
	}
}

//One more
public int homework = 0;

void Start(){
    for(int i = 100; i > homework; i--){
        print("I got " + i + " homework assignments left");
        }
    }
}


