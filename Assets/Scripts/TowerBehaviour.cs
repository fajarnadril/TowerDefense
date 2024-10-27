using System.Collections;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    public TowerTargetting towerTargetting; // Reference to TowerTargetting script
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
            // Deal damage to the current target
            EnemyStat enemyStat = towerTargetting.target.GetComponent<EnemyStat>();
            if (enemyStat != null)
            {
                enemyStat.TakeDamage(Damage);
            }

            // Wait for the delay time before attacking again
            yield return new WaitForSeconds(Delay);
        }

        // Stop attacking if the target goes out of range or is destroyed
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
