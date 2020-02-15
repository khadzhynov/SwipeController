using UnityEngine;

namespace GG.Infrastructure.Utils.Swipe
{
    public class DirectionId
    {
        public const string ID_UP = "Up";
        public const string ID_DOWN = "Down";
        public const string ID_LEFT = "Left";
        public const string ID_RIGHT = "Right";
        public const string ID_UP_LEFT = "UpLeft";
        public const string ID_UP_RIGHT = "UpRight";
        public const string ID_DOWN_LEFT = "DownLeft";
        public const string ID_DOWN_RIGHT = "DownRight";

        public readonly string Id;
        public readonly Vector3 Direction;

        public DirectionId(string id, Vector3 direction)
        {
            Id = id;
            Direction = direction;
        }
    }
}
