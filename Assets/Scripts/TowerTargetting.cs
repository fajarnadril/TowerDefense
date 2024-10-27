using UnityEngine;

public class TowerTargetting : MonoBehaviour
{
    public float range = 10f;
    public Transform target; // Set as public to allow access from TowerBehaviour
    public TowerBehaviour TB;

    void Update()
    {
        FindClosestEnemyToLastWaypoint();

        if (target != null)
        {
            // Rotate tower to face the target
            Vector3 dir = (target.position - transform.position).normalized;
            dir.y = 0;
            transform.rotation = Quaternion.LookRotation(dir, Vector3.up);

            // Start attacking if there is a target
            TB.StartAttacking();
        }
        else
        {
            TB.StopAttacking();
        }
    }

    void FindClosestEnemyToLastWaypoint()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Transform lastWaypoint = Waypoints.points[Waypoints.points.Length - 1];

        float shortestDistance = Mathf.Infinity;
        GameObject closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToLastWaypoint = Vector3.Distance(enemy.transform.position, lastWaypoint.position);

            if (distanceToLastWaypoint < shortestDistance && Vector3.Distance(transform.position, enemy.transform.position) <= range)
            {
                shortestDistance = distanceToLastWaypoint;
                closestEnemy = enemy;
            }
        }

        if (closestEnemy != null)
        {
            target = closestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
