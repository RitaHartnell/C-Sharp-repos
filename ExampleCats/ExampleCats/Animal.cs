using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCats
{
    public class Animal
    {
        private string name = "sad face";
        private int age = 0;

        /// <summary>
        /// setter for name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// setter for age
        /// </summary>
        /// <param name="age"></param>
        public void SetAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// getter for name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// getter for age
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return age;
        }
    }
}
