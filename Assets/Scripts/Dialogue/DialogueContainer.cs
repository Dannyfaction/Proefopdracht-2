using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("DialogueCollection")]
public class DialogueContainer
{
    [XmlArray("Dialogues")]
    [XmlArrayItem("Dialogue")]
    public List<Dialogue> dialogues = new List<Dialogue>();

    public static DialogueContainer Load(string path)
    {
        //Loads from Path
        TextAsset _xml = Resources.Load<TextAsset>(path);
        //Serialize
        XmlSerializer serializer = new XmlSerializer(typeof(DialogueContainer));
        //Reads
        StringReader reader = new StringReader(_xml.text);
        //Deserialze
        DialogueContainer dialogues = serializer.Deserialize(reader) as DialogueContainer;
        //Closes
        reader.Close();
        //Returns the Dialogue
        return dialogues;
    }
}