using UnityEngine;
using TMPro;

public class IkinciSahneYaziAyarlayici : MonoBehaviour
{
    public TextMeshProUGUI ikinciSahneYazi1;
    public TextMeshProUGUI ikinciSahneYazi2;

    void Start()
    {
        // Birinci sahneden kaydedilen metinleri al
        string birinciSahneYazi1Metni = PlayerPrefs.GetString("Altın", "");
        string birinciSahneYazi2Metni = PlayerPrefs.GetString("Yemek", "");

        // İkinci sahnede bulunan metinleri ayarla
        ikinciSahneYazi1.text = birinciSahneYazi1Metni;
        ikinciSahneYazi2.text = birinciSahneYazi2Metni;
    }
}
