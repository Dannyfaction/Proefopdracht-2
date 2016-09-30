using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueLoader : MonoBehaviour {

    //Event after this script has been loaded
    public delegate void LoadEvent();
    public static event LoadEvent OnLoadEvent;

    //The file in the resource folder
    public const string path = "Dialogues";

    //Lists with all Dialogue information
    private List<float> ids = new List<float>();
    private List<string> sources = new List<string>();
    private List<string> texts = new List<string>();
    private List<string> options1 = new List<string>();
    private List<string> options2 = new List<string>();

    void Start ()
    {
        DialogueContainer dc = DialogueContainer.Load(path);

        //Puts all the information from the XML file in lists
        foreach (Dialogue dialogue in dc.dialogues)
        {
            ids.Add(dialogue.id);
            sources.Add(dialogue.source);
            texts.Add(dialogue.text);
            options1.Add(dialogue.option1);
            options2.Add(dialogue.option2);
        }
        //Debug.Log(options1[2]);
        OnLoadEvent();
	}

    //Getters
    public List<float> IdsGetter()
    {
        return ids;
    }
    public List<string> SourcesGetter()
    {
        return sources;
    }
    public List<string> TextsGetter()
    {
        return texts;
    }
    public List<string> Options1Getter()
    {
        return options1;
    }
    public List<string> Options2Getter()
    {
        return options2;
    }
}