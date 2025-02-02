﻿using UnityEngine;

namespace OUA.Npcs.Occupations
{
    public interface IOccupation
    {
        string Name { get; }
        void Trigger(GameObject other);
    }
}
