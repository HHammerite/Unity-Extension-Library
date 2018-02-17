using UnityEngine;
using System.Collections;
 
public static class PlayerPrefExtensions
{
    public static bool GetBool (this PlayerPrefs playerPrefs, string key)
    {
        return PlayerPrefs.GetInt (key) == 1;
    }
 
    public static void SetBool (this PlayerPrefs playerPrefs, string key, bool state)
    {
        PlayerPrefs.SetInt (key, state ? 1 : 0);
    }
}