using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talltekst
{
    public partial class Main : Form
    {
        int InputNumber, LengthOfInput;
        int[] InputArray;
        public Main()
        {
            InitializeComponent();
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            InputNumber = int.Parse(InputBox.Text); // Gjør om inputen fra string til tall
            InputArray = intToArray(InputNumber); // Lager et array av tallet
            
            LengthOfInput = CheckLengthOfInput(InputNumber); // Sjekker lengden på tallet
            CallUpSwitchStatements(LengthOfInput.ToString(), InputNumber); // Validerer med switch statements
         }

       
        public void CallUpSwitchStatements(string Lengde, int InputNumber)
        {
            switch (Lengde)
            {
                case "1": // Om det er 1 tall 
                    SkrivUt("Et tall");
                    SkrivUt(ValiderEtTall(InputNumber));
                    break;

                case "2": // Om det er 2 tall 
                    SkrivUt(ValiderToSisteTall(InputNumber));

                    break;

                case "3": // Om det er 3 tall 
                    SkrivUt("Tre Tall");
                    SkrivUt(ValiderTreSisteTall(InputNumber));
                    break;

                case "4": // Om det er 4 tall 
                    SkrivUt("Fire Tall");
                    SkrivUt(ValiderFireTall(InputNumber));
                    break;

                case "5": // Om det er 5 tall 
                    SkrivUt("Fem Tall");
                    
                    break;

                case "6": // Om det er 6 tall 
                    SkrivUt("Seks Tall");
                    break;
            }
        }

        public string ValiderEtTall(int input)
        {
           
            return EnTilTjue[input];
        }

        public string ValiderToSisteTall(int input)
        {
            
            int LastDigit = InputArray[InputArray.Length - 1];
            int SecondLastDigit = InputArray[InputArray.Length - 2];
            string LastTwoDigitsText = SecondLastDigit.ToString()+LastDigit.ToString();
            int LastTwoDigits = int.Parse(LastTwoDigitsText);
            if (LastTwoDigits < 20)
            {
                return EnTilTjue[LastTwoDigits];
            }
            if (LastTwoDigits % 10 == 0)
            {
                return Tiere[SecondLastDigit];
            }

            return Tiere[SecondLastDigit] + EnTilTjue[LastDigit];
        }

        public string ValiderTreSisteTall(int input)
        {
            int ThirdLastDigit = InputArray[InputArray.Length - 3];
           if (input % 100 == 0)
            {
                return Hundrere[ThirdLastDigit];
            }
            return Hundrere[ThirdLastDigit] + " og " + ValiderToSisteTall(input);
            

        }
        
        public string ValiderFireSisteTallOverHundre(int input)
        {
            int FourthLastDigit = InputArray[InputArray.Length - 4];
            return Tusener[FourthLastDigit] + " " + ValiderTreSisteTall(input);
        }

        public string ValiderFireSisteTallUnderHundre(int input)
        {
            int FourthLastDigit = InputArray[InputArray.Length - 4];
            return Tusener[FourthLastDigit] + " og " + ValiderToSisteTall(input);
        }

        public string ValiderFireTall(int input)
        {
            int TheThirdLastDigit = InputArray[InputArray.Length - 3];
            int FourthLastDigit = InputArray[InputArray.Length - 4];
            if (input % 1000 == 0)
            {
                return Tusener[FourthLastDigit];
            }
            if (TheThirdLastDigit == 0)
            {
                return ValiderFireSisteTallUnderHundre(input);
            }
           
            return ValiderFireSisteTallOverHundre(input);

        }

        //public string ValiderFemTall(int input)
        //{
        //    int FourthLastDigit = InputArray[InputArray.Length - 4];
        //    int FifthLastDigit = InputArray[InputArray.Length - 5];
        //    string TiTusenPlassTekst = FifthLastDigit.ToString() + FourthLastDigit.ToString();
        //    int TisenTusenPlassTall = int.Parse(TiTusenPlassTekst);
        //    if (TisenTusenPlassTall % 10000 == 0)
        //    {

        //    }
        //    if (TisenTusenPlassTall < 20)
        //    {
        //        return EnTilTjue[TisenTusenPlassTall] + " tusen ";
        //    }
        //    
        //}

        private void SkrivUt(string value)
        {
            OutPutBox.Text = value;
        }

        public static int[] intToArray(int num)
        {
            List<int> numbers = new List<int>();
            do
            {
                numbers.Insert(0, num % 10);
                num /= 10;
            } while (num > 0);
            return numbers.ToArray();
        }

        public static int CheckLengthOfInput(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }

        string[] EnTilTjue = new string[] { "Null", "En", "To", "Tre", "Fire", "Fem", "Seks", "Syv", "Åtte", "Ni", "Ti", "Elleve", "Tolv", "Tretten", "Fjorten", "Femten", "Seksten", "Sytten", "Atten", "Nitten" };
        string[] Tiere = new string[] { "Null", "Ti", "Tjue", "Tretti", "Førti", "Femti", "Seksti", "Søtti", "Åtti", "Nitti" };
        string[] Hundrere = new string[] { "Null", "Ett Hundre", "To Hundre", "Tre Hundre", "Fire Hundre", "Fem Hundre", "Seks Hundre", "Syv Hundre", "Åtte Hundre", "Ni Hundre" };
        string[] Tusener = new String[] { "Null", "Ett tusen", "To Tusen", "Tre Tusen", "Fire Tusen", "Fem Tusen", "Seks Tusen", "Syv Tusen", "Åtte Tusen", "Ni Tusen" };
        
    }
}
