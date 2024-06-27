using System.Collections.Generic;
using UnityEngine;

public class CompetitorManager : MonoBehaviour
{
    public void ControllerCompetitor()
    {

        GameObject obj = GameObject.Find("EventSystem");
        
        List<int> emptyIndices = new List<int>();
        for (int i = 0; i < obj.GetComponent<LeoVariablesManager>().varibalesValue.Length; i++)
        {
            if (obj.GetComponent<LeoVariablesManager>().varibalesValue[i] == "0u8")
            {
                emptyIndices.Add(i);
            }
        }

        if (emptyIndices.Count > 0)
        {
            int randomIndex = emptyIndices[UnityEngine.Random.Range(0, emptyIndices.Count)];

            ChangeVeriables(randomIndex, "2u8");
        }


        obj.GetComponent<LeoVariablesManager>().RefreshVariables();
    }

   

    void ChangeVeriables(int VariablesIndex, string NewValue)
    {
        GameObject obj = GameObject.Find("EventSystem");

        obj.GetComponent<LeoVariablesManager>().varibalesValue[VariablesIndex] = NewValue;
       
    }
}
