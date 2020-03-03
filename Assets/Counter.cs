using AwesomeCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text collisionCounter;
    [SerializeField] private float waitTime = 0.1f;
    [SerializeField] private LineChart chart;
    [SerializeField] private int MaxPointsOnChart = 20;

    private float timer = 0.0f;
    private int currentPoint = 0;

    private int collisions;

    private void Start()
    {
        chart.GetChartData().DataSets[0].AddEntry(new LineEntry(0, 0));
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            collisions = Int32.Parse(collisionCounter.text);
            currentPoint++;

            chart.GetChartData().DataSets[0].AddEntry(new LineEntry(currentPoint, collisions));

            if (chart.GetChartData().DataSets[0].GetEntriesCount() > MaxPointsOnChart)
            {
                chart.GetChartData().DataSets[0].RemoveEntry(0);
            }

            chart.SetDirty();

            collisionCounter.text = "0";

            timer -= waitTime;
        }
    }
}