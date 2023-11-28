using DG.Tweening;
using UnityEngine;

namespace Braindrops.Unolith.Sprites
{
    public class SpriteGroupColorChanger : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer[] spriteRenderers;
        [SerializeField] private float duration = .5f;
        [SerializeField] private Color dimColor;

        public void DimColor()
        {
            foreach (var spriteRenderer in spriteRenderers)
                spriteRenderer.DOColor(dimColor, duration);
        }

        public void NormalizeColor()
        {
            foreach (var spriteRenderer in spriteRenderers)
                spriteRenderer.DOColor(Color.white, duration);
        }
    }
}