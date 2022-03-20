using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

namespace Commands
{
    
    public interface ICommand
    {
        void Init(PlayerController actor);
        void Load();
        void Execute(PlayerController controller);
    }
}

