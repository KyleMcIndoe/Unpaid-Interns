public class fraction {
    public int numerator;
    public int denominator;

    public fraction(int n, int d) {
        this.numerator = n;
        this.denominator = d;
    }

    public double toDecimal() {
        return numerator/denominator;
    }

    public void simplify() {
        int divisor = 0;
        for(int i = 0; i <= this.denominator; i++) {
            if(this.denominator % i != 0 && this.numerator % i != 0) divisor = i;
        }

        this.numerator /= divisor;
        this.denominator /= divisor;
    }

    public bool isEqualTo(fraction y) {
        if(this.toDecimal() == y.toDecimal()) return true;
        return false;
    }
} 

public static class fracMath {
    public static fraction add(fraction x, fraction y) {
        int commonDenom = x.denominator * y.denominator;
        int newNumer = x.numerator * y.denominator + y.numerator * x.denominator;
        fraction newFrac = new fraction(newNumer, commonDenom);
        newFrac.simplify();
        return newFrac;
    }

    public static fraction subtract(fraction x, fraction y) {
        int commonDenom = x.denominator * y.denominator;
        int newNumer = x.numerator * y.denominator - y.numerator * x.denominator;
        fraction newFrac = new fraction(newNumer, commonDenom);
        newFrac.simplify();
        return newFrac;
    }

    public static fraction multiply(fraction x, fraction y) {
        int newNumer = x.numerator * y.numerator;
        int newDenom = x.denominator * x.denominator;
        fraction newFrac = new fraction(newNumer, newDenom);
        newFrac.simplify();
        return newFrac;
    }

    public static fraction divide(fraction x, fraction y) {
        fraction recip = new fraction(y.denominator, y.numerator);
        return multiply(x, recip);
    }
}