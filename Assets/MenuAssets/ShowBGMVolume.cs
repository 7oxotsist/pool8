using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowBGMVolume : MonoBehaviour
{
    public TMP_Text BGMVolumeValue;
    public Scrollbar bar;
    void Update()
    {
        BGMVolumeValue = GetComponent<TMP_Text>();
        BGMVolumeValue.text = (GetBGMVolumeValue(bar)*100).ToString("0.##\\%");
    }

    float GetBGMVolumeValue (Scrollbar bar)
    {
        return bar.value;
    }
}
