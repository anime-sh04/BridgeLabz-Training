using System;

class Animal{
	public string Name;
	public int Age;
	
	public Animal(string name,int age){
		this.Name= name;
		this.Age= age;
	}
	
	public virtual void MakeSound(){
		Console.WriteLine("Animal Made Sound");
	}
}

class Dog :Animal{
	public Dog(string name, int age) : base(name, age){}
	public override void MakeSound(){
		Console.WriteLine("Dog is Barking");
	}
}
class Cat :Animal{
	public Cat(string name, int age) : base(name, age){}
	public override void MakeSound(){
		Console.WriteLine("Cat is Meows");
	}
}
class Bird :Animal{
	public Bird(string name, int age) : base(name, age){}
	
	public override void MakeSound(){
		Console.WriteLine("Bird is Chirps");
	}
}

class AnimalHierarchy{
	static void Main(string[] args){
		Animal dog = new Dog("Doggy",12);
		Animal cat = new Cat("Catty",5);
		Animal bird = new Bird("Birdy",7);
		dog.MakeSound();
		cat.MakeSound();
		bird.MakeSound();
	}
}

