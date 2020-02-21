using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GG.Infrastructure.Utils.Swipe
{
    [Serializable]
    public class SwipeListenerEvent : UnityEvent<string> { }

    public class SwipeListener : MonoBehaviour
    {
        public UnityEvent OnSwipeCancelled;

        public SwipeListenerEvent OnSwipe;

        [SerializeField]
        private float _sensetivity = 10;

        [SerializeField]
        private bool _continuousDetection;

        [SerializeField]
        private SwipeDetectionMode _swipeDetectionMode = SwipeDetectionMode.EightSides;

        private bool _waitForSwipe = true;

        private float _minMoveDistance = 0.1f;

        private Vector3 _swipeStartPoint;

        private Vector3 _offset;

        private VectorToDirection _directions;

        public bool ContinuousDetection { get => _continuousDetection; set => _continuousDetection = value; }

        public float Sensetivity
        {
            get
            {
                return _sensetivity;
            }
            set
            {
                _sensetivity = value;
                UpdateSensetivity();
            }
        }

        public SwipeDetectionMode SwipeDetectionMode { get => _swipeDetectionMode; set => _swipeDetectionMode = value; }

        public void SetDetectionMode(List<DirectionId> directions)
        {
            _directions = new VectorToDirection(directions);
        }

        private void Start()
        {
            UpdateSensetivity();

            if (SwipeDetectionMode != SwipeDetectionMode.Custom)
            {
                SetDetectionMode(DirectionPresets.GetPresetByMode(SwipeDetectionMode));
            }
        }

        private void UpdateSensetivity()
        {
            int screenShortSide = Screen.width < Screen.height ? Screen.width : Screen.height;
            _minMoveDistance = screenShortSide / _sensetivity;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                InitSwipe();
            }

            if (_waitForSwipe && Input.GetMouseButton(0))
            {
                CheckSwipe();
            }

            if (_continuousDetection == false)
            {
                CheckSwipeCancellation();
            }
        }

        private void CheckSwipeCancellation()
        {
            if (Input.GetMouseButtonUp(0))
            {

                if (_waitForSwipe)
                {
                    OnSwipeCancelled?.Invoke();
                }
            }
        }

        private void InitSwipe()
        {
            SampleSwipeStart();
            _waitForSwipe = true;
        }

        private void CheckSwipe()
        {
            _offset = Input.mousePosition - _swipeStartPoint;
            if (_offset.magnitude >= _minMoveDistance)
            {
                OnSwipe?.Invoke(_directions.GetSwipeId(_offset));
                if (!_continuousDetection)
                {
                    _waitForSwipe = false;
                }
                SampleSwipeStart();
            }
        }

        private void SampleSwipeStart()
        {
            _swipeStartPoint = Input.mousePosition;
            _offset = Vector3.zero;
        }
    }
}