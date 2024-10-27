using System.Collections;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    public TowerTargetting towerTargetting;
    public float Damage;
    public float Firerate;
    private float Delay;
    private Coroutine attackCoroutine;
    
    public int Price = 250;

    void Start()
    {
        Delay = 1 / Firerate;
    }

    public void StartAttacking()
    {
        if (towerTargetting.target != null && attackCoroutine == null)
        {
            attackCoroutine = StartCoroutine(AttackTarget());
        }
    }

    private IEnumerator AttackTarget()
    {
        while (towerTargetting.target != null && Vector3.Distance(transform.position, towerTargetting.target.position) <= towerTargetting.range)
        {
            EnemyStat enemyStat = towerTargetting.target.GetComponent<EnemyStat>();
            if (enemyStat != null)
            {
                enemyStat.TakeDamage(Damage);
            }
            yield return new WaitForSeconds(Delay);
        }

        StopAttacking();
    }

    public void StopAttacking()
    {
        if (attackCoroutine != null)
        {
            StopCoroutine(attackCoroutine);
            attackCoroutine = null;
        }
    }
}
