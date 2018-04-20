//In scripting, syntax is like grammar and Conventions is like a writer's style of writing
//Syntax has to be written for the code to work. Written wrong, and the code will fail
void Start(){
    if(this){
        do this;
    }
}
//This code will work because the syntax is proper
void start ()
    IF(this)
        do this
    }
}
//This would not run because the syntax is wrong
//Conventions are just how the programer writes the code
void Update(){
    //lines of code
}
//and
void Update()
{
    //line of code
}
//Both lines of code will still run even if the bracket is on a different line
//Syntax involves the names we use to call things. Transform, void, bool, etc. are all examples of syntax that have to be written right
//Conventions are interchangeabe. They usually refer to indentation 
void Start(){
    if(Input.GetKeyDown(KeyCode.W)){
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
//Above is the prefered indentation, that comes after each bracket
void Start(){
if(Input.GetKeyDown(KeyCode.W)){
transform.Translate(Vector3.forward * Time.deltaTime);
}
}
//While the code above works, it is less prefered, and is harder to read
void Start(){ if(Input.GetKeyDown(KeyCode.W)){ transform.Translate(Vector3.forward * Time.deltaTime);}}
//This code would work as well, but it is very messy, and many people do not like this