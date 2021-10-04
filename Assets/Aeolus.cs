using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Aeolus : Actor
{
    public GameObject airCut;

    public Sprite idle, attack, damaged;

    protected override void Start()
    {
        base.Start();
        startPosition = transform.position;
    }

    public override void Attack()
    {
        enemies[0].StartCoroutine(enemies[0].GetComponent<Player>().BlockTimingCoroutine(20 + Strength - enemies[0].Armor, type, this, 2f));
        Debug.Log("Air Cutter used against " + enemies[0].name + "!");
        Invoke("AirCutter", 1f);
    }

    private void AirCutter()
    {
        spriteRenderer.sprite = attack;
        GameObject slash = Instantiate(airCut, transform.position - new Vector3(1, 0, 0), Quaternion.identity);
        slash.transform.DOMove(enemies[0].transform.position, 1f).OnComplete(() => {ReturnToNormal(); Destroy(slash);});
    }

    public override bool TakeDamage(float damageAmount, Constants.Type damageType)
    {
        spriteRenderer.sprite = damaged;
        Invoke("ReturnToNormal", 1f);
        return base.TakeDamage(damageAmount, damageType);
    }

    private void ReturnToNormal()
    {
        spriteRenderer.sprite = idle;
    }
}
