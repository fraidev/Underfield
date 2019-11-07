using System;

namespace Underfield
{
    public class FluentWriteProperty
    {
        private EditableTypes _editableType;
        private Type _type;

        public FluentWriteProperty(Type type)
        {
            _type = type;
        }
        
        public void Editable(EditableTypes editableTypes)
        {
            _editableType = editableTypes;
        }
    }
}