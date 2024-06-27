using UnityEngine;

public class UpdateLeoVariables : MonoBehaviour
{
    public int index;
    public string value;

    public void GetIndex(int VariablesIndex)
    {
        index = VariablesIndex;

    }

    public void GetValue(string VariablesValue)
    {
        value = VariablesValue;
        ChangeVeriables(index,value);
    }

    void ChangeVeriables(int VariablesIndex, string NewValue) 
    {
        GameObject obj = GameObject.Find("EventSystem");

        obj.GetComponent<LeoVariablesManager>().varibalesValue[VariablesIndex] = NewValue;
        obj.GetComponent<CompetitorManager>().ControllerCompetitor();
    }
}
