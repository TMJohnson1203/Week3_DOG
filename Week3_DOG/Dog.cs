﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_DOG
{
    class Dog
    {// fields = camel case
        private string furLength;
        private float height;
        private string runningSpeed;
        private double weight;

        //Properties = Pascal case
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }  
            public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Weight
        {
            get { return this.weight; } //
            set { this.weight = value; }
        }

        // Constructor
        public Dog()
        {
            // default = no perameters 
        }

        // overload Constructor
        public Dog(string furLength, float height)//can add more characteristics
        {
            this.furLength = FurLength;
            this.height = Height;
        }

        public void Run()
        {
            runningSpeed = "getting faster.";
            weight--;
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight -= 0.1;
        }

        public void Groom()
        {
            furLength = "all cleaned up.";
        }
     
    }
}