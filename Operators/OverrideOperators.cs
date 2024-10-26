namespace CM_CSharp_Course.Operators;

public class OverrideOperators
{
    public void OverrideOperatorisMainmethod()
    {
        ResourceAmount resourceAmount1 = new ResourceAmount
        {
            resourceType = ResourceType.Wood,
            amount = 5,
        };
        ResourceAmount resourceAmount2 = new ResourceAmount
        {
            resourceType = ResourceType.Wood,
            amount = 12,
        };

        ResourceAmount resourceAmountTotal = resourceAmount1 + resourceAmount2;

        Console.WriteLine(resourceAmountTotal);

        Console.WriteLine(resourceAmount1 == resourceAmount2);
    }
    public enum ResourceType
    {
        Wood,
        Gold
    }
    public class ResourceAmount
    {
        public ResourceType resourceType;
        public int amount;
        public override string ToString()
        {
            return resourceType + " : " + amount;
        }

        public static ResourceAmount operator +(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return new ResourceAmount
            {
                resourceType = resourceAmountA.resourceType,
                amount = resourceAmountA.amount + resourceAmountB.amount,
            };
        }

        public static bool operator ==(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return resourceAmountA.resourceType == resourceAmountB.resourceType && resourceAmountA.amount == resourceAmountB.amount;
        }

        public static bool operator !=(ResourceAmount resourceAmountA, ResourceAmount resourceAmountB)
        {
            return !(resourceAmountA == resourceAmountB);
        }
    }
}