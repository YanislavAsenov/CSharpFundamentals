﻿using System.Collections.Generic;

public class ItemCommand : AbstractCommand
{
    public ItemCommand(IList<string> args, IManager manager) 
        : base(args, manager)
    {
    }

    public override string Execute()
    {
        string result = this.Manager.AddItemToHero(this.Args);
        return result;
    }
}