using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antoine_Equation
{
    class Compound
    {
        private int ddb;
        private string empf;
        private string name;
        private string casn;
        private string smiles;
        private string csid;
        private double factorA;
        private double factorB;
        private double factorC;
        private double tMin;
        private double tMax;
        private double tbCal;
        private double tb;
        private string tbSrc;
        private double temperature;

        public Compound()
        {
        }

        public Compound(int ddb, string empf, string name, string casn, string smiles, string csid, double factorA, double factorB, double factorC, double tMin, double tMax, double tbCal, double tb, string tbSrc, double temperature)
        {
            this.Ddb = ddb;
            this.Empf = empf;
            this.Name = name;
            this.Casn = casn;
            this.Smiles = smiles;
            this.Csid = csid;
            this.FactorA = factorA;
            this.FactorB = factorB;
            this.FactorC = factorC;
            this.TMin = tMin;
            this.TMax = tMax;
            this.TbCal = tbCal;
            this.Tb = tb;
            this.TbSrc = tbSrc;
            this.Temperature = temperature;
        }

        public int Ddb { get => ddb; set => ddb = value; }
        public string Empf { get => empf; set => empf = value; }
        public string Name { get => name; set => name = value; }
        public string Casn { get => casn; set => casn = value; }
        public string Smiles { get => smiles; set => smiles = value; }
        public string Csid { get => csid; set => csid = value; }
        public double FactorA { get => factorA; set => factorA = value; }
        public double FactorB { get => factorB; set => factorB = value; }
        public double FactorC { get => factorC; set => factorC = value; }
        public double TMin { get => tMin; set => tMin = value; }
        public double TMax { get => tMax; set => tMax = value; }
        public double TbCal { get => tbCal; set => tbCal = value; }
        public double Tb { get => tb; set => tb = value; }
        public string TbSrc { get => tbSrc; set => tbSrc = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public double VaporPressure
        {
            get => Antoine_Equation(FactorA, FactorB, FactorC, Temperature);
        }

        public double VaporKiloPascals
        {
            get
            {
                return this.VaporPressure * 0.133322;
            }
        }
        //Returns mmHg. 
        public double Antoine_Equation(double a, double b, double c, double t)
        {
            return Math.Pow(10, (a - (b / (t + c))));
        }

        public double Antoine_Equation(double t)
        {
            return Antoine_Equation(FactorA, FactorB, FactorC, t);
        }

        public Dictionary<Double, Double> TheDictionary
        {
            get
            {
                Dictionary<Double, Double> retDictionary = new Dictionary<double, double>();
                double temperatureRange = this.TMax - this.TMin;
                double temperatureBuckets = temperatureRange / 25.0;
                double startTemp = this.TMin;
                while (startTemp < this.TMax)
                {
                    retDictionary.Add(startTemp, Antoine_Equation(startTemp));
                    startTemp += temperatureBuckets;
                }
                return retDictionary;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append(Ddb + " ");
            sb.Append(Empf + " ");
            sb.Append(Name + " ");
            sb.Append(Casn + " ");
            sb.Append(Smiles + " ");
            sb.Append(Csid + " ");
            sb.Append(FactorA + " ");
            sb.Append(FactorB + " ");
            sb.Append(FactorC + " ");
            sb.Append(TMin + " ");
            sb.Append(TMax + " ");
            sb.Append(TbCal + " ");
            sb.Append(Tb + " ");
            sb.Append(TbSrc + " ");
            sb.Append(Temperature + " ");
            sb.Append(VaporPressure.ToString());

            return sb.ToString();
        }
    }
}
