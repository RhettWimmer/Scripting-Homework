/* 
While loops iterate until the loop is proven false. 
 */


//This example will count down through the enemies starting at 10

public int enemies = 10;

	void Start()
	{
		while(enemies > 0){
			print("Ememy number " + enemies + " Down!");
			enemies--;
		}
	}
}

//We can use any numbers
//This script will print "There is 100 squid" once

	public int squid = 100;
	void Start()
	{
		while(squid > 99){
			print("There is " + squid + " Squid");
			squid--;
		}
	}
}

//Here is a silly loop
	public int cats = 666;

	void Start()
	{
		while(cats > 555){
			print("CATS ARE TAKING OVER THE WORLD!");
            cats--;
		}
	}
}

//Above is a perfectly working loop. 
//If we forget the decrementor, this loop becomes evil
//This is an infinte loop RUN AT YOUR OWN COST

public int cats = 666;
	void Start()
	{
		while(cats > 555){
			print("CATS HAVE DESTROYED THE WORLD!");
		}
	}
}

/* I've used a lot of decrementors, this time I'll use an
incrementor that will count up
*/

public int catCounter = 0;

void Start()
{
	while(catCounter <= 10){
		print("Here's cat number " + catCounter);
		catCounter++;
	}
}
}

//Here's some more uses of incremting loops

public int howHighCanYouCount = 0;
void Start(){
    while(howHighCanYouCount <= 100){
        print(howHighCanYouCount + " Mississippi");
        howHighCanYouCount++;
    }
}
}

//Another, although, I don't think it will run with that number

public int stars = 0;
 void Start(){
     while(stars < 10000000000000000000){
         print("There are like " + stars + " in the sky");
         stars++;
     }
 }

//Another example counting up
public int money = 0;
void Start(){
    while(money <= 2){
        print("You only have " + money + " In your account");
    money++;
    }
}

//Down counter
public int secondsToLive = 60;
void Start(){
    while(secondsToLive > 0){
        print("You've got " + secondsToLive + " to live.");
        secondsToLive--;
    }
}

//Last one, let's count down
public int newYears = 5;
void Start(){
    while(newYears > 0){
        print(newYears + " Seconds to New Years!");
        newYears--;
    }
}
