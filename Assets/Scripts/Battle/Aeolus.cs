using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using DG.Tweening;

public class Aeolus : Actor
{
    public GameObject airCut;

    public Sprite idle, attack, damaged;

    protected override void Start()
    {
        base.Start();
        transform.position += new Vector3(1, 2, 0);
        startPosition = transform.position;
    }

    public override void Attack()
    {
        enemies[0].StartCoroutine(enemies[0].GetComponent<Player>().BlockTimingCoroutine(20 + Strength - enemies[0].Armor, type, this, 1.75f));
        Debug.Log("Air Cutter used against " + enemies[0].name + "!");
        Invoke("AirCutter", 1f);
    }

    private void AirCutter()
    {
        spriteRenderer.sprite = attack;
        GameObject slash = Instantiate(airCut, transform.position, Quaternion.identity);
        slash.transform.DOMove(enemies[0].transform.position + new Vector3(3, 0, 0), 0.75f).SetEase(Ease.Linear).OnComplete(() => {ReturnToNormal(); Destroy(slash);});
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
