using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_S : MonoBehaviour
{
    public GameObject aim, player;
    public Vector3 screenPosition, worlPosition;
    public float smooth;
    public LayerMask groundLayer = 6;
    public LayerMask turretLayer = 7;
    public Vector3 plus;

   
    void Update()
    {
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        //IgnoraObjeto
        if (Physics.Raycast(ray, out RaycastHit hitData, 300, groundLayer) == true)
        {
            worlPosition = hitData.point;
        }
        if (Physics.Raycast(ray, out RaycastHit hit, 300, turretLayer) == true)
        {
            
        }
        
        aim.transform.position = worlPosition + plus;
        player.transform.position = Vector3.Lerp(player.transform.position, aim.transform.position, smooth);

        if (Input.GetMouseButton(0) && hit.collider.gameObject.CompareTag("Turret")==true) {
            GameObject turret;
            turret = hit.collider.gameObject;
            turret.transform.position = aim.transform.position;
        }
        else {
            return;
        }
    }
}
