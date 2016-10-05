using UnityEngine;
[ExecuteInEditMode()]
public class RotatableGuiItem : MonoBehaviour
{
    public Texture2D texture = null;
    public Texture2D texture2 = null;
    public float angle = 0;
    public Vector2 size = new Vector2(128, 128);
    public Vector2 size2 = new Vector2(128, 128);
    Vector2 pos = new Vector2(0, 0);
    Rect rect;
    Rect rect2;
    Vector2 pivot;
    void Start()
    {
        UpdateSettings();
    }
    void UpdateSettings()
    {
        pos = new Vector2(transform.localPosition.x, transform.localPosition.y);
        rect = new Rect(pos.x - size.x * 0.5f, pos.y - size.y * 0.5f, size.x, size.y);
        rect2 = new Rect(pos.x - size2.x * 0.5f, pos.y - size2.y * 0.5f, size2.x, size2.y);
        pivot = new Vector2(rect.xMin + rect.width * 0.5f, rect.yMin + rect.height * 0.5f);
    }
    void OnGUI()
    {
        if (Application.isEditor) { UpdateSettings(); }
        Matrix4x4 matrixBackup = GUI.matrix;
        GUI.DrawTexture(rect2, texture2);
        GUIUtility.RotateAroundPivot(angle, pivot);
        GUI.DrawTexture(rect, texture);
        GUI.matrix = matrixBackup;
    }
}


