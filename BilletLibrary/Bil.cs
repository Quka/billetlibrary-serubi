﻿using System;

namespace BilletLibrary
{
    public class Bil : Vehicle
    {

        // Constructor
        public Bil(string nummerplade, DateTime dato):base(nummerplade,dato)
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }
        
    }
}
