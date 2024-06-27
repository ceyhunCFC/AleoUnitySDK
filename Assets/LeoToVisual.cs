using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeoToVisual : MonoBehaviour
{
    public static string[] varibalesValue;
    public void StartVisual()
    {
        GameObject obj = GameObject.Find("EventSystem");
        varibalesValue = obj.GetComponent<LeoVariablesManager>().varibalesValue;
        PreparingVisual();
    }



    public GameObject[] Boxes;
    public GameObject[] Elements;

    List<int> usedindex = new List<int>();

    public void PreparingVisual()
    {
        for (int i = 0; i < varibalesValue.Length; i++)
        {
            if (varibalesValue[i]=="1u8")
            {
                if(!usedindex.Contains(i))
                {
                    Instantiate(Elements[0], new Vector3(Boxes[i].transform.position.x,Boxes[i].transform.position.y+5,Boxes[i].transform.position.z) , Quaternion.identity);
                    GameObject vfx = Instantiate(Elements[2], new Vector3(Boxes[i].transform.position.x,Boxes[i].transform.position.y,Boxes[i].transform.position.z) , Quaternion.identity);
                    vfx.transform.eulerAngles = new Vector3(-90,0,0);
                    usedindex.Add(i);
                }
                
                
            }
            else if (varibalesValue[i] == "2u8")
            {
                if(!usedindex.Contains(i))
                {
                   StartCoroutine(CreateO(i));
                    usedindex.Add(i);
                    
                }
            }
           
        }
    }

    IEnumerator CreateO(int i)
    {

        yield return new WaitForSeconds(1);

        Instantiate(Elements[1], new Vector3(Boxes[i].transform.position.x,Boxes[i].transform.position.y+5,Boxes[i].transform.position.z) , Quaternion.identity);
        GameObject vfx = Instantiate(Elements[2], new Vector3(Boxes[i].transform.position.x,Boxes[i].transform.position.y,Boxes[i].transform.position.z) , Quaternion.identity);
        vfx.transform.eulerAngles = new Vector3(-90,0,0);
    }
    
}
