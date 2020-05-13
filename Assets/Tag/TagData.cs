using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TagFramework
{
    public enum TagData
    {
        // Always add to the end to avoid having everything get resorted.
        Floor,
        Wall,
        Player,
        Interactive,
        Noninteractive,
        Unit
    }
}
