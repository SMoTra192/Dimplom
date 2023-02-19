#nullable enable
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Utils;


public class UIDamage : MonoBehaviour
{
    [SerializeField] private Image damagePanel = null!;
    [SerializeField] private EnemyGiveDamage _enemyGiveDamage = null!;
    private void Awake()
    {
        _enemyGiveDamage.EnsureNotNull().GetComponent<EnemyGiveDamage>();
        _enemyGiveDamage.giveDamage.AddListener(() => StartCoroutine(DamagePanel()));
    }

    private IEnumerator DamagePanel()
    {
        damagePanel.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        damagePanel.gameObject.SetActive(false);
    }
    
}
