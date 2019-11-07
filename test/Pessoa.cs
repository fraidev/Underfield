namespace Underfield
{
    public class PeopleS
    {
        public string Name { get; set; }
    }
    public class PeopleM
    {
        public string Name { get; set; }
    }
    public class People: UnderfieldMap<PeopleS, PeopleM>
    {
        public People()
        {
             
            
            
//            MapWrite(x => x.Name).Editable(EditableTypes.InputText);
            
            MapRead(x => x.Name).Display();
        }
    }
}