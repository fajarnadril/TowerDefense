using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    [SerializeField] private LayerMask CheckMask;
    [SerializeField] private LayerMask PlacementCollideMask;
    [SerializeField] private Camera PlayerCamera;
    private GameObject CurrentPlacingTower;

    public bool CannotBuy = false;

    public Economy Econ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentPlacingTower != null){
            Ray camray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit HitInfo;
            if(Physics.Raycast(camray, out HitInfo, 1000f, PlacementCollideMask)){
                CurrentPlacingTower.transform.position = HitInfo.point;
            }

            if(Input.GetKeyDown(KeyCode.Q)){
                Destroy(CurrentPlacingTower);
                CurrentPlacingTower = null;
                Econ.Money = Econ.NewPrice + Econ.Money;
                return;
            }

            if(Input.GetMouseButtonDown(0) && HitInfo.collider.gameObject != null){
                if(!HitInfo.collider.gameObject.CompareTag("CantPlace")){
                    BoxCollider TowerCollider = CurrentPlacingTower.gameObject.GetComponent<BoxCollider>();
                    CurrentPlacingTower.layer = LayerMask.NameToLayer("TowerPlaced");
                    TowerCollider.isTrigger = true;

                    Vector3 BoxCenter = CurrentPlacingTower.gameObject.transform.position + TowerCollider.center;
                    Vector3 HalfExtents = TowerCollider.size/2;
                    if(Physics.CheckBox(BoxCenter, HalfExtents*4, Quaternion.identity,CheckMask, QueryTriggerInteraction.Ignore)){
                        TowerCollider.isTrigger = false;
                        CurrentPlacingTower = null;
                    }
                }
            }
        }
    }

    public void SetTowerToPlace(GameObject tower){
        CurrentPlacingTower = Instantiate(tower, Vector3.zero, Quaternion.identity);
    }
}
