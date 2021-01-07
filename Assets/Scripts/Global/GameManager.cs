using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


public class GlobalInfo {
    public GlobalInfo(int _level, int _mapId)
    {

    }
}

public class GlobalStat
{
    public GlobalStat(float _health, float _shield)
    {
        health = _health;
        shield = _shield;
    }
    public float health, shield;
}

public class GameManager : MonoBehaviour
{

    private List<EnemyManager> GlobalEnemyList;

    private GlobalStat Stat;

    public List<Vector2> unitSpawnPos = new List<Vector2>();

    private void Start()
    {
        //Stat = new GlobalStat(1000f, 100f);

        //StageSpawn();
        SpawnUnit();
    }

    private void Update()
    {
        //if(GlobalEnemyList.Count <= 0)
        //{
        //    // 승리
        //}
    }

    public void GlobalDamage(float damage)
    {
        Stat.health -= damage;
    }

    private void SpawnUnit()
    {
        int length = 4;

        for(int i=0; i<length; i++)
        {
            GameObject unit = new GameObject("unit_" + i);
            unit.AddComponent<UnitManager>().Setup(this, i, 1f, 10f);
            unit.transform.position = unitSpawnPos[i];
        }

        //public List<ChrStat> loadInfo;
        //loadInfo = JsonConvert.DeserializeObject<List<ChrStat>>(PlayerPrefs.GetString("unitInfo"));

        //for(int i=0; i<loadInfo.Count; i++)
        //{
        //    CharacterController c = Instantiate(character, transform.position, Quaternion.identity);
        //    c.Setup(loadInfo[i].idx, loadInfo[i].atk, loadInfo[i].delay, 0f);
        //}
    }

    private void SpawnEnemy()
    {
        //int stage = PlayerPrefs.GetInt("stage");
        //GameObject map = Resources.Load<GameObject>("LV" + stage);
        //Instantiate(map, transform.position, Quaternion.identity);
    }

}



/*
 
글로벌 방어력
글로벌 체력

캐릭터들 스텟
공격력, 공속 

스킬 슬롯1~4 : id, lv
 
*/