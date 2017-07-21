﻿using System;
using System.Collections.Generic;

public class MyList : IMyList
{
    private IList<string> elements = new List<string>();

    public int Used => this.elements.Count;

    public int Add(string item)
    {
        this.elements.Insert(0, item);
        return 0;
    }

    public string Remove()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException("No items in the collection");
        }

        var itemToReturn = this.elements[0];
        this.elements.RemoveAt(0);

        return itemToReturn;
    }
}