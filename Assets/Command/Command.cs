using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  Base class command, define common interface for all commands
namespace CommandPattern
{
    //Base class for the commands
    public abstract class Command
    {
        public abstract void Execute();

    }
}
