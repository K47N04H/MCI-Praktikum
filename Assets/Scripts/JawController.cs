/// Intended Use: Unity Reallusion Character Creator 3 Mouth Open Fix

/// Example Usage (at video time 2:00-2:24) : https://youtu.be/I9lT5sKLI6Q?t=120

/// This script resolves a bug with Reallusion Character Creator 3 models where the mouth is open by default.

/// Controls the rotation of the Jaw Bone using a min/max range based on the Mouth_Open BlendShape.

/// Setup Instructions
/// 1. Attach it to your character model game object
/// 2. Assign the model's animator
/// 3. Assign the model's mesh which contains facial BlendShapes
/// 4. Assign the Mouth_Open BlendShape Index

using UnityEngine;

public class JawController : MonoBehaviour
{
    [Tooltip("Animator to get the Jaw reference from.")]
    public Animator _animator;
    [Tooltip("Skinned Mesh Renderer to get the Mouth_Open BlendShape Weight from.")]
    public SkinnedMeshRenderer mesh;
    [Tooltip("Mouth_Open BlendShape Index on the mesh.")]
    public int blendShapeIndex;
    [Tooltip("Min rotation of the Jaw bone rotation.")]
    public float min = -90;
    [Tooltip("Max rotation of the Jaw bone rotation.")]
    public float max = -94;
    private Transform jawBoneTransform; // Cached reference to the jaw bone transform
    private float mouthOpenWeight;      // Current Mouth_Open BlendShape Weight
    private float normalizedWeight;     // Linear 0-1 translation of Mouth_Open BlendShape Weight
    private float rotation;             // Rotation value applied to the jaw bones local rotation on the z axis

    private void Awake()
    {
        jawBoneTransform = _animator.GetBoneTransform(HumanBodyBones.Jaw); // Cache the reference to the jaw bone
    }
    void LateUpdate()
    {
        mouthOpenWeight = mesh.GetBlendShapeWeight(blendShapeIndex);        // Get Mouth_Open Weight
        normalizedWeight = Mathf.InverseLerp(0, 100, mouthOpenWeight);      // Translate the Mouth_Open Weight to a linear 0-1 value
        rotation = Mathf.Lerp(min, max, normalizedWeight);                  // Determine the rotation value
        jawBoneTransform.localRotation = Quaternion.Euler(0, 0, rotation);  // Apply rotation to the jaw bone
    }
}