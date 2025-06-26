

using System;
 
// single inheritance
class Animal {
    public void Eat() {
        Console.WriteLine("Animal is eating.");
    }
}
 
class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Dog is barking.");
    }
}
 
// multi-level inheritance
class Mammal : Animal {
    public void Run() {
        Console.WriteLine("Mammal is running.");
    }
}
 
class Horse : Mammal {
    public void Gallop() {
        Console.WriteLine("Horse is galloping.");
    }
}
 
// hierarchical inheritance
class Bird : Animal {
    public void Fly() {
        Console.WriteLine("Bird is flying.");
    }
}
 
class Eagle : Bird {
    public void Hunt() {
        Console.WriteLine("Eagle is hunting.");
    }
}
 
class Penguin : Bird {
    public void Swim() {
        Console.WriteLine("Penguin is swimming.");
    }
}
 
// multiple inheritance
interface I1 {
    void Method1();
}
 
interface I2 {
    void Method2();
}
 
class MyClass : I1, I2 {
    public void Method1() {
        Console.WriteLine("Method1 is called.");
    }
 
    public void Method2() {
        Console.WriteLine("Method2 is called.");
    }
}
class Program {
    static void Main(string[] args) {
        Dog d=new Dog();
        d.Eat();
        d.Bark();
        
        Mammal m=new Mammal();
         Console.WriteLine("\n");
        m.Run();
        m.Eat();
        
        Horse h=new Horse();
         Console.WriteLine("\n");
        h.Eat();
        h.Run();
        h.Gallop();
        
        Eagle e=new Eagle();
        Console.WriteLine("\n");
        e.Hunt();
        e.Fly();
        e.Eat();
         Console.WriteLine("\n");
         MyClass n=new MyClass();
         n.Method1();
         n.Method2();
  
    }}