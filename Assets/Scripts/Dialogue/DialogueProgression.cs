using UnityEngine;
using System.Collections;

public class DialogueProgression : MonoBehaviour {

    //End of Dialogue Event
    public delegate void EndOfDialogueEvent();
    public static event EndOfDialogueEvent OnEndOfDialogueEvent;

    [SerializeField]
    private TextDisplay textDisplay;

    //Current Dialogue #
    private float currentProgress = 0;

    //Sets the text at start after the DialogueLoader has been loaded
	void Awake () {
        DialogueLoader.OnLoadEvent += RefreshTexts;
    }

    //Refreshes the UI after the buttons get clicked on
    void RefreshTexts()
    {
        textDisplay.RefreshTexts(currentProgress);
    }

    //Changes the dialogues when buttons get clicked
    public void SetFloat(float optionNumber)
    {
        switch ((int)currentProgress)
        {
            case 0:
                if (optionNumber == 1)
                {
                    currentProgress = 1;
                }else
                {
                    currentProgress = 2;
                }
                break;
            case 1:
                if (optionNumber == 1)
                {
                    currentProgress = 3;
                }
                else
                {
                    currentProgress = 4;
                }
                break;
            case 2:
                if (optionNumber == 1)
                {
                    currentProgress = 5;
                }
                else
                {
                    currentProgress = 6;
                }
                break;
            default:
                OnEndOfDialogueEvent();
                break;
        }
        RefreshTexts();
    }
}
