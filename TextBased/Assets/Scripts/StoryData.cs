using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StoryFragment
{
    string StoryLine;
    List<string> option;
}

[System.Serializable]
public class StoryData {

    public List<StoryFragment> storyBits;

}
