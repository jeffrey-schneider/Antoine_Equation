using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Antoine_Equation
{
    public partial class Form1 : Form
    {
        Compound compound;
        string fileName = @"../chemicalWeights.xml";
        string msg = string.Empty;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        static StringBuilder retVal = new StringBuilder();
        List<ChemicalElements> chemicals = new List<ChemicalElements>();
        Dictionary<string, double> compoundDictionary = new Dictionary<string, double>();
        ChemicalFormula.ResolveMolecule Formula = new ChemicalFormula.ResolveMolecule();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtCASNInput.Text = "7732-18-5";
            //string filePath = @"C:\Users\jcschneider\Documents\AntoineCalculation\Antoine_Coefficients.csv";
            string filePath = @"C:\Users\jcschneider\Documents\AntoineCalculation\AntoinesLatest02.csv";
            using (var reader = new StreamReader(filePath))            
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))            
            {                
                using (var dr = new CsvDataReader(csv))
                {
                    var dt = new DataTable();
                    dt.Columns.Add("DDB", typeof(int));
                    dt.Columns.Add("EMPF");
                    dt.Columns.Add("NAME");
                    dt.Columns.Add("CASN");
                    dt.Columns.Add("SMILES");
                    dt.Columns.Add("CSID");
                    dt.Columns.Add("A", typeof(double));
                    dt.Columns.Add("B", typeof(double));
                    dt.Columns.Add("C", typeof(double));
                    dt.Columns.Add("TMIN", typeof(double));
                    dt.Columns.Add("TMAX", typeof(double));
                    dt.Columns.Add("TBCAL", typeof(double));
                    dt.Columns.Add("TB", typeof(double));
                    dt.Columns.Add("TBSRC");
                    dt.Load(dr);                    
                    DGV01.DataSource = dt;                    
                }
            }
        }
       
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            Int32 selectedRowCount =
                DGV01.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a compound");
                DGV01.Focus();
            }
            else
            {
                if (compound == null)
                    compound = new Compound();
                
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                int selectedCellCount = DGV01.GetCellCount(DataGridViewElementStates.Selected);
                List<string> theList = new List<string>();
                //MessageBox.Show(dataGridView1.SelectedCells[0].RowIndex.ToString());

                //MessageBox.Show(selectedCellCount.ToString());
                int a = 0;
                int column_counter = 0;
                int intBuffer = 0;
                double doubleBuffer = 0.0;
                

                for (int i = 0; i < selectedCellCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(DGV01.SelectedCells[i].RowIndex.ToString());
                    sb.Append(", Column: ");
                    a = DGV01.SelectedCells[i].ColumnIndex;
                    sb.Append(DGV01.SelectedCells[i].ColumnIndex.ToString());
                    theList.Add(DGV01.SelectedCells[i].Value.ToString());
                    sb.Append(Environment.NewLine);
                    column_counter++;
                }
                
                if (int.TryParse(DGV01.SelectedCells[0].Value.ToString(), out intBuffer))
                {
                    compound.Ddb = intBuffer;
                }
                compound.Empf = DGV01.SelectedCells[1].Value.ToString();
                compound.Name = DGV01.SelectedCells[2].Value.ToString();
                compound.Casn = DGV01.SelectedCells[3].Value.ToString();
                compound.Smiles = DGV01.SelectedCells[4].Value.ToString();
                compound.Csid = DGV01.SelectedCells[5].Value.ToString();
                if(double.TryParse(DGV01.SelectedCells[6].Value.ToString(), out doubleBuffer))
                {
                    compound.FactorA = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[7].Value.ToString(), out doubleBuffer))
                {
                    compound.FactorB = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[8].Value.ToString(), out doubleBuffer))
                {
                    compound.FactorC = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[9].Value.ToString(), out doubleBuffer))
                {
                    compound.TMin = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[10].Value.ToString(), out doubleBuffer))
                {
                    compound.TMax = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[11].Value.ToString(), out doubleBuffer))
                {
                    compound.TbCal = doubleBuffer;
                }
                if (double.TryParse(DGV01.SelectedCells[12].Value.ToString(), out doubleBuffer))
                {
                    compound.Tb = doubleBuffer;
                }
                compound.TbSrc = DGV01.SelectedCells[13].Value.ToString();

               
                TxtBoxOutput01.Text = compound.ToString();
                foreach (var item in theList)
                {
                    sb2.Append(item + ", ");
                }
                TxtBoxOutput01.Text = sb2.ToString();
                if( double.TryParse(TxtTemperatureInput.Text, out doubleBuffer)){
                    compound.Temperature = doubleBuffer;
                }
                
                textBox4.Text = compound.VaporPressure.ToString();
                textBox5.Text = (compound.VaporPressure * 0.133322).ToString();
                textBox6.Text = (compound.VaporPressure * 0.00133322).ToString();

                double minimumTemperature = compound.TMin;
                double maximumTemperature = compound.TMax;
                double tempRange = maximumTemperature - minimumTemperature;
                double tempFactor = tempRange / 25.0;
                double startTemp = minimumTemperature;
                
                string retString = "";
                DataTable table = new DataTable();
                table.Columns.Add("Temperature", typeof(double));
                table.Columns.Add("Pressure", typeof(double));
                foreach (KeyValuePair<double, double> entry in compound.TheDictionary)
                {
                    AddKeyValuePair(table, entry.Key, entry.Value);
                }

                DGV02.DataSource = table;


                foreach (KeyValuePair<double,double> entry in compound.TheDictionary)
                {
                    retString += entry.Key.ToString() + " " + entry.Value.ToString() + Environment.NewLine;
                }
                
                textBox7.Text = retString;                
                //Change color of Text Temperature Input if Input Temp is less than TMin or greater than TMax
                TxtTemperatureInput.BackColor = Color.White;
                if (compound.Temperature < compound.TMin)
                {
                    TxtTemperatureInput.BackColor = Color.LightBlue;
                }
                if (compound.Temperature > compound.TMax)
                {
                    TxtTemperatureInput.BackColor = Color.Pink;
                }


            }
        }

        private void AddKeyValuePair(DataTable table, double v1, double v2)
        {
            DataRow row = table.NewRow();
            row["Temperature"] = v1;
            row["Pressure"] = v2;
            table.Rows.Add(row);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = TxtCASNInput.Text;
            DGV01.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int rowIndex = -1;
            try            
            {
                foreach(DataGridViewRow row in DGV01.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        rowIndex = row.Index;
                        DGV01.CurrentCell = DGV01.Rows[rowIndex].Cells[0];
                        break;
                    }
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGV01.Columns[e.ColumnIndex].Name == "Ddb")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int intValue))
                {
                    e.Value = intValue;
                    e.FormattingApplied = true;
                }
                else
                {
                    e.FormattingApplied = true;
                }
            }
        }

        
    }             
}
