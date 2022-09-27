using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadingText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI loadingText;
    // Start is called before the first frame update
    void Start()
    {
        loadingText.text = "Loading";
        StartCoroutine(blink());
    }

    // Update is called once per frame
    IEnumerator blink()
    {
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading.";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading..";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading...";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading.";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading..";
        yield return new WaitForSeconds(0.5f);
        loadingText.text = "Loading...";
        Ad_Manager.instance.Show_Ad();
        SceneManager.LoadScene(1);
    }
}
