using UnityEngine;
using System.Collections;

public class CloseDialogue : MonoBehaviour {

    [SerializeField]
    private GameObject canvas;

    //Adds event when the dialogue ends
	void Start () {
        DialogueProgression.OnEndOfDialogueEvent += Destroy;
	}

    //Destroys the canvas
    void Destroy()
    {
        GameObject.Destroy(canvas);
    }
}
