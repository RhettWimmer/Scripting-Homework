//Void functions are functions that do not return a value. 
//We will mostly be using these types of functions when coding for Unity.
//We've already noticed these functions before in the form of Start and Update.
void Start(){
   //code that runs at the start
}
//and
void Update(){
    //Code that updates
}
//I've learned the hard way that you NEED TO CAPATALIZE THE FIRST LETTER OF THE NAME.
//DO NOT DO THESE. These will not run.
void start(){
    //Block of code
}

void update(){
    //Block of code
}
//Not every function has to be named Start and Update, we can name them anything.
void Run(){
    //Block of code
}

void UniqueName(){
    //Block of code
}
//All of these examples have been private, since we haven't indicated the access modifier to be otherwise.
//We can make public functions like this:
public void DreamScape(){
    //Block of code
}

public void ViewFinder(){
    //Block of code
}
//These are examples of private functions, that have actually been called with the private access.
private void Secret(){
    //Block of code
}

private void Hidden(){
    //Block of code
}