/* When creating a C# file from Unity,
it will automatically initalize the file with a code like this:*/
public class Classes : MonoBehavior 
//Note when initalizing, always be sure to use the same case
//It it was written like this
public class classes : MonoBehavior
//It would not work because classes is not uppercase
//If your file was named something like 
public class classesHomework : MonoBehavior
//Do not add a space to it like this
public class classes Homework : MonoBehavior
//If you change one name, you have to change the other. 
//It is wise to not change the name unless you really have to

//Classes work as a warehouse for objects
public class SodaFile : MonoBehavior{
    public int cola;
    public int rootBeer;
    public int sprite;
}
//Classes can sometimes go in other classes
public class dinosaurs : MonoBehavior{
    public class dinoPower{
        public int dimetrodon;
        public int stegasaurus;
        public int allosaurus;
    }
//We can then assign values
        public dinoPower(int dim, int steg, int allo){
            dimetrodon = dim;
            stegasaurus = steg;
            allosaurus = allo;
        }
    }
    public dinoPower powers = new dinoPower(999999, 200, 200);
//Classes act like the warehouse which holds the containers example
/*This is the warehouse*/ public class Warehouse : MonoBehavior{
/* These are the containers */ public int shipment1; public int shipment2; }
//Thankfully Unity initalizes with a class, but if we have to write it will look like this
public class nameOfScriptFile : MonoBehavior{ 
    //Code goes here
}



