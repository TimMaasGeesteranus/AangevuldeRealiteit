using System;
using System.Collections;
using UnityEngine;

namespace ARLocation.Utils
{
    public class SmoothMove : MonoBehaviour
    {
        [Tooltip("The smoothing factor."), Range(0, 1)]
        public float Epsilon = 0.5f;

        [Tooltip("The Precision."), Range(0, 0.1f)]
        public float Precision = 0.05f;



        public Vector3 Target
        {
            get { return target; }
            set
            {
                target = value;

                if (co != null)
                {
                    StopCoroutine(co);
                }

                co = MoveTo(target);
                StartCoroutine(MoveTo(target));
            }
        }

        private Vector3 target;
        private Action onTargetReached;
        private IEnumerator co;

        public void Move(Vector3 to, Action callback = null)
        {
            onTargetReached = callback;

            Target = to;
        }

        private IEnumerator MoveTo(Vector3 pTarget)
        {
            while (Vector3.Distance(transform.position, pTarget) > Precision)
            {
                float t = 1.0f - Mathf.Pow(Epsilon, Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, pTarget, t);

                yield return null;
            }

            transform.position = pTarget;

            onTargetReached?.Invoke();
            onTargetReached = null;
        }

        public static SmoothMove AddSmoothMove(GameObject go, float epsilon)
        {
            var smoothMove = go.AddComponent<SmoothMove>();
            smoothMove.Epsilon = epsilon;

            return smoothMove;
        }
    }
}
