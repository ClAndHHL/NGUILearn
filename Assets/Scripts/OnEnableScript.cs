using UnityEngine;
using System.Collections;

public class OnEnableScript : MonoBehaviour
{
    private bool isEnable = false;
    public void OnEnable() {
        //bool tt = !gameObject.activeInHierarchy;
        //isEnable = !isEnable;
        gameObject.SetActive(true);
         print(gameObject.activeInHierarchy);
    }
}
