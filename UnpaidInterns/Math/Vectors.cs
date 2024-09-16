public class vector {
    public double x;
    public double y;
    public double z;

    public double magnitude;
    public vector(double xc, double yc, double zc) {
        this.x = xc;
        this.y = yc;
        this.z = zc;

        this.magnitude = Math.Sqrt((xc * xc) + (yc * yc) + (zc * zc));
    }
}

public class vectorMath {
    public double scalarProduct(vector a, vector b) {
        double x = a.x * b.x;
        double y = a.y * b.y;
        double z = a.z * b.z;

        return x + y + z;
    }

    public double dotProduct(vector a, vector b) { // dot and scalar product are the same with different names (I could be wrong)
        return scalarProduct(a, b); 
    }

    public double angleBetween(vector a, vector b) {
        return Math.Acos((a.magnitude * b.magnitude)/(Math.Abs(a.magnitude) * Math.Abs(b.magnitude)));
    }

    public double crossProduct(vector a, vector b) {
        double theta = angleBetween(a, b);

        return Math.Abs(a.magnitude) * Math.Abs(b.magnitude) * Math.Sin(theta);
    }
}