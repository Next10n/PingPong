﻿using System;

namespace Code.Progress
{
    public class PlayerProgressService : IPlayerProgressService
    {
        public PlayerProgress Progress { get; private set; }

        public void Load()
        {
            
        }
    }

    [Serializable]
    public class PlayerProgress
    {
        
    }
}