using UnityEngine;
using System;

public class RuletaController : MonoBehaviour
{
    [SerializeField] private RuletaData ruletaData;
    [SerializeField] private float spinDuration = 2f;
    
    public Action<RuletaData.RuletaSegment> OnResultSelected;

    private bool isSpinning = false;

    public void Spin()
    {
        if (isSpinning) return;
        isSpinning = true;
        
        StartCoroutine(SpinRoutine());
    }

    private System.Collections.IEnumerator SpinRoutine()
    {
        float elapsed = 0f;
        while (elapsed < spinDuration)
        {
            //rotación visual
            elapsed += Time.deltaTime;
            yield return null;
        }

        RuletaData.RuletaSegment result = GetRandomSegment();

        OnResultSelected?.Invoke(result);

        isSpinning = false;
    }

    private RuletaData.RuletaSegment GetRandomSegment()
    {
        int randomIndex = UnityEngine.Random.Range(0, ruletaData.segmentos.Length);
        return ruletaData.segmentos[randomIndex];
    }
}