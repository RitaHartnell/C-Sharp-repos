using System;

namespace ExampleCats
{
    public class Cat : Animal
    {
        //set attributes
        private string breed;

        /// <summary>
        /// constructor that takes in name, age and breed5
        /// </summary>
        /// <param name="thisName"></param>
        /// <param name="thisAge"></param>
        public Cat(string thisName, int thisAge, string thisBreed = "floof")
        {
            SetName(thisName);
            SetAge(thisAge);
            breed = thisBreed;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Cat()
        {
            SetName("nameless");
            SetAge(0);
            breed = "floof";
        }

        public string GetBreed()
        {
            return breed;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }
        
    }
}
