using System;

class AccessModifiers{
    public int publicValue = 1;                  // public is accessible everywhere
    private int privateValue = 2;                // private can only be used inside this class
    protected int protectedValue = 3;            // protected can be used in this class and derived classes
    internal int internalValue = 4;              // internal in same project
    protected internal int protectedInternalValue = 5;  // protected/internal access
	// private protected int privateProtectedValue = 6;
		
	static void Main(string[] args){
		
		AccessModifiers obj = new AccessModifiers();
		Console.WriteLine(obj.publicValue); // public
		Console.WriteLine(obj.privateValue); //  private
		Console.WriteLine(obj.protectedValue); // protected
		Console.WriteLine(obj.internalValue); // internal
		Console.WriteLine(obj.protectedInternalValue); //  protectedInternal
		// Console.WriteLine(privateProtectedValue); // privateProtected cant be used because we are using c# 5.0 version which doesnt have privateProtected
		
		Derived d = new Derived();
		Console.WriteLine(d.GetProtectedValue());
		Console.WriteLine(d.GetPublicValue());
		Console.WriteLine(d.GetInternalValue());
	}
}

class Derived : AccessModifiers
{
	
    public int GetProtectedValue(){
        return protectedValue;   // allowed
    }

    public int GetPublicValue(){
        return publicValue;      // allowed
    }

    public int GetInternalValue(){
        return internalValue;    // allowed 
    }
	public int protectedInternal(){
		return protectedInternalValue; // allowed
	}
}

