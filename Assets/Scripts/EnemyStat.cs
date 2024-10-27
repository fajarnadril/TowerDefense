using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStat : MonoBehaviour
{
    public float MaxHealth;
    public float Health;
    public int ID;

    public GameObject otherGameObject;
    public GameObject GO;
    public Economy Econ;

    public WaveSpawner WS;

    public Image variable;

    void Start(){
        otherGameObject = GameObject.Find("MoveCamera");
        Econ = otherGameObject.GetComponent<Economy>();

        GO = GameObject.Find("EnemySumoner");
        WS = GO.GetComponent<WaveSpawner>();

    }

    public void Init(){
        Health = MaxHealth;
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;
        variable.fillAmount = Health/MaxHealth;
        if (Health <= 0)
        {
            Die();
            Econ.Money = Econ.Money + 100;
            WS.MonsterCount = WS.MonsterCount - 1;
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
