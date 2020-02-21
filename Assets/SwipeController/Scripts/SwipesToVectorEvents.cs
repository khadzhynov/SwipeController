using GG.Infrastructure.Utils.Swipe;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GG.Infrastructure.Utils.Swipe
{

    [Serializable]
    public class Vector3Event
    {
        public Vector3 Vector;
        public SwipeVectorEvent Event;
    }

    [Serializable]
    public class SwipeVectorEvent : UnityEvent<Vector3> { }

    public class SwipesToVectorEvents : MonoBehaviour
    {
        private const string ID_PREFIX = "customID_{0}";

        [SerializeField]
        private List<Vector3Event> _swipes;

        [SerializeField]
        private SwipeListener _swipeListener;

        private Dictionary<string, Vector3Event> _swipesDictionary;

        private void Start()
        {
            List<DirectionId> directions = new List<DirectionId>();

            _swipesDictionary = new Dictionary<string, Vector3Event>();

            foreach (var swipe in _swipes)
            {
                string id = string.Format(ID_PREFIX, swipe.Vector.ToString());
                directions.Add(new DirectionId(id, swipe.Vector));
                _swipesDictionary.Add(id, swipe);
            }
            _swipeListener.SwipeDetectionMode = SwipeDetectionMode.Custom;
            _swipeListener.SetDetectionMode(directions);
        }

        private void OnEnable()
        {
            _swipeListener.OnSwipe.AddListener(OnSwipeHandler);
        }

        private void OnDisable()
        {
            _swipeListener.OnSwipe.RemoveListener(OnSwipeHandler);
        }

        private void OnSwipeHandler(string id)
        {
            if (_swipesDictionary.ContainsKey(id))
            {
                _swipesDictionary[id].Event?.Invoke(_swipesDictionary[id].Vector);
            }
            else
            {
                Debug.LogWarning("Unrecognized swipe id!");
            }
        }
    }
}
