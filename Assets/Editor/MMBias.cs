using UnityEditor;
using UnityEngine;

public sealed class MMBias : AssetPostprocessor
{
    private void OnPostprocessTexture(Texture2D texture)
    {
        var importer = AssetImporter.GetAtPath(assetPath) as TextureImporter;
        importer.mipMapBias = -0.7f;
    }
}