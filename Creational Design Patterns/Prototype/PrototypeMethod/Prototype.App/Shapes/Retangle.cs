namespace Prototype.App.Shapes
{
    public class Rectangle : Shape
    {
        public int width;
        public int height;
        public Rectangle()
        {
        }

        public Rectangle(Rectangle target) : base(target)
        {
            if (target != null)
            {
                this.width = target.width;
                this.height = target.height;
            }
        }


        public override Shape clone(){
            return new Rectangle(this);
        }

        
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
            Rectangle shape2 = (Rectangle) obj;
            return shape2.width == width && shape2.height == height;

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