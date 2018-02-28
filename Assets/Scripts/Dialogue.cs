using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue : MonoBehaviour
{
    public Text text;
    public List<DialogueText> lists = new List<DialogueText>();

    float currentTime;
    int currentListPosition;

    void Start()
    {
        currentTime = 0;
        currentListPosition = 0;
        text.text = lists[0].words;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the current time is greater than the current text's length
        // if it is, you need to increase the position in the list, change the text, and reset the currentTime variable
        if (currentTime > lists[currentListPosition].timeLength)
        {
            if (currentListPosition < lists.Count - 1)
            {
                currentListPosition++;
                text.text = lists[currentListPosition].words;
                currentTime = 0; 
            }
            else
            {
                currentListPosition = 0;
                text.text = lists[currentListPosition].words;
                currentTime = 0;
            }
        }

        currentTime += Time.deltaTime;
    }
}

[System.Serializable]
public class DialogueText
{
    [TextArea]
    public string words;
    public float timeLength;
}
