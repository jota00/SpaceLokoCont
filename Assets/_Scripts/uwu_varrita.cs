using UnityEngine;
using System.Collections;

public class uwu_varrita : MonoBehaviour {
    ControlNave bida;
    public float vida;
	void Start () {
        bida = GameObject.Find("Nave").GetComponent<ControlNave>();
        vida = bida.hp;
	}
	
	void Update () {
        if (bida.hp < 0)
        {
            transform.localScale = new Vector3(0, 0.8846154f, 1);
        }
        else
        {
            vida = bida.hp;
            transform.localScale = new Vector3(((bida.hp / bida.maxHp) * 0.9871244f), 0.8846154f, 1);
        }
	}
}
