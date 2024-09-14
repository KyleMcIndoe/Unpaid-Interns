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

    public static double[] findUnknowns(double?[] inputs) { // take an array [s, u, v, a, t] and find missing values
        double[] ans = new double[5];

        return ans;
    }
}