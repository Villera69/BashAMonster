
namespace BashAMonster {
class Goomba{
    public int hp;

    public Goomba (int hp){
        this.hp = hp;
    }

}

class Player{

    string name;

    public Player(string name){
        this.name = name;
    }
}

class Program{
        static void Main(){
        Goomba Goomba1 = new Goomba(100);
        Console.WriteLine("The Goomba has " + (Goomba1.hp) + "hp. Press enter to hit it.");
        Console.ReadLine();
        Goomba1.hp =- 20;
        Console.WriteLine("The Goomba now has " + (Goomba1.hp) + "hp");
        Console.ReadLine();

    }
    

}
}


