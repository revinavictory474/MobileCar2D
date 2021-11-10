using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tool
{
    internal static class ResourcesLoader 
    {
        public static Sprite LoadSprite(ResourcesPath path) =>
            Resources.Load<Sprite>(path.PathResource);

        public static GameObject LoadPrefab(ResourcesPath path) =>
            Resources.Load<GameObject>(path.PathResource);
    }
}