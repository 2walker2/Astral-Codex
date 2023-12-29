using UnityEngine;
using System.IO;

public class AssetBundleChecker : MonoBehaviour
{
    public AssetBundle assetBundle;
    public string bundleName;
    void Start()
    {

        //Get the asset from Streaming Assets path 
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleName));

        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
        //set the public Asset bundle variable 
        assetBundle = myLoadedAssetBundle;
    }
}
