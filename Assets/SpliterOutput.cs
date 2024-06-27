using System.IO;
using UnityEngine;
using TMPro;


public class SpliterOutput : MonoBehaviour
{
    public TMP_Text outputprint;

    public void ReadTextFile()
    {
        string filePath = "Assets/helloworld/outputs/Output.txt"; 

        if (File.Exists(filePath))
        {
           
            string fileContent = File.ReadAllText(filePath);


            int startIndex = fileContent.IndexOf("{");
            int endIndex = fileContent.LastIndexOf("}") + 1;

            string json = fileContent.Substring(startIndex, endIndex - startIndex);

            outputprint.text = json;
            File.Delete(filePath);

            this.gameObject.GetComponent<LeoToVisual>().StartVisual();

        }
        else
        {
            Debug.LogError("No File: " + filePath);
        }
    }

  
}
