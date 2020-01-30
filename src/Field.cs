using System;
using System.Collections.Generic;

namespace Underfield
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.ReturnValue)]  
    public class Field : Attribute 
    {
        private UnderType UnderType { get; set; }

        // public Field(UnderType underType)
        // {
        //     UnderType = underType;
        // }
        
        public Field(Type e)
        {
        }
        
        public Field(params object[] e)
        {
        }
    }
    
    [AttributeUsage(AttributeTargets.Class)]  
    public class UnderClass : Attribute 
    {
        private UnderType UnderType { get; set; }
    }
}