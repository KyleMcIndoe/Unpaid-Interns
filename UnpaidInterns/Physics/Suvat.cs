// S = displacement
// u = initial velocity
// v = final velocity
// a = acceleration
// t = time

using System.ComponentModel;
using System.Reflection;
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

    public static double uwithoutv(double[] ins) {
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
        string[] suvatChars = {"s", "u", "v", "a", "t"};
        double[] funcInputs = new double[5];

        List<int> unknownIndices = new List<int>();


        string unkone = "";
        string unktwo = "";

        for(int i = 0; i < inputs.Length; i++) {
            if(inputs[i] == null) {
                unknownIndices.Add(i);
                funcInputs[i] = 0;
            } else {
                #pragma warning disable CS8629 // Nullable value type may be null. I just wanted vscode to shut up, its wrong
                ans[i] = (double)inputs[i];
                funcInputs[i] = (double)inputs[i];
                #pragma warning restore CS8629 // Nullable value type may be null.
            }
        }

        if(unknownIndices.Count < 2) {
            throw new Exception("input needs 2 null values");
        }

        if(unknownIndices.Count > 2) {
            throw new Exception("Not enough data, need 3 known values");
        }

        unkone = suvatChars[unknownIndices[0]];
        unktwo = suvatChars[unknownIndices[1]];

        double callFromString(string s) { // This is coding GORE, but i dont want to use reflection, so its ok
            if(s == "swithoutu") return swithoutu(funcInputs);
            if(s == "swithoutv") return swithoutv(funcInputs);
            if(s == "swithouta") return swithouta(funcInputs);
            if(s == "swithoutt") return swithoutt(funcInputs);
            if(s == "uwithouts") return uwithouts(funcInputs);
            if(s == "uwithoutv") return uwithoutv(funcInputs);
            if(s == "uwithouta") return uwithouta(funcInputs);
            if(s == "uwithoutt") return uwithoutt(funcInputs);
            if(s == "vwithouts") return vwithouts(funcInputs);
            if(s == "vwithoutu") return vwithoutu(funcInputs);
            if(s == "vwithouta") return vwithouta(funcInputs);
            if(s == "vwithoutt") return vwithoutt(funcInputs);
            if(s == "awithouts") return awithouts(funcInputs);
            if(s == "awithoutu") return awithoutu(funcInputs);
            if(s == "awithoutv") return awithoutv(funcInputs);
            if(s == "awithoutt") return awithoutt(funcInputs);
            if(s == "twithouts") return twithouts(funcInputs);
            if(s == "twithoutu") return twithoutu(funcInputs);
            if(s == "twithoutv") return twithoutv(funcInputs);
            if(s == "twithouta") return twithouta(funcInputs);
            return 0;
        }

        double unkoneans = callFromString(unkone + "without" + unktwo);
        double unktwoans = callFromString(unktwo + "without" + unkone);

        ans[unknownIndices[0]] = unkoneans;
        ans[unknownIndices[1]] = unktwoans;

        return ans;
    }
}