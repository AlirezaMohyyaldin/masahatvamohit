using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace masahat_va_mohit
{
    internal class cercle
    {
        private double cerc;

        public double Cerc
        { get { return cerc; } set {  cerc = value; } }
        public cercle() { }
        public cercle(double cerc)
        {
            cerc = Cerc;
        }
        public double masahat()
        {
            double m = Math.Pow(cerc, 2) * 3.14;
                return m; 
        }
        public double mohit()
        {
            double n = (cerc * 2) * 3.14;
            return n;
                }
    }
    internal class moraba
    {
        private double mora;

        public double Mora { get {  return mora; } set {  mora = value; } }
        public moraba() { }
        public moraba(double mora) 
        {
            mora = Mora;
        }
        public double masahat()
        {
            double b = Math.Pow(mora, 2);
            return b;
        }
        public double mohit() 
        {
            double n = mora * 4;
            return n;
        }
    }
    internal class mosalas
    {
        private double mora;
        private double mosa;
        private double w;
        private double n;
        private double m;
        public double Mosa
        {
            get { return mosa; }
            set { Mosa = value; }
        }
        public double Mora
        {
            get { return mora; }
            set { mora = value; }
        }
        public double W
        {
            get { return w; }
            set { w = value; }
        }
        public double N
        {
            get { return n; }
            set { n = value; }
        }
        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public mosalas() { }
        public mosalas(double mosa , double mora ,double w ,double n,double m)
        {
            mosa = Mosa;
            mora = Mora;
            w = W;
            n = N;
            m = M;
        }
        public double masahat()
        {
            double m = mosa * mora;
            return m;
        }
       public double mohit()
        {
            double g= m + n + w;
            return g;
        }
    }
    internal class Lozy
    {
        private double m;
        private double w;
        private double g;

        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public double W
        {
            get { return w; }
                set { w = value; }
        }
        public double G
        {
            get { return g; }
            set { g = value; }
        }
        public Lozy() { }  
        public Lozy (double m,double w,double g)
        {
            m = M;
            w = W;
            g = G;
        }
        public double masahat() 
        {
            double k = (m+w)/2;
            return k;
        }
        public double mohit() 
        {
            double k = g * 4;
            return k;
        }
    }
    internal class zozanaghe
    {
        private double m;
        private double w;
        private double h;
        private double i;
        private double j;
            private double k;

        public double M
        {
            get { return m; }
                set { m = value; }
        }
        public double W
        {
            get { return w; }
            set { w = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        private double I
        {
            get { return i; }
            set { i = value; }
        }
        public double J
        {
            get { return j; }
            set { j = value; }
        }
        public double K
        {
            get { return k; }
            set { k = value; }
        }
        public zozanaghe() { }
        public zozanaghe(double m, double w,double h,double i,double j,double k)
        {   
            m = M;
            w = W;
            h = H;
            i = I;
            j = J;
            k = K;
        }
        public double masahat()
        {
            double b = ((m+w) * h)/2;
            return b;
        }
        public double mohit()
        {
            double v = i + j + k + h;
            return v;
        }
    }
                    //baraye harkodomesh bayad class benevesi 
        public class test
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter your number you choise calculate it");
                Console.WriteLine("1 = masahat va mohit cercle");
                Console.WriteLine("2 = masahat va mohit moraba");
                Console.WriteLine("3 = masahat va mohit mosalas");
                Console.WriteLine("4 = masahat va mohit lozy");
                Console.WriteLine("5 = masahat va mohit zozanaghe");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {
                Console.WriteLine("enter shoa cercle :");
                double r = Convert.ToDouble(Console.ReadLine());
                    cercle c = new cercle(r);
                    Console.WriteLine(c.masahat());
                Console.WriteLine(c.mohit());
                }
               else if(d == 2)
            {
                Console.WriteLine("enetr zelhe moraba:");
                double w = Convert.ToDouble(Console.ReadLine());
                moraba v = new moraba(w);
                Console.WriteLine(v.masahat());
                Console.WriteLine(v.mohit());
            }
                else if( d == 3)
            {
                Console.WriteLine("enter ghaeede va ertefah mosalas");
                Console.WriteLine(" se zele mosalas vared konid");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double w = Convert.ToDouble(Console.ReadLine()); 
                double f  = Convert.ToDouble(Console.ReadLine());
                mosalas s = new mosalas(x, y, z, w, f);
                Console.WriteLine(s.masahat());
                Console.WriteLine(s.mohit());
            }
                else if (d == 4) 
            {
                Console.WriteLine("enter smal and big ghoter va zele :");
                double r = Convert.ToDouble(Console.ReadLine());
                double q = Convert.ToDouble(Console.ReadLine());
                double t = Convert.ToDouble(Console.ReadLine());
                Lozy l = new Lozy(r, q, t);
                Console.WriteLine(l.masahat());
                Console.WriteLine(l.mohit());

            }
                else if (d == 5) 
            {
                Console.WriteLine("enter 4 zele va gheede va ertefa");
                double i = Convert.ToDouble(Console.ReadLine());
                double j = Convert.ToDouble(Console.ReadLine());
                double k = Convert.ToDouble(Console.ReadLine());
                double l = Convert.ToDouble(Console.ReadLine());
                double m = Convert.ToDouble(Console.ReadLine());
                double n = Convert.ToDouble(Console.ReadLine());
                zozanaghe z =new zozanaghe(i,j, k, l, m, n);
                Console.WriteLine(z.masahat());
                Console.WriteLine(z.mohit());
            }
            }
        }
    
}
