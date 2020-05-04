using System;
//using NameSpaces;
//using First;
//using Second;

/*{
namespace NameSpaces
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Namespace!");
            //System.Console.WriteLine("Hello Namespace!");
        }


    } 

} */


namespace First
 {
    class Hello
    {  
    public void sayHello() { 
        Console.WriteLine("Hello First Namespace"); 
        
        }  
}  
}  
namespace Second  
{  
    public class Welcome 
    {  
        public void sayWelcome() { 
            Console.WriteLine("Welcome Namespace"); 
            
            }  
    }  
}  
public class TestNamespace  
{  
    public static void Main()  
    {  
        First.Hello h1 = new First.Hello();  
        Second.Welcome h2 = new Second.Welcome();  
        h1.sayHello();  
        h2.sayWelcome();  
  
    }  
} 
   


