using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsSetting : MonoBehaviour
{
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
