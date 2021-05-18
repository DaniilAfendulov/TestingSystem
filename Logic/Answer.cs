using System;

namespace TestingSystem
{
    [Serializable]
    public struct Answer
    {
        public string text;
        public bool isRight;
        public Answer(string text, bool isRight)
        {
            this.text = text;
            this.isRight = isRight;
        }
    }
}