// from wlsdn629.tistory.com/entry/����Ƽ-PlayerPrefs-�ʱ�ȭ�ϴ�-���

using UnityEngine;
using UnityEditor;

public class ResetPlayerPrefs : MonoBehaviour
{
    [MenuItem("Window/PlayerPrefs �ʱ�ȭ")]
    private static void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs has been reset.");
    }
}