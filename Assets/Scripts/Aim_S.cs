using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_S : MonoBehaviour
{
    public GameObject aim, player;
    public Vector3 screenPosition, worlPosition;
    public float smooth;
    public LayerMask layerToHit;
    public LayerMask layerObj;

    private void Start()
    {
        layerToHit = 3;
    }
    void Update()
    {
        screenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        //IgnoraObjeto
        if (Physics.Raycast(ray, out RaycastHit hitData,300,6))
        {
            
        }
        //Hita o Chao
        if (Physics.Raycast(ray, out RaycastHit hit, 300, 3))
        {
            worlPosition = hitData.point;
        }

        aim.transform.position = worlPosition;
        player.transform.position = Vector3.Lerp(player.transform.position, aim.transform.position, smooth);

        if (Input.GetMouseButton(0))
        {
            //hit.collider.gameObject.transform.position = aim.transform.position;
            Debug.Log(hitData.collider.gameObject.name + " ground");
            Debug.Log(hit.collider.gameObject.name + " object");
        }
    }
}
