using System.Diagnostics;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class AleoUnitySDKManager : MonoBehaviour
{
    public void StarterButton()
    {
        Process.Start("Assets\\helloworld\\Start.bat");
        Invoke("OutputDetector", 1f);
    }

    public void OutputDetector()
    {
        string assetPath = "Assets/helloworld/outputs/Output.txt"; 

#if UNITY_EDITOR
        if (AssetDatabase.LoadAssetAtPath(assetPath, typeof(UnityEngine.Object)))
        {
            Invoke("CallSpilter", 1f);
            print("Dosya mevcut.");
        }
        else
        {
            print("Dosya mevcut değil.");
            Invoke("OutputDetector", 1f);
        }
#else
        if (System.IO.File.Exists(assetPath))
        {
            Invoke("CallSpilter", 1f);
            print("Dosya mevcut.");
        }
        else
        {
            print("Dosya mevcut değil.");
            Invoke("OutputDetector", 1f);
        }
#endif
    }

    void CallSpilter()
    {
        this.gameObject.GetComponent<SpliterOutput>().ReadTextFile();
    }
}
