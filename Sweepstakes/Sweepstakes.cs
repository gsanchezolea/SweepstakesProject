﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    
    public class Sweepstakes 
    {
        //Member Variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
      


        //Constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();

            this.Name = name;
          

        }

        //Member Method
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int result = random.Next(contestants.Count);
            return contestants[result];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Regsitration #: " + contestant.RegistrationNumber + "\n" + 
                "Name: "+ contestant.FirstName + " " + contestant.LastName);
            Console.ReadLine();
            
        }
      
    }
}
