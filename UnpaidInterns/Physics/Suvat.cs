// S = displacement
// u = initial velocity
// v = final velocity
// a = acceleration
// t = time

using System.Runtime.CompilerServices;

public static class suvatFuncs {

    public static double swithoutu(double[] ins) { // if you dont know a value, input 0, it wont matter anyway
        double v = ins[2];
        double a = ins[3];
        double t = ins[4];
        return (v * t) + (0.5 * (a * (t * t)));
    }

    public static double swithoutv(double[] ins) {
        return swithoutu([0, 0, ins[1], ins[3], ins[4]]);
    }

    public static double swithouta(double[] ins) {
        double u = ins[1];
        double v = ins[2];
        double t = ins[4];

        return (t / 2) * (u + v);
    }

    public static double swithoutt(double[] ins) {
        double u = ins[1];
        double v = ins[2];
        double a = ins[3];

        return ((u * u) + (v * v)) / (2 * a);
    }

    public static double uwithouts(double[] ins) {
        double v = ins[2];
        double a = ins[3];
        double t = ins[4];

        return v - (a * t);
    }

    public static double uwihtoutv(double[] ins) {
        double s = ins[0];
        double a = ins[3];
        double t = ins[4];

        return (s - (a * (t * t))) / (2 * t);
    }

    public static double uwithouta(double[] ins) {
        double s = ins[0];
        double v = ins[2];
        double t = ins[4];

        return ((2 * s) / t) + v;
    }

    public static double uwithoutt(double[] ins) {
        double s = ins[0];
        double v = ins[2];
        double a = ins[3];

        return Math.Sqrt((2 * a * s) - (v * v));
    }

    public static double vwithouts(double[] ins) {
        double u = ins[0];
        double a = ins[3];
        double t = ins[4];

        return u + (a * t);
    }

    public static double vwithoutu(double[] ins) {
        double s = ins[0];
        double a = ins[3];
        double t = ins[4];

        return (s + (a * (t * t))) / (2 * t);
    }

    public static double vwithouta(double[] ins) {
        double s = ins[0];
        double u = ins[1];
        double t = ins[4];

        return ((2 * s) / t) - u;
    }

    public static double vwithoutt(double[] ins) {
        double u = ins[1];
        double s = ins[0];
        double a = ins[3];

        return Math.Sqrt((u * u) + (2 * a * s));
    }

    public static double awithouts(double[] ins) {
        double u = ins[1];
        double v = ins[2];
        double t = ins[4];

        return (v - u) / t;
    }

    public static double awithoutu(double[] ins) {
        double s = ins[0];
        double v = ins[2];
        double t = ins[4];

        return (2 * ((v * t) - 2)) / (t * t);
    }

    public static double awithoutv(double[] ins) {
        double s = ins[0];
        double u = ins[1];
        double t = ins[4];

        return (2 * (s - (u * t))) / (t * t);
    }

    public static double awithoutt(double[] ins) {
        double s = ins[0];
        double u = ins[1];
        double v = ins[2];

        return ((v * v) - (u * u)) / (2 * s);
    }

    public static double twithouts(double[] ins) {
        double u = ins[1];
        double v = ins[2];
        double a = ins[3];

        return (v - u) / a;
    }

    public static double twithoutu(double[] ins) {
        double s = ins[0];
        double v = ins[2];
        double a = ins[3];

        return (v - Math.Sqrt((v * v) - (2 * a * s))) / a;
    }

    public static double twithoutv(double[] ins) {
        double s = ins[0];
        double u = ins[1];
        double a = ins[3];

        return (Math.Sqrt((2 * a * s) + (u * u)) - u) / a;
    }

    public static double twithouta(double[] ins) {
        double s = ins[0];
        double u = ins[1];
        double v = ins[2];

        return (2 * s) / (u + v);
    }

    public static double[] findUnknowns(double?[] inputs) { // take an array [s, u, v, a, t] and find missing values
        double[] ans = new double[5];

        return ans;
    }
}