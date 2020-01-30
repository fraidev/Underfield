using System.Collections.Generic;

namespace Underfield
{
    [UnderClass]
    public class Person
    {
        // [Field(UnderType.Checkbox)]
        [Field]
        public bool LikePizza { get; set; } 
        
        // [Field(UnderType.Input)]
        [Field]
        public string Name { get; set; }
       
        // [Field(UnderType.Number)] 
        [Field]
        public int Age { get; set; }
  
        // [Field(UnderType.AutoComplete)] 
        [Field("Rio de Janeiro" ,"São Paulo", "Macaé")]
        public string City { get; set; }

        // [Field((UnderType.Select))]
        [Field(typeof(Sex))]
        public string Sex { get; set; }
        
        [Field]
        public List<string> Thinks { get; set; }  
    }


    public enum Sex
    {
        Female,
        Male
    }
}