using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using UnityEngine.UI;
using System.Xml.Serialization;

// https://www.youtube.com/watch?v=rTgjFnTvDUc
public class loadXMLFile : MonoBehaviour
{
    public SaveData data = new SaveData();


    [SerializeField]
    private TextAsset xmlRawFile;

    public Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        string data = xmlRawFile.text;
        ParseXmlFile(data);
    }

    void ParseXmlFile(string xmlData)
    {
        string totVal = "";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(new StringReader(xmlData));

        string xmlPathPattern = "//GameSystem/Score";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);
        foreach(XmlNode node in myNodeList)
        {
            XmlNode score = node.FirstChild;

            totVal += "HighScore : \n" + score.InnerXml;
            uiText.text = totVal;
        }
    }

    public void StoreData(string xmlData)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(new StringReader(xmlData));
        
        string xmlPathPattern = "//GameSystem/Score";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);
        foreach (XmlNode node in myNodeList)
        {
            XmlNode score = node.FirstChild;
            score.InnerXml = GameManager.Instance.HighScore.ToString();
        }
        xmlDoc.Save(xmlData);
    }

    private void Update()
    {

    }

}
public class SaveData
{
    [XmlAttribute("Score")]
    public int score;
}