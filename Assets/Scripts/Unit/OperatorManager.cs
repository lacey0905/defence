using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorManager : MonoBehaviour
{

    private GameManager manager;

    // Stat Data
    public float delay;
    public float damage;

    public void Setup(GameManager _manager, int c_id, float _delay, float _damage)
    {
        manager = _manager;
        delay = _delay;
        damage = _damage;

        GameObject sprite = Resources.Load<GameObject>("c_" + c_id);
        sprite = Instantiate(sprite, transform.position, Quaternion.identity);
        sprite.transform.parent = this.transform;

    }
}
