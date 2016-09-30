using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Dialogue {

    //Gets all the information from the XML file and puts it in Variables

    [XmlAttribute("id")]
    public float id;

    [XmlElement("Source")]
    public string source;

    [XmlElement("Text")]
    public string text;

    [XmlElement("Option1")]
    public string option1;

    [XmlElement("Option2")]
    public string option2;
}