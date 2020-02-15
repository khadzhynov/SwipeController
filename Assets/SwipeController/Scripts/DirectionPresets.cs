using System.Collections.Generic;
using UnityEngine;

namespace GG.Infrastructure.Utils.Swipe
{
    public static class DirectionPresets
    {
        public static List<DirectionId> GetPresetByMode(SwipeDetectionMode mode)
        {
            switch (mode)
            {
                case SwipeDetectionMode.LeftRight:
                    return LeftRightPreset();

                case SwipeDetectionMode.UpDown:
                    return UpDownPreset();

                case SwipeDetectionMode.FourSides:
                    return FourSidesPreset();

                case SwipeDetectionMode.EightSides:
                    return EightSidesPreset();

                case SwipeDetectionMode.HexagonalHorizontal:
                    return HexagonalHorizontalPreset();

                case SwipeDetectionMode.HexagonalVertical:
                    return HexagonalVerticalPreset();

                default:
                    return FourSidesPreset();
            }
        }

        public static List<DirectionId> HexagonalVerticalPreset()
        {
            return new List<DirectionId> {
            new DirectionId(DirectionId.ID_UP, Vector3.up),
            new DirectionId(DirectionId.ID_DOWN, Vector3.down),
            new DirectionId(DirectionId.ID_UP_LEFT, Vector3.left + Vector3.up * 0.5f),
            new DirectionId(DirectionId.ID_UP_RIGHT, Vector3.right + Vector3.up * 0.5f),
            new DirectionId(DirectionId.ID_DOWN_LEFT, Vector3.left + Vector3.down * 0.5f),
            new DirectionId(DirectionId.ID_DOWN_RIGHT, Vector3.right + Vector3.down * 0.5f)};
        }

        public static List<DirectionId> HexagonalHorizontalPreset()
        {
            return new List<DirectionId> {
            new DirectionId(DirectionId.ID_LEFT, Vector3.left),
            new DirectionId(DirectionId.ID_RIGHT, Vector3.right),
            new DirectionId(DirectionId.ID_UP_LEFT, Vector3.up + Vector3.left * 0.5f),
            new DirectionId(DirectionId.ID_UP_RIGHT, Vector3.up + Vector3.right * 0.5f),
            new DirectionId(DirectionId.ID_DOWN_LEFT, Vector3.down + Vector3.left * 0.5f),
            new DirectionId(DirectionId.ID_DOWN_RIGHT, Vector3.down + Vector3.right * 0.5f)};
        }

        public static List<DirectionId> EightSidesPreset()
        {
            return new List<DirectionId> {
            new DirectionId(DirectionId.ID_UP, Vector3.up),
            new DirectionId(DirectionId.ID_DOWN, Vector3.down),
            new DirectionId(DirectionId.ID_LEFT, Vector3.left),
            new DirectionId(DirectionId.ID_RIGHT, Vector3.right),
            new DirectionId(DirectionId.ID_UP_LEFT, Vector3.up + Vector3.left),
            new DirectionId(DirectionId.ID_UP_RIGHT, Vector3.up + Vector3.right),
            new DirectionId(DirectionId.ID_DOWN_LEFT, Vector3.down + Vector3.left),
            new DirectionId(DirectionId.ID_DOWN_RIGHT, Vector3.down + Vector3.right)};
        }

        public static List<DirectionId> FourSidesPreset()
        {
            return new List<DirectionId> {
                    new DirectionId(DirectionId.ID_UP, Vector3.up),
                    new DirectionId(DirectionId.ID_DOWN, Vector3.down),
                    new DirectionId(DirectionId.ID_LEFT, Vector3.left),
                    new DirectionId(DirectionId.ID_RIGHT, Vector3.right)};
        }

        public static List<DirectionId> UpDownPreset()
        {
            return new List<DirectionId> {
                    new DirectionId(DirectionId.ID_UP, Vector3.up),
                    new DirectionId(DirectionId.ID_DOWN, Vector3.down)};
        }

        public static List<DirectionId> LeftRightPreset()
        {
            return new List<DirectionId> {
                    new DirectionId(DirectionId.ID_LEFT, Vector3.left),
                    new DirectionId(DirectionId.ID_RIGHT, Vector3.right)};
        }
    }
}
