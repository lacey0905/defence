using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [System.Serializable]
    public class Stat
    {
        public float health, speed, delay;
    }
    public Stat stat;

    private GameManager manager;
    private float currentDelay = 0f;

    public void Setup(GameManager _mamager)
    {
        manager = _mamager;
    }

    private void Update()
    {

        //if (transform.position.y > -0.7f)
        //{
        //    currentDelay = 0f;
        //    //transform.position = (Vector2)transform.position - Vector2.up * speed * Time.deltaTime * GameManager.instance.time;
        //}
        //else
        //{
        //    if(delay <= currentDelay)
        //    {
        //        currentDelay = 0f;
        //        //GameManager.instance.Damage(2f);
        //    }
        //    else
        //    {
        //        //currentDelay += Time.deltaTime * GameManager.instance.time;
        //    }

        //}
    }

    //public void Damage(float damage)
    //{
    //    hp -= damage;
    //    if(hp <= 0f)
    //    {
    //        Die();
    //    }
    //}

    //public void Die()
    //{
    //    Destroy(this.gameObject);
    //    GameManager.instance.mapMonster.Remove(this);
    //}
}
