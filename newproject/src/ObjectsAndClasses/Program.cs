using System;

namespace ObjectsAndClasses
{
    public class Student
    {
         public int id;
        public string name;

       public  void insert (int i , string n)
        {
             id = i;
             name = n;
        }

        void display ()
        {
              Console.WriteLine(" id is " + id );
              Console.WriteLine(" name is " + name );
        }
        class Teacher{
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student S2= new Student();
/*             s1.id=101;
            s1.name= "Test";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name); */
            s1.insert(101,"Scott");
            S2.insert(201,"Tom");
            s1.display();
            S2.display();
            

        }
    }
}
}
