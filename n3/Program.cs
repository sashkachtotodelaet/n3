interface IGun
{
    void shot();
}

class Gun : IGun
{
    void IGun.shot()
    {
        Console.WriteLine("пыщ");
    }
}
class MachineGun : IGun {
    void IGun.shot()
    {
        Console.WriteLine("пыщ, пыщ, пыщ");
    }
}
class n3
{

    static void Main(){
        Gun gun = new Gun();
        MachineGun machine = new MachineGun();

        n(machine);
        n(gun);
    }
    static void n(IGun n)
    {
        n.shot();
    }
}
