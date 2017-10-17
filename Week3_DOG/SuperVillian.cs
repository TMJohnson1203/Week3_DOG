using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_DOG
{
    class SuperVillian
    {
        private string powers;
        private int numberofEnemies;
        private string howToDestroy;
        private int numberOfApples;


        public string Powers
        {
            get { return this.powers; }
            set { this.powers = value; }
        }
        public int NumberofEnemies
        {
            get { return this.numberofEnemies; }
            set { this.numberofEnemies = value; }
        }
        public string HowToDestroy
        {
            get { return this.howToDestroy; }
            set { this.howToDestroy = value; }
        }
        public int NumberOfApples
        {
            get { return this.numberOfApples; }
            set { this.numberOfApples = value; }
        }

        public SuperVillian()
        {

        }
        public SuperVillian(int numberOfApples, int numberofEnemies)
        {
            this.numberOfApples = numberOfApples;
            this.numberofEnemies = numberofEnemies;
        }

        public void Poison()
        {
            numberOfApples = 13;
        }
        public void Enemies()
        {
            numberofEnemies = 3;
        }

        public void DestroyHer()
        {
            howToDestroy = "Shatter her mirror.";
        }

    }

}

