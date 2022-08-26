using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Ability
{
        
        [Flags]
        public enum Types
        {   // plausible values 2 / 3 / 4 / 5
            Ultimate = 1,
            Passive = 2,
            Active = 4


        }
        
        public int Id;
        public string Name;
        public int Damage;
        public Types Type;
        public int CastRange;
        public int EnergyCost;
        public string Tooltip;


    
    public Ability()
    {     
        
    }

  
}





