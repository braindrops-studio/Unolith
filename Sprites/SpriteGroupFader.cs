using System.Collections;
using UnityEngine;

namespace Braindrops.Unolith.Sprites
{
    public class SpriteGroupFader : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer[] sprites;
        [SerializeField] private bool disableAfter = false;

        public float Alpha {
            get;
            set;
        }

        public void ChangeAlpha(float targetAlpha, float duration, bool disable = false) {
            if (!gameObject.activeInHierarchy && targetAlpha > 0)
                gameObject.SetActive(true);
            StopAllCoroutines();
            foreach (var sprite in sprites)
            {
                StartCoroutine(ChangeAlphaGradually(sprite, targetAlpha, duration, disable));
            }
        }

        public void ChangeAlpha(float targetAlpha)
        {
            if (!gameObject.activeInHierarchy && targetAlpha > 0)
                gameObject.SetActive(true);
            StopAllCoroutines();
            foreach (var sprite in sprites)
            {
                StartCoroutine(ChangeAlphaGradually(sprite, targetAlpha, .2f, disableAfter));
            }
        }

        private IEnumerator ChangeAlphaGradually(SpriteRenderer sprite, float targetAlpha, float duration, bool disable) {
            Color initialColor = sprite.color;
            Color targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, targetAlpha);
            float t = 0;
            while (t < duration) {
                t += Time.deltaTime;
                sprite.color = Color.Lerp(initialColor, targetColor, t / duration);
                yield return null;
            }

            sprite.color = targetColor;
            if (disable)
                gameObject.SetActive(false);
        }
    }
}