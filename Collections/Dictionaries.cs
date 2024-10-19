namespace CM_CSharp_Course.Collections;

    public class Dictionaries
    {
        public enum ResourceType
        {
            Wood,
            Stone,
            Gold
        }

        private static Dictionary<ResourceType, int> resourceTypeAmountDictionary = new()
        {
            {ResourceType.Gold, 0},
            {ResourceType.Stone, 0},
            {ResourceType.Wood, 0}
        };

        public static void CreateDictionary(ResourceType resourceType, int amount)
        {
            resourceTypeAmountDictionary[resourceType] = amount;
            Console.WriteLine($"{resourceType} value is: {resourceTypeAmountDictionary[resourceType]}");
        }

        public static void UpdateDictionary(ResourceType resourceType, int newValue)
        {
            if (resourceTypeAmountDictionary.ContainsKey(resourceType))
            {
                resourceTypeAmountDictionary[resourceType] = newValue;
                Console.WriteLine($"{resourceType} updated to: {resourceTypeAmountDictionary[resourceType]}");
            }
            else
            {
                Console.WriteLine($"ResourceType '{resourceType}' does not exist in the dictionary.");
            }
        }
        public static void IterateDictionary()
        {
            foreach (KeyValuePair<ResourceType, int> kvp in resourceTypeAmountDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
    