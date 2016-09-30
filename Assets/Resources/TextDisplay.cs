using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour {

    [SerializeField]
    private Text text;
    [SerializeField]
    private DialogueLoader dialogueLoader;
    [SerializeField]
    private Text options1Text;
    [SerializeField]
    private Text options2Text;

    void Start () {
        dialogueLoader.GetComponent<DialogueLoader>();
	}

    //Refreshes all the texts in the UI
    public void RefreshTexts(float i)
    {
        text.text = dialogueLoader.TextsGetter()[(int)i];
        options1Text.text = dialogueLoader.Options1Getter()[(int)i];
        options2Text.text = dialogueLoader.Options2Getter()[(int)i];
    }
}
