using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class StatisticsElementUI : MonoBehaviour
{
    public StatisticsNames statisticsName;
    public TMP_Text text;

    [Inject]
    Statistics statistics;

    void Start()
    {
        text.text = statistics.GetStatisticsValueByName(statisticsName).ToString();
    }
}
