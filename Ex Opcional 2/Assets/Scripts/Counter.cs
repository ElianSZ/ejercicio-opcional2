using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private float numberSec = 1f;
    private float countNum = 10f;

    private string message;
    public TextMeshProUGUI counterText;

    void Start()
    {
        // Inicia la cuenta atrás
        StartCoroutine("counter");
    }

    // Cuenta atrás
    private IEnumerator counter()
    {
        while (countNum >= 0)
        {
            message = countNum.ToString();
            counterText.text = message;
            countNum--;
            yield return new WaitForSeconds(numberSec);
        }

        message = "FIN DE LA CUENTA";
        counterText.text = message;
    }
}