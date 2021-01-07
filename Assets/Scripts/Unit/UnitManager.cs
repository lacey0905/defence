using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{

    private float atkRange = 7f;
    private float currentDist = 0f;
    private float targetDist = 100f;
    private int targetIndex = -1;
    private float currentDelay = 0f;

    private GameManager manager;

    // Stat Data
    public int id;
    public float delay;
    public float damage;

    public void Setup(GameManager _manager, int _id, float _delay, float _damage)
    {
        manager = _manager;
        id = _id;
        delay = _delay;
        damage = _damage;
    }

    //public List<MonsterController> GetGlobalMonsterList()
    //{
    //    //return manager.mapMonster;
    //}

    void Update()
    {

        //    // 거리 검사 인수
        //    currentDist = 0f;
        //    targetIndex = -1;

        //    // 몹 전체 탐색
        //    for (int i = 0; i < GetGlobalMonsterList().Count; i++)
        //    {
        //        // 거리 계산
        //        currentDist = Vector2.Distance(transform.position, GetGlobalMonsterList()[i].transform.position);

        //        // 일정 거리 들어온 몹
        //        if (currentDist <= atkRange)
        //        {
        //            // 제일 가까운 몹 찾기
        //            if (targetDist >= currentDist)
        //            {
        //                targetIndex = i;
        //                targetDist = currentDist;
        //            }
        //        }
        //    }

        //    // 검사 된 몹이 1개라도 있으면
        //    if (targetIndex != -1)
        //    {
        //        if (delay >= currentDelay)
        //        {
        //            currentDelay += Time.deltaTime;
        //        }
        //        else
        //        {
        //            currentDelay = 0f;
        //            Vector2 dir = GetGlobalMonsterList()[targetIndex].transform.position - transform.position;
        //            transform.up = dir;
        //            //Missile m = Instantiate(mi, transform.position, Quaternion.identity);
        //            //m.Shooting(dir, atkDamage);
        //        }
        //    }
        //    targetDist = 100f;
        //}
    }
}
