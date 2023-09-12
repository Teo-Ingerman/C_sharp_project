
namespace Enemies
{

    class Enemies
    {
        public int health;
        public int experience;
        public int level;
        public int damage;
        
    }
    class Goblin : Enemies
    {   
        public Goblin()
        {
            health = 10;
            experience = 2;
            level = 1;
            damage = 2;
        }
    }


    class Skeleton : Enemies
    {
        public Skeleton()
        {
            health = 30;
            experience = 10;
            level = 3;
            damage = 10;
        }
    }

    class Orc : Enemies
    {
        public Orc()
        {
            health = 50;
            experience = 10;
            level = 3;
            damage = 15;
        }
    }



}