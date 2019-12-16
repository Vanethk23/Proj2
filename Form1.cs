using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)  //make the correct panel visible
            {
                CataPanel.Visible = true;
                PersPanel.Visible = false;
            }
        }

        private void PesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PesButton.Checked)  //make the correct panel visible
            {
                PersPanel.Visible = true;
                CataPanel.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            PersList.Items.AddRange(new object[] {
                "George Washington",
                "John Adams",
                "Thomas Jafferson",
                "James Madison",
                "James Monroe",
                "John Quincy Adams",
                "Andrew Jackson",
                "Martin Van Buren",
                "William Henry Harrison",
                "John Tyler",
                "James Polk",
                "Zachary Taylor",
                "Millard Fillmore",
                 "Franklin Pierce",
                 "James Buchanan",
                 "Abraham Lincoln",
                 "Andrew Johnson",
                 "Ulysses Grant",
                 "Rutherford Hayes",
                 "James Garfield",
                 "Chester Arthur",
                 "Stephen Grover Cleveland",
                 "Benjamin Harrison",
                 "Stephen Grover Cleveland",
                 "William Mckinley",
                 "Theodore Roosevelt",
                 "William Taft",
                 "Woodrow Wilson",
                 "Warren Harding",
                 "Calvin Coolidge",
                 "Herbert Hoover",
                 "Franklin Roosevelt",
                 "Harry Truman",
                 "Dwight Eisenhower",
                 "John Kennedy",
                 "Lyndon Johnson",
                 "Richard Nixon",
                 "Gerald Ford",
                 "James Carter",
                 "Ronald Reagan",
                 "George Bush",
                 "William Clinton",
                 "George W Bush",
                 "Barack Obama",
                 "Donald Trump"});

            Cata.Items.AddRange(new object[] { "Death", "Party", "Education" });



            Singlist.Items.AddRange(new object[] { "startYr", "stateBorn", "occupation", "religion", "First Oppent" });


        }

        private void Cata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cata.SelectedItem == "Death")
            {
                Catalist.Items.Clear();

                Catalist.Items.AddRange(new object[] { "gunshot", "heart", "cancer","stroke","other" });

            }
            else if (Cata.SelectedItem == "Party")
            {
                Catalist.Items.Clear();

                Catalist.Items.AddRange(new object[] { "Democratic", "Republican", "Federalist","Whing","Union","others" });

            }
            else if (Cata.SelectedItem == "Education")
            {
                Catalist.Items.Clear();

                Catalist.Items.AddRange(new object[] { "Yale", "Oxford", "Harvard","Collage","otherss"});

            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            int QUAN_PROPERTIES = 38; 
            string filePath = "C:\\Users\\Vanethk\\Presidents.csv";
            string strRead;

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readerClass = new StreamReader(fs);

            int count = 0;
            count = GetCount(filePath); 

            
            President[] pres = new President[count];
            for (int i = 0; i < count; ++i)
            {
                pres[i] = new President();
            }
            string[] record = new string[QUAN_PROPERTIES];
            for (int counter = 1; counter < count; ++counter)
            {
                strRead = readerClass.ReadLine();

                record = strRead.Split(',');

                pres[counter].FirstName = record[1];
                pres[counter].LastName = record[2];
                pres[counter].startYr = record[10];
                pres[counter].stateBorn = record[14];
                pres[counter].religion = record[18];
                pres[counter].occupation = record[20];
                pres[counter].Foppent = record[22];
            }
            readerClass.Close();
            fs.Close();

            int x =PersList.SelectedIndex + 2;
            string outputString = $"{pres[x].FirstName} {pres[x].LastName}";

            int Info = Singlist.SelectedItems.Count;
            string[] Options = new string[Info];
            int OptionsCount = 0;

            foreach (var infoOption in Singlist.SelectedItems)
            {
                Options[OptionsCount] = infoOption.ToString();
                OptionsCount++;
            }

            for(int y = 0; y < Options.Length; y++)
            {
                if(Options[y] == "startYr")
                {
                    outputString += $"\n Year started: {pres[x].startYr}";
                }
                else if(Options[y] == "stateBorn")
                {
                    outputString += $"\n Birth State: {pres[x].stateBorn}";
                }
                else if (Options[y] == "occupation")
                {
                    outputString += $"\n occupation: {pres[x].occupation}";
                }
                else if (Options[y] == "religion")
                {
                    outputString += $"\n religion: {pres[x].religion}";
                }
                else if (Options[y] == "First Oppent")
                {
                    outputString += $"\n First Oppent: {pres[x].Foppent}";
                }
            }

            MessageBox.Show(outputString);
        }
        static int GetCount(string file)
        {
            int count = 0;
            string strRead;
            FileStream sr = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader readerCount = new StreamReader(sr);

            strRead = readerCount.ReadLine(); 

            while (strRead != null)
            {
                ++count;
                strRead = readerCount.ReadLine();
            }
            readerCount.Close();
            sr.Close();

            return count;
        }

        private void CataButton_Click(object sender, EventArgs e)
        {
            int QUAN_PROPERTIES = 38;
            string filePath = "C:\\Users\\Vanethk\\Presidents.csv";
            string strRead;

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readerClass = new StreamReader(fs);

            int count = 0;
            count = GetCount(filePath);

            Catalog[] catal = new Catalog[count];
            for (int i = 0; i < count; ++i)
            {
                catal[i] = new Catalog();
            }
            string[] record = new string[QUAN_PROPERTIES];
            for (int counter = 1; counter < count; ++counter)
            {
                strRead = readerClass.ReadLine();

                record = strRead.Split(',');

                catal[counter].FirstName = record[1];
                catal[counter].LastName = record[2];
                catal[counter].deaths = record[34];
                catal[counter].partys = record[3];
                catal[counter].school = record[19];
            }
            readerClass.Close();
            fs.Close();

            int x = Cata.SelectedIndex + 2;
            //string nameOutString = $"{catal[x].FirstName} {catal[x].LastName}";
            string nameOutString = "";

            int Info = Catalist.SelectedItems.Count;
            string[] Options = new string[Info];
            int OptionsCount = 0;

            foreach (var infoOption in Catalist.SelectedItems)
            {
                Options[OptionsCount] = infoOption.ToString();
              
                OptionsCount++;
                
            }



            for (int y = 0; y < Options.Length; y++)
            {
                //death
                if (Options[y] == "gunshot")
                {
                    for (x=1; x < count; ++x)
                    {
                    
                        if ((catal[x].deaths).Contains("gunshot"))
                        {
                            
                           nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} Death : {catal[x].deaths}";
                        }
                    }
                    
                    
                }
                else if (Options[y] == "heart")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].deaths).Contains("heart"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} Death : {catal[x].deaths}";
                        }
                    }


                }
                else if (Options[y] == "cancer")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].deaths).Contains("cancer"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} Death : {catal[x].deaths}";
                        }
                    }


                }
                else if (Options[y] == "stroke")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].deaths).Contains("stroke"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} Death : {catal[x].deaths}";
                        }
                    }


                }
                else if (Options[y] == "other")
                {
                    for (x = 1; x < count; ++x)
                    {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} Death : {catal[x].deaths}";
                        
                    }


                }
                //edu
                else if (Options[y] == "Yale")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].school).Contains("Yale"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} School : {catal[x].school}";
                        }
                    }


                }
                else if (Options[y] == "Oxford")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].school).Contains("Oxford"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} School : {catal[x].school}";
                        }
                    }


                }
                else if (Options[y] == "Harvard")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].school).Contains("Harvard"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} School : {catal[x].school}";
                        }
                    }


                }
                else if (Options[y] == "Collage")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].school).Contains("College"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} School : {catal[x].school}";
                        }
                    }


                }
                else if (Options[y] == "otherss")
                {
                    for (x = 1; x < count; ++x)
                    {

                        nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} school : {catal[x].school}";

                    }


                }
                //party
                else if (Options[y] == "Democratic")
                {
                    
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].partys).Contains("Democratic"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";
                        }
                    }


                }
                else if (Options[y] == "Republican")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].partys).Contains("Republican"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";
                        }
                    }


                }
                else if (Options[y] == "Federalist")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].partys).Contains("Federalist"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";
                        }
                    }


                }
                else if (Options[y] == "Whing")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].partys).Contains("Whig"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";
                        }
                    }


                }
                else if (Options[y] == "Union")
                {
                    for (x = 1; x < count; ++x)
                    {

                        if ((catal[x].partys).Contains("Union"))
                        {

                            nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";
                        }
                    }


                }
                else if (Options[y] == "others")
                {
                    for (x = 1; x < count; ++x)
                    {

                        nameOutString += $"\n {catal[x].FirstName} {catal[x].LastName} party : {catal[x].partys}";

                    }


                }
                //end
            }

            MessageBox.Show(nameOutString);
            
        }
    }
    public class President
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string stateBorn { get; set; }
        public string startYr { get; set; }
        public string occupation { get; set; }
        public string religion { get; set; }
        public string Foppent { get; set; }
    }

    public class Catalog
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Death
        public string deaths { get; set; }
        //Party
        public string partys { get; set; }
        //Edu
        public string school { get; set; }
    }

}
