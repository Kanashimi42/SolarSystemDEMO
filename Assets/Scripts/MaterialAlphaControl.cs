using UnityEngine;

public class MaterialAlphaControl : MonoBehaviour
{
    [Header("Alpha control | Bigger value = more transparent")]
    public float alpha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        var block = new MaterialPropertyBlock();

        renderer.GetPropertyBlock(block);
        block.SetFloat("_Cutoff", alpha);
        renderer.SetPropertyBlock(block);
    }

}
