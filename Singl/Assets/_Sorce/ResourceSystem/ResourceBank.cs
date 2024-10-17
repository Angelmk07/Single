using ResourceSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank 
{
    const int _start = 0;
    private Dictionary<ResourceType, Resource> _resorce;
    public ResourceBank()
    {
        InitRes();
    }
    private void InitRes()
    {
        _resorce = new();
        for (int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
        {
            Resource Newresources = new((ResourceType)i,_start);
        }
    }
}
