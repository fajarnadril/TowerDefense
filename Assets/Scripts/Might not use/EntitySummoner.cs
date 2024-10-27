using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySummoner : MonoBehaviour
{
    //public static List<Enemy> EnemiesInGame;
    //public static Dictionary<int, GameObject> EnemyPrefabs;
    //public static Dictionary<int, Queue<Enemy>> EnemyObjectPools;
    //private static bool IsInitialized;

    //public static void Init(){
        //if(!IsInitialized){
            //EnemyPrefabs = new Dictionary<int, GameObject>();
            //EnemyObjectPools = new Dictionary<int, Queue<Enemy>>();
            //EnemiesInGame = new List<Enemy>();

            //EnemySummonData[] Enemies = Resources.LoadAll<EnemySummonData>("Enemies");

            //foreach (EnemySummonData enemy in Enemies){
                //EnemyPrefabs.Add(Enemy.EnemyID, enemy.EnemyPrefabs);
                //EnemyObjectPools.Add(enemy.EnemyID, new Queue<Enemy>());
            //}
            //IsInitialized = true;
        //}else{
            //Debug.Log("ES: alr initialized");
        //}
    //}

    //public static Enemy SummonEnemy(int EnemyID){
        //Enemy SummonedEnemy = null;

        //if(EnemyPrefabs.ContainsKey(EnemyID)){
            //Queue<Enemy> ReferencedQueue = EnemyObjectPools[EnemyID];
            //if(ReferencedQueue.Count > 0){
                //SummonedEnemy = ReferencedQueue.Dequeue();
                //SummonedEnemy.Init();
            //}else{
                //GameObject NewEnemy = Instantiate(EnemyPrefabs[EnemyID], Vector3.zero, Quaternion.identity);
                //SummonedEnemy = NewEnemy.GetComponent<Enemy>();
                //SummonedEnemy.Init();
            //}
        //}else{
            //Debug.Log($"ES: enemy with ID of {EnemyID} doesnt exist");
            //return null;
        //}
        //return SummonedEnemy;
    //}
}
