using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antoine_Equation
{
    class ChemicalElements
    {
        private int atomicNumber;
        private string stableNuclides;
        private double atomicWeight;
        private string name;
        private string symbol;
        private double meltingPoint;
        private double boilingPoint;
        private double density;
        private double crustPercent;
        private string yearDiscovered;
        private int group;
        private string electronConfig;
        private double ionizationEnergy;

        public ChemicalElements(int atomicNumber, string stableNuclides, 
            double atomicWeight, string name, string symbol, double meltingPoint, 
            double boilingPoint, double density, double crustPercent, 
            string yearDiscovered, int group, string electronConfig, double ionizationEnergy)
        {
            this.AtomicNumber = atomicNumber;
            this.StableNuclides = stableNuclides;
            this.AtomicWeight = atomicWeight;
            this.Name = name;
            this.Symbol = symbol;
            this.MeltingPoint = meltingPoint;
            this.BoilingPoint = boilingPoint;
            this.Density = density;
            this.CrustPercent = crustPercent;
            this.YearDiscovered = yearDiscovered;
            this.Group = group;
            this.ElectronConfig = electronConfig;
            this.IonizationEnergy = ionizationEnergy;
        }

        public int AtomicNumber { get => atomicNumber; set => atomicNumber = value; }
        public string StableNuclides { get => stableNuclides; set => stableNuclides = value; }
        public double AtomicWeight { get => atomicWeight; set => atomicWeight = value; }
        public string Name { get => name; set => name = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public double MeltingPoint { get => meltingPoint; set => meltingPoint = value; }
        public double BoilingPoint { get => boilingPoint; set => boilingPoint = value; }
        public double Density { get => density; set => density = value; }
        public double CrustPercent { get => crustPercent; set => crustPercent = value; }
        public string YearDiscovered { get => yearDiscovered; set => yearDiscovered = value; }
        public int Group { get => group; set => group = value; }
        public string ElectronConfig { get => electronConfig; set => electronConfig = value; }
        public double IonizationEnergy { get => ionizationEnergy; set => ionizationEnergy = value; }

        public ChemicalElements(int atomicNumber, string name)
        {
            this.AtomicNumber = atomicNumber;
            this.Name = name;
        }

        public override string ToString()
        {
            return this.AtomicNumber + " " + Name;
        }

        public bool Equals(ChemicalElements other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
