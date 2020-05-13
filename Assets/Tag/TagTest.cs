using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

namespace TagFramework
{
    public class TagTest : MonoBehaviour
    {
        void Start ()
        {
            Debug.AssertFormat(CompareTagsTest1(),
                               "Searching listA and listB did not return true.");
            Debug.AssertFormat(CompareTagsTest2(),
                               "Searching listA and listB found a match- it shouldn't.");
            Debug.AssertFormat(HasTagTest1(),
                               "Searching for a value that should match the tag list- it didn't.");
            
            Debug.AssertFormat(CompareTagsTest3(),
                               "When comparing two Tag classes it did not figure out they both had the same " +
                               "enum value.");
            Debug.Log("If there are no errors all tests passed!");
        }

        bool HasTagTest1()
        {
            List<TagData> first = new List<TagData>();
            first.Add(TagData.Floor);
            first.Add(TagData.Player);
            first.Add(TagData.Interactive);
            first.Add(TagData.Wall);

            return true;
        }

        // Compare two lists that share one value, CompareTags() should
        // return true.
        bool CompareTagsTest1 ()
        {
            List<TagData> first = new List<TagData>();
            List<TagData> second = new List<TagData>();
            
            first.Add(TagData.Floor);
            first.Add(TagData.Player);
            first.Add(TagData.Wall);
            
            second.Add(TagData.Player);
            second.Add(TagData.Wall);
            
            return Tag.CompareTags(first, second);
        }

        // Compare two lists with different values, making CompareTags()
        // return false.
        bool CompareTagsTest2 ()
        {
            List<TagData> first = new List<TagData>();
            List<TagData> second = new List<TagData>();

            first.Add(TagData.Floor);
            first.Add(TagData.Player);
            first.Add(TagData.Wall);

            second.Add(TagData.Interactive);
            second.Add(TagData.Noninteractive);

            return !Tag.CompareTags(first, second);
        }

        // Test against two Tag objects. Creates two tests objects, uses
        // reflection to modify them. Then compares and makes sure it
        // will return true for TagData.Interactive.
        bool CompareTagsTest3 ()
        {
            Tag first = gameObject.AddComponent(typeof(Tag)) as Tag;
            Tag second = gameObject.AddComponent(typeof(Tag)) as Tag;

            List<TagData> firstList = new List<TagData>();
            firstList.Add(TagData.Floor);
            firstList.Add(TagData.Interactive);
            firstList.Add(TagData.Noninteractive);

            List<TagData> secondList = new List<TagData>();
            secondList.Add(TagData.Wall);
            secondList.Add(TagData.Player);
            secondList.Add(TagData.Interactive);

            Type tagType = typeof(Tag);
            FieldInfo getTags = tagType.GetField("tags",
                                                 BindingFlags.NonPublic | BindingFlags.Instance);

            getTags.SetValue(first, firstList);
            getTags.SetValue(second, secondList);

            return first.CompareTags(second);
        }
    }
}
