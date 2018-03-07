//Foreach loops uses Arrays like this
arg[0] = "One";
arg[1] = "Two";
arg[2] = "Three";
arg[3] = "Four";
arg[4] = "Five";

//Initialzation in a foreach loop looks like this
string[] arg = new string[5];

//The last part of this loop is to call foreach
foreach(string item in arg){
    print(item);
}

//All together, it should look like this

void Start(){
    string[] cats = new string[5];

    cats[0] = "Bean";
    cats[1] = "Floofer";
    cats[2] = "Soggy";
    cats[3] = "Raven";
    cats[4] = "Bobber";

    foreach(string item in cats){
        print(item);
    }
}

//We can make an enemies list 
void Start(){
    string[] villians = new string[3];

    villians[0] = "Satan";
    villians[1] = "Durger Donger";
    villians[2] = "Suggar Dade";

    foreach(string item in villians){
        print(item);
    }
}

//Here's one for friendlies
void Start(){
    string[] backUp = new string [3];

    backUp[0] = "Big Boi";
    backUp[1] = "Pug";
    backUp[2] = "Clint Eastwood";

    foreach(string item in backUp){
        print(item);
    }
} 

//Since we are using an array, you can notice we don't write things like this
//We got to remember that arrays start at 0 not 1
badArg[1] = "Example 1"; 
badArg[2] = "Example 2";
badArg[3] = "Example 3";

//If we don't add five items in our cars, the empty ones will return null
void Start(){
    string[] cars = new string [5];

    cars[0] = "Green Lamborghini";
    cars[1] = "White Lamborghini";
    cars[2] = "Purple Lamborghini";

    foreach(string item in cars){
        print(item);
    }
}

/*
Output:
Green Lamborghini
White Lamborghini
Purple Lamborghini
Null
Null
*/

//Few more exampls 
void Start(){
    string[] outlaws = new string [3];

    outlaws[0] = "Jesse McCree";
    outlaws[1] = "John Marston";
    outlaws[2] = "Cullen Bohannon";

    foreach(string item in outlaws){
        print(item);
    }
}

//Example
void Start(){
    string[] monkies = new string[2];

    monkies[0] = "Winston";
    monkies[1] = "Hammond";

    foreach(string item in monkies){
        print(item);
    }
}