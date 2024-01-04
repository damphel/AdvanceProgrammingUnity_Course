using UnityEngine;

namespace Course.PatronesDiseno.Command
{
    public class Move : ICommand
    {
        private Transform _objectToMove;
        private Vector3 _direction;
        private float _distance;

        public Move(Transform objectToMove, Vector3 direction, float distance = 1)
        {
            _objectToMove = objectToMove;
            _direction = direction;
            _distance = distance;
        }

        public void Execute()
        {
            _objectToMove.position += _direction * _distance;
        }

        public void Undo()
        {
            _objectToMove.position -= _direction * _distance;
        }
    }
}
