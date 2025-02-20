using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

//Function Psedeo Code



RandomizeAnimals();
//var group = AssignGroup();
//string[,] group = AssignGroup();
Console.WriteLine("School");
//PrintGroup(group);

//RandomizeAnimals Function;
void RandomizeAnimals(){
    Random random = new Random();
    for(int i=0;i<pettingZoo.Length;i++)
    {
        // int i = 0;
        int r = random.Next(i,pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
      
    }
      foreach(string animal in pettingZoo) 
        {
        Console.WriteLine(animal);
        }
}
//AssignGroup();
//AssignGroup();

