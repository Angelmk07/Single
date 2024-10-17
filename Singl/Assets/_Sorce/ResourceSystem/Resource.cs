using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ResourceSystem
{
    public class Resource 
    {
        private int ResourceAmount;
        public ResourceType ResourceType {  get; private set; }
        public Resource(ResourceType resourceType,int resourceAmount)
        {
            ResourceAmount = resourceAmount;
            ResourceType = resourceType;
        }
        public void AddRecource(int val)
        {
            ResourceAmount += val;
        }
    }

}
