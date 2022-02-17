using System;

namespace heist{

public class Bank {

    public int DifficultyLvl = 100;

       public int LuckValue()
    {
        Random random = new Random();
        return random.Next(-10, 10);
    }
}
}