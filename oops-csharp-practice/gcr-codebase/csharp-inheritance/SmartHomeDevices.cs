using System;

class Device{

    protected int DeviceId;
    protected string Status;

    public Device(int id,string status){
        DeviceId = id;
        Status = status;
    }

    public virtual void DisplayStatus(){
        Console.WriteLine("Device ID : " + DeviceId);
        Console.WriteLine("Status : " + Status);
    }
}

class Thermostat : Device{

    int TemperatureSetting;

    public Thermostat(int id,string status,int temp) : base(id,status){
        TemperatureSetting = temp;
    }

    public override void DisplayStatus(){
        base.DisplayStatus();
        Console.WriteLine("Temperature :" + TemperatureSetting + "°C");
    }
}

class SmartHomeDevices{
    static void Main(string[] args){
        Thermostat t = new Thermostat(101,"ON",24);

        t.DisplayStatus();
    }
}
