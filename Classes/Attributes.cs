using Microsoft.VisualBasic.CompilerServices;

namespace CM_CSharp_Course.Classes;

public class Attributes
{
    public void AttributesMainMethod()
    {
        object[] attributeObjectArray = typeof(PlayerCharacter).GetCustomAttributes(typeof(IsObjectTypeAttribute), false);
        IsObjectTypeAttribute isObjectTypeAttribute = (IsObjectTypeAttribute)attributeObjectArray[0];
        Console.WriteLine(isObjectTypeAttribute.GetObjectType());
    }
    
    [IsObjectType(ObjectType.Unit)]
    public class PlayerCharacter
    {
    
    }
    
    public enum ObjectType
    {
        Unit,
        Object,
        Prop,
    }
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class IsObjectTypeAttribute : System.Attribute
    {
        private ObjectType objectType;

        public IsObjectTypeAttribute(ObjectType objectType)
        {
            this.objectType = objectType;
        }

        public ObjectType GetObjectType()
        {
            return objectType;
        }
    }
}



