using System.IO;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class LeoVariablesManager : MonoBehaviour
{
    public string TransitionName;
    public bool isPublic = true;
    public string[] varibalesName;
    public string[] varibalesType;
    public string[] varibalesValue;

    string inputScript;

    private void Start()
    {
        SaveVariables();
    }

    public void SaveVariables()
    {
        inputScript = "[" + TransitionName + "]";

        if (isPublic)
        {
            inputScript += "public ";
        }
        else
        {
            inputScript += "private ";
        }

        for (int i = 0; i < varibalesName.Length; i++)
        {
            inputScript += varibalesName[i] + ":" + varibalesType[i] + "=" + varibalesValue[i] + ";";
        }

        string path = "Assets/helloworld/inputs/helloworld.txt";
        File.WriteAllText(path, inputScript);

#if UNITY_EDITOR
        AssetDatabase.Refresh();
#endif

        ChangeFileExtension(path, ".in");
    }

    void ChangeFileExtension(string FilePath, string NewExtension)
    {
        if (File.Exists(FilePath))
        {
            try
            {
                string NewFilePath = Path.ChangeExtension(FilePath, NewExtension);

                if (File.Exists(NewFilePath))
                {
                    File.Delete(NewFilePath);
                }

                File.Move(FilePath, NewFilePath);

                Debug.Log("Changed File Extension: " + NewFilePath);

            }
            catch (System.Exception e)
            {
                Debug.LogError("Error: " + e.Message);
            }
        }
        else
        {
            Debug.LogError("No File: " + FilePath);
        }
    }

    public void RefreshVariables()
    {
        inputScript = "[" + TransitionName + "]";

        if (isPublic)
        {
            inputScript += "public ";
        }
        else
        {
            inputScript += "private ";
        }

        for (int i = 0; i < varibalesName.Length; i++)
        {
            inputScript += varibalesName[i] + ":" + varibalesType[i] + "=" + varibalesValue[i] + ";";
        }

        string path = "Assets/helloworld/inputs/helloworld.txt";
        File.WriteAllText(path, inputScript);

#if UNITY_EDITOR
        AssetDatabase.Refresh();
#endif

        ChangeFileExtensionGoStarter(path, ".in");
    }

    void ChangeFileExtensionGoStarter(string FilePath, string NewExtension)
    {
        if (File.Exists(FilePath))
        {
            try
            {
                string NewFilePath = Path.ChangeExtension(FilePath, NewExtension);

                if (File.Exists(NewFilePath))
                {
                    File.Delete(NewFilePath);
                }

                File.Move(FilePath, NewFilePath);

                Debug.Log("Changed File Extension: " + NewFilePath);
                this.gameObject.GetComponent<AleoUnitySDKManager>().StarterButton();
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error: " + e.Message);
            }
        }
        else
        {
            Debug.LogError("No File: " + FilePath);
        }
    }
}
