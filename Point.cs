namespace FunWithLinqAndEnumerable
{
    struct Point 
    {
        private int _x;
        private int _y;
        
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void MoveUp()
        {
            _y++;
        }

        public override string ToString()
        {
            return $"({_x},{_y})";
        }
    }
}