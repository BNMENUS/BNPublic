using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
            new GradientColorKey(Color.magenta, 0.9f),//ass
            new GradientColorKey(Color.black, 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
