using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject[] terraPrefab;
    public GameObject coinPrefab;
    public AnimationCurve[] coinLine;

    int coinCount;
    float coinY;
    int coinLineIndex;

    float count = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobaleData.isGameover) return;
        count += Time.deltaTime;
        if (count > 2)
        {
            count = 0;
            GameObject obj = ObjectPool.Instance.getGameObject(terraPrefab[Random.Range(0,terraPrefab.Length)]);
            obj.SetActive(true);
            obj.transform.position = new Vector3(8, Random.Range(0, 3) / 2.0f, 0);
            obj.transform.SetParent(transform, true);

            if (Random.Range(0,3) == 0)
            {
                coinCount = 60;
                coinY = Random.Range(0f, 2f);
                coinLineIndex = Random.Range(0, coinLine.Length);
            }
        }

        if (coinCount >0 )
        {
            coinCount -= 1;
            if (coinCount % 5 == 0)
            {
                GameObject obj = ObjectPool.Instance.getGameObject(coinPrefab);
                obj.SetActive(true);
                obj.transform.position = new Vector3(9, coinY + coinLine[coinLineIndex].Evaluate(coinCount / 30f), 0);
                obj.transform.SetParent(transform, true);

            }

        }
    }
}
