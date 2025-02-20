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
string[,] group = AssignGroup();
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
    //   foreach(string animal in pettingZoo) 
    //     {
    //     Console.WriteLine(animal);
    //     }
}


string[,] AssignGroup(int groups = 6){

    string[,] result = new string[groups, pettingZoo.Length/groups];

    int start = 0;
    for(int i = 0; i < groups;i++){
        for(int j = 0; j < result.GetLength(1); j++){
            result[i,j] = pettingZoo[start++];

        }
    }
    return result;
}
//AssignGroup();
//AssignGroup();

