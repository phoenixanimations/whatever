using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace TagFramework
{
    public class Tag : MonoBehaviour
    {
        [SerializeField]
        private List<TagData> tags = new List<TagData>();

        public bool HasTag (TagData tag)
        {
            return tags.Contains(tag);
        }

        public List<TagData> GetTags ()
        {
            return tags;
        }

        public bool HasTags (List<TagData> TagData)
        {
            return tags.Any(t => TagData.Contains(t));
        }

        // Used when wanting to compare two different objects, in a file
        // where it doesn't make sense to do Tag.CompareTags(tagB).
        public static bool CompareTags (List<TagData> first, List<TagData> second)
        {
            return first.Any(t => second.Contains(t));
        }

        public static bool CompareTags (List<TagData> first, Tag second)
        {
            return CompareTags(first, second.tags);
        }

        public static bool CompareTags (Tag first, Tag second)
        {
            return CompareTags(first.tags, second.tags);
        }

        public bool CompareTags (Tag second)
        {
            return CompareTags(tags, second.tags);
        }
    }
}

