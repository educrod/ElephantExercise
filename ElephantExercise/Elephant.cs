﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantExercise
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ears are {EarSize} inches tall.");
        }

    }
}
