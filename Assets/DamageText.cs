using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class DamageText : MonoBehaviour
{
    public TextMeshPro textMesh;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(transform.position.y + 1, 1f);
        textMesh.DOFade(0f, 1f).OnComplete(() => Destroy(this.gameObject));
    }
}
