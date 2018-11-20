namespace Prototype.App.Shapes
{
    public class Circle : Shape
    {
        public int radius;

        public Circle()
        {
        }
        public Circle(Circle target):base(target)
        {
            
            if (target != null)
            {
                this.radius = target.radius;
            }
        }

        public override Shape clone(){
            return new Circle(this);
        }

        // override object.Equals
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
            Circle shape2 = (Circle) obj;
            return shape2.radius == radius;

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