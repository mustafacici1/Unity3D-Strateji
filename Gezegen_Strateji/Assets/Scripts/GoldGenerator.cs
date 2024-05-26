using UnityEngine;
using System.Collections;
using TMPro;

public class GoldGenerator : MonoBehaviour
{
    public TextMeshProUGUI goldText; // Canvas içindeki altın metninin referansı
    public int goldToAdd = 20; // Her artışta eklenecek altın miktarı
    public float interval = 10f; // Altın artışının tekrarlanma aralığı (saniye)

    private void Start()
    {
        StartCoroutine(GenerateGold());
    }

    IEnumerator GenerateGold()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);

            // Altın miktarını artır
            int currentGold;
            if (!int.TryParse(goldText.text.Split(':')[1].Trim(), out currentGold))
            {
                Debug.LogError("Gold text format is incorrect!");
                yield break;
            }

            currentGold += goldToAdd;
            goldText.text = "Altın Miktarı: " + currentGold.ToString();

            // PlayerPrefs ile veriyi sakla
            PlayerPrefs.SetInt("Altın Miktarı", currentGold);
        }
    }
}
