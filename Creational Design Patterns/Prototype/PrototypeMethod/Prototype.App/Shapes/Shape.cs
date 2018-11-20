namespace Prototype.App.Shapes
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public string color;

        public Shape(){

        }

        public Shape(Shape target)
        {
            if (target != null)
            {
                this.x = target.x;
                this.y = target.y;
                this.color = target.color;
            }
        }

        public abstract Shape clone();

        
        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            Shape shape2 = (Shape) obj;
            return shape2.x == x && shape2.y == y && object.Equals(shape2.color, color);

            
            
            return base.Equals (obj);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }
    }
}