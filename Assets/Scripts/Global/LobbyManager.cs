using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[System.Serializable]
public class ChrStat
{
    public ChrStat(int _idx, float _atk, float _delay)
    {
        idx = _idx;
        atk = _atk;
        delay = _delay;
    }
    public int idx;
    public float atk, delay;
}

public class LobbyManager : MonoBehaviour
{
    public List<ChrStat> unitList = new List<ChrStat>();

    public List<ChrStat> loadInfo;

    private void Start()
    {
        unitList.Add(new ChrStat(0, 10f, 1f));
        string jData = JsonConvert.SerializeObject(unitList);
        PlayerPrefs.SetString("unitInfo", jData);
        

    }

    public void save()
    {
        string jData = JsonConvert.SerializeObject(unitList);
        PlayerPrefs.SetString("unitInfo", jData);
        loadInfo = JsonConvert.DeserializeObject<List<ChrStat>>(PlayerPrefs.GetString("unitInfo"));

    }


}
