#nullable enable
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils;

public class UIDamage : MonoBehaviour
{
    [SerializeField] private Image damagePanel;
    [SerializeField] private PlayerHealth _playerHealth;
    private void Awake()
    {
        _playerHealth.GetComponent<PlayerHealth>().EnsureNotNull("There is no component");
        _playerHealth.damaged.AddListener(() => StartCoroutine(DamagePanel()));
    }

    private IEnumerator DamagePanel()
    {
        damagePanel.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        damagePanel.gameObject.SetActive(false);
    }
}
