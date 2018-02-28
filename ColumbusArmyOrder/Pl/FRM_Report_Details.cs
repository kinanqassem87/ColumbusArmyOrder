using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ColumbusArmyOrder.BL;

namespace ColumbusArmyOrder.Pl
{
    public partial class FRM_Report_Details : Form
    {
       public static String buttonSelectedL1 = "";
       public static String buttonSelectedL2 = "";
       public static String buttonSelectedL3 = "";
       public static String buttonSelectedL5 = "";
       public static String buttonSelectedL6 = "";
       public static String buttonSelectedL7 = "";
       public static String buttonSelectedL8 = "";
       public static String buttonSelectedL9 = "";
       public static String buttonSelectedL10 = "";
       public static String buttonSelectedL11 = "";
       public static String buttonSelectedL12 = "";
       public static String buttonSelectedLHJ = "";
       public static String buttonSelectedLL = "";
       public static String buttonSelectedLD = "";
       public static String buttonSelectedf1 = "";
       public static String buttonSelectedf2 = "";
       public static String buttonSelectedf3 = "";
       public static String buttonSelectedf4 = "";
       public static String buttonSelectedf5 = "";
       public static String buttonSelectedf6 = "";
       public static String buttonSelectedf7 = "";
       public static String buttonSelectedf8 = "";
       public static String buttonSelectedf9 = "";
       public static String buttonSelectedf10 = "";
       public static String buttonSelectedf11 = "";
       public static String buttonSelectedf12 = "";
       public static String buttonSelectedf13 = "";
       public static String buttonSelectedf14 = "";
       public static String buttonSelectedf15 = "";
       public static String buttonSelectedf16 = "";
       public static String buttonSelectedf17 = "";
       public static String buttonSelectedf18 = "";
       public static String buttonSelectedf19 = "";
       public static String buttonSelectedf20 = "";
       public static String buttonSelectedf21 = "";
       public static String buttonSelectedp1 = "";
       public static String buttonSelectedp2 = "";
       public static String buttonSelectedp3 = "";
       public static String buttonSelectedp4 = "";
       public static String buttonSelectedp5 = "";
       public static String buttonSelectedp6 = "";

       //public static int sumqL1 = 0;
       //public static int sumqL2 = 0;
       //public static int sumqL3 = 0;
       //public static int sumqL5 = 0;
       //public static int sumqL6 = 0;
       //public static int sumqL7 = 0;
       //public static int sumqL8 = 0;
       //public static int sumqL9 = 0;
       //public static int sumqL10 = 0;
       //public static int sumqL11 = 0;
       //public static int sumqL12 = 0;


       //public static int sumOL1 = 0;
       //public static int sumOL2 = 0;
       //public static int sumOL3 = 0;
       //public static int sumOL5 = 0;
       //public static int sumOL6 = 0;
       //public static int sumOL7 = 0;
       //public static int sumOL8 = 0;
       //public static int sumOL9 = 0;
       //public static int sumOL10 = 0;
       //public static int sumOL11 = 0;
       //public static int sumOL12 = 0;
        


        
        Color ActiveQuot = Color.LightGreen;
        Color BrigadeCol = Color.LightBlue;
        Color BattalionCol = Color.LightCyan;
        Color Sarayacol = Color.LightGray;
        Color Fog = Color.LightYellow;


        DataTable Bri = ClassBrigade.allBrigade();
        DataTable BriBat = ClassBrigade.sp_allBattalion();
        DataTable BriSaraya = ClassBrigade.sp_allSaraya();
        

     //   DataTable Reg = ClassRegiments.sp_allRegiment();
        
     //   DataTable Military = ClassMilitaryPieces.sp_allMilitaryPieces();

        public FRM_Report_Details()
        { 
            InitializeComponent();
            namesAll();
            //displayStatic();
            

            //**********
            
            //*********
            //foreach (Control c in this.Controls)
            //{
            //    if (c is Label)
            //        c.BackColor = Color.Red;
            //}
            
        }

        void namesAll() 
        {
            nameAllItemsL1();
            nameAllItemsL2();
            nameAllItemsL3();
            nameAllItemsL5();
            nameAllItemsL6();
            nameAllItemsL7();
            nameAllItemsL8();
            nameAllItemsL9();
            nameAllItemsL10();
            nameAllItemsL11();
            nameAllItemsL12();
            nameAllItemsLHJ();
            nameAllItemsLL();
            nameAllItemsLD();
            f1name();
            f2name();
            f3name();
            f4name();
            f5name();
            f6name();
            f7name();
            f8name();
            f9name();
            f10name();
            f11name();
            f12name();
            f13name();
            f14name();
            f15name();
            f16name();
            f17name();
            f18name();
            f19name();
            f20name();
            f21name();
            PiecesName();
        }
        //Quot L1
        void calQoutationL1() 
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                    ((Button)this.Controls["S1" + i+j]).Text = QoutS.Rows[0][0].ToString();
                 //   sumqL1 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S1" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S1" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                ((Button)this.Controls["K1" + i]).Text = QoutB.Rows[0][0].ToString();
               // sumqL1 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K1" + i]).Text.Equals("0")) { ((Button)this.Controls["K1" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L1.Text, "0", "0");
            L1.Text = QoutL.Rows[0][0].ToString();
         //   sumqL1 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L1.Text.Equals("0")) { L1.BackColor = ActiveQuot; }
               
        }
        //Quot L2
        void calQoutationL2()
        {
           
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);
                    ((Button)this.Controls["S2" + i + j]).Text = QoutS.Rows[0][0].ToString();
                   // sumqL2 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S2" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S2" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                ((Button)this.Controls["K2" + i]).Text = QoutB.Rows[0][0].ToString();
               // sumqL2 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K2" + i]).Text.Equals("0")) { ((Button)this.Controls["K2" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L2.Text, "0", "0");
            L2.Text = QoutL.Rows[0][0].ToString();
          //  sumqL2 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L2.Text.Equals("0")) { L2.BackColor = ActiveQuot; }
           

        }
        //Quot L3
        void calQoutationL3()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);
                    ((Button)this.Controls["S3" + i + j]).Text = QoutS.Rows[0][0].ToString();
                 //   sumqL3 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S3" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S3" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                ((Button)this.Controls["K3" + i]).Text = QoutB.Rows[0][0].ToString();
              //  sumqL3 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K3" + i]).Text.Equals("0")) { ((Button)this.Controls["K3" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L3.Text, "0", "0");
            L3.Text = QoutL.Rows[0][0].ToString();
         //   sumqL3 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L3.Text.Equals("0")) { L3.BackColor = ActiveQuot; }

        }
        //Quot L5
        void calQoutationL5()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);
                    ((Button)this.Controls["S5" + i + j]).Text = QoutS.Rows[0][0].ToString();
                  //  sumqL5 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S5" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S5" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                ((Button)this.Controls["K5" + i]).Text = QoutB.Rows[0][0].ToString();
             //   sumqL5 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K5" + i]).Text.Equals("0")) { ((Button)this.Controls["K5" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L5.Text, "0", "0");
            L5.Text = QoutL.Rows[0][0].ToString();
         //   sumqL5 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L5.Text.Equals("0")) { L5.BackColor = ActiveQuot; }

        }
        //Quot L6
        void calQoutationL6()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);
                    ((Button)this.Controls["S6" + i + j]).Text = QoutS.Rows[0][0].ToString();
                //    sumqL6 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S6" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S6" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                ((Button)this.Controls["K6" + i]).Text = QoutB.Rows[0][0].ToString();
             //   sumqL6 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K6" + i]).Text.Equals("0")) { ((Button)this.Controls["K6" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L6.Text, "0", "0");
            L6.Text = QoutL.Rows[0][0].ToString();
          //  sumqL6 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L6.Text.Equals("0")) { L6.BackColor = ActiveQuot; }

        }
        //Quot L7
        void calQoutationL7()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);
                    ((Button)this.Controls["S7" + i + j]).Text = QoutS.Rows[0][0].ToString();
                //    sumqL7 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S7" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S7" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                ((Button)this.Controls["K7" + i]).Text = QoutB.Rows[0][0].ToString();
            //    sumqL7 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K7" + i]).Text.Equals("0")) { ((Button)this.Controls["K7" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L7.Text, "0", "0");
            L7.Text = QoutL.Rows[0][0].ToString();
          //  sumqL7 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L7.Text.Equals("0")) { L7.BackColor = ActiveQuot; }

        }
        //Quot L8
        void calQoutationL8()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);
                    ((Button)this.Controls["S8" + i + j]).Text = QoutS.Rows[0][0].ToString();
               //     sumqL8 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S8" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S8" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                ((Button)this.Controls["K8" + i]).Text = QoutB.Rows[0][0].ToString();
             //   sumqL8 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K8" + i]).Text.Equals("0")) { ((Button)this.Controls["K8" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L8.Text, "0", "0");
            L8.Text = QoutL.Rows[0][0].ToString();
          //  sumqL8 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L8.Text.Equals("0")) { L8.BackColor = ActiveQuot; }

        }
        //Quot L9
        void calQoutationL9()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);
                    ((Button)this.Controls["S9" + i + j]).Text = QoutS.Rows[0][0].ToString();
                  //  sumqL9 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S9" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S9" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                ((Button)this.Controls["K9" + i]).Text = QoutB.Rows[0][0].ToString();
              //  sumqL9 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K9" + i]).Text.Equals("0")) { ((Button)this.Controls["K9" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L9.Text, "0", "0");
            L9.Text = QoutL.Rows[0][0].ToString();
       //     sumqL9 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L9.Text.Equals("0")) { L9.BackColor = ActiveQuot; }

        }
        //Quot L10
        void calQoutationL10()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);
                    ((Button)this.Controls["S10" + i + j]).Text = QoutS.Rows[0][0].ToString();
                  //  sumqL10 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S10" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S10" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable QoutB = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                ((Button)this.Controls["K10" + i]).Text = QoutB.Rows[0][0].ToString();
            //    sumqL10 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K10" + i]).Text.Equals("0")) { ((Button)this.Controls["K10" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L10.Text, "0", "0");
            L10.Text = QoutL.Rows[0][0].ToString();
          //  sumqL10 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L10.Text.Equals("0")) { L10.BackColor = ActiveQuot; }

        }
        //Quot L11
        void calQoutationL11()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);
                    ((Button)this.Controls["S11" + i + j]).Text = QoutS.Rows[0][0].ToString();
                 //   sumqL11 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S11" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S11" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable QoutB = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                ((Button)this.Controls["K11" + i]).Text = QoutB.Rows[0][0].ToString();
              //  sumqL11 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K11" + i]).Text.Equals("0")) { ((Button)this.Controls["K11" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L11.Text, "0", "0");
            L11.Text = QoutL.Rows[0][0].ToString();
         //   sumqL11 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L11.Text.Equals("0")) { L11.BackColor = ActiveQuot; }

        }
        //Quot L12
        void calQoutationL12()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);
                    ((Button)this.Controls["S12" + i + j]).Text = QoutS.Rows[0][0].ToString();
                 //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S12" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S12" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable QoutB = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                ((Button)this.Controls["K12" + i]).Text = QoutB.Rows[0][0].ToString();
             //   sumqL12 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K12" + i]).Text.Equals("0")) { ((Button)this.Controls["K12" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable QoutL = ClassReports.selectQout(L12.Text, "0", "0");
            L12.Text = QoutL.Rows[0][0].ToString();
          //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!L12.Text.Equals("0")) { L12.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationLHJ()
        {
           
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kj" + i + j]).Text = QoutS.Rows[0][0].ToString();
                    //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kj" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kj" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable QoutB = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "0");
                ((Button)this.Controls["kj" + i]).Text = QoutB.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kj" + i]).Text.Equals("0")) { ((Button)this.Controls["kj" + i]).BackColor = ActiveQuot; }
                
            }
            DataTable QoutL = ClassReports.selectQout(LHJ.Text, "0", "0");
            LHJ.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!LHJ.Text.Equals("0")) { LHJ.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationLL()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kl" + i + j]).Text = QoutS.Rows[0][0].ToString();
                    //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kl" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kl" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable QoutB = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "0");
                ((Button)this.Controls["kl" + i]).Text = QoutB.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kl" + i]).Text.Equals("0")) { ((Button)this.Controls["kl" + i]).BackColor = ActiveQuot; }

            }
            DataTable QoutL = ClassReports.selectQout(LL.Text, "0", "0");
            LL.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!LL.Text.Equals("0")) { LL.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationLD()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kd" + i + j]).Text = QoutS.Rows[0][0].ToString();
                    //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kd" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kd" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable QoutB = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "0");
                ((Button)this.Controls["kd" + i]).Text = QoutB.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kd" + i]).Text.Equals("0")) { ((Button)this.Controls["kd" + i]).BackColor = ActiveQuot; }

            }
            DataTable QoutL = ClassReports.selectQout(LD.Text, "0", "0");
            LD.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!LD.Text.Equals("0")) { LD.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf1()
        {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable QoutS = ClassReports.selectQout(f1.Text, "fs1" + j.ToString(), "0");
                    ((Button)this.Controls["fs1" + j]).Text = QoutS.Rows[0][0].ToString();
                    //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["fs1" + j]).Text.Equals("0")) { ((Button)this.Controls["fs1" + j]).BackColor = ActiveQuot; }
                }
            
            DataTable QoutL = ClassReports.selectQout(f1.Text, "0", "0");
            f1.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f1.Text.Equals("0")) { f1.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf2()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f2.Text, "fs2" + j.ToString(), "0");
                ((Button)this.Controls["fs2" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs2" + j]).Text.Equals("0")) { ((Button)this.Controls["fs2" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f2.Text, "0", "0");
            f2.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f2.Text.Equals("0")) { f2.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf3()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f3.Text, "fs3" + j.ToString(), "0");
                ((Button)this.Controls["fs3" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs3" + j]).Text.Equals("0")) { ((Button)this.Controls["fs3" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f3.Text, "0", "0");
            f3.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f3.Text.Equals("0")) { f3.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf4()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f4.Text, "fs4" + j.ToString(), "0");
                ((Button)this.Controls["fs4" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs4" + j]).Text.Equals("0")) { ((Button)this.Controls["fs4" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f4.Text, "0", "0");
            f4.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f4.Text.Equals("0")) { f4.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf5()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f5.Text, "fs5" + j.ToString(), "0");
                ((Button)this.Controls["fs5" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs5" + j]).Text.Equals("0")) { ((Button)this.Controls["fs5" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f5.Text, "0", "0");
            f5.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f5.Text.Equals("0")) { f5.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf6()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f6.Text, "fs6" + j.ToString(), "0");
                ((Button)this.Controls["fs6" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs6" + j]).Text.Equals("0")) { ((Button)this.Controls["fs6" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f6.Text, "0", "0");
            f6.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f6.Text.Equals("0")) { f6.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf7()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f7.Text, "fs7" + j.ToString(), "0");
                ((Button)this.Controls["fs7" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs7" + j]).Text.Equals("0")) { ((Button)this.Controls["fs7" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f7.Text, "0", "0");
            f7.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f7.Text.Equals("0")) { f7.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf8()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f8.Text, "fs8" + j.ToString(), "0");
                ((Button)this.Controls["fs8" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs8" + j]).Text.Equals("0")) { ((Button)this.Controls["fs8" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f8.Text, "0", "0");
            f8.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f8.Text.Equals("0")) { f8.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf9()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f9.Text, "fs9" + j.ToString(), "0");
                ((Button)this.Controls["fs9" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs9" + j]).Text.Equals("0")) { ((Button)this.Controls["fs9" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f9.Text, "0", "0");
            f9.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f9.Text.Equals("0")) { f9.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf10()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f10.Text, "fs10" + j.ToString(), "0");
                ((Button)this.Controls["fs10" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs10" + j]).Text.Equals("0")) { ((Button)this.Controls["fs10" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f10.Text, "0", "0");
            f10.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f10.Text.Equals("0")) { f10.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf11()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f11.Text, "fs11" + j.ToString(), "0");
                ((Button)this.Controls["fs11" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs11" + j]).Text.Equals("0")) { ((Button)this.Controls["fs11" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f11.Text, "0", "0");
            f11.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f11.Text.Equals("0")) { f11.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf12()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f12.Text, "fs12" + j.ToString(), "0");
                ((Button)this.Controls["fs12" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs12" + j]).Text.Equals("0")) { ((Button)this.Controls["fs12" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f12.Text, "0", "0");
            f12.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f12.Text.Equals("0")) { f12.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf13()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f13.Text, "fs13" + j.ToString(), "0");
                ((Button)this.Controls["fs13" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs13" + j]).Text.Equals("0")) { ((Button)this.Controls["fs13" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f13.Text, "0", "0");
            f13.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f13.Text.Equals("0")) { f13.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf14()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f14.Text, "fs14" + j.ToString(), "0");
                ((Button)this.Controls["fs14" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs14" + j]).Text.Equals("0")) { ((Button)this.Controls["fs14" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f14.Text, "0", "0");
            f14.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f14.Text.Equals("0")) { f14.BackColor = ActiveQuot; }

        }
        //***************


        void calQoutationf15()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f15.Text, "fs15" + j.ToString(), "0");
                ((Button)this.Controls["fs15" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs15" + j]).Text.Equals("0")) { ((Button)this.Controls["fs15" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f15.Text, "0", "0");
            f15.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f15.Text.Equals("0")) { f15.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf16()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f16.Text, "fs16" + j.ToString(), "0");
                ((Button)this.Controls["fs16" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs16" + j]).Text.Equals("0")) { ((Button)this.Controls["fs16" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f16.Text, "0", "0");
            f16.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f16.Text.Equals("0")) { f16.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf17()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f17.Text, "fs17" + j.ToString(), "0");
                ((Button)this.Controls["fs17" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs17" + j]).Text.Equals("0")) { ((Button)this.Controls["fs17" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f17.Text, "0", "0");
            f17.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f17.Text.Equals("0")) { f17.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf18()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f18.Text, "fs18" + j.ToString(), "0");
                ((Button)this.Controls["fs18" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs18" + j]).Text.Equals("0")) { ((Button)this.Controls["fs18" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f18.Text, "0", "0");
            f18.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f18.Text.Equals("0")) { f18.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf19()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f19.Text, "fs19" + j.ToString(), "0");
                ((Button)this.Controls["fs19" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs19" + j]).Text.Equals("0")) { ((Button)this.Controls["fs19" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f19.Text, "0", "0");
            f19.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f19.Text.Equals("0")) { f19.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf20()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f20.Text, "fs20" + j.ToString(), "0");
                ((Button)this.Controls["fs20" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs20" + j]).Text.Equals("0")) { ((Button)this.Controls["fs20" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f20.Text, "0", "0");
            f20.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f20.Text.Equals("0")) { f20.BackColor = ActiveQuot; }

        }
        //***************

        void calQoutationf21()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable QoutS = ClassReports.selectQout(f21.Text, "fs21" + j.ToString(), "0");
                ((Button)this.Controls["fs21" + j]).Text = QoutS.Rows[0][0].ToString();
                //   sumqL12 += int.Parse(QoutS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs21" + j]).Text.Equals("0")) { ((Button)this.Controls["fs21" + j]).BackColor = ActiveQuot; }
            }

            DataTable QoutL = ClassReports.selectQout(f21.Text, "0", "0");
            f21.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!f21.Text.Equals("0")) { f21.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp1()
        {
            DataTable QoutL = ClassReports.selectQout(Piece1.Text, "0", "0");
            Piece1.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece1.Text.Equals("0")) { Piece1.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp2()
        {
            DataTable QoutL = ClassReports.selectQout(Piece2.Text, "0", "0");
            Piece2.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece2.Text.Equals("0")) { Piece2.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp3()
        {
            DataTable QoutL = ClassReports.selectQout(Piece3.Text, "0", "0");
            Piece3.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece3.Text.Equals("0")) { Piece3.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp4()
        {
            DataTable QoutL = ClassReports.selectQout(Piece4.Text, "0", "0");
            Piece4.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece4.Text.Equals("0")) { Piece4.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp5()
        {
            DataTable QoutL = ClassReports.selectQout(Piece5.Text, "0", "0");
            Piece5.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece5.Text.Equals("0")) { Piece5.BackColor = ActiveQuot; }

        }
        //***************
        void calQoutationp6()
        {
            DataTable QoutL = ClassReports.selectQout(Piece6.Text, "0", "0");
            Piece6.Text = QoutL.Rows[0][0].ToString();
            //  sumqL12 += int.Parse(QoutL.Rows[0][0].ToString());
            if (!Piece6.Text.Equals("0")) { Piece6.BackColor = ActiveQuot; }

        }
        //***************


        //NoOrder L1
        void NoOrderL1() 
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                   
                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S1" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K1" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L1.BackColor = ActiveQuot; } 
        }

        //*****************
        //NoOrder L2
        void NoOrderL2()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S2" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K2" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L2.BackColor = ActiveQuot; }
        }

        //***************
        //NoOrder L3
        void NoOrderL3()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S3" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K3" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L3.BackColor = ActiveQuot; }
        }
        //***************
        //NoOrder L5
        void NoOrderL5()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S5" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K5" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L5.BackColor = ActiveQuot; }
        }
        //****************
        //NoOrder L6
        void NoOrderL6()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S6" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K6" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L6.BackColor = ActiveQuot; }
        }
        //****************
        //NoOrder L7
        void NoOrderL7()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S7" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K7" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L7.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L7.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L7.BackColor = ActiveQuot; }
        }
        //****************
        //NoOrder L8
        void NoOrderL8()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S8" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K8" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L8.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L8.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L8.BackColor = ActiveQuot; }
        }
        //*****************
        //NoOrder L9
        void NoOrderL9()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S9" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K9" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L9.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L9.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L9.BackColor = ActiveQuot; }
        }
        //*****************
        //NoOrder L10
        void NoOrderL10()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S10" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K10" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L10.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L10.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L10.BackColor = ActiveQuot; }
        }
        //******************
        //NoOrder L11
        void NoOrderL11()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S11" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K11" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L11.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L11.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L11.BackColor = ActiveQuot; }
        }
        //******************
        //NoOrder L12
        void NoOrderL12()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["S12" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["K12" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L12.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L12.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { L12.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder LHJ
        void NoOrderLHJ()
        {
            
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kj" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LHJ.Text, "kj" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kj" + i]).BackColor = ActiveQuot; }
               
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LHJ.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LHJ.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { LHJ.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder LL
        void NoOrderLL()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kl" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LL.Text, "kl" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kl" + i]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LL.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LL.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { LL.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder LD
        void NoOrderLD()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kd" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LD.Text, "kd" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) == 0 && int.Parse(QoutB.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["kd" + i]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LD.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LD.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { LD.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f1
        void NoOrderf1()
        {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(f1.Text, "fs1" + j.ToString(), "0");
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(f1.Text, "fs1" + j.ToString(), "0");

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs1" + j]).BackColor = ActiveQuot; }

                }
            DataTable NoOrderL = ClassReports.selectNOOrder(f1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f1.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f2
        void NoOrderf2()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f2.Text, "fs2" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f2.Text, "fs2" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs2" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f2.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f3
        void NoOrderf3()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f3.Text, "fs3" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f3.Text, "fs3" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs3" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f3.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f4
        void NoOrderf4()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f4.Text, "fs4" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f4.Text, "fs4" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs4" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f4.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f4.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f4.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f5
        void NoOrderf5()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f5.Text, "fs5" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f5.Text, "fs5" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs5" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f5.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f6
        void NoOrderf6()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f6.Text, "fs6" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f6.Text, "fs6" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs6" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f6.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f7
        void NoOrderf7()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f7.Text, "fs7" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f7.Text, "fs7" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs7" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f7.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f7.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f7.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f8
        void NoOrderf8()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f8.Text, "fs8" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f8.Text, "fs8" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs8" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f8.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f8.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f8.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f9
        void NoOrderf9()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f9.Text, "fs9" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f9.Text, "fs9" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs9" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f9.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f9.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f9.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f10
        void NoOrderf10()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f10.Text, "fs10" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f10.Text, "fs10" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs10" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f10.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f10.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f10.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f11
        void NoOrderf11()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f11.Text, "fs11" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f11.Text, "fs11" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs11" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f11.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f11.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f11.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f12
        void NoOrderf12()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f12.Text, "fs12" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f12.Text, "fs12" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs12" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f12.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f12.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f12.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f13
        void NoOrderf13()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f13.Text, "fs13" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f13.Text, "fs13" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs13" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f13.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f13.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f13.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f14
        void NoOrderf14()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f14.Text, "fs14" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f14.Text, "fs14" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs14" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f14.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f14.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f14.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f15
        void NoOrderf15()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f15.Text, "fs15" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f15.Text, "fs15" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs15" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f15.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f15.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f15.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f16
        void NoOrderf16()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f16.Text, "fs16" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f16.Text, "fs16" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs16" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f16.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f16.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f16.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f17
        void NoOrderf17()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f17.Text, "fs17" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f17.Text, "fs17" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs17" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f17.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f17.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f17.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f18
        void NoOrderf18()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f18.Text, "fs18" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f18.Text, "fs18" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs18" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f18.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f18.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f18.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f19
        void NoOrderf19()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f19.Text, "fs19" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f19.Text, "fs19" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs19" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f19.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f19.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f19.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f20
        void NoOrderf20()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f20.Text, "fs20" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f20.Text, "fs20" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs20" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f20.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f20.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f20.BackColor = ActiveQuot; }
        }
        //********************

        //NoOrder f21
        void NoOrderf21()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f21.Text, "fs21" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f21.Text, "fs21" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) == 0 && int.Parse(Qouts.Rows[0][0].ToString()) != 0) { ((Button)this.Controls["fs21" + j]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(f21.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f21.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { f21.BackColor = ActiveQuot; }
        }
        //********************

        void NoOrderp1()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece1.BackColor = ActiveQuot; }
        }
        //********************
        void NoOrderp2()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece2.BackColor = ActiveQuot; }
        }
        //********************
        void NoOrderp3()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece3.BackColor = ActiveQuot; }
        }
        //********************
        void NoOrderp4()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece4.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece4.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece4.BackColor = ActiveQuot; }
        }
        //********************
        void NoOrderp5()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece5.BackColor = ActiveQuot; }
        }
        //********************
        void NoOrderp6()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) == 0 && int.Parse(QoutL.Rows[0][0].ToString()) != 0) { Piece6.BackColor = ActiveQuot; }
        }
        //********************

        //SomeOrder L1
        void SomeOrderL1()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) )!=0)
                    { ((Button)this.Controls["S1" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K1" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L1.BackColor = ActiveQuot; }
        }
        //*********
        //SomeOrder L2
        void SomeOrderL2()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S2" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K2" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L2.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L3
        void SomeOrderL3()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S3" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K3" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L3.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L5
        void SomeOrderL5()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S5" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K5" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L5.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L6
        void SomeOrderL6()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S6" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K6" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L6.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L7
        void SomeOrderL7()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S7" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K7" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L7.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L7.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L7.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L8
        void SomeOrderL8()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S8" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K8" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L8.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L8.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L8.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L9
        void SomeOrderL9()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S9" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K9" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L9.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L9.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L9.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L10
        void SomeOrderL10()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S10" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K10" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L10.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L10.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L10.BackColor = ActiveQuot; }
        }
        //*****************
        //SomeOrder L11
        void SomeOrderL11()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S11" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K11" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L11.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L11.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { L11.BackColor = ActiveQuot; }
        }
        //******************
        //SomeOrder L12
        void SomeOrderL12()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["S12" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                DataTable QoutB = ClassReports.selectQout(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["K12" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(L12.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(L12.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { L12.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder LHJ
        void SomeOrderLHJ()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["kj" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LHJ.Text, "kj" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LHJ.Text, "kj" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["kj" + i]).BackColor = ActiveQuot; }
               
            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LHJ.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LHJ.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { LHJ.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder LL
        void SomeOrderLL()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["kl" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LL.Text, "kl" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LL.Text, "kl" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["kl" + i]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LL.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LL.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { LL.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder LD
        void SomeOrderLD()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["kd" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable NoOrderB = ClassReports.selectNOOrder(LD.Text, "kd" + i.ToString(), "0");
                DataTable QoutB = ClassReports.selectQout(LD.Text, "kd" + i.ToString(), "0");
                if (int.Parse(NoOrderB.Rows[0][0].ToString()) != 0 && (int.Parse(QoutB.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["kd" + i]).BackColor = ActiveQuot; }

            }
            DataTable NoOrderL = ClassReports.selectNOOrder(LD.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(LD.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { LD.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f1
        void SomeOrderf1()
        {
                for (int j = 1; j <= 4; j++)
                {
                    //number of quotations executed for this
                    DataTable NoOrderS = ClassReports.selectNOOrder(f1.Text, "fs1" + j.ToString(), "0");
                    //number of quotations for this
                    DataTable Qouts = ClassReports.selectQout(f1.Text, "fs1" + j.ToString(), "0");

                    if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                    { ((Button)this.Controls["fs1" + j]).BackColor = ActiveQuot; }

                }

            
            DataTable NoOrderL = ClassReports.selectNOOrder(f1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f1.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f2
        void SomeOrderf2()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f2.Text, "fs2" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f2.Text, "fs2" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs2" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f2.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f3
        void SomeOrderf3()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f3.Text, "fs3" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f3.Text, "fs3" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs3" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f3.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f4
        void SomeOrderf4()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f4.Text, "fs4" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f4.Text, "fs4" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs4" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f4.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f4.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f4.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f5
        void SomeOrderf5()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f5.Text, "fs5" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f5.Text, "fs5" + j.ToString(), "0");
                //- int.Parse(NoOrderS.Rows[0][0].ToString())
                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString())) != 0)
                { ((Button)this.Controls["fs5" + j]).BackColor = ActiveQuot; }

            }

            //- int.Parse(NoOrderL.Rows[0][0].ToString())
            DataTable NoOrderL = ClassReports.selectNOOrder(f5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f5.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f6
        void SomeOrderf6()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f6.Text, "fs6" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f6.Text, "fs6" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs6" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f6.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f7
        void SomeOrderf7()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f7.Text, "fs7" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f7.Text, "fs7" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs7" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f7.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f7.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f7.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f8
        void SomeOrderf8()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f8.Text, "fs8" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f8.Text, "fs8" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs8" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f8.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f8.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f8.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f9
        void SomeOrderf9()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f9.Text, "fs9" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f9.Text, "fs9" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs9" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f9.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f9.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f9.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f10
        void SomeOrderf10()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f10.Text, "fs10" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f10.Text, "fs10" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs10" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f10.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f10.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f10.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f11
        void SomeOrderf11()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f11.Text, "fs11" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f11.Text, "fs11" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs11" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f11.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f11.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f11.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f12
        void SomeOrderf12()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f12.Text, "fs12" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f12.Text, "fs12" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs12" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f12.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f12.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f12.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f13
        void SomeOrderf13()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f13.Text, "fs13" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f13.Text, "fs13" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs13" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f13.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f13.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f13.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f14
        void SomeOrderf14()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f14.Text, "fs14" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f14.Text, "fs14" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs14" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f14.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f14.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f14.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f15
        void SomeOrderf15()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f15.Text, "fs15" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f15.Text, "fs15" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs15" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f15.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f15.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f15.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f16
        void SomeOrderf16()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f16.Text, "fs16" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f16.Text, "fs16" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs16" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f16.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f16.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f16.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f17
        void SomeOrderf17()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f17.Text, "fs17" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f17.Text, "fs17" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs17" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f17.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f17.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f17.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f18
        void SomeOrderf18()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f18.Text, "fs18" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f18.Text, "fs18" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs18" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f18.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f18.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { f18.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f19
        void SomeOrderf19()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f19.Text, "fs19" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f19.Text, "fs19" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString())) != 0)
                { ((Button)this.Controls["fs19" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f19.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f19.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString()) ) != 0)
            { f19.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f20
        void SomeOrderf20()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f20.Text, "fs20" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f20.Text, "fs20" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs20" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f20.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f20.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { f20.BackColor = ActiveQuot; }
        }
        //*******************

        //SomeOrder f21
        void SomeOrderf21()
        {
            for (int j = 1; j <= 4; j++)
            {
                //number of quotations executed for this
                DataTable NoOrderS = ClassReports.selectNOOrder(f21.Text, "fs21" + j.ToString(), "0");
                //number of quotations for this
                DataTable Qouts = ClassReports.selectQout(f21.Text, "fs21" + j.ToString(), "0");

                if (int.Parse(NoOrderS.Rows[0][0].ToString()) != 0 && (int.Parse(Qouts.Rows[0][0].ToString()) ) != 0)
                { ((Button)this.Controls["fs21" + j]).BackColor = ActiveQuot; }

            }


            DataTable NoOrderL = ClassReports.selectNOOrder(f21.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(f21.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { f21.BackColor = ActiveQuot; }
        }
        //*******************
        
        void SomeOrderp1()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece1.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece1.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece1.BackColor = ActiveQuot; }
        }
        //*******************
        void SomeOrderp2()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece2.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece2.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece2.BackColor = ActiveQuot; }
        }
        //*******************
        void SomeOrderp3()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece3.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece3.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece3.BackColor = ActiveQuot; }
        }
        //*******************
        void SomeOrderp4()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece4.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece4.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece4.BackColor = ActiveQuot; }
        }
        //*******************
        void SomeOrderp5()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece5.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece5.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece5.BackColor = ActiveQuot; }
        }
        //*******************
        void SomeOrderp6()
        {
            DataTable NoOrderL = ClassReports.selectNOOrder(Piece6.Text, "0", "0");
            DataTable QoutL = ClassReports.selectQout(Piece6.Text, "0", "0");
            if (int.Parse(NoOrderL.Rows[0][0].ToString()) != 0 && (int.Parse(QoutL.Rows[0][0].ToString())) != 0)
            { Piece6.BackColor = ActiveQuot; }
        }
        //*******************


        //Order L1
        void calOrderL1() 
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                    ((Button)this.Controls["S1" + i + j]).Text = OrderS.Rows[0][0].ToString();
                  //  sumOL1 += int.Parse(OrderS.Rows[0][0].ToString());

                    if (!((Button)this.Controls["S1" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S1" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable OrderB = ClassReports.selectorder(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                ((Button)this.Controls["K1" + i]).Text = OrderB.Rows[0][0].ToString();
           //     sumOL1 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K1" + i]).Text.Equals("0")) { ((Button)this.Controls["K1" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L1.Text, "0", "0");
            L1.Text = OrderL.Rows[0][0].ToString();
         //   sumOL1 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L1.Text.Equals("0")) { L1.BackColor = ActiveQuot; }
        }
        //Order L2
        void calOrderL2()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);
                    ((Button)this.Controls["S2" + i + j]).Text = OrderS.Rows[0][0].ToString();
                 //   sumOL2 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S2" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S2" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                ((Button)this.Controls["K2" + i]).Text = OrderB.Rows[0][0].ToString();
              //  sumOL2 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K2" + i]).Text.Equals("0")) { ((Button)this.Controls["K2" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L2.Text, "0", "0");
            L2.Text = OrderL.Rows[0][0].ToString();
          //  sumOL2 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L2.Text.Equals("0")) { L2.BackColor = ActiveQuot; }
        }
        //Order L3
        void calOrderL3()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);
                    ((Button)this.Controls["S3" + i + j]).Text = OrderS.Rows[0][0].ToString();
                 //   sumOL3 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S3" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S3" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                ((Button)this.Controls["K3" + i]).Text = OrderB.Rows[0][0].ToString();
            //    sumOL3 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K3" + i]).Text.Equals("0")) { ((Button)this.Controls["K3" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L3.Text, "0", "0");
            L3.Text = OrderL.Rows[0][0].ToString();
         //   sumOL3 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L3.Text.Equals("0")) { L3.BackColor = ActiveQuot; }
        }
        //Order L5
        void calOrderL5()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);
                    ((Button)this.Controls["S5" + i + j]).Text = OrderS.Rows[0][0].ToString();
                 //   sumOL5 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S5" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S5" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                ((Button)this.Controls["K5" + i]).Text = OrderB.Rows[0][0].ToString();
            //    sumOL5 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K5" + i]).Text.Equals("0")) { ((Button)this.Controls["K5" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L5.Text, "0", "0");
            L5.Text = OrderL.Rows[0][0].ToString();
          //  sumOL5 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L5.Text.Equals("0")) { L5.BackColor = ActiveQuot; }
        }
        //Order L6
        void calOrderL6()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);
                    ((Button)this.Controls["S6" + i + j]).Text = OrderS.Rows[0][0].ToString();
               //     sumOL6 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S6" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S6" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                ((Button)this.Controls["K6" + i]).Text = OrderB.Rows[0][0].ToString();
            //    sumOL6 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K6" + i]).Text.Equals("0")) { ((Button)this.Controls["K6" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L6.Text, "0", "0");
            L6.Text = OrderL.Rows[0][0].ToString();
         //   sumOL6 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L6.Text.Equals("0")) { L6.BackColor = ActiveQuot; }
        }
        //Order L7
        void calOrderL7()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);
                    ((Button)this.Controls["S7" + i + j]).Text = OrderS.Rows[0][0].ToString();
              //      sumOL7 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S7" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S7" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                ((Button)this.Controls["K7" + i]).Text = OrderB.Rows[0][0].ToString();
              //  sumOL7 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K7" + i]).Text.Equals("0")) { ((Button)this.Controls["K7" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L7.Text, "0", "0");
            L7.Text = OrderL.Rows[0][0].ToString();
         //   sumOL7 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L7.Text.Equals("0")) { L7.BackColor = ActiveQuot; }
        }
        //Order L8
        void calOrderL8()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);
                    ((Button)this.Controls["S8" + i + j]).Text = OrderS.Rows[0][0].ToString();
                //    sumOL8 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S8" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S8" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                ((Button)this.Controls["K8" + i]).Text = OrderB.Rows[0][0].ToString();
             //   sumOL8 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K8" + i]).Text.Equals("0")) { ((Button)this.Controls["K8" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L8.Text, "0", "0");
            L8.Text = OrderL.Rows[0][0].ToString();
         //   sumOL8 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L8.Text.Equals("0")) { L8.BackColor = ActiveQuot; }
        }
        //Order L9
        void calOrderL9()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);
                    ((Button)this.Controls["S9" + i + j]).Text = OrderS.Rows[0][0].ToString();
                  //  sumOL9 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S9" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S9" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                ((Button)this.Controls["K9" + i]).Text = OrderB.Rows[0][0].ToString();
               // sumOL9 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K9" + i]).Text.Equals("0")) { ((Button)this.Controls["K9" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L9.Text, "0", "0");
            L9.Text = OrderL.Rows[0][0].ToString();
          //  sumOL9 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L9.Text.Equals("0")) { L9.BackColor = ActiveQuot; }
        }
        //Order L10
        void calOrderL10()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);
                    ((Button)this.Controls["S10" + i + j]).Text = OrderS.Rows[0][0].ToString();
                //    sumOL10 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S10" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S10" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                ((Button)this.Controls["K10" + i]).Text = OrderB.Rows[0][0].ToString();
              //  sumOL10 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K10" + i]).Text.Equals("0")) { ((Button)this.Controls["K10" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L10.Text, "0", "0");
            L10.Text = OrderL.Rows[0][0].ToString();
         //   sumOL10 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L10.Text.Equals("0")) { L10.BackColor = ActiveQuot; }
        }
        //Order L11
        void calOrderL11()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);
                    ((Button)this.Controls["S11" + i + j]).Text = OrderS.Rows[0][0].ToString();
                //    sumOL11 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S11" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S11" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                ((Button)this.Controls["K11" + i]).Text = OrderB.Rows[0][0].ToString();
               // sumOL11 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K11" + i]).Text.Equals("0")) { ((Button)this.Controls["K11" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L11.Text, "0", "0");
            L11.Text = OrderL.Rows[0][0].ToString();
          //  sumOL11 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L11.Text.Equals("0")) { L11.BackColor = ActiveQuot; }
        }
        //Order L12
        void calOrderL12()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);
                    ((Button)this.Controls["S12" + i + j]).Text = OrderS.Rows[0][0].ToString();
                 //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["S12" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S12" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                ((Button)this.Controls["K12" + i]).Text = OrderB.Rows[0][0].ToString();
               // sumOL12 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["K12" + i]).Text.Equals("0")) { ((Button)this.Controls["K12" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable OrderL = ClassReports.selectorder(L12.Text, "0", "0");
            L12.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!L12.Text.Equals("0")) { L12.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order LHJ

        void calOrderLHJ()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kj" + i + j]).Text = OrderS.Rows[0][0].ToString();
                    //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kj" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kj" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(LHJ.Text, "kj" + i.ToString(), "0");
                ((Button)this.Controls["kj" + i]).Text = OrderB.Rows[0][0].ToString();
                // sumOL12 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kj" + i]).Text.Equals("0")) { ((Button)this.Controls["kj" + i]).BackColor = ActiveQuot; }
                
            }
            DataTable OrderL = ClassReports.selectorder(LHJ.Text, "0", "0");
            LHJ.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!LHJ.Text.Equals("0")) { LHJ.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order LL
        void calOrderLL()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kl" + i + j]).Text = OrderS.Rows[0][0].ToString();
                    //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kl" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kl" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(LL.Text, "kl" + i.ToString(), "0");
                ((Button)this.Controls["kl" + i]).Text = OrderB.Rows[0][0].ToString();
                // sumOL12 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kl" + i]).Text.Equals("0")) { ((Button)this.Controls["kl" + i]).BackColor = ActiveQuot; }

            }
            DataTable OrderL = ClassReports.selectorder(LL.Text, "0", "0");
            LL.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!LL.Text.Equals("0")) { LL.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order LD
        void calOrderLD()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kd" + i + j]).Text = OrderS.Rows[0][0].ToString();
                    //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["kd" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kd" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable OrderB = ClassReports.selectorder(LD.Text, "kd" + i.ToString(), "0");
                ((Button)this.Controls["kd" + i]).Text = OrderB.Rows[0][0].ToString();
                // sumOL12 += int.Parse(OrderB.Rows[0][0].ToString());
                if (!((Button)this.Controls["kd" + i]).Text.Equals("0")) { ((Button)this.Controls["kd" + i]).BackColor = ActiveQuot; }

            }
            DataTable OrderL = ClassReports.selectorder(LD.Text, "0", "0");
            LD.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!LD.Text.Equals("0")) { LD.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f1
        void calOrderf1()
        {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable OrderS = ClassReports.selectorder(f1.Text, "fs1" + j.ToString(), "0");
                    ((Button)this.Controls["fs1" + j]).Text = OrderS.Rows[0][0].ToString();
                    //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                    if (!((Button)this.Controls["fs1" + j]).Text.Equals("0")) { ((Button)this.Controls["fs1" + j]).BackColor = ActiveQuot; }
                }

            
            DataTable OrderL = ClassReports.selectorder(f1.Text, "0", "0");
            f1.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f1.Text.Equals("0")) { f1.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f2
        void calOrderf2()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f2.Text, "fs2" + j.ToString(), "0");
                ((Button)this.Controls["fs2" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs2" + j]).Text.Equals("0")) { ((Button)this.Controls["fs2" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f2.Text, "0", "0");
            f2.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f2.Text.Equals("0")) { f2.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f3
        void calOrderf3()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f3.Text, "fs3" + j.ToString(), "0");
                ((Button)this.Controls["fs3" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs3" + j]).Text.Equals("0")) { ((Button)this.Controls["fs3" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f3.Text, "0", "0");
            f3.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f3.Text.Equals("0")) { f3.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f4
        void calOrderf4()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f4.Text, "fs4" + j.ToString(), "0");
                ((Button)this.Controls["fs4" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs4" + j]).Text.Equals("0")) { ((Button)this.Controls["fs4" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f4.Text, "0", "0");
            f4.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f4.Text.Equals("0")) { f4.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f5
        void calOrderf5()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f5.Text, "fs5" + j.ToString(), "0");
                ((Button)this.Controls["fs5" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs5" + j]).Text.Equals("0")) { ((Button)this.Controls["fs5" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f5.Text, "0", "0");
            f5.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f5.Text.Equals("0")) { f5.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f6
        void calOrderf6()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f6.Text, "fs6" + j.ToString(), "0");
                ((Button)this.Controls["fs6" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs6" + j]).Text.Equals("0")) { ((Button)this.Controls["fs6" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f6.Text, "0", "0");
            f6.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f6.Text.Equals("0")) { f6.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f7
        void calOrderf7()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f7.Text, "fs7" + j.ToString(), "0");
                ((Button)this.Controls["fs7" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs7" + j]).Text.Equals("0")) { ((Button)this.Controls["fs7" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f7.Text, "0", "0");
            f7.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f7.Text.Equals("0")) { f7.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f8
        void calOrderf8()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f8.Text, "fs8" + j.ToString(), "0");
                ((Button)this.Controls["fs8" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs8" + j]).Text.Equals("0")) { ((Button)this.Controls["fs8" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f8.Text, "0", "0");
            f8.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f8.Text.Equals("0")) { f8.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f9
        void calOrderf9()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f9.Text, "fs9" + j.ToString(), "0");
                ((Button)this.Controls["fs9" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs9" + j]).Text.Equals("0")) { ((Button)this.Controls["fs9" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f9.Text, "0", "0");
            f9.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f9.Text.Equals("0")) { f9.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f10
        void calOrderf10()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f10.Text, "fs10" + j.ToString(), "0");
                ((Button)this.Controls["fs10" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs10" + j]).Text.Equals("0")) { ((Button)this.Controls["fs10" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f10.Text, "0", "0");
            f10.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f10.Text.Equals("0")) { f10.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f11
        void calOrderf11()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f11.Text, "fs11" + j.ToString(), "0");
                ((Button)this.Controls["fs11" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs11" + j]).Text.Equals("0")) { ((Button)this.Controls["fs11" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f11.Text, "0", "0");
            f11.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f11.Text.Equals("0")) { f11.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f12
        void calOrderf12()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f12.Text, "fs12" + j.ToString(), "0");
                ((Button)this.Controls["fs12" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs12" + j]).Text.Equals("0")) { ((Button)this.Controls["fs12" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f12.Text, "0", "0");
            f12.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f12.Text.Equals("0")) { f12.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f13
        void calOrderf13()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f13.Text, "fs13" + j.ToString(), "0");
                ((Button)this.Controls["fs13" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs13" + j]).Text.Equals("0")) { ((Button)this.Controls["fs13" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f13.Text, "0", "0");
            f13.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f13.Text.Equals("0")) { f13.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f14
        void calOrderf14()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f14.Text, "fs14" + j.ToString(), "0");
                ((Button)this.Controls["fs14" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs14" + j]).Text.Equals("0")) { ((Button)this.Controls["fs14" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f14.Text, "0", "0");
            f14.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f14.Text.Equals("0")) { f14.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f15
        void calOrderf15()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f15.Text, "fs15" + j.ToString(), "0");
                ((Button)this.Controls["fs15" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs15" + j]).Text.Equals("0")) { ((Button)this.Controls["fs15" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f15.Text, "0", "0");
            f15.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f15.Text.Equals("0")) { f15.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f16
        void calOrderf16()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f16.Text, "fs16" + j.ToString(), "0");
                ((Button)this.Controls["fs16" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs16" + j]).Text.Equals("0")) { ((Button)this.Controls["fs16" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f16.Text, "0", "0");
            f16.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f16.Text.Equals("0")) { f16.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f17
        void calOrderf17()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f17.Text, "fs17" + j.ToString(), "0");
                ((Button)this.Controls["fs17" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs17" + j]).Text.Equals("0")) { ((Button)this.Controls["fs17" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f17.Text, "0", "0");
            f17.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f17.Text.Equals("0")) { f17.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f18
        void calOrderf18()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f18.Text, "fs18" + j.ToString(), "0");
                ((Button)this.Controls["fs18" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs18" + j]).Text.Equals("0")) { ((Button)this.Controls["fs18" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f18.Text, "0", "0");
            f18.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f18.Text.Equals("0")) { f18.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f19
        void calOrderf19()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f19.Text, "fs19" + j.ToString(), "0");
                ((Button)this.Controls["fs19" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs19" + j]).Text.Equals("0")) { ((Button)this.Controls["fs19" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f19.Text, "0", "0");
            f19.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f19.Text.Equals("0")) { f19.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f20
        void calOrderf20()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f20.Text, "fs20" + j.ToString(), "0");
                ((Button)this.Controls["fs20" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs20" + j]).Text.Equals("0")) { ((Button)this.Controls["fs20" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f20.Text, "0", "0");
            f20.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f20.Text.Equals("0")) { f20.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        //Order f21
        void calOrderf21()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable OrderS = ClassReports.selectorder(f21.Text, "fs21" + j.ToString(), "0");
                ((Button)this.Controls["fs21" + j]).Text = OrderS.Rows[0][0].ToString();
                //   sumOL12 += int.Parse(OrderS.Rows[0][0].ToString());
                if (!((Button)this.Controls["fs21" + j]).Text.Equals("0")) { ((Button)this.Controls["fs21" + j]).BackColor = ActiveQuot; }
            }


            DataTable OrderL = ClassReports.selectorder(f21.Text, "0", "0");
            f21.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!f21.Text.Equals("0")) { f21.BackColor = ActiveQuot; }
        }

        //****************************************************************************

        void calOrderp1()
        {
            DataTable OrderL = ClassReports.selectorder(Piece1.Text, "0", "0");
            Piece1.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece1.Text.Equals("0")) { Piece1.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        void calOrderp2()
        {
            DataTable OrderL = ClassReports.selectorder(Piece2.Text, "0", "0");
            Piece2.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece2.Text.Equals("0")) { Piece2.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        void calOrderp3()
        {
            DataTable OrderL = ClassReports.selectorder(Piece3.Text, "0", "0");
            Piece3.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece3.Text.Equals("0")) { Piece3.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        void calOrderp4()
        {
            DataTable OrderL = ClassReports.selectorder(Piece4.Text, "0", "0");
            Piece4.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece4.Text.Equals("0")) { Piece4.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        void calOrderp5()
        {
            DataTable OrderL = ClassReports.selectorder(Piece5.Text, "0", "0");
            Piece5.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece5.Text.Equals("0")) { Piece5.BackColor = ActiveQuot; }
        }

        //****************************************************************************
        void calOrderp6()
        {
            DataTable OrderL = ClassReports.selectorder(Piece6.Text, "0", "0");
            Piece6.Text = OrderL.Rows[0][0].ToString();
            //sumOL12 += int.Parse(OrderL.Rows[0][0].ToString());
            if (!Piece6.Text.Equals("0")) { Piece6.BackColor = ActiveQuot; }
        }

        //****************************************************************************

        //Bill L1
        void calBillL1() 
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L1.Text, ((Button)this.Controls["K1" + i]).Text, ((Button)this.Controls["S1" + i + j]).Text);
                    ((Button)this.Controls["S1" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S1" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S1" + i + j]).BackColor = ActiveQuot; }

                }

                DataTable BillB = ClassReports.selectBill(L1.Text, ((Button)this.Controls["K1" + i]).Text, "0");
                ((Button)this.Controls["K1" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K1" + i]).Text.Equals("0")) { ((Button)this.Controls["K1" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L1.Text, "0", "0");
            L1.Text = BillL.Rows[0][0].ToString();
            if (!L1.Text.Equals("0")) { L1.BackColor = ActiveQuot; }
        }
        //******************
        //Bill L2
        void calBillL2()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L2.Text, ((Button)this.Controls["K2" + i]).Text, ((Button)this.Controls["S2" + i + j]).Text);
                    ((Button)this.Controls["S2" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S2" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S2" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L2.Text, ((Button)this.Controls["K2" + i]).Text, "0");
                ((Button)this.Controls["K2" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K2" + i]).Text.Equals("0")) { ((Button)this.Controls["K2" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L2.Text, "0", "0");
            L2.Text = BillL.Rows[0][0].ToString();
            if (!L2.Text.Equals("0")) { L2.BackColor = ActiveQuot; }
        }
        //**************
        //Bill L3
        void calBillL3()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L3.Text, ((Button)this.Controls["K3" + i]).Text, ((Button)this.Controls["S3" + i + j]).Text);
                    ((Button)this.Controls["S3" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S3" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S3" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L3.Text, ((Button)this.Controls["K3" + i]).Text, "0");
                ((Button)this.Controls["K3" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K3" + i]).Text.Equals("0")) { ((Button)this.Controls["K3" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L3.Text, "0", "0");
            L3.Text = BillL.Rows[0][0].ToString();
            if (!L3.Text.Equals("0")) { L3.BackColor = ActiveQuot; }
        }
        //**************
        //Bill L5
        void calBillL5()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L5.Text, ((Button)this.Controls["K5" + i]).Text, ((Button)this.Controls["S5" + i + j]).Text);
                    ((Button)this.Controls["S5" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S5" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S5" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L5.Text, ((Button)this.Controls["K5" + i]).Text, "0");
                ((Button)this.Controls["K5" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K5" + i]).Text.Equals("0")) { ((Button)this.Controls["K5" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L5.Text, "0", "0");
            L5.Text = BillL.Rows[0][0].ToString();
            if (!L5.Text.Equals("0")) { L5.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L6
        void calBillL6()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L6.Text, ((Button)this.Controls["K6" + i]).Text, ((Button)this.Controls["S6" + i + j]).Text);
                    ((Button)this.Controls["S6" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S6" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S6" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L6.Text, ((Button)this.Controls["K6" + i]).Text, "0");
                ((Button)this.Controls["K6" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K6" + i]).Text.Equals("0")) { ((Button)this.Controls["K6" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L6.Text, "0", "0");
            L6.Text = BillL.Rows[0][0].ToString();
            if (!L6.Text.Equals("0")) { L6.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L7
        void calBillL7()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L7.Text, ((Button)this.Controls["K7" + i]).Text, ((Button)this.Controls["S7" + i + j]).Text);
                    ((Button)this.Controls["S7" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S7" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S7" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L7.Text, ((Button)this.Controls["K7" + i]).Text, "0");
                ((Button)this.Controls["K7" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K7" + i]).Text.Equals("0")) { ((Button)this.Controls["K7" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L7.Text, "0", "0");
            L7.Text = BillL.Rows[0][0].ToString();
            if (!L7.Text.Equals("0")) { L7.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L8
        void calBillL8()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L8.Text, ((Button)this.Controls["K8" + i]).Text, ((Button)this.Controls["S8" + i + j]).Text);
                    ((Button)this.Controls["S8" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S8" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S8" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L8.Text, ((Button)this.Controls["K8" + i]).Text, "0");
                ((Button)this.Controls["K8" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K8" + i]).Text.Equals("0")) { ((Button)this.Controls["K8" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L8.Text, "0", "0");
            L8.Text = BillL.Rows[0][0].ToString();
            if (!L8.Text.Equals("0")) { L8.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L9
        void calBillL9()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L9.Text, ((Button)this.Controls["K9" + i]).Text, ((Button)this.Controls["S9" + i + j]).Text);
                    ((Button)this.Controls["S9" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S9" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S9" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L9.Text, ((Button)this.Controls["K9" + i]).Text, "0");
                ((Button)this.Controls["K9" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K9" + i]).Text.Equals("0")) { ((Button)this.Controls["K9" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L9.Text, "0", "0");
            L9.Text = BillL.Rows[0][0].ToString();
            if (!L9.Text.Equals("0")) { L9.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L10
        void calBillL10()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L10.Text, ((Button)this.Controls["K10" + i]).Text, ((Button)this.Controls["S10" + i + j]).Text);
                    ((Button)this.Controls["S10" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S10" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S10" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L10.Text, ((Button)this.Controls["K10" + i]).Text, "0");
                ((Button)this.Controls["K10" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K10" + i]).Text.Equals("0")) { ((Button)this.Controls["K10" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L10.Text, "0", "0");
            L10.Text = BillL.Rows[0][0].ToString();
            if (!L10.Text.Equals("0")) { L10.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L11
        void calBillL11()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L11.Text, ((Button)this.Controls["K11" + i]).Text, ((Button)this.Controls["S11" + i + j]).Text);
                    ((Button)this.Controls["S11" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S11" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S11" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L11.Text, ((Button)this.Controls["K11" + i]).Text, "0");
                ((Button)this.Controls["K11" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K11" + i]).Text.Equals("0")) { ((Button)this.Controls["K11" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L11.Text, "0", "0");
            L11.Text = BillL.Rows[0][0].ToString();
            if (!L11.Text.Equals("0")) { L11.BackColor = ActiveQuot; }
        }
        //****************
        //Bill L12
        void calBillL12()
        {
            int k = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(L12.Text, ((Button)this.Controls["K12" + i]).Text, ((Button)this.Controls["S12" + i + j]).Text);
                    ((Button)this.Controls["S12" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["S12" + i + j]).Text.Equals("0")) { ((Button)this.Controls["S12" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(L12.Text, ((Button)this.Controls["K12" + i]).Text, "0");
                ((Button)this.Controls["K12" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["K12" + i]).Text.Equals("0")) { ((Button)this.Controls["K12" + i]).BackColor = ActiveQuot; }
                k += 4;
            }
            DataTable BillL = ClassReports.selectBill(L12.Text, "0", "0");
            L12.Text = BillL.Rows[0][0].ToString();
            if (!L12.Text.Equals("0")) { L12.BackColor = ActiveQuot; }
        }
        //******************

        //Bill LHJ
        void calBillLHJ()
        {
            
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(LHJ.Text, "kj" + i.ToString(), "kj" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kj" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["kj" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kj" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(LHJ.Text, "kj" + i.ToString(), "0");
                ((Button)this.Controls["kj" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["kj" + i]).Text.Equals("0")) { ((Button)this.Controls["kj" + i]).BackColor = ActiveQuot; }
                
            }
            DataTable BillL = ClassReports.selectBill(LHJ.Text, "0", "0");
            LHJ.Text = BillL.Rows[0][0].ToString();
            if (!LHJ.Text.Equals("0")) { LHJ.BackColor = ActiveQuot; }
        }
        //******************

        //Bill LL
        void calBillLL()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(LL.Text, "kl" + i.ToString(), "kl" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kl" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["kl" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kl" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(LL.Text, "kl" + i.ToString(), "0");
                ((Button)this.Controls["kl" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["kl" + i]).Text.Equals("0")) { ((Button)this.Controls["kl" + i]).BackColor = ActiveQuot; }

            }
            DataTable BillL = ClassReports.selectBill(LL.Text, "0", "0");
            LL.Text = BillL.Rows[0][0].ToString();
            if (!LL.Text.Equals("0")) { LL.BackColor = ActiveQuot; }
        }
        //******************

        //Bill LD
        void calBillLD()
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(LD.Text, "kd" + i.ToString(), "kd" + i.ToString() + j.ToString());
                    ((Button)this.Controls["kd" + i + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["kd" + i + j]).Text.Equals("0")) { ((Button)this.Controls["kd" + i + j]).BackColor = ActiveQuot; }
                }

                DataTable BillB = ClassReports.selectBill(LD.Text, "kd" + i.ToString(), "0");
                ((Button)this.Controls["kd" + i]).Text = BillB.Rows[0][0].ToString();
                if (!((Button)this.Controls["kd" + i]).Text.Equals("0")) { ((Button)this.Controls["kd" + i]).BackColor = ActiveQuot; }

            }
            DataTable BillL = ClassReports.selectBill(LD.Text, "0", "0");
            LD.Text = BillL.Rows[0][0].ToString();
            if (!LD.Text.Equals("0")) { LD.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f1
        void calBillf1()
        {
                for (int j = 1; j <= 4; j++)
                {
                    DataTable BillS = ClassReports.selectBill(f1.Text, "fs1" + j.ToString(), "0");
                    ((Button)this.Controls["fs1" + j]).Text = BillS.Rows[0][0].ToString();
                    if (!((Button)this.Controls["fs1" + j]).Text.Equals("0")) { ((Button)this.Controls["fs1" + j]).BackColor = ActiveQuot; }
                }

            
            DataTable BillL = ClassReports.selectBill(f1.Text, "0", "0");
            f1.Text = BillL.Rows[0][0].ToString();
            if (!f1.Text.Equals("0")) { f1.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f2
        void calBillf2()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f2.Text, "fs2" + j.ToString(), "0");
                ((Button)this.Controls["fs2" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs2" + j]).Text.Equals("0")) { ((Button)this.Controls["fs2" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f2.Text, "0", "0");
            f2.Text = BillL.Rows[0][0].ToString();
            if (!f2.Text.Equals("0")) { f2.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f3
        void calBillf3()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f3.Text, "fs3" + j.ToString(), "0");
                ((Button)this.Controls["fs3" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs3" + j]).Text.Equals("0")) { ((Button)this.Controls["fs3" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f3.Text, "0", "0");
            f3.Text = BillL.Rows[0][0].ToString();
            if (!f3.Text.Equals("0")) { f3.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f4
        void calBillf4()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f4.Text, "fs4" + j.ToString(), "0");
                ((Button)this.Controls["fs4" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs4" + j]).Text.Equals("0")) { ((Button)this.Controls["fs4" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f4.Text, "0", "0");
            f4.Text = BillL.Rows[0][0].ToString();
            if (!f4.Text.Equals("0")) { f4.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f5
        void calBillf5()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f5.Text, "fs5" + j.ToString(), "0");
                ((Button)this.Controls["fs5" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs5" + j]).Text.Equals("0")) { ((Button)this.Controls["fs5" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f5.Text, "0", "0");
            f5.Text = BillL.Rows[0][0].ToString();
            if (!f5.Text.Equals("0")) { f5.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f6
        void calBillf6()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f6.Text, "fs6" + j.ToString(), "0");
                ((Button)this.Controls["fs6" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs6" + j]).Text.Equals("0")) { ((Button)this.Controls["fs6" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f6.Text, "0", "0");
            f6.Text = BillL.Rows[0][0].ToString();
            if (!f6.Text.Equals("0")) { f6.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f7
        void calBillf7()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f7.Text, "fs7" + j.ToString(), "0");
                ((Button)this.Controls["fs7" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs7" + j]).Text.Equals("0")) { ((Button)this.Controls["fs7" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f7.Text, "0", "0");
            f7.Text = BillL.Rows[0][0].ToString();
            if (!f7.Text.Equals("0")) { f7.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f8
        void calBillf8()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f8.Text, "fs8" + j.ToString(), "0");
                ((Button)this.Controls["fs8" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs8" + j]).Text.Equals("0")) { ((Button)this.Controls["fs8" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f8.Text, "0", "0");
            f8.Text = BillL.Rows[0][0].ToString();
            if (!f8.Text.Equals("0")) { f8.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f9
        void calBillf9()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f9.Text, "fs9" + j.ToString(), "0");
                ((Button)this.Controls["fs9" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs9" + j]).Text.Equals("0")) { ((Button)this.Controls["fs9" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f9.Text, "0", "0");
            f9.Text = BillL.Rows[0][0].ToString();
            if (!f9.Text.Equals("0")) { f9.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f10
        void calBillf10()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f10.Text, "fs10" + j.ToString(), "0");
                ((Button)this.Controls["fs10" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs10" + j]).Text.Equals("0")) { ((Button)this.Controls["fs10" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f10.Text, "0", "0");
            f10.Text = BillL.Rows[0][0].ToString();
            if (!f10.Text.Equals("0")) { f10.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f11
        void calBillf11()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f11.Text, "fs11" + j.ToString(), "0");
                ((Button)this.Controls["fs11" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs11" + j]).Text.Equals("0")) { ((Button)this.Controls["fs11" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f11.Text, "0", "0");
            f11.Text = BillL.Rows[0][0].ToString();
            if (!f11.Text.Equals("0")) { f11.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f12
        void calBillf12()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f12.Text, "fs12" + j.ToString(), "0");
                ((Button)this.Controls["fs12" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs12" + j]).Text.Equals("0")) { ((Button)this.Controls["fs12" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f12.Text, "0", "0");
            f12.Text = BillL.Rows[0][0].ToString();
            if (!f12.Text.Equals("0")) { f12.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f13
        void calBillf13()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f13.Text, "fs13" + j.ToString(), "0");
                ((Button)this.Controls["fs13" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs13" + j]).Text.Equals("0")) { ((Button)this.Controls["fs13" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f13.Text, "0", "0");
            f13.Text = BillL.Rows[0][0].ToString();
            if (!f13.Text.Equals("0")) { f13.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f14
        void calBillf14()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f14.Text, "fs14" + j.ToString(), "0");
                ((Button)this.Controls["fs14" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs14" + j]).Text.Equals("0")) { ((Button)this.Controls["fs14" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f14.Text, "0", "0");
            f14.Text = BillL.Rows[0][0].ToString();
            if (!f14.Text.Equals("0")) { f14.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f15
        void calBillf15()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f15.Text, "fs15" + j.ToString(), "0");
                ((Button)this.Controls["fs15" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs15" + j]).Text.Equals("0")) { ((Button)this.Controls["fs15" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f15.Text, "0", "0");
            f15.Text = BillL.Rows[0][0].ToString();
            if (!f15.Text.Equals("0")) { f15.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f16
        void calBillf16()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f16.Text, "fs16" + j.ToString(), "0");
                ((Button)this.Controls["fs16" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs16" + j]).Text.Equals("0")) { ((Button)this.Controls["fs16" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f16.Text, "0", "0");
            f16.Text = BillL.Rows[0][0].ToString();
            if (!f16.Text.Equals("0")) { f16.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f17
        void calBillf17()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f17.Text, "fs17" + j.ToString(), "0");
                ((Button)this.Controls["fs17" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs17" + j]).Text.Equals("0")) { ((Button)this.Controls["fs17" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f17.Text, "0", "0");
            f17.Text = BillL.Rows[0][0].ToString();
            if (!f17.Text.Equals("0")) { f17.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f18
        void calBillf18()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f18.Text, "fs18" + j.ToString(), "0");
                ((Button)this.Controls["fs18" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs18" + j]).Text.Equals("0")) { ((Button)this.Controls["fs18" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f18.Text, "0", "0");
            f18.Text = BillL.Rows[0][0].ToString();
            if (!f18.Text.Equals("0")) { f18.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f19
        void calBillf19()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f19.Text, "fs19" + j.ToString(), "0");
                ((Button)this.Controls["fs19" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs19" + j]).Text.Equals("0")) { ((Button)this.Controls["fs19" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f19.Text, "0", "0");
            f19.Text = BillL.Rows[0][0].ToString();
            if (!f19.Text.Equals("0")) { f19.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f20
        void calBillf20()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f20.Text, "fs20" + j.ToString(), "0");
                ((Button)this.Controls["fs20" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs20" + j]).Text.Equals("0")) { ((Button)this.Controls["fs20" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f20.Text, "0", "0");
            f20.Text = BillL.Rows[0][0].ToString();
            if (!f20.Text.Equals("0")) { f20.BackColor = ActiveQuot; }
        }
        //******************

        //Bill f21
        void calBillf21()
        {
            for (int j = 1; j <= 4; j++)
            {
                DataTable BillS = ClassReports.selectBill(f20.Text, "fs21" + j.ToString(), "0");
                ((Button)this.Controls["fs21" + j]).Text = BillS.Rows[0][0].ToString();
                if (!((Button)this.Controls["fs21" + j]).Text.Equals("0")) { ((Button)this.Controls["fs21" + j]).BackColor = ActiveQuot; }
            }


            DataTable BillL = ClassReports.selectBill(f21.Text, "0", "0");
            f21.Text = BillL.Rows[0][0].ToString();
            if (!f21.Text.Equals("0")) { f21.BackColor = ActiveQuot; }
        }
        //******************

        void calBillp1()
        {
            DataTable BillL = ClassReports.selectBill(Piece1.Text, "0", "0");
            Piece1.Text = BillL.Rows[0][0].ToString();
            if (!Piece1.Text.Equals("0")) { Piece1.BackColor = ActiveQuot; }
        }
        //******************
        void calBillp2()
        {
            DataTable BillL = ClassReports.selectBill(Piece2.Text, "0", "0");
            Piece2.Text = BillL.Rows[0][0].ToString();
            if (!Piece2.Text.Equals("0")) { Piece2.BackColor = ActiveQuot; }
        }
        //******************
        void calBillp3()
        {
            DataTable BillL = ClassReports.selectBill(Piece3.Text, "0", "0");
            Piece3.Text = BillL.Rows[0][0].ToString();
            if (!Piece3.Text.Equals("0")) { Piece3.BackColor = ActiveQuot; }
        }
        //******************
        void calBillp4()
        {
            DataTable BillL = ClassReports.selectBill(Piece4.Text, "0", "0");
            Piece4.Text = BillL.Rows[0][0].ToString();
            if (!Piece4.Text.Equals("0")) { Piece4.BackColor = ActiveQuot; }
        }
        //******************
        void calBillp5()
        {
            DataTable BillL = ClassReports.selectBill(Piece5.Text, "0", "0");
            Piece5.Text = BillL.Rows[0][0].ToString();
            if (!Piece5.Text.Equals("0")) { Piece5.BackColor = ActiveQuot; }
        }
        //******************
        void calBillp6()
        {
            DataTable BillL = ClassReports.selectBill(Piece6.Text, "0", "0");
            Piece6.Text = BillL.Rows[0][0].ToString();
            if (!Piece6.Text.Equals("0")) { Piece6.BackColor = ActiveQuot; }
        }
        //******************


        void nameAllItemsL1() 
        {
            int k = 0;
            // put names for L1  **********************
            L1.Text = Bri.Rows[1-1][1].ToString();
            L1.BackColor = BrigadeCol;

            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(L1, "اللواء الاول");

            for (int i = 1; i <= 7; i++)
            {
                ((Button)this.Controls["K1" + i]).Text = BriBat.Rows[i-1][1].ToString();
                ((Button)this.Controls["K1" + i]).BackColor = BattalionCol;

                ToolTip ToolTipK = new ToolTip();
                ToolTipK.SetToolTip(((Button)this.Controls["K1" + i]), ((Button)this.Controls["K1" + i]).Name);

                for (int j = 0; j < 4; j++)
                {
                    ((Button)this.Controls["S1"+i + j]).Text = BriSaraya.Rows[j+k][1].ToString();
                    ((Button)this.Controls["S1" + i + j]).BackColor = Sarayacol;

                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["S1" + i + j]), ((Button)this.Controls["S1" + i + j]).Name);
                    
                }
                k += 4;
            }
            //*******************************
            

        }
        void nameAllItemsL2()
        {
            int k = 28;
            int s = 7;
            // put names for L1  **********************
            L2.Text = Bri.Rows[2-1][1].ToString();
            L2.BackColor = BrigadeCol;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(L2, "اللواء الثاني");

            for (int i = 1; i <= 7; i++)
            {
                ((Button)this.Controls["K2" + i]).Text = BriBat.Rows[i+s - 1][1].ToString();
                ((Button)this.Controls["K2" + i]).BackColor = BattalionCol;
                ToolTip ToolTipK = new ToolTip();
                ToolTipK.SetToolTip(((Button)this.Controls["K2" + i]), ((Button)this.Controls["K2" + i]).Name);
                for (int j = 0; j < 4; j++)
                {
                    ((Button)this.Controls["S2" + i + j]).Text = BriSaraya.Rows[j+k][1].ToString();
                    ((Button)this.Controls["S2" + i + j]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["S2" + i + j]), ((Button)this.Controls["S2" + i + j]).Name);
                }
                k += 4;
            }
          
        }

        //*******************************

        void nameAllItemsL3()
        {
            int k = 28*2;
            int s = 2*7;
            // put names for L1  **********************
            L3.Text = Bri.Rows[3-1][1].ToString();
            L3.BackColor = BrigadeCol;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(L3, "اللواء الثالث");
            for (int i = 1; i <= 7; i++)
            {
                ((Button)this.Controls["K3" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                ((Button)this.Controls["K3" + i]).BackColor = BattalionCol;
                ToolTip ToolTipK = new ToolTip();
                ToolTipK.SetToolTip(((Button)this.Controls["K3" + i]), ((Button)this.Controls["K3" + i]).Name);
                for (int j = 0; j < 4; j++)
                {
                    ((Button)this.Controls["S3" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                    ((Button)this.Controls["S3" + i + j]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["S3" + i + j]), ((Button)this.Controls["S3" + i + j]).Name);

                }
                k += 4;
            }
            //*******************************


        }
        void nameAllItemsL5()
        {
            int k = 28 * 3;
            int s = 3 * 7;
            // put names for L1  **********************
            L5.Text = Bri.Rows[4 - 1][1].ToString();
            L5.BackColor = BrigadeCol;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(L5, "اللواء الخامس");
            for (int i = 1; i <= 7; i++)
            {
                ((Button)this.Controls["K5" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                ((Button)this.Controls["K5" + i]).BackColor = BattalionCol;
                ToolTip ToolTipK = new ToolTip();
                ToolTipK.SetToolTip(((Button)this.Controls["K5" + i]), ((Button)this.Controls["K5" + i]).Name);
                for (int j = 0; j < 4; j++)
                {
                    ((Button)this.Controls["S5" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                    ((Button)this.Controls["S5" + i + j]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["S5" + i + j]), ((Button)this.Controls["S5" + i + j]).Name);

                }
                k += 4;
            }
        }
            //*******************************
            void nameAllItemsL6()
        {
            int k = 28 * 4;
            int s = 4 * 7;
            // put names for L1  **********************
            L6.Text = Bri.Rows[5 - 1][1].ToString();
            L6.BackColor = BrigadeCol;
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(L6, "اللواء السادس");
            for (int i = 1; i <= 7; i++)
            {
                ((Button)this.Controls["K6" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                ((Button)this.Controls["K6" + i]).BackColor = BattalionCol;
                ToolTip ToolTipK = new ToolTip();
                ToolTipK.SetToolTip(((Button)this.Controls["K6" + i]), ((Button)this.Controls["K6" + i]).Name);
                for (int j = 0; j < 4; j++)
                {
                    ((Button)this.Controls["S6" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                    ((Button)this.Controls["S6" + i + j]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["S6" + i + j]), ((Button)this.Controls["S6" + i + j]).Name);

                }
                k += 4;
            }
            //*******************************

        }
            void nameAllItemsL7()
            {
                int k = 28 * 5;
                int s = 5 * 7;
                // put names for L1  **********************
                L7.Text = Bri.Rows[6 - 1][1].ToString();
                L7.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L1, "اللواء السابع");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K7" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K7" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K7" + i]), ((Button)this.Controls["K7" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S7" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S7" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S7" + i + j]), ((Button)this.Controls["S7" + i + j]).Name);

                    }
                    k += 4;
                }
                //*******************************

            }
            void nameAllItemsL8()
            {
                int k = 28 * 6;
                int s = 6 * 7;
                // put names for L1  **********************
                L8.Text = Bri.Rows[7 - 1][1].ToString();
                L8.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L1, "اللواء الثامن");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K8" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K8" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K8" + i]), ((Button)this.Controls["K8" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S8" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S8" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S8" + i + j]), ((Button)this.Controls["S8" + i + j]).Name);

                    }
                    k += 4;
                }
                //*******************************

            }
            void nameAllItemsL9()
            {
                int k = 28 * 7;
                int s = 7 * 7;
                // put names for L1  **********************
                L9.Text = Bri.Rows[8 - 1][1].ToString();
                L9.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L9, "اللواء التاسع");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K9" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K9" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K9" + i]), ((Button)this.Controls["K9" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S9" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S9" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S9" + i + j]), ((Button)this.Controls["S9" + i + j]).Name);

                    }
                    k += 4;
                }
                //*******************************

            }
            void nameAllItemsL10()
            {
                int k = 28 * 8;
                int s = 8 * 7;
                // put names for L1  **********************
                L10.Text = Bri.Rows[9 - 1][1].ToString();
                L10.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L10, "اللواء العاشر");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K10" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K10" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K10" + i]), ((Button)this.Controls["K10" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S10" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S10" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S10" + i + j]), ((Button)this.Controls["S10" + i + j]).Name);

                    }
                    k += 4;
                }
                //*******************************

            }
            void nameAllItemsL11()
            {
                int k = 28 * 9;
                int s = 9 * 7;
                // put names for L1  **********************
                L11.Text = Bri.Rows[10 - 1][1].ToString();
                L11.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L11, "اللواء الحادي عشر");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K11" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K11" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K11" + i]), ((Button)this.Controls["K11" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S11" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S11" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S11" + i + j]), ((Button)this.Controls["S11" + i + j]).Name);

                    }
                    k += 4;
                }
                //*******************************

            }
            void nameAllItemsL12()
            {
                int k = 28 * 10;
                int s = 10 * 7;
                // put names for L1  **********************
                L12.Text = Bri.Rows[11 - 1][1].ToString();
                L12.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(L12, "اللواء الثاني عشر");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["K12" + i]).Text = BriBat.Rows[i + s - 1][1].ToString();
                    ((Button)this.Controls["K12" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["K12" + i]), ((Button)this.Controls["K12" + i]).Name);
                    for (int j = 0; j < 4; j++)
                    {
                        ((Button)this.Controls["S12" + i + j]).Text = BriSaraya.Rows[j + k][1].ToString();
                        ((Button)this.Controls["S12" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["S12" + i + j]), ((Button)this.Controls["S12" + i + j]).Name);

                    }
                    k += 4;
                }
            }
            //*******************************

            void nameAllItemsLHJ()
            {
                // put names for L1  **********************
                LHJ.Text = "لواء الحرس الجمهوري";
                LHJ.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(LHJ, "لواء الحرس الجمهوري");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["kj" + i]).Text = "k" + i.ToString();
                    ((Button)this.Controls["kj" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["kj" + i]), "k" + i.ToString());
                    for (int j = 1; j <= 4; j++)
                    {
                        ((Button)this.Controls["kj" + i + j]).Text = "s" + j.ToString();
                        ((Button)this.Controls["kj" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["kj" + i + j]), "s" + j.ToString());

                    }
                }
            }
            //*******************************

            void nameAllItemsLL()
            {
                // put names for L1  **********************
                LL.Text = "اللواء اللوجستي";
                LL.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(LL, "اللواء اللوجستي");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["kl" + i]).Text = "k" + i.ToString();
                    ((Button)this.Controls["kl" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["kl" + i]), "k" + i.ToString());
                    for (int j = 1; j <= 4; j++)
                    {
                        ((Button)this.Controls["kl" + i + j]).Text = "s" + j.ToString();
                        ((Button)this.Controls["kl" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["kl" + i + j]), "s" + j.ToString());

                    }
                }
            }
            //*******************************

            void nameAllItemsLD()
            {
                // put names for L1  **********************
                LD.Text = "لواء الدعم";
                LD.BackColor = BrigadeCol;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(LD, "لواء الدعم");
                for (int i = 1; i <= 7; i++)
                {
                    ((Button)this.Controls["kd" + i]).Text = "k" + i.ToString();
                    ((Button)this.Controls["kd" + i]).BackColor = BattalionCol;
                    ToolTip ToolTipK = new ToolTip();
                    ToolTipK.SetToolTip(((Button)this.Controls["kd" + i]), "k" + i.ToString());
                    for (int j = 1; j <= 4; j++)
                    {
                        ((Button)this.Controls["kd" + i + j]).Text = "s" + j.ToString();
                        ((Button)this.Controls["kd" + i + j]).BackColor = Sarayacol;
                        ToolTip ToolTipS = new ToolTip();
                        ToolTipS.SetToolTip(((Button)this.Controls["kd" + i + j]), "s" + j.ToString());

                    }
                }
            }
            //*******************************
            //Regiments names

            void f1name() 
            {
                f1.Text = "فوج التدخل الاول";
                f1.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f1, "فوج التدخل الاول");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs1" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs1" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs1" + i]), "s" + i.ToString());
                }
            }
        //*******************************
            void f2name()
            {
                f2.Text = "فوج التدخل الثاني";
                f2.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f2, "فوج التدخل الثاني");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs2" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs2" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs2" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f3name()
            {
                f3.Text = "فوج التدخل الثالث";
                f3.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f3, "فوج التدخل الثالث");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs3" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs3" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs3" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f4name()
            {
                f4.Text = "فوج التدخل الرابع";
                f4.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f4, "فوج التدخل الرابع");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs4" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs4" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs4" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f5name()
            {
                f5.Text = "فوج التدخل الخامس";
                f5.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f5, "فوج التدخل الخامس");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs5" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs5" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs5" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f6name()
            {
                f6.Text = "فوج التدخل السادس";
                f6.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f6, "فوج التدخل السادس");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs6" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs6" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs6" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f7name()
            {
                f7.Text = "فوج المضاد للدروع";
                f7.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f7, "فوج المضاد للدروع");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs7" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs7" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs7" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f8name()
            {
                f8.Text = "فوج الاشارة";
                f8.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f8, "فوج الاشارة");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs8" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs8" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs8" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f9name()
            {
                f9.Text = "فوج الاشغال المستقل";
                f9.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f9, "فوج الاشغال المستقل");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs9" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs9" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs9" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f10name()
            {
                f10.Text = "فوج النقل";
                f10.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f10, "فوج النقل");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs10" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs10" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs10" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f11name()
            {
                f11.Text = "فوج الحدود البرية الاول";
                f11.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f11, "فوج الحدود البرية الاول");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs11" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs11" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs11" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f12name()
            {
                f12.Text = "فوج الحدود البرية الثاني";
                f12.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f12, "فوج الحدود البرية الثاني");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs12" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs12" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs12" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f13name()
            {
                f13.Text = "فوج الحدود البرية الثالث";
                f13.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f13, "فوج الحدود البرية الثالث");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs13" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs13" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs13" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f14name()
            {
                f14.Text = "فوج الحدود البرية الرابع";
                f14.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f14, "فوج الحدود البرية الرابع");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs14" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs14" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs14" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f15name()
            {
                f15.Text = "فوج المجوقل";
                f15.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f15, "فوج المجوقل");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs15" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs15" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs15" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f16name()
            {
                f16.Text = "فوج المدرعات الاول";
                f16.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f16, "فوج المدرعات الاول");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs16" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs16" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs16" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f17name()
            {
                f17.Text = "فوج المدفعية الاول";
                f17.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f17, "فوج المدفعية الاول");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs17" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs17" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs17" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f18name()
            {
                f18.Text = "فوج المدفعية الثاني";
                f18.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f18, "فوج المدفعية الثاني");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs18" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs18" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs18" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f19name()
            {
                f19.Text = "فوج  الهندسة";
                f19.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f19, "فوج  الهندسة");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs19" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs19" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs19" + i]), "s" + i.ToString());
                }
            }
            //*******************************
            void f20name()
            {
                f20.Text = "فوج  مغاوير البحر";
                f20.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f20, "فوج  مغاوير البحر");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs20" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs20" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs20" + i]), "s" + i.ToString());
                }
            }
            //*******************************
           
        void f21name()
            {
                f21.Text = "فوج  مغاوير البر";
                f21.BackColor = Fog;
                ToolTip ToolTip1 = new ToolTip();
                ToolTip1.SetToolTip(f21, "فوج  مغاوير البر");
                for (int i = 1; i <= 4; i++)
                {
                    ((Button)this.Controls["fs21" + i]).Text = "s" + i.ToString();
                    ((Button)this.Controls["fs21" + i]).BackColor = Sarayacol;
                    ToolTip ToolTipS = new ToolTip();
                    ToolTipS.SetToolTip(((Button)this.Controls["fs21" + i]), "s" + i.ToString());
                }
            }
            //*******************************
        void PiecesName()
        {
            string[] arr = { "القوات البحرية", "الكليات العسكرية", "كتيبة المدافعة و الحماية", "مديريات", "مديرية التوجيه", "مقر عام قيادة الجيش" };
            for (int i = 1; i <= 6; i++) 
            {
                ((Button)this.Controls["Piece" + i]).Text = arr[i-1];
                ((Button)this.Controls["Piece" + i]).BackColor = Fog;
                ToolTip ToolTipS = new ToolTip();
                ToolTipS.SetToolTip(((Button)this.Controls["Piece" + i]), arr[i-1]);
            } 
        }
        //*******************************


        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && L1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void btnnumofQout_Click(object sender, EventArgs e)
        {
            buttonSelectedL1 = btnnumofQout.Text;
            nameAllItemsL1();
            calQoutationL1();
            lb1.Text = "Quotation";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonSelectedL2 = button3.Text;
            nameAllItemsL2();
            calQoutationL2();
            lb2.Text = "Quotation";
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            buttonSelectedL3 = button6.Text;
            nameAllItemsL3();
            calQoutationL3();
            lb3.Text = "Quotation";
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonSelectedL5 = button9.Text;
            nameAllItemsL5();
            calQoutationL5();
            lb5.Text = "Quotation";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonSelectedL6 = button12.Text;
            nameAllItemsL6();
            calQoutationL6();
            lb6.Text = "Quotation";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonSelectedL7 = button15.Text;
            nameAllItemsL7();
            calQoutationL7();
            lb7.Text = "Quotation";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonSelectedL8 = button18.Text;
            nameAllItemsL8();
            calQoutationL8();
            lb8.Text = "Quotation";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonSelectedL9 = button21.Text;
            nameAllItemsL9();
            calQoutationL9();
            lb9.Text = "Quotation";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonSelectedL10 = button24.Text;
            nameAllItemsL10();
            calQoutationL10();
            lb10.Text = "Quotation";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            buttonSelectedL11 = button27.Text;
            nameAllItemsL11();
            calQoutationL11();
            lb11.Text = "Quotation";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            buttonSelectedL12 = button30.Text;
            nameAllItemsL12();
            calQoutationL12();
            lb12.Text = "Quotation";
        }

        private void Btnnumoforder_Click(object sender, EventArgs e)
        {
            buttonSelectedL1 = Btnnumoforder.Text;
            nameAllItemsL1();
            calOrderL1();
            lb1.Text = "Order";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonSelectedL2 = button2.Text;
            nameAllItemsL2();
            calOrderL2();
            lb2.Text = "Order";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonSelectedL3 = button5.Text;
            nameAllItemsL3();
            calOrderL3();
            lb3.Text = "Order";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonSelectedL5 = button8.Text;
            nameAllItemsL5();
            calOrderL5();
            lb5.Text = "Order";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonSelectedL6 = button11.Text;
            nameAllItemsL6();
            calOrderL6();
            lb6.Text = "Order";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonSelectedL7 = button14.Text;
            nameAllItemsL7();
            calOrderL7();
            lb7.Text = "Order";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonSelectedL8 = button17.Text;
            nameAllItemsL8();
            calOrderL8();
            lb8.Text = "Order";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonSelectedL9 = button20.Text;
            nameAllItemsL9();
            calOrderL9();
            lb9.Text = "Order";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonSelectedL10 = button23.Text;
            nameAllItemsL10();
            calOrderL10();
            lb10.Text = "Order";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            buttonSelectedL11 = button26.Text;
            nameAllItemsL11();
            calOrderL11();
            lb11.Text = "Order";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            buttonSelectedL12 = button29.Text;
            nameAllItemsL12();
            calOrderL12();
            lb12.Text = "Order";
        }

        private void BtnNumofbill_Click(object sender, EventArgs e)
        {
            buttonSelectedL1 = BtnNumofbill.Text;
            nameAllItemsL1();
            calBillL1();
            lb1.Text = "Bill";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            buttonSelectedL1 = "CHK";
            if (radioButton1.Checked) 
            {
                nameAllItemsL1();
                NoOrderL1();
                lb1.Text = "No Order";
            }
            else if (radioButton2.Checked) 
            {
                nameAllItemsL1();
                SomeOrderL1();
                lb1.Text = "Some Order";
            }
        }

        private void BtnBacktoname_Click(object sender, EventArgs e)
        {
            namesAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonSelectedL2 = button1.Text;
            nameAllItemsL2();
            calBillL2();
            lb2.Text = "Bill";
        }

        private void K11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K11.Text, "0");
                p.ShowDialog();
            }
        }

        private void K12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K12.Text, "0");
                p.ShowDialog();
            }
        }

        private void K13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K13.Text, "0");
                p.ShowDialog();
            }
        }

        private void K14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K14.Text, "0");
                p.ShowDialog();
            }
        }

        private void K15_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K15.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K15.Text, "0");
                p.ShowDialog();
            }
        }

        private void K16_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K16.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K16.Text, "0");
                p.ShowDialog();
            }
        }

        private void K17_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && K17.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K17.Text, "0");
                p.ShowDialog();
            }
        }

        private void S110_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S110.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K11.Text, S110.Text);
                p.ShowDialog();
            }
        }

        private void S111_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S111.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K11.Text, S111.Text);
                p.ShowDialog();
            }
        }

        private void S112_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S112.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K11.Text, S112.Text);
                p.ShowDialog();
            }
        }

        private void S113_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S113.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K11.Text, S113.Text);
                p.ShowDialog();
            }
        }

        private void S120_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S120.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K12.Text, S120.Text);
                p.ShowDialog();
            }
        }

        private void S121_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S121.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K12.Text, S121.Text);
                p.ShowDialog();
            }
        }

        private void S122_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S122.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K12.Text, S122.Text);
                p.ShowDialog();
            }
        }

        private void S123_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S123.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K12.Text, S123.Text);
                p.ShowDialog();
            }
        }

        private void S130_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S130.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K13.Text, S130.Text);
                p.ShowDialog();
            }
        }

        private void S131_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S131.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K13.Text, S131.Text);
                p.ShowDialog();
            }
        }

        private void S132_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S132.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K13.Text, S132.Text);
                p.ShowDialog();
            }
        }

        private void S133_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S133.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K13.Text, S133.Text);
                p.ShowDialog();
            }
        }

        private void S140_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S140.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K14.Text, S140.Text);
                p.ShowDialog();
            }
        }

        private void S141_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S141.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K14.Text, S141.Text);
                p.ShowDialog();
            }
        }

        private void S142_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S142.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K14.Text, S142.Text);
                p.ShowDialog();
            }
        }

        private void S143_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S143.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K14.Text, S143.Text);
                p.ShowDialog();
            }
        }

        private void S150_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S150.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K15.Text, S150.Text);
                p.ShowDialog();
            }
        }

        private void S151_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S151.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K15.Text, S151.Text);
                p.ShowDialog();
            }
        }

        private void S152_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S152.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K15.Text, S152.Text);
                p.ShowDialog();
            }
        }

        private void S153_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S153.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K15.Text, S153.Text);
                p.ShowDialog();
            }
        }

        private void S160_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S160.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K16.Text, S160.Text);
                p.ShowDialog();
            }
        }

        private void S161_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S161.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K16.Text, S161.Text);
                p.ShowDialog();
            }
        }

        private void S162_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S162.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K16.Text, S162.Text);
                p.ShowDialog();
            }
        }

        private void S163_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S163.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K16.Text, S163.Text);
                p.ShowDialog();
            }
        }

        private void S170_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S170.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K17.Text, S170.Text);
                p.ShowDialog();
            }
        }

        private void S171_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S171.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K17.Text, S171.Text);
                p.ShowDialog();
            }
        }

        private void S172_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S172.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K17.Text, S172.Text);
                p.ShowDialog();
            }
        }

        private void S173_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL1.Equals("CHK") && S173.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L1.Text, K17.Text, S173.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl2_Click(object sender, EventArgs e)
        {
            buttonSelectedL2 = "CHK";
            if (rdNoL2.Checked)
            {
                nameAllItemsL2();
                NoOrderL2();
                lb2.Text = "No Order";
            }
            else if (rdsol2.Checked)
            {
                nameAllItemsL2();
                SomeOrderL2();
                lb2.Text = "Some Order";
            }
        }

        private void L2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && L2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K21.Text, "0");
                p.ShowDialog();
            }
        }

        private void S210_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S210.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K21.Text, S210.Text);
                p.ShowDialog();
            }
        }

        private void S211_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S211.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K21.Text, S211.Text);
                p.ShowDialog();
            }
        }

        private void S212_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S212.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K21.Text, S212.Text);
                p.ShowDialog();
            }
        }

        private void S213_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S213.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K21.Text, S213.Text);
                p.ShowDialog();
            }
        }

        private void K22_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K22.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K22.Text, "0");
                p.ShowDialog();
            }
        }

        private void K23_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K23.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K23.Text, "0");
                p.ShowDialog();
            }
        }

        private void K24_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K24.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K24.Text, "0");
                p.ShowDialog();
            }
        }

        private void K25_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K25.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K25.Text, "0");
                p.ShowDialog();
            }
        }

        private void K26_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K26.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K26.Text, "0");
                p.ShowDialog();
            }
        }

        private void K27_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && K27.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K27.Text, "0");
                p.ShowDialog();
            }
        }

        private void S220_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S220.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K22.Text, S220.Text);
                p.ShowDialog();
            }
        }

        private void S221_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S221.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K22.Text, S221.Text);
                p.ShowDialog();
            }
        }

        private void S222_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S222.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K22.Text, S222.Text);
                p.ShowDialog();
            }
        }

        private void S223_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S223.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K22.Text, S223.Text);
                p.ShowDialog();
            }
        }

        private void S230_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S230.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K23.Text, S230.Text);
                p.ShowDialog();
            }
        }

        private void S231_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S231.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K23.Text, S231.Text);
                p.ShowDialog();
            }
        }

        private void S232_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S232.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K23.Text, S232.Text);
                p.ShowDialog();
            }
        }

        private void S233_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S233.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K23.Text, S233.Text);
                p.ShowDialog();
            }
        }

        private void S240_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S240.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K24.Text, S240.Text);
                p.ShowDialog();
            }
        }

        private void S241_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S241.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K24.Text, S241.Text);
                p.ShowDialog();
            }
        }

        private void S242_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S242.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K24.Text, S242.Text);
                p.ShowDialog();
            }
        }

        private void S243_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S243.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K24.Text, S243.Text);
                p.ShowDialog();
            }
        }

        private void S250_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S250.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K25.Text, S250.Text);
                p.ShowDialog();
            }
        }

        private void S251_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S251.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K25.Text, S251.Text);
                p.ShowDialog();
            }
        }

        private void S252_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S252.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K25.Text, S252.Text);
                p.ShowDialog();
            }
        }

        private void S253_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S253.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K25.Text, S253.Text);
                p.ShowDialog();
            }
        }

        private void S260_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S260.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K26.Text, S260.Text);
                p.ShowDialog();
            }
        }

        private void S261_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S261.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K26.Text, S261.Text);
                p.ShowDialog();
            }
        }

        private void S262_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S262.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K26.Text, S262.Text);
                p.ShowDialog();
            }
        }

        private void S263_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S263.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K26.Text, S263.Text);
                p.ShowDialog();
            }
        }

        private void S270_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S270.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K27.Text, S270.Text);
                p.ShowDialog();
            }
        }

        private void S271_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S271.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K27.Text, S271.Text);
                p.ShowDialog();
            }
        }

        private void S272_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S272.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K27.Text, S272.Text);
                p.ShowDialog();
            }
        }

        private void S273_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL2.Equals("CHK") && S273.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L2.Text, K27.Text, S273.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl3_Click(object sender, EventArgs e)
        {
            buttonSelectedL3 = "CHK";
            if (rdnol3.Checked)
            {
                nameAllItemsL3();
                NoOrderL3();
                lb3.Text = "No Order";
            }
            else if (rdsol3.Checked)
            {
                nameAllItemsL3();
                SomeOrderL3();
                lb3.Text = "Some Order";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonSelectedL3 = button4.Text;
            nameAllItemsL3();
            calBillL3();
            lb3.Text = "Bill";
        }

        private void L3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && L3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K31_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K31.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K31.Text, "0");
                p.ShowDialog();
            }
        }

        private void K32_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K32.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K32.Text, "0");
                p.ShowDialog();
            }
        }

        private void K33_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K33.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K33.Text, "0");
                p.ShowDialog();
            }
        }

        private void K34_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K34.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K34.Text, "0");
                p.ShowDialog();
            }
        }

        private void K35_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K35.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K35.Text, "0");
                p.ShowDialog();
            }
        }

        private void K36_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K36.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K36.Text, "0");
                p.ShowDialog();
            }
        }

        private void K37_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && K37.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K37.Text, "0");
                p.ShowDialog();
            }
        }

        private void S310_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S310.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K31.Text, S310.Text);
                p.ShowDialog();
            }
        }

        private void S311_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S311.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K31.Text, S311.Text);
                p.ShowDialog();
            }
        }

        private void S312_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S312.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K31.Text, S312.Text);
                p.ShowDialog();
            }
        }

        private void S313_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S313.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K31.Text, S313.Text);
                p.ShowDialog();
            }
        }

        private void S320_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S320.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K32.Text, S320.Text);
                p.ShowDialog();
            }
        }

        private void S321_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S321.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K32.Text, S321.Text);
                p.ShowDialog();
            }
        }

        private void S322_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S322.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K32.Text, S322.Text);
                p.ShowDialog();
            }
        }

        private void S323_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S323.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K32.Text, S323.Text);
                p.ShowDialog();
            }
        }

        private void S330_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S330.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K33.Text, S330.Text);
                p.ShowDialog();
            }
        }

        private void S331_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S331.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K33.Text, S331.Text);
                p.ShowDialog();
            }
        }

        private void S332_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S332.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K33.Text, S332.Text);
                p.ShowDialog();
            }
        }

        private void S333_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S333.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K33.Text, S333.Text);
                p.ShowDialog();
            }
        }

        private void S340_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S340.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K34.Text, S340.Text);
                p.ShowDialog();
            }
        }

        private void S341_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S341.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K34.Text, S341.Text);
                p.ShowDialog();
            }
        }

        private void S342_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S342.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K34.Text, S342.Text);
                p.ShowDialog();
            }
        }

        private void S343_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S343.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K34.Text, S343.Text);
                p.ShowDialog();
            }
        }

        private void S350_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S350.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K35.Text, S350.Text);
                p.ShowDialog();
            }
        }

        private void S351_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S351.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K35.Text, S351.Text);
                p.ShowDialog();
            }
        }

        private void S352_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S352.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K35.Text, S352.Text);
                p.ShowDialog();
            }
        }

        private void S353_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S353.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K35.Text, S353.Text);
                p.ShowDialog();
            }
        }

        private void S360_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S360.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K36.Text, S360.Text);
                p.ShowDialog();
            }
        }

        private void S361_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S361.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K36.Text, S361.Text);
                p.ShowDialog();
            }
        }

        private void S362_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S362.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K36.Text, S362.Text);
                p.ShowDialog();
            }
        }

        private void S363_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S363.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K36.Text, S363.Text);
                p.ShowDialog();
            }
        }

        private void S370_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S370.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K37.Text, S370.Text);
                p.ShowDialog();
            }
        }

        private void S371_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S371.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K37.Text, S371.Text);
                p.ShowDialog();
            }
        }

        private void S372_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S372.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K37.Text, S372.Text);
                p.ShowDialog();
            }
        }

        private void S373_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL3.Equals("CHK") && S373.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L3.Text, K37.Text, S373.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl5_Click(object sender, EventArgs e)
        {
            buttonSelectedL5 = "CHK";
            if (rdnol5.Checked)
            {
                nameAllItemsL5();
                NoOrderL5();
                lb5.Text = "No Order";
            }
            else if (rdsol5.Checked)
            {
                nameAllItemsL5();
                SomeOrderL5();
                lb5.Text = "Some Order";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonSelectedL5 = button7.Text;
            nameAllItemsL5();
            calBillL5();
            lb5.Text = "Bill";
        }

        private void L5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && L5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K51_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K51.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K51.Text, "0");
                p.ShowDialog();
            }
        }

        private void K52_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K52.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K52.Text, "0");
                p.ShowDialog();
            }
        }

        private void K53_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K53.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K53.Text, "0");
                p.ShowDialog();
            }
        }

        private void K54_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K54.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K54.Text, "0");
                p.ShowDialog();
            }
        }

        private void K55_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K55.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K55.Text, "0");
                p.ShowDialog();
            }
        }

        private void K56_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K56.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K56.Text, "0");
                p.ShowDialog();
            }
        }

        private void K57_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && K57.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K57.Text, "0");
                p.ShowDialog();
            }
        }

        private void S510_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S510.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K51.Text, S510.Text);
                p.ShowDialog();
            }
        }

        private void S511_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S511.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K51.Text, S511.Text);
                p.ShowDialog();
            }
        }

        private void S512_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S512.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K51.Text, S512.Text);
                p.ShowDialog();
            }
        }

        private void S513_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S513.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K51.Text, S513.Text);
                p.ShowDialog();
            }
        }

        private void S520_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S520.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K52.Text, S520.Text);
                p.ShowDialog();
            }
        }

        private void S521_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S521.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K52.Text, S521.Text);
                p.ShowDialog();
            }
        }

        private void S522_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S522.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K52.Text, S522.Text);
                p.ShowDialog();
            }
        }

        private void S523_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S523.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K52.Text, S523.Text);
                p.ShowDialog();
            }
        }

        private void S530_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S530.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K53.Text, S530.Text);
                p.ShowDialog();
            }
        }

        private void S531_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S531.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K53.Text, S531.Text);
                p.ShowDialog();
            }
        }

        private void S532_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S532.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K53.Text, S532.Text);
                p.ShowDialog();
            }
        }

        private void S533_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S533.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K53.Text, S533.Text);
                p.ShowDialog();
            }
        }

        private void S540_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S540.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K54.Text, S540.Text);
                p.ShowDialog();
            }
        }

        private void S541_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S541.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K54.Text, S541.Text);
                p.ShowDialog();
            }
        }

        private void S542_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S542.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K54.Text, S542.Text);
                p.ShowDialog();
            }
        }

        private void S543_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S543.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K54.Text, S543.Text);
                p.ShowDialog();
            }
        }

        private void S550_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S550.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K55.Text, S550.Text);
                p.ShowDialog();
            }
        }

        private void S551_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S551.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K55.Text, S551.Text);
                p.ShowDialog();
            }
        }

        private void S552_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S552.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K55.Text, S552.Text);
                p.ShowDialog();
            }
        }

        private void S553_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S553.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K55.Text, S553.Text);
                p.ShowDialog();
            }
        }

        private void S560_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S560.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K56.Text, S560.Text);
                p.ShowDialog();
            }
        }

        private void S561_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S561.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K56.Text, S561.Text);
                p.ShowDialog();
            }
        }

        private void S562_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S562.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K56.Text, S562.Text);
                p.ShowDialog();
            }
        }

        private void S563_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S563.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K56.Text, S563.Text);
                p.ShowDialog();
            }
        }

        private void S570_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S570.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K57.Text, S570.Text);
                p.ShowDialog();
            }
        }

        private void S571_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S570.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K57.Text, S571.Text);
                p.ShowDialog();
            }
        }

        private void S572_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S572.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K57.Text, S572.Text);
                p.ShowDialog();
            }
        }

        private void S573_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL5.Equals("CHK") && S573.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L5.Text, K57.Text, S573.Text);
                p.ShowDialog();
            }
        }

        private void chkl6_Click(object sender, EventArgs e)
        {
            buttonSelectedL6 = "CHK";
            if (rdnol6.Checked)
            {
                nameAllItemsL6();
                NoOrderL6();
                lb6.Text = "No Order";
            }
            else if (rdsol6.Checked)
            {
                nameAllItemsL6();
                SomeOrderL6();
                lb6.Text = "Some Order";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonSelectedL6 = button10.Text;
            nameAllItemsL6();
            calBillL6();
            lb6.Text = "Bill";
        }

        private void L6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && L6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K61_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K61.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K61.Text, "0");
                p.ShowDialog();
            }
        }

        private void K62_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K62.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K62.Text, "0");
                p.ShowDialog();
            }
        }

        private void K63_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K63.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K63.Text, "0");
                p.ShowDialog();
            }
        }

        private void K64_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K64.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K64.Text, "0");
                p.ShowDialog();
            }
        }

        private void K65_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K65.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K65.Text, "0");
                p.ShowDialog();
            }
        }

        private void K66_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K66.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K66.Text, "0");
                p.ShowDialog();
            }
        }

        private void K67_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && K67.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K67.Text, "0");
                p.ShowDialog();
            }
        }

        private void S610_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S610.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K61.Text, S610.Text);
                p.ShowDialog();
            }
        }

        private void S611_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S611.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K61.Text, S611.Text);
                p.ShowDialog();
            }
        }

        private void S612_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S612.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K61.Text, S612.Text);
                p.ShowDialog();
            }
        }

        private void S613_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S613.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K61.Text, S613.Text);
                p.ShowDialog();
            }
        }

        private void S620_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S620.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K62.Text, S620.Text);
                p.ShowDialog();
            }
        }

        private void S621_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S621.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K62.Text, S621.Text);
                p.ShowDialog();
            }
        }

        private void S622_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S622.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K62.Text, S622.Text);
                p.ShowDialog();
            }
        }

        private void S623_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S623.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K62.Text, S623.Text);
                p.ShowDialog();
            }
        }

        private void S630_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S630.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K63.Text, S630.Text);
                p.ShowDialog();
            }
        }

        private void S631_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S631.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K63.Text, S631.Text);
                p.ShowDialog();
            }
        }

        private void S632_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S632.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K63.Text, S632.Text);
                p.ShowDialog();
            }
        }

        private void S633_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S633.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K63.Text, S633.Text);
                p.ShowDialog();
            }
        }

        private void S640_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S640.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K64.Text, S640.Text);
                p.ShowDialog();
            }
        }

        private void S641_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S641.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K64.Text, S641.Text);
                p.ShowDialog();
            }
        }

        private void S642_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S642.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K64.Text, S642.Text);
                p.ShowDialog();
            }
        }

        private void S643_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S643.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K64.Text, S643.Text);
                p.ShowDialog();
            }
        }

        private void S650_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S650.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K65.Text, S650.Text);
                p.ShowDialog();
            }
        }

        private void S651_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S651.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K65.Text, S651.Text);
                p.ShowDialog();
            }
        }

        private void S652_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S652.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K65.Text, S652.Text);
                p.ShowDialog();
            }
        }

        private void S653_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S653.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K65.Text, S653.Text);
                p.ShowDialog();
            }
        }

        private void S660_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S660.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K66.Text, S660.Text);
                p.ShowDialog();
            }
        }

        private void S661_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S661.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K66.Text, S661.Text);
                p.ShowDialog();
            }
        }

        private void S662_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S662.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K66.Text, S662.Text);
                p.ShowDialog();
            }
        }

        private void S663_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S663.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K66.Text, S663.Text);
                p.ShowDialog();
            }
        }

        private void S670_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S670.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K67.Text, S670.Text);
                p.ShowDialog();
            }
        }

        private void S671_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S671.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K67.Text, S671.Text);
                p.ShowDialog();
            }
        }

        private void S672_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S672.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K67.Text, S672.Text);
                p.ShowDialog();
            }
        }

        private void S673_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL6.Equals("CHK") && S673.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L6.Text, K67.Text, S673.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl7_Click(object sender, EventArgs e)
        {
            buttonSelectedL7 = "CHK";
            if (rdnol7.Checked)
            {
                nameAllItemsL7();
                NoOrderL7();
                lb7.Text = "No Order";
            }
            else if (rdsol7.Checked)
            {
                nameAllItemsL7();
                SomeOrderL7();
                lb7.Text = "Some Order";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonSelectedL7 = button13.Text;
            nameAllItemsL7();
            calBillL7();
            lb7.Text = "Bill";
        }

        private void L7_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && L7.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K71_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K71.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K71.Text, "0");
                p.ShowDialog();
            }
        }

        private void K72_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K72.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K72.Text, "0");
                p.ShowDialog();
            }
        }

        private void K73_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K73.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K73.Text, "0");
                p.ShowDialog();
            }
        }

        private void K74_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K74.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K74.Text, "0");
                p.ShowDialog();
            }
        }

        private void K75_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K75.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K75.Text, "0");
                p.ShowDialog();
            }
        }

        private void K76_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K76.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, "0");
                p.ShowDialog();
            }
        }

        private void K77_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && K77.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K77.Text, "0");
                p.ShowDialog();
            }
        }

        private void S710_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S710.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K71.Text, S710.Text);
                p.ShowDialog();
            }
        }

        private void S711_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S711.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K71.Text, S711.Text);
                p.ShowDialog();
            }
        }

        private void S712_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S712.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K71.Text, S712.Text);
                p.ShowDialog();
            }
        }

        private void S713_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S713.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K71.Text, S713.Text);
                p.ShowDialog();
            }
        }

        private void S720_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S720.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K72.Text, S720.Text);
                p.ShowDialog();
            }
        }

        private void S721_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S721.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K72.Text, S721.Text);
                p.ShowDialog();
            }
        }

        private void S722_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S722.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K72.Text, S722.Text);
                p.ShowDialog();
            }
        }

        private void S723_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S723.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K72.Text, S723.Text);
                p.ShowDialog();
            }
        }

        private void S730_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S730.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K73.Text, S730.Text);
                p.ShowDialog();
            }
        }

        private void S731_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S731.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K73.Text, S731.Text);
                p.ShowDialog();
            }
        }

        private void S732_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S732.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K73.Text, S732.Text);
                p.ShowDialog();
            }
        }

        private void S733_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S733.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K73.Text, S733.Text);
                p.ShowDialog();
            }
        }

        private void S740_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S740.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K74.Text, S740.Text);
                p.ShowDialog();
            }
        }

        private void S741_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S741.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K74.Text, S741.Text);
                p.ShowDialog();
            }
        }

        private void S742_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S742.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K74.Text, S742.Text);
                p.ShowDialog();
            }
        }

        private void S743_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S743.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K74.Text, S743.Text);
                p.ShowDialog();
            }
        }

        private void S750_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S750.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K75.Text, S750.Text);
                p.ShowDialog();
            }
        }

        private void S751_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S751.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K75.Text, S751.Text);
                p.ShowDialog();
            }
        }

        private void S752_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S752.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K75.Text, S752.Text);
                p.ShowDialog();
            }
        }

        private void S753_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S753.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K75.Text, S753.Text);
                p.ShowDialog();
            }
        }

        private void S760_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S760.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S760.Text);
                p.ShowDialog();
            }
        }

        private void S761_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S761.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S761.Text);
                p.ShowDialog();
            }
        }

        private void S762_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S762.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S762.Text);
                p.ShowDialog();
            }
        }

        private void S763_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S763.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S763.Text);
                p.ShowDialog();
            }
        }

        private void S770_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S770.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S770.Text);
                p.ShowDialog();
            }
        }

        private void S771_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S771.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S771.Text);
                p.ShowDialog();
            }
        }

        private void S772_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S772.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S772.Text);
                p.ShowDialog();
            }
        }

        private void S773_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL7.Equals("CHK") && S773.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L7.Text, K76.Text, S773.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl8_Click(object sender, EventArgs e)
        {
            buttonSelectedL8 = "CHK";
            if (rdnol8.Checked)
            {
                nameAllItemsL8();
                NoOrderL8();
                lb8.Text = "No Order";
            }
            else if (rdsol8.Checked)
            {
                nameAllItemsL8();
                SomeOrderL8();
                lb8.Text = "Some Order";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonSelectedL8 = button16.Text;
            nameAllItemsL8();
            calBillL8();
            lb8.Text = "Bill";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonSelectedL9 = button19.Text;
            nameAllItemsL9();
            calBillL9();
            lb9.Text = "Bill";
        }

        private void L8_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && L8.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K81_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K81.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K81.Text, "0");
                p.ShowDialog();
            }
        }

        private void K82_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K82.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K82.Text, "0");
                p.ShowDialog();
            }
        }

        private void K83_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K83.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K83.Text, "0");
                p.ShowDialog();
            }
        }

        private void K84_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K84.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K84.Text, "0");
                p.ShowDialog();
            }
        }

        private void K85_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K85.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K85.Text, "0");
                p.ShowDialog();
            }
        }

        private void K86_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K86.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K86.Text, "0");
                p.ShowDialog();
            }
        }

        private void K87_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && K87.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K87.Text, "0");
                p.ShowDialog();
            }
        }

        private void S810_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S810.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K81.Text, S810.Text);
                p.ShowDialog();
            }
        }

        private void S811_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S811.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K81.Text, S811.Text);
                p.ShowDialog();
            }
        }

        private void S812_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S812.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K81.Text, S812.Text);
                p.ShowDialog();
            }
        }

        private void S813_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S813.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K81.Text, S813.Text);
                p.ShowDialog();
            }
        }

        private void S820_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S820.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K82.Text, S820.Text);
                p.ShowDialog();
            }
        }

        private void S821_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S821.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K82.Text, S821.Text);
                p.ShowDialog();
            }
        }

        private void S822_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S822.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K82.Text, S822.Text);
                p.ShowDialog();
            }
        }

        private void S823_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S823.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K82.Text, S823.Text);
                p.ShowDialog();
            }
        }

        private void S830_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S830.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K83.Text, S830.Text);
                p.ShowDialog();
            }
        }

        private void S831_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S831.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K83.Text, S831.Text);
                p.ShowDialog();
            }
        }

        private void S832_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S832.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K83.Text, S832.Text);
                p.ShowDialog();
            }
        }

        private void S833_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S833.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K83.Text, S833.Text);
                p.ShowDialog();
            }
        }

        private void S840_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S840.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K84.Text, S840.Text);
                p.ShowDialog();
            }
        }

        private void S841_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S841.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K84.Text, S841.Text);
                p.ShowDialog();
            }
        }

        private void S842_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S842.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K84.Text, S842.Text);
                p.ShowDialog();
            }
        }

        private void S843_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S843.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K84.Text, S843.Text);
                p.ShowDialog();
            }
        }

        private void S850_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S850.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K85.Text, S850.Text);
                p.ShowDialog();
            }
        }

        private void S851_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S851.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K85.Text, S851.Text);
                p.ShowDialog();
            }
        }

        private void S852_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S852.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K85.Text, S852.Text);
                p.ShowDialog();
            }
        }

        private void S853_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S853.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K85.Text, S853.Text);
                p.ShowDialog();
            }
        }

        private void S860_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S860.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K86.Text, S860.Text);
                p.ShowDialog();
            }
        }

        private void S861_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S861.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K86.Text, S861.Text);
                p.ShowDialog();
            }
        }

        private void S862_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S862.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K86.Text, S862.Text);
                p.ShowDialog();
            }
        }

        private void S863_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S863.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K86.Text, S863.Text);
                p.ShowDialog();
            }
        }

        private void S870_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S870.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K87.Text, S870.Text);
                p.ShowDialog();
            }
        }

        private void S871_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S871.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K87.Text, S871.Text);
                p.ShowDialog();
            }
        }

        private void S872_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S872.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K87.Text, S872.Text);
                p.ShowDialog();
            }
        }

        private void S873_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL8.Equals("CHK") && S873.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L8.Text, K87.Text, S873.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl9_Click(object sender, EventArgs e)
        {
            buttonSelectedL9 = "CHK";
            if (rdnol9.Checked)
            {
                nameAllItemsL9();
                NoOrderL9();
                lb9.Text = "No Order";
            }
            else if (rdsol9.Checked)
            {
                nameAllItemsL9();
                SomeOrderL9();
                lb9.Text = "Some Order";
            }
        }

        private void L9_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && L9.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K91_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K91.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K91.Text, "0");
                p.ShowDialog();
            }
        }

        private void K92_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K92.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K92.Text, "0");
                p.ShowDialog();
            }
        }

        private void K93_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K93.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K93.Text, "0");
                p.ShowDialog();
            }
        }

        private void K94_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K94.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K94.Text, "0");
                p.ShowDialog();
            }
        }

        private void K95_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K95.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K95.Text, "0");
                p.ShowDialog();
            }
        }

        private void K96_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K96.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K96.Text, "0");
                p.ShowDialog();
            }
        }

        private void K97_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && K97.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K97.Text, "0");
                p.ShowDialog();
            }
        }

        private void S910_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S910.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K91.Text,S910.Text);
                p.ShowDialog();
            }
        }

        private void S911_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S911.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K91.Text, S911.Text);
                p.ShowDialog();
            }
        }

        private void S912_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S912.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K91.Text, S912.Text);
                p.ShowDialog();
            }
        }

        private void S913_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S913.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K91.Text, S913.Text);
                p.ShowDialog();
            }
        }

        private void S920_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S920.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K92.Text, S920.Text);
                p.ShowDialog();
            }
        }

        private void S921_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S921.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K92.Text, S921.Text);
                p.ShowDialog();
            }
        }

        private void S922_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S922.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K92.Text, S922.Text);
                p.ShowDialog();
            }
        }

        private void S923_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S923.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K92.Text, S923.Text);
                p.ShowDialog();
            }
        }

        private void S930_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S930.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K93.Text, S930.Text);
                p.ShowDialog();
            }
        }

        private void S931_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S931.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K93.Text, S931.Text);
                p.ShowDialog();
            }
        }

        private void S932_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S932.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K93.Text, S932.Text);
                p.ShowDialog();
            }
        }

        private void S933_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S933.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K93.Text, S933.Text);
                p.ShowDialog();
            }
        }

        private void S940_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S940.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K94.Text, S940.Text);
                p.ShowDialog();
            }
        }

        private void S941_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S941.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K94.Text, S941.Text);
                p.ShowDialog();
            }
        }

        private void S942_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S942.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K94.Text, S942.Text);
                p.ShowDialog();
            }
        }

        private void S943_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S943.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K94.Text, S943.Text);
                p.ShowDialog();
            }
        }

        private void S950_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S950.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K95.Text, S950.Text);
                p.ShowDialog();
            }
        }

        private void S951_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S951.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K95.Text, S951.Text);
                p.ShowDialog();
            }
        }

        private void S952_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S952.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K95.Text, S952.Text);
                p.ShowDialog();
            }
        }

        private void S953_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S953.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K95.Text, S953.Text);
                p.ShowDialog();
            }
        }

        private void S960_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S960.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K96.Text, S960.Text);
                p.ShowDialog();
            }
        }

        private void S961_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S961.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K96.Text, S961.Text);
                p.ShowDialog();
            }
        }

        private void S962_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S962.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K96.Text, S962.Text);
                p.ShowDialog();
            }
        }

        private void S963_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S963.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K96.Text, S963.Text);
                p.ShowDialog();
            }
        }

        private void S970_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S970.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K97.Text, S970.Text);
                p.ShowDialog();
            }
        }

        private void S971_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S971.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K97.Text, S971.Text);
                p.ShowDialog();
            }
        }

        private void S972_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S972.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K97.Text, S972.Text);
                p.ShowDialog();
            }
        }

        private void S973_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL9.Equals("CHK") && S973.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L9.Text, K97.Text, S973.Text);
                p.ShowDialog();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonSelectedL10 = button22.Text;
            nameAllItemsL10();
            calBillL10();
            lb10.Text = "Bill";
        }

        private void btnchkl10_Click(object sender, EventArgs e)
        {
            buttonSelectedL10 = "CHK";
            if (rdnol10.Checked)
            {
                nameAllItemsL10();
                NoOrderL10();
                lb10.Text = "No Order";
            }
            else if (rdsol10.Checked)
            {
                nameAllItemsL10();
                SomeOrderL10();
                lb10.Text = "Some Order";
            }
        }

        private void L10_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && L10.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K101_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K101.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, "0");
                p.ShowDialog();
            }
        }

        private void K102_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K102.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K102.Text, "0");
                p.ShowDialog();
            }
        }

        private void K103_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K103.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K103.Text, "0");
                p.ShowDialog();
            }
        }

        private void K104_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K104.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K104.Text, "0");
                p.ShowDialog();
            }
        }

        private void K105_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K105.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K105.Text, "0");
                p.ShowDialog();
            }
        }

        private void K106_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K106.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K106.Text, "0");
                p.ShowDialog();
            }
        }

        private void K107_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && K107.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, "0");
                p.ShowDialog();
            }
        }

        private void S1010_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1010.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, S1010.Text);
                p.ShowDialog();
            }
        }

        private void S1011_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1011.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, S1011.Text);
                p.ShowDialog();
            }
        }

        private void S1012_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1012.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, S1012.Text);
                p.ShowDialog();
            }
        }

        private void S1013_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1013.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K101.Text, S1013.Text);
                p.ShowDialog();
            }
        }

        private void S1020_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1020.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K102.Text, S1020.Text);
                p.ShowDialog();
            }
        }

        private void S1021_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1021.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K102.Text, S1021.Text);
                p.ShowDialog();
            }
        }

        private void S1022_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1022.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K102.Text, S1022.Text);
                p.ShowDialog();
            }
        }

        private void S1023_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1023.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K102.Text, S1023.Text);
                p.ShowDialog();
            }
        }

        private void S1030_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1030.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K103.Text, S1030.Text);
                p.ShowDialog();
            }
        }

        private void S1031_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1031.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K103.Text, S1031.Text);
                p.ShowDialog();
            }
        }

        private void S1032_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1032.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K103.Text, S1032.Text);
                p.ShowDialog();
            }
        }

        private void S1033_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1033.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K103.Text, S1033.Text);
                p.ShowDialog();
            }
        }

        private void S1040_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1040.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K104.Text, S1040.Text);
                p.ShowDialog();
            }
        }

        private void S1041_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1041.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K104.Text, S1041.Text);
                p.ShowDialog();
            }
        }

        private void S1042_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1042.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K104.Text, S1042.Text);
                p.ShowDialog();
            }
        }

        private void S1043_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1043.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K104.Text, S1043.Text);
                p.ShowDialog();
            }
        }

        private void S1050_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1050.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K105.Text, S1050.Text);
                p.ShowDialog();
            }
        }

        private void S1051_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1051.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K105.Text, S1051.Text);
                p.ShowDialog();
            }
        }

        private void S1052_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1052.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K105.Text, S1052.Text);
                p.ShowDialog();
            }
        }

        private void S1053_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1053.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K105.Text, S1053.Text);
                p.ShowDialog();
            }
        }

        private void S1060_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1060.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K106.Text, S1060.Text);
                p.ShowDialog();
            }
        }

        private void S1061_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1061.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K106.Text, S1061.Text);
                p.ShowDialog();
            }
        }

        private void S1062_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1062.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K106.Text, S1062.Text);
                p.ShowDialog();
            }
        }

        private void S1063_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1063.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K106.Text, S1063.Text);
                p.ShowDialog();
            }
        }

        private void S1070_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1070.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K107.Text, S1070.Text);
                p.ShowDialog();
            }
        }

        private void S1071_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1071.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K107.Text, S1071.Text);
                p.ShowDialog();
            }
        }

        private void S1072_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1072.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K107.Text, S1072.Text);
                p.ShowDialog();
            }
        }

        private void S1073_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL10.Equals("CHK") && S1073.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L10.Text, K107.Text, S1073.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl11_Click(object sender, EventArgs e)
        {
            buttonSelectedL11 = "CHK";
            if (rdnol11.Checked)
            {
                nameAllItemsL11();
                NoOrderL11();
                lb11.Text = "No Order";
            }
            else if (rdsol11.Checked)
            {
                nameAllItemsL11();
                SomeOrderL11();
                lb11.Text = "Some Order";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonSelectedL11 = button25.Text;
            nameAllItemsL11();
            calBillL11();
            lb11.Text = "Bill";
        }

        private void L11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && L11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K111_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K111.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K111.Text, "0");
                p.ShowDialog();
            }
        }

        private void K112_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K112.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K112.Text, "0");
                p.ShowDialog();
            }
        }

        private void K113_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K113.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K113.Text, "0");
                p.ShowDialog();
            }
        }

        private void K114_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K114.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K114.Text, "0");
                p.ShowDialog();
            }
        }

        private void K115_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K115.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K115.Text, "0");
                p.ShowDialog();
            }
        }

        private void K116_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K116.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K116.Text, "0");
                p.ShowDialog();
            }
        }

        private void K117_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && K117.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K117.Text, "0");
                p.ShowDialog();
            }
        }

        private void S1110_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1110.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K111.Text, S1110.Text);
                p.ShowDialog();
            }
        }

        private void S1111_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1111.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K111.Text, S1111.Text);
                p.ShowDialog();
            }
        }

        private void S1112_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1112.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K111.Text, S1112.Text);
                p.ShowDialog();
            }
        }

        private void S1113_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1113.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K111.Text, S1113.Text);
                p.ShowDialog();
            }
        }

        private void S1120_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1120.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K112.Text, S1120.Text);
                p.ShowDialog();
            }
        }

        private void S1121_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1121.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K112.Text, S1121.Text);
                p.ShowDialog();
            }
        }

        private void S1122_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1122.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K112.Text, S1122.Text);
                p.ShowDialog();
            }
        }

        private void S1123_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1123.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K112.Text, S1123.Text);
                p.ShowDialog();
            }
        }

        private void S1130_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1130.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K113.Text, S1130.Text);
                p.ShowDialog();
            }
        }

        private void S1131_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1131.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K113.Text, S1131.Text);
                p.ShowDialog();
            }
        }

        private void S1132_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1132.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K113.Text, S1132.Text);
                p.ShowDialog();
            }
        }

        private void S1133_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1133.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K113.Text, S1133.Text);
                p.ShowDialog();
            }
        }

        private void S1140_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1140.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K114.Text, S1140.Text);
                p.ShowDialog();
            }
        }

        private void S1141_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1141.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K114.Text, S1141.Text);
                p.ShowDialog();
            }
        }

        private void S1142_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1142.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K114.Text, S1142.Text);
                p.ShowDialog();
            }
        }

        private void S1143_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1143.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K114.Text, S1143.Text);
                p.ShowDialog();
            }
        }

        private void S1150_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1150.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K115.Text, S1150.Text);
                p.ShowDialog();
            }
        }

        private void S1151_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1151.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K115.Text, S1151.Text);
                p.ShowDialog();
            }
        }

        private void S1152_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1152.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K115.Text, S1152.Text);
                p.ShowDialog();
            }
        }

        private void S1153_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1153.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K115.Text, S1153.Text);
                p.ShowDialog();
            }
        }

        private void S1160_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1160.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K116.Text, S1160.Text);
                p.ShowDialog();
            }
        }

        private void S1161_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1161.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K116.Text, S1161.Text);
                p.ShowDialog();
            }
        }

        private void S1162_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1162.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K116.Text, S1162.Text);
                p.ShowDialog();
            }
        }

        private void S1163_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1163.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K116.Text, S1163.Text);
                p.ShowDialog();
            }
        }

        private void S1170_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1170.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K117.Text, S1170.Text);
                p.ShowDialog();
            }
        }

        private void S1171_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1171.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K117.Text, S1171.Text);
                p.ShowDialog();
            }
        }

        private void S1172_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1172.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K117.Text, S1172.Text);
                p.ShowDialog();
            }
        }

        private void S1173_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL11.Equals("CHK") && S1173.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L11.Text, K117.Text, S1173.Text);
                p.ShowDialog();
            }
        }

        private void btnchkl12_Click(object sender, EventArgs e)
        {
            buttonSelectedL12 = "CHK";
            if (rdnol12.Checked)
            {
                nameAllItemsL12();
                NoOrderL12();
                lb12.Text = "No Order";
            }
            else if (rdsol12.Checked)
            {
                nameAllItemsL12();
                SomeOrderL12();
                lb12.Text = "Some Order";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            buttonSelectedL12 = button28.Text;
            nameAllItemsL12();
            calBillL12();
            lb12.Text = "Bill";
        }

        private void L12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && L12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void K121_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K121.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K121.Text, "0");
                p.ShowDialog();
            }
        }

        private void K122_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K122.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K122.Text, "0");
                p.ShowDialog();
            }
        }

        private void K123_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K123.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K123.Text, "0");
                p.ShowDialog();
            }
        }

        private void K124_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K124.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K124.Text, "0");
                p.ShowDialog();
            }
        }

        private void K125_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K125.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K125.Text, "0");
                p.ShowDialog();
            }
        }

        private void K126_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K126.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K126.Text, "0");
                p.ShowDialog();
            }
        }

        private void K127_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && K127.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K127.Text, "0");
                p.ShowDialog();
            }
        }

        private void S1210_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1210.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K121.Text, S1210.Text);
                p.ShowDialog();
            }
        }

        private void S1211_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1211.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K121.Text, S1211.Text);
                p.ShowDialog();
            }
        }

        private void S1212_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1212.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K121.Text, S1212.Text);
                p.ShowDialog();
            }
        }

        private void S1213_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1213.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K121.Text, S1213.Text);
                p.ShowDialog();
            }
        }

        private void S1220_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1220.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K122.Text, S1220.Text);
                p.ShowDialog();
            }
        }

        private void S1221_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1221.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K122.Text, S1221.Text);
                p.ShowDialog();
            }
        }

        private void S1222_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1222.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K122.Text, S1222.Text);
                p.ShowDialog();
            }
        }

        private void S1223_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1223.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K122.Text, S1223.Text);
                p.ShowDialog();
            }
        }

        private void S1230_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1230.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K123.Text, S1230.Text);
                p.ShowDialog();
            }
        }

        private void S1231_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1231.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K123.Text, S1231.Text);
                p.ShowDialog();
            }
        }

        private void S1232_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1232.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K123.Text, S1232.Text);
                p.ShowDialog();
            }
        }

        private void S1233_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1233.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K123.Text, S1233.Text);
                p.ShowDialog();
            }
        }

        private void S1240_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1240.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K124.Text, S1240.Text);
                p.ShowDialog();
            }
        }

        private void S1241_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1241.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K124.Text, S1241.Text);
                p.ShowDialog();
            }
        }

        private void S1242_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1242.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K124.Text, S1242.Text);
                p.ShowDialog();
            }
        }

        private void S1243_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1243.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K124.Text, S1243.Text);
                p.ShowDialog();
            }
        }

        private void S1250_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1250.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K125.Text, S1250.Text);
                p.ShowDialog();
            }
        }

        private void S1251_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1251.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K125.Text, S1251.Text);
                p.ShowDialog();
            }
        }

        private void S1252_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1252.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K125.Text, S1252.Text);
                p.ShowDialog();
            }
        }

        private void S1253_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1253.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K125.Text, S1253.Text);
                p.ShowDialog();
            }
        }

        private void S1260_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1260.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K126.Text, S1260.Text);
                p.ShowDialog();
            }
        }

        private void S1261_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1261.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K126.Text, S1261.Text);
                p.ShowDialog();
            }
        }

        private void S1262_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1260.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K126.Text, S1262.Text);
                p.ShowDialog();
            }
        }

        private void S1263_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1263.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K126.Text, S1263.Text);
                p.ShowDialog();
            }
        }

        private void S1270_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1270.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K127.Text, S1270.Text);
                p.ShowDialog();
            }
        }

        private void S1271_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1271.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K127.Text, S1271.Text);
                p.ShowDialog();
            }
        }

        private void S1272_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1272.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K127.Text, S1272.Text);
                p.ShowDialog();
            }
        }

        private void S1273_Click(object sender, EventArgs e)
        {
            if (buttonSelectedL12.Equals("CHK") && S1273.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(L12.Text, K127.Text, S1273.Text);
                p.ShowDialog();
            }
        }

      /*  void displayStatic() 
        {
            DataTable harasQ = ClassReports.selectAllQuotL("لواء الحرس الجمهوري");
            int sumqlHaras = int.Parse(harasQ.Rows[0][0].ToString());

            DataTable L1Q = ClassReports.selectAllQuotL("اللواء الاول");
            int sumqL1 = int.Parse(L1Q.Rows[0][0].ToString());

            DataTable L2Q = ClassReports.selectAllQuotL("اللواء الثاني");
            int sumqL2 = int.Parse(L2Q.Rows[0][0].ToString());

            DataTable L3Q = ClassReports.selectAllQuotL("اللواء الثالث");
            int sumqL3 = int.Parse(L3Q.Rows[0][0].ToString());

            DataTable L5Q = ClassReports.selectAllQuotL("اللواء الخامس");
            int sumqL5 = int.Parse(L5Q.Rows[0][0].ToString());

            DataTable L6Q = ClassReports.selectAllQuotL("اللواء السادس");
            int sumqL6 = int.Parse(L6Q.Rows[0][0].ToString());

            DataTable L7Q = ClassReports.selectAllQuotL("اللواء السابع");
            int sumqL7 = int.Parse(L7Q.Rows[0][0].ToString());

            DataTable L8Q = ClassReports.selectAllQuotL("اللواء الثامن");
            int sumqL8 = int.Parse(L8Q.Rows[0][0].ToString());

            DataTable L9Q = ClassReports.selectAllQuotL("اللواء التاسع");
            int sumqL9 = int.Parse(L9Q.Rows[0][0].ToString());

            DataTable L10Q = ClassReports.selectAllQuotL("اللواء العاشر");
            int sumqL10 = int.Parse(L10Q.Rows[0][0].ToString());

            DataTable L11Q = ClassReports.selectAllQuotL("اللواء الحادي عشر");
            int sumqL11 = int.Parse(L11Q.Rows[0][0].ToString());

            DataTable L12Q = ClassReports.selectAllQuotL("اللواء الثاني عشر");
            int sumqL12 = int.Parse(L12Q.Rows[0][0].ToString());



            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الاول", sumqL1);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الثاني", sumqL2);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الثالث", sumqL3);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الخامس", sumqL5);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء السادس", sumqL6);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء السابع", sumqL7);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الثامن", sumqL8);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء التاسع", sumqL9);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء العاشر", sumqL10);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الحادي عشر", sumqL11);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("اللواء الثاني عشر", sumqL12);
            this.L1Chart.Series["Qoutaions"].Points.AddXY("لواء الحرس الجمهوري", sumqlHaras);
            //*****************************************************************************



            DataTable harasO = ClassReports.selectAllOrderL("لواء الحرس الجمهوري");
            int sumOlHaras = int.Parse(harasQ.Rows[0][0].ToString());

            DataTable L1O = ClassReports.selectAllOrderL("اللواء الاول");
            int sumOL1 = int.Parse(L1O.Rows[0][0].ToString());

            DataTable L2O = ClassReports.selectAllOrderL("اللواء الثاني");
            int sumOL2 = int.Parse(L2O.Rows[0][0].ToString());

            DataTable L3O = ClassReports.selectAllOrderL("اللواء الثالث");
            int sumOL3 = int.Parse(L3O.Rows[0][0].ToString());

            DataTable L5O = ClassReports.selectAllOrderL("اللواء الخامس");
            int sumOL5 = int.Parse(L5O.Rows[0][0].ToString());

            DataTable L6O = ClassReports.selectAllOrderL("اللواء السادس");
            int sumOL6 = int.Parse(L6O.Rows[0][0].ToString());

            DataTable L7O = ClassReports.selectAllOrderL("اللواء السابع");
            int sumOL7 = int.Parse(L7O.Rows[0][0].ToString());

            DataTable L8O = ClassReports.selectAllOrderL("اللواء الثامن");
            int sumOL8 = int.Parse(L8O.Rows[0][0].ToString());

            DataTable L9O = ClassReports.selectAllOrderL("اللواء التاسع");
            int sumOL9 = int.Parse(L9O.Rows[0][0].ToString());

            DataTable L10O = ClassReports.selectAllOrderL("اللواء العاشر");
            int sumOL10 = int.Parse(L10O.Rows[0][0].ToString());

            DataTable L11O = ClassReports.selectAllOrderL("اللواء الحادي عشر");
            int sumOL11 = int.Parse(L11O.Rows[0][0].ToString());

            DataTable L12O = ClassReports.selectAllOrderL("اللواء الثاني عشر");
            int sumOL12 = int.Parse(L12O.Rows[0][0].ToString());
            //********************************************************************************
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الاول", sumOL1);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الثاني", sumOL2);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الثالث", sumOL3);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الخامس", sumOL5);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء السادس", sumOL6);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء السابع", sumOL7);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الثامن", sumOL8);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء التاسع", sumOL9);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء العاشر", sumOL10);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الحادي عشر", sumOL11);
            this.L1Chart.Series["Orders"].Points.AddXY("اللواء الثاني عشر", sumOL12);
            this.L1Chart.Series["Orders"].Points.AddXY("لواء الحرس الجمهوري", sumOlHaras);

            
        }*/
        private void button32_Click(object sender, EventArgs e)
        {
             
        }

        private void btnNOForAll_Click(object sender, EventArgs e)
        {
            buttonSelectedL1 = "CHK";
            buttonSelectedL2 = "CHK";
            buttonSelectedL3 = "CHK";
            buttonSelectedL5 = "CHK";
            buttonSelectedL6 = "CHK";
            buttonSelectedL7 = "CHK";
            buttonSelectedL8 = "CHK";
            buttonSelectedL9 = "CHK";
            buttonSelectedL10 = "CHK";
            buttonSelectedL11 = "CHK";
            buttonSelectedL12 = "CHK";
            buttonSelectedL11 = "CHK";
            buttonSelectedL12 = "CHK";
            buttonSelectedLHJ = "CHK";
            buttonSelectedLL = "CHK";
            buttonSelectedLD = "CHK";
            buttonSelectedf1 = "CHK";
            buttonSelectedf2 = "CHK";
            buttonSelectedf3 = "CHK";
            buttonSelectedf4 = "CHK";
            buttonSelectedf5 = "CHK";
            buttonSelectedf6 = "CHK";
            buttonSelectedf7 = "CHK";
            buttonSelectedf8 = "CHK";
            buttonSelectedf9 = "CHK";
            buttonSelectedf10 = "CHK";
            buttonSelectedf11 = "CHK";
            buttonSelectedf12 = "CHK";
            buttonSelectedf13 = "CHK";
            buttonSelectedf14 = "CHK";
            buttonSelectedf15 = "CHK";
            buttonSelectedf16 = "CHK";
            buttonSelectedf17 = "CHK";
            buttonSelectedf18 = "CHK";
            buttonSelectedf19 = "CHK";
            buttonSelectedf20 = "CHK";
            buttonSelectedf21 = "CHK";
            buttonSelectedp1 = "CHK";
            buttonSelectedp2 = "CHK";
            buttonSelectedp3 = "CHK";
            buttonSelectedp4 = "CHK";
            buttonSelectedp5 = "CHK";
            buttonSelectedp6 = "CHK";




            nameAllItemsL1();
            NoOrderL1();
            lb1.Text = "No Order";
            
            nameAllItemsL2();
            NoOrderL2();
            lb2.Text = "No Order";

            nameAllItemsL3();
            NoOrderL3();
            lb3.Text = "No Order";

            nameAllItemsL5();
            NoOrderL5();
            lb5.Text = "No Order";

            nameAllItemsL6();
            NoOrderL6();
            lb6.Text = "No Order";

            nameAllItemsL7();
            NoOrderL7();
            lb7.Text = "No Order";

            nameAllItemsL8();
            NoOrderL8();
            lb8.Text = "No Order";

            nameAllItemsL9();
            NoOrderL9();
            lb9.Text = "No Order";

            nameAllItemsL10();
            NoOrderL10();
            lb10.Text = "No Order";

            nameAllItemsL11();
            NoOrderL11();
            lb11.Text = "No Order";

            nameAllItemsL12();
            NoOrderL12();
            lb12.Text = "No Order";

            nameAllItemsLHJ();
            NoOrderLHJ();
            LbHJ.Text = "No Order";

            nameAllItemsLL();
            NoOrderLL();
            lbLL.Text = "No Order";

            nameAllItemsLD();
            NoOrderLD();
            lbLD.Text = "No Order";

            f1name();
            NoOrderf1();
            lbf1.Text = "No Order";

            f2name();
            NoOrderf2();
            lbf2.Text = "No Order";

            f3name();
            NoOrderf3();
            lbf3.Text = "No Order";

            f4name();
            NoOrderf4();
            lbf4.Text = "No Order";

            f5name();
            NoOrderf5();
            lbf5.Text = "No Order";

            f6name();
            NoOrderf6();
            lbf6.Text = "No Order";

            f7name();
            NoOrderf7();
            lbf7.Text = "No Order";

            f8name();
            NoOrderf8();
            lbf8.Text = "No Order";

            f9name();
            NoOrderf9();
            lbf9.Text = "No Order";

            f10name();
            NoOrderf10();
            lbf10.Text = "No Order";

            f11name();
            NoOrderf11();
            lbf11.Text = "No Order";

            f12name();
            NoOrderf12();
            lbf12.Text = "No Order";

            f13name();
            NoOrderf13();
            lbf13.Text = "No Order";

            f14name();
            NoOrderf14();
            lbf14.Text = "No Order";

            f15name();
            NoOrderf15();
            lbf15.Text = "No Order";

            f16name();
            NoOrderf16();
            lbf16.Text = "No Order";

            f17name();
            NoOrderf17();
            lbf17.Text = "No Order";

            f18name();
            NoOrderf18();
            lbf18.Text = "No Order";

            f19name();
            NoOrderf19();
            lbf19.Text = "No Order";

            f20name();
            NoOrderf20();
            lbf20.Text = "No Order";

            f21name();
            NoOrderf21();
            lbf21.Text = "No Order";

            PiecesName();

            NoOrderp1();
            lp1.Text = "No Order";
            NoOrderp2();
            lp2.Text = "No Order";
            NoOrderp3();
            lp3.Text = "No Order";
            NoOrderp4();
            lp4.Text = "No Order";
            NoOrderp5();
            lp5.Text = "No Order";
            NoOrderp6();
            lp6.Text = "No Order";


        }

        private void btnSOForAll_Click(object sender, EventArgs e)
        {

            buttonSelectedL1 = "CHK";
            buttonSelectedL2 = "CHK";
            buttonSelectedL3 = "CHK";
            buttonSelectedL5 = "CHK";
            buttonSelectedL6 = "CHK";
            buttonSelectedL7 = "CHK";
            buttonSelectedL8 = "CHK";
            buttonSelectedL9 = "CHK";
            buttonSelectedL10 = "CHK";
            buttonSelectedL11 = "CHK";
            buttonSelectedL12 = "CHK";
            buttonSelectedLHJ = "CHK";
            buttonSelectedLL = "CHK";
            buttonSelectedLD = "CHK";
            buttonSelectedf1 = "CHK";
            buttonSelectedf2 = "CHK";
            buttonSelectedf3 = "CHK";
            buttonSelectedf4 = "CHK";
            buttonSelectedf5 = "CHK";
            buttonSelectedf6 = "CHK";
            buttonSelectedf7 = "CHK";
            buttonSelectedf8 = "CHK";
            buttonSelectedf9 = "CHK";
            buttonSelectedf10 = "CHK";
            buttonSelectedf11 = "CHK";
            buttonSelectedf12 = "CHK";
            buttonSelectedf13 = "CHK";
            buttonSelectedf14 = "CHK";
            buttonSelectedf15 = "CHK";
            buttonSelectedf16 = "CHK";
            buttonSelectedf17 = "CHK";
            buttonSelectedf18 = "CHK";
            buttonSelectedf19 = "CHK";
            buttonSelectedf20 = "CHK";
            buttonSelectedf21 = "CHK";
            buttonSelectedp1 = "CHK";
            buttonSelectedp2 = "CHK";
            buttonSelectedp3 = "CHK";
            buttonSelectedp4 = "CHK";
            buttonSelectedp5 = "CHK";
            buttonSelectedp6 = "CHK";


            nameAllItemsL1();
            SomeOrderL1();
            lb1.Text = "Some Order";

            nameAllItemsL2();
            SomeOrderL2();
            lb2.Text = "Some Order";

            nameAllItemsL3();
            SomeOrderL3();
            lb3.Text = "Some Order";

            nameAllItemsL5();
            SomeOrderL5();
            lb5.Text = "Some Order";

            nameAllItemsL6();
            SomeOrderL6();
            lb6.Text = "Some Order";

            nameAllItemsL7();
            SomeOrderL7();
            lb7.Text = "Some Order";

            nameAllItemsL8();
            SomeOrderL8();
            lb8.Text = "Some Order";

            nameAllItemsL9();
            SomeOrderL9();
            lb9.Text = "Some Order";

            nameAllItemsL10();
            SomeOrderL10();
            lb10.Text = "Some Order";

            nameAllItemsL11();
            SomeOrderL11();
            lb11.Text = "Some Order";

            nameAllItemsL12();
            SomeOrderL12();
            lb12.Text = "Some Order";

            nameAllItemsLHJ();
            SomeOrderLHJ();
            LbHJ.Text = "Some Order";

            nameAllItemsLL();
            SomeOrderLL();
            lbLL.Text = "Some Order";

            nameAllItemsLD();
            SomeOrderLD();
            lbLD.Text = "Some Order";

            f1name();
            SomeOrderf1();
            lbf1.Text = "Some Order";

            f2name();
            SomeOrderf2();
            lbf2.Text = "Some Order";

            f3name();
            SomeOrderf3();
            lbf3.Text = "Some Order";

            f4name();
            SomeOrderf4();
            lbf4.Text = "Some Order";

            f5name();
            SomeOrderf5();
            lbf5.Text = "Some Order";

            f6name();
            SomeOrderf6();
            lbf6.Text = "Some Order";

            f7name();
            SomeOrderf7();
            lbf7.Text = "Some Order";

            f8name();
            SomeOrderf8();
            lbf8.Text = "Some Order";

            f9name();
            SomeOrderf9();
            lbf9.Text = "Some Order";

            f10name();
            SomeOrderf10();
            lbf10.Text = "Some Order";

            f11name();
            SomeOrderf11();
            lbf11.Text = "Some Order";

            f12name();
            SomeOrderf12();
            lbf12.Text = "Some Order";

            f13name();
            SomeOrderf13();
            lbf13.Text = "Some Order";

            f14name();
            SomeOrderf14();
            lbf14.Text = "Some Order";

            f15name();
            SomeOrderf15();
            lbf15.Text = "Some Order";

            f16name();
            SomeOrderf16();
            lbf16.Text = "Some Order";

            f17name();
            SomeOrderf17();
            lbf17.Text = "Some Order";

            f18name();
            SomeOrderf18();
            lbf18.Text = "Some Order";

            f19name();
            SomeOrderf19();
            lbf19.Text = "Some Order";

            f20name();
            SomeOrderf20();
            lbf20.Text = "Some Order";

            f21name();
            SomeOrderf21();
            lbf21.Text = "Some Order";

            PiecesName();

            SomeOrderp1();
            lp1.Text = "Some Order";
            SomeOrderp2();
            lp2.Text = "Some Order";
            SomeOrderp3();
            lp3.Text = "Some Order";
            SomeOrderp4();
            lp4.Text = "Some Order";
            SomeOrderp5();
            lp5.Text = "Some Order";
            SomeOrderp6();
            lp6.Text = "Some Order";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            buttonSelectedLHJ = btnnumofQout.Text;
            nameAllItemsLHJ();
            calQoutationLHJ();
            LbHJ.Text = "Quotation";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            buttonSelectedLHJ = Btnnumoforder.Text;
            nameAllItemsLHJ();
            calOrderLHJ();
            LbHJ.Text = "Order";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            buttonSelectedLHJ = BtnNumofbill.Text;
            nameAllItemsLHJ();
            calBillLHJ();
            LbHJ.Text = "Bill";
        }

        private void btnchkHJ_Click(object sender, EventArgs e)
        {
            buttonSelectedLHJ = "CHK";
            if (rdnohj.Checked)
            {
                nameAllItemsLHJ();
                NoOrderLHJ();
                LbHJ.Text = "No Order";
            }
            else if (rdsohj.Checked)
            {
                nameAllItemsLHJ();
                SomeOrderLHJ();
                LbHJ.Text = "Some Order";
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            buttonSelectedLL = btnnumofQout.Text;
            nameAllItemsLL();
            calQoutationLL();
            lbLL.Text = "Quotation";
        }

        private void button74_Click(object sender, EventArgs e)
        {
            buttonSelectedLL = Btnnumoforder.Text;
            nameAllItemsLL();
            calOrderLL();
            lbLL.Text = "Order";
        }

        private void button73_Click(object sender, EventArgs e)
        {
            buttonSelectedLL = BtnNumofbill.Text;
            nameAllItemsLL();
            calBillLL();
            lbLL.Text = "Bill";
        }

        private void btnchkLL_Click(object sender, EventArgs e)
        {
            buttonSelectedLL = "CHK";
            if (rdnoll.Checked)
            {
                nameAllItemsLL();
                NoOrderLL();
                lbLL.Text = "No Order";
            }
            else if (rdsoll.Checked)
            {
                nameAllItemsLL();
                SomeOrderLL();
                lbLL.Text = "Some Order";
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            buttonSelectedLD = btnnumofQout.Text;
            nameAllItemsLD();
            calQoutationLD();
            lbLD.Text = "Quotation";
        }

        private void button114_Click(object sender, EventArgs e)
        {
            buttonSelectedLD = Btnnumoforder.Text;
            nameAllItemsLD();
            calOrderLD();
            lbLD.Text = "Order";
        }

        private void button113_Click(object sender, EventArgs e)
        {
            buttonSelectedLD = BtnNumofbill.Text;
            nameAllItemsLD();
            calBillLD();
            lbLD.Text = "Bill";
        }

        private void btnchkLD_Click(object sender, EventArgs e)
        {
            buttonSelectedLD = "CHK";
            if (rdnoLD.Checked)
            {
                nameAllItemsLD();
                NoOrderLD();
                lbLD.Text = "No Order";
            }
            else if (rdsoLD.Checked)
            {
                nameAllItemsLD();
                SomeOrderLD();
                lbLD.Text = "Some Order";
            }
        }

        private void LHJ_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && LHJ.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void LL_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && LL.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void LD_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && LD.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void kj1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj1.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj2.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj3.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj4_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj4.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj4.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj5.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj6.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj7_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj7.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj7.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl1.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl2.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl3.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl4_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl4.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl4.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl5.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl6.Name, "0");
                p.ShowDialog();
            }
        }

        private void kl7_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl7.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl7.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd1.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd2.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd3.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd4_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd4.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd4.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd5.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd6.Name, "0");
                p.ShowDialog();
            }
        }

        private void kd7_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd7.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd7.Name, "0");
                p.ShowDialog();
            }
        }

        private void kj11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj1.Name, kj11.Name);
                p.ShowDialog();
            }
        }

        private void kj12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj1.Name, kj12.Name);
                p.ShowDialog();
            }
        }

        private void kj13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj1.Name, kj13.Name);
                p.ShowDialog();
            }
        }

        private void kj14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj1.Name, kj14.Name);
                p.ShowDialog();
            }
        }

        private void kj21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj2.Name, kj21.Name);
                p.ShowDialog();
            }
        }

        private void kj22_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj22.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj2.Name, kj22.Name);
                p.ShowDialog();
            }
        }

        private void kj23_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj23.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj2.Name, kj23.Name);
                p.ShowDialog();
            }
        }

        private void kj24_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj24.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj2.Name, kj24.Name);
                p.ShowDialog();
            }
        }

        private void kj31_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj31.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj3.Name, kj31.Name);
                p.ShowDialog();
            }
        }

        private void kj32_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj32.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj3.Name, kj32.Name);
                p.ShowDialog();
            }
        }

        private void kj33_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj33.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj3.Name, kj33.Name);
                p.ShowDialog();
            }
        }

        private void kj34_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj34.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj3.Name, kj34.Name);
                p.ShowDialog();
            }
        }

        private void kj41_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj41.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj4.Name, kj41.Name);
                p.ShowDialog();
            }
        }

        private void kj42_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj42.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj4.Name, kj42.Name);
                p.ShowDialog();
            }
        }

        private void kj43_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj43.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj4.Name, kj43.Name);
                p.ShowDialog();
            }
        }

        private void kj44_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj44.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj4.Name, kj44.Name);
                p.ShowDialog();
            }
        }

        private void kj51_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj51.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj5.Name, kj51.Name);
                p.ShowDialog();
            }
        }

        private void kj52_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj52.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj5.Name, kj52.Name);
                p.ShowDialog();
            }
        }

        private void kj53_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj53.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj5.Name, kj53.Name);
                p.ShowDialog();
            }
        }

        private void kj54_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj54.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj5.Name, kj54.Name);
                p.ShowDialog();
            }
        }

        private void kj61_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj61.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj6.Name, kj61.Name);
                p.ShowDialog();
            }
        }

        private void kj62_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj62.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj6.Name, kj62.Name);
                p.ShowDialog();
            }
        }

        private void kj63_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj63.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj6.Name, kj63.Name);
                p.ShowDialog();
            }
        }

        private void kj64_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj64.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj6.Name, kj64.Name);
                p.ShowDialog();
            }
        }

        private void kj71_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj71.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj7.Name, kj71.Name);
                p.ShowDialog();
            }
        }

        private void kj72_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj72.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj7.Name, kj72.Name);
                p.ShowDialog();
            }
        }

        private void kj73_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj73.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj7.Name, kj73.Name);
                p.ShowDialog();
            }
        }

        private void kj74_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLHJ.Equals("CHK") && kj74.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LHJ.Text, kj7.Name, kj74.Name);
                p.ShowDialog();
            }
        }

        private void kl11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl1.Name, kl11.Name);
                p.ShowDialog();
            }
        }

        private void kl12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl1.Name, kl12.Name);
                p.ShowDialog();
            }
        }

        private void kl13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl1.Name, kl13.Name);
                p.ShowDialog();
            }
        }

        private void kl14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl1.Name, kl14.Name);
                p.ShowDialog();
            }
        }

        private void kl21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl2.Name, kl21.Name);
                p.ShowDialog();
            }
        }

        private void kl22_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl22.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl2.Name, kl22.Name);
                p.ShowDialog();
            }
        }

        private void kl23_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl23.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl2.Name, kl23.Name);
                p.ShowDialog();
            }
        }

        private void kl24_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl24.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl2.Name, kl24.Name);
                p.ShowDialog();
            }
        }

        private void kl31_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl31.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl3.Name, kl31.Name);
                p.ShowDialog();
            }
        }

        private void kl32_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl32.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl3.Name, kl32.Name);
                p.ShowDialog();
            }
        }

        private void kl33_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl33.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl3.Name, kl33.Name);
                p.ShowDialog();
            }
        }

        private void kl34_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl34.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl3.Name, kl34.Name);
                p.ShowDialog();
            }
        }

        private void kl41_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl41.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl4.Name, kl41.Name);
                p.ShowDialog();
            }
        }

        private void kl42_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl42.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl4.Name, kl42.Name);
                p.ShowDialog();
            }
        }

        private void kl43_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl43.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl4.Name, kl43.Name);
                p.ShowDialog();
            }
        }

        private void kl44_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl44.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl4.Name, kl44.Name);
                p.ShowDialog();
            }
        }

        private void kl51_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl51.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl5.Name, kl51.Name);
                p.ShowDialog();
            }
        }

        private void kl52_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl52.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl5.Name, kl52.Name);
                p.ShowDialog();
            }
        }

        private void kl53_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl53.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl5.Name, kl53.Name);
                p.ShowDialog();
            }
        }

        private void kl54_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl54.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl5.Name, kl54.Name);
                p.ShowDialog();
            }
        }

        private void kl61_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl61.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl6.Name, kl61.Name);
                p.ShowDialog();
            }
        }

        private void kl62_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl62.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl6.Name, kl62.Name);
                p.ShowDialog();
            }
        }

        private void kl63_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl63.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl6.Name, kl63.Name);
                p.ShowDialog();
            }
        }

        private void kl64_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl64.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl6.Name, kl64.Name);
                p.ShowDialog();
            }
        }

        private void kl71_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl71.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl7.Name, kl71.Name);
                p.ShowDialog();
            }
        }

        private void kl72_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl72.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl7.Name, kl72.Name);
                p.ShowDialog();
            }
        }

        private void kl73_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl73.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl7.Name, kl73.Name);
                p.ShowDialog();
            }
        }

        private void kl74_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLL.Equals("CHK") && kl74.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LL.Text, kl7.Name, kl74.Name);
                p.ShowDialog();
            }
        }

        private void kd11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd1.Name, kd11.Name);
                p.ShowDialog();
            }
        }

        private void kd12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd1.Name, kd12.Name);
                p.ShowDialog();
            }
        }

        private void kd13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd1.Name, kd13.Name);
                p.ShowDialog();
            }
        }

        private void kd14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd1.Name, kd14.Name);
                p.ShowDialog();
            }
        }

        private void kd21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd2.Name, kd21.Name);
                p.ShowDialog();
            }
        }

        private void kd22_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd22.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd2.Name, kd22.Name);
                p.ShowDialog();
            }
        }

        private void kd23_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd23.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd2.Name, kd23.Name);
                p.ShowDialog();
            }
        }

        private void kd24_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd24.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd2.Name, kd24.Name);
                p.ShowDialog();
            }
        }

        private void kd31_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd31.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd3.Name, kd31.Name);
                p.ShowDialog();
            }
        }

        private void kd32_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd32.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd3.Name, kd32.Name);
                p.ShowDialog();
            }
        }

        private void kd33_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd33.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd3.Name, kd33.Name);
                p.ShowDialog();
            }
        }

        private void kd34_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd34.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd3.Name, kd34.Name);
                p.ShowDialog();
            }
        }

        private void kd41_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd41.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd4.Name, kd41.Name);
                p.ShowDialog();
            }
        }

        private void kd42_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd42.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd4.Name, kd42.Name);
                p.ShowDialog();
            }
        }

        private void kd43_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd43.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd4.Name, kd43.Name);
                p.ShowDialog();
            }
        }

        private void kd44_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd44.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd4.Name, kd44.Name);
                p.ShowDialog();
            }
        }

        private void kd51_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd51.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd5.Name, kd51.Name);
                p.ShowDialog();
            }
        }

        private void kd52_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd52.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd5.Name, kd52.Name);
                p.ShowDialog();
            }
        }

        private void kd53_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd53.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd5.Name, kd53.Name);
                p.ShowDialog();
            }
        }

        private void kd54_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd54.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd5.Name, kd54.Name);
                p.ShowDialog();
            }
        }

        private void kd61_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd61.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd6.Name, kd61.Name);
                p.ShowDialog();
            }
        }

        private void kd62_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd62.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd6.Name, kd62.Name);
                p.ShowDialog();
            }
        }

        private void kd63_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd63.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd6.Name, kd63.Name);
                p.ShowDialog();
            }
        }

        private void kd64_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd64.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd6.Name, kd64.Name);
                p.ShowDialog();
            }
        }

        private void kd71_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd71.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd7.Name, kd71.Name);
                p.ShowDialog();
            }
        }

        private void kd72_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd72.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd7.Name, kd72.Name);
                p.ShowDialog();
            }
        }

        private void kd73_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd73.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd7.Name, kd73.Name);
                p.ShowDialog();
            }
        }

        private void kd74_Click(object sender, EventArgs e)
        {
            if (buttonSelectedLD.Equals("CHK") && kd74.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(LD.Text, kd7.Name, kd74.Name);
                p.ShowDialog();
            }
        }

        private void button160_Click(object sender, EventArgs e)
        {
            buttonSelectedf1 = btnnumofQout.Text;
            f1name();
            calQoutationf1();
            lbf1.Text = "Quotation";
        }

        private void button166_Click(object sender, EventArgs e)
        {
            buttonSelectedf2 = btnnumofQout.Text;
            f2name();
            calQoutationf2();
            lbf2.Text = "Quotation";
        }

        private void button175_Click(object sender, EventArgs e)
        {
            buttonSelectedf3 = btnnumofQout.Text;
            f3name();
            calQoutationf3();
            lbf3.Text = "Quotation";
        }

        private void button184_Click(object sender, EventArgs e)
        {
            buttonSelectedf4 = btnnumofQout.Text;
            f4name();
            calQoutationf4();
            lbf4.Text = "Quotation";
        }

        private void button193_Click(object sender, EventArgs e)
        {
            buttonSelectedf5 = btnnumofQout.Text;
            f5name();
            calQoutationf5();
            lbf5.Text = "Quotation";
        }

        private void button202_Click(object sender, EventArgs e)
        {
            buttonSelectedf6 = btnnumofQout.Text;
            f6name();
            calQoutationf6();
            lbf6.Text = "Quotation";
        }

        private void button211_Click(object sender, EventArgs e)
        {
            buttonSelectedf7 = btnnumofQout.Text;
            f7name();
            calQoutationf7();
            lbf7.Text = "Quotation";
        }

        private void button220_Click(object sender, EventArgs e)
        {
            buttonSelectedf8 = btnnumofQout.Text;
            f8name();
            calQoutationf8();
            lbf8.Text = "Quotation";
        }

        private void button229_Click(object sender, EventArgs e)
        {
            buttonSelectedf9 = btnnumofQout.Text;
            f9name();
            calQoutationf9();
            lbf9.Text = "Quotation";
        }

        private void button238_Click(object sender, EventArgs e)
        {
            buttonSelectedf10 = btnnumofQout.Text;
            f10name();
            calQoutationf10();
            lbf10.Text = "Quotation";
        }

        private void button247_Click(object sender, EventArgs e)
        {
            buttonSelectedf11 = btnnumofQout.Text;
            f11name();
            calQoutationf11();
            lbf11.Text = "Quotation";
        }

        private void button256_Click(object sender, EventArgs e)
        {
            buttonSelectedf12 = btnnumofQout.Text;
            f12name();
            calQoutationf12();
            lbf12.Text = "Quotation";
        }

        private void button265_Click(object sender, EventArgs e)
        {
            buttonSelectedf13 = btnnumofQout.Text;
            f13name();
            calQoutationf13();
            lbf13.Text = "Quotation";
        }

        private void button274_Click(object sender, EventArgs e)
        {
            buttonSelectedf14 = btnnumofQout.Text;
            f14name();
            calQoutationf14();
            lbf14.Text = "Quotation";
        }

        private void button283_Click(object sender, EventArgs e)
        {
            buttonSelectedf15 = btnnumofQout.Text;
            f15name();
            calQoutationf15();
            lbf15.Text = "Quotation";
        }

        private void button292_Click(object sender, EventArgs e)
        {
            buttonSelectedf16 = btnnumofQout.Text;
            f16name();
            calQoutationf16();
            lbf16.Text = "Quotation";
        }

        private void button302_Click(object sender, EventArgs e)
        {
            buttonSelectedf17 = btnnumofQout.Text;
            f17name();
            calQoutationf17();
            lbf17.Text = "Quotation";
        }

        private void button311_Click(object sender, EventArgs e)
        {
            buttonSelectedf18 = btnnumofQout.Text;
            f18name();
            calQoutationf18();
            lbf18.Text = "Quotation";
        }

        private void button320_Click(object sender, EventArgs e)
        {
            buttonSelectedf19 = btnnumofQout.Text;
            f19name();
            calQoutationf19();
            lbf19.Text = "Quotation";
        }

        private void button329_Click(object sender, EventArgs e)
        {
            buttonSelectedf20 = btnnumofQout.Text;
            f20name();
            calQoutationf20();
            lbf20.Text = "Quotation";
        }

        private void button338_Click(object sender, EventArgs e)
        {
            buttonSelectedf21 = btnnumofQout.Text;
            f21name();
            calQoutationf21();
            lbf21.Text = "Quotation";
        }

        private void button159_Click(object sender, EventArgs e)
        {
            buttonSelectedf1 = Btnnumoforder.Text;
            f1name();
            calOrderf1();
            lbf1.Text = "Order";
        }

        private void button165_Click(object sender, EventArgs e)
        {
            buttonSelectedf2 = Btnnumoforder.Text;
            f2name();
            calOrderf2();
            lbf2.Text = "Order";
        }

        private void button174_Click(object sender, EventArgs e)
        {
            buttonSelectedf3 = Btnnumoforder.Text;
            f3name();
            calOrderf3();
            lbf3.Text = "Order";
        }

        private void button183_Click(object sender, EventArgs e)
        {
            buttonSelectedf4 = Btnnumoforder.Text;
            f4name();
            calOrderf4();
            lbf4.Text = "Order";
        }

        private void button192_Click(object sender, EventArgs e)
        {
            buttonSelectedf5 = Btnnumoforder.Text;
            f5name();
            calOrderf5();
            lbf5.Text = "Order";
        }

        private void button201_Click(object sender, EventArgs e)
        {
            buttonSelectedf6 = Btnnumoforder.Text;
            f6name();
            calOrderf6();
            lbf6.Text = "Order";
        }

        private void button210_Click(object sender, EventArgs e)
        {
            buttonSelectedf7 = Btnnumoforder.Text;
            f7name();
            calOrderf7();
            lbf7.Text = "Order";
        }

        private void button219_Click(object sender, EventArgs e)
        {
            buttonSelectedf8 = Btnnumoforder.Text;
            f8name();
            calOrderf8();
            lbf8.Text = "Order";
        }

        private void button228_Click(object sender, EventArgs e)
        {
            buttonSelectedf9 = Btnnumoforder.Text;
            f9name();
            calOrderf9();
            lbf9.Text = "Order";
        }

        private void button237_Click(object sender, EventArgs e)
        {
            buttonSelectedf10 = Btnnumoforder.Text;
            f10name();
            calOrderf10();
            lbf10.Text = "Order";
        }

        private void button246_Click(object sender, EventArgs e)
        {
            buttonSelectedf11 = Btnnumoforder.Text;
            f11name();
            calOrderf11();
            lbf11.Text = "Order";
        }

        private void button255_Click(object sender, EventArgs e)
        {
            buttonSelectedf12 = Btnnumoforder.Text;
            f12name();
            calOrderf12();
            lbf12.Text = "Order";
        }

        private void button264_Click(object sender, EventArgs e)
        {
            buttonSelectedf13 = Btnnumoforder.Text;
            f13name();
            calOrderf13();
            lbf13.Text = "Order";
        }

        private void button273_Click(object sender, EventArgs e)
        {
            buttonSelectedf14 = Btnnumoforder.Text;
            f14name();
            calOrderf14();
            lbf14.Text = "Order";
        }

        private void button282_Click(object sender, EventArgs e)
        {
            buttonSelectedf15 = Btnnumoforder.Text;
            f15name();
            calOrderf15();
            lbf15.Text = "Order";
        }

        private void button291_Click(object sender, EventArgs e)
        {
            buttonSelectedf16 = Btnnumoforder.Text;
            f16name();
            calOrderf16();
            lbf16.Text = "Order";
        }

        private void button301_Click(object sender, EventArgs e)
        {
            buttonSelectedf17 = Btnnumoforder.Text;
            f17name();
            calOrderf17();
            lbf17.Text = "Order";
        }

        private void button310_Click(object sender, EventArgs e)
        {
            buttonSelectedf18 = Btnnumoforder.Text;
            f18name();
            calOrderf18();
            lbf18.Text = "Order";
        }

        private void button319_Click(object sender, EventArgs e)
        {
            buttonSelectedf19 = Btnnumoforder.Text;
            f19name();
            calOrderf19();
            lbf19.Text = "Order";
        }

        private void button328_Click(object sender, EventArgs e)
        {
            buttonSelectedf20 = Btnnumoforder.Text;
            f20name();
            calOrderf20();
            lbf20.Text = "Order";
        }

        private void button337_Click(object sender, EventArgs e)
        {
            buttonSelectedf21 = Btnnumoforder.Text;
            f21name();
            calOrderf21();
            lbf21.Text = "Order";
        }

        private void button158_Click(object sender, EventArgs e)
        {
            buttonSelectedf1 = BtnNumofbill.Text;
            f1name();
            calBillf1();
            lbf1.Text = "Bill";
        }

        private void button164_Click(object sender, EventArgs e)
        {
            buttonSelectedf2 = BtnNumofbill.Text;
            f2name();
            calBillf2();
            lbf2.Text = "Bill";
        }

        private void button173_Click(object sender, EventArgs e)
        {
            buttonSelectedf3 = BtnNumofbill.Text;
            f3name();
            calBillf3();
            lbf3.Text = "Bill";
        }

        private void button182_Click(object sender, EventArgs e)
        {
            buttonSelectedf4 = BtnNumofbill.Text;
            f4name();
            calBillf4();
            lbf4.Text = "Bill";
        }

        private void button191_Click(object sender, EventArgs e)
        {
            buttonSelectedf5 = BtnNumofbill.Text;
            f5name();
            calBillf5();
            lbf5.Text = "Bill";
        }

        private void button200_Click(object sender, EventArgs e)
        {
            buttonSelectedf6 = BtnNumofbill.Text;
            f6name();
            calBillf6();
            lbf6.Text = "Bill";
        }

        private void button209_Click(object sender, EventArgs e)
        {
            buttonSelectedf7 = BtnNumofbill.Text;
            f7name();
            calBillf7();
            lbf7.Text = "Bill";
        }

        private void button218_Click(object sender, EventArgs e)
        {
            buttonSelectedf8 = BtnNumofbill.Text;
            f8name();
            calBillf8();
            lbf8.Text = "Bill";
        }

        private void button227_Click(object sender, EventArgs e)
        {
            buttonSelectedf9 = BtnNumofbill.Text;
            f9name();
            calBillf9();
            lbf9.Text = "Bill";
        }

        private void button236_Click(object sender, EventArgs e)
        {
            buttonSelectedf10 = BtnNumofbill.Text;
            f10name();
            calBillf10();
            lbf10.Text = "Bill";
        }

        private void button245_Click(object sender, EventArgs e)
        {
            buttonSelectedf11 = BtnNumofbill.Text;
            f11name();
            calBillf11();
            lbf11.Text = "Bill";
        }

        private void fs114_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf11.Equals("CHK") && fs114.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f11.Text, fs114.Name, "0");
                p.ShowDialog();
            }
        }

        private void f11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf11.Equals("CHK") && f11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f11.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void button254_Click(object sender, EventArgs e)
        {
            buttonSelectedf12 = BtnNumofbill.Text;
            f12name();
            calBillf12();
            lbf12.Text = "Bill";
        }

        private void button263_Click(object sender, EventArgs e)
        {
            buttonSelectedf13 = BtnNumofbill.Text;
            f13name();
            calBillf13();
            lbf13.Text = "Bill";
        }

        private void button272_Click(object sender, EventArgs e)
        {
            buttonSelectedf14 = BtnNumofbill.Text;
            f14name();
            calBillf14();
            lbf14.Text = "Bill";
        }

        private void button281_Click(object sender, EventArgs e)
        {
            buttonSelectedf15 = BtnNumofbill.Text;
            f15name();
            calBillf15();
            lbf15.Text = "Bill";
        }

        private void button290_Click(object sender, EventArgs e)
        {
            buttonSelectedf16 = BtnNumofbill.Text;
            f16name();
            calBillf16();
            lbf16.Text = "Bill";
        }

        private void button300_Click(object sender, EventArgs e)
        {
            buttonSelectedf17 = BtnNumofbill.Text;
            f17name();
            calBillf17();
            lbf17.Text = "Bill";
        }

        private void button309_Click(object sender, EventArgs e)
        {
            buttonSelectedf18 = BtnNumofbill.Text;
            f18name();
            calBillf18();
            lbf18.Text = "Bill";
        }

        private void button318_Click(object sender, EventArgs e)
        {
            buttonSelectedf19 = BtnNumofbill.Text;
            f19name();
            calBillf19();
            lbf19.Text = "Bill";
        }

        private void button327_Click(object sender, EventArgs e)
        {
            buttonSelectedf20 = BtnNumofbill.Text;
            f20name();
            calBillf20();
            lbf20.Text = "Bill";
        }

        private void button336_Click(object sender, EventArgs e)
        {
            buttonSelectedf21 = BtnNumofbill.Text;
            f21name();
            calBillf21();
            lbf21.Text = "Bill";
        }

        private void btnchkf1_Click(object sender, EventArgs e)
        {
            buttonSelectedf1 = "CHK";
            if (rdnof1.Checked)
            {
                f1name();
                NoOrderf1();
                lbf1.Text = "No Order";
            }
            else if (rdsof1.Checked)
            {
                f1name();
                SomeOrderf1();
                lbf1.Text = "Some Order";
            }
        }

        private void btnchkf2_Click(object sender, EventArgs e)
        {
            buttonSelectedf2 = "CHK";
            if (rdnof2.Checked)
            {
                f2name();
                NoOrderf2();
                lbf2.Text = "No Order";
            }
            else if (rdsof2.Checked)
            {
                f2name();
                SomeOrderf2();
                lbf2.Text = "Some Order";
            }
        }

        private void btnchkf3_Click(object sender, EventArgs e)
        {
            buttonSelectedf3 = "CHK";
            if (rdnof3.Checked)
            {
                f3name();
                NoOrderf3();
                lbf3.Text = "No Order";
            }
            else if (rdsof3.Checked)
            {
                f3name();
                SomeOrderf3();
                lbf3.Text = "Some Order";
            }
        }

        private void btnchkf4_Click(object sender, EventArgs e)
        {
            buttonSelectedf4 = "CHK";
            if (rdnof4.Checked)
            {
                f4name();
                NoOrderf4();
                lbf4.Text = "No Order";
            }
            else if (rdsof4.Checked)
            {
                f4name();
                SomeOrderf4();
                lbf4.Text = "Some Order";
            }
        }

        private void btnchkf5_Click(object sender, EventArgs e)
        {
            buttonSelectedf5 = "CHK";
            if (rdnof5.Checked)
            {
                f5name();
                NoOrderf5();
                lbf5.Text = "No Order";
            }
            else if (rdsof5.Checked)
            {
                f5name();
                SomeOrderf5();
                lbf5.Text = "Some Order";
            }
        }

        private void btnchkf6_Click(object sender, EventArgs e)
        {
            buttonSelectedf6 = "CHK";
            if (rdnof6.Checked)
            {
                f6name();
                NoOrderf6();
                lbf6.Text = "No Order";
            }
            else if (rdsof6.Checked)
            {
                f6name();
                SomeOrderf6();
                lbf6.Text = "Some Order";
            }
        }

        private void btnchkf7_Click(object sender, EventArgs e)
        {
            buttonSelectedf7 = "CHK";
            if (rdnof7.Checked)
            {
                f7name();
                NoOrderf7();
                lbf7.Text = "No Order";
            }
            else if (rdsof7.Checked)
            {
                f7name();
                SomeOrderf7();
                lbf7.Text = "Some Order";
            }
        }

        private void btnchkf8_Click(object sender, EventArgs e)
        {
            buttonSelectedf8 = "CHK";
            if (rdnof8.Checked)
            {
                f8name();
                NoOrderf8();
                lbf8.Text = "No Order";
            }
            else if (rdsof8.Checked)
            {
                f8name();
                SomeOrderf8();
                lbf8.Text = "Some Order";
            }
        }

        private void btnchkf9_Click(object sender, EventArgs e)
        {
            buttonSelectedf9 = "CHK";
            if (rdnof9.Checked)
            {
                f9name();
                NoOrderf9();
                lbf9.Text = "No Order";
            }
            else if (rdsof9.Checked)
            {
                f9name();
                SomeOrderf9();
                lbf9.Text = "Some Order";
            }
        }

        private void button239_Click(object sender, EventArgs e)
        {
            buttonSelectedf10 = "CHK";
            if (rdnof10.Checked)
            {
                f10name();
                NoOrderf10();
                lbf10.Text = "No Order";
            }
            else if (rdsof10.Checked)
            {
                f10name();
                SomeOrderf10();
                lbf10.Text = "Some Order";
            }
        }

        private void btnchkf11_Click(object sender, EventArgs e)
        {
            buttonSelectedf11 = "CHK";
            if (rdnof11.Checked)
            {
                f11name();
                NoOrderf11();
                lbf11.Text = "No Order";
            }
            else if (rdsof11.Checked)
            {
                f11name();
                SomeOrderf11();
                lbf11.Text = "Some Order";
            }
        }

        private void btnchkf12_Click(object sender, EventArgs e)
        {
            buttonSelectedf12 = "CHK";
            if (rdnof12.Checked)
            {
                f12name();
                NoOrderf12();
                lbf12.Text = "No Order";
            }
            else if (rdsof12.Checked)
            {
                f12name();
                SomeOrderf12();
                lbf12.Text = "Some Order";
            }
        }

        private void btnchkf13_Click(object sender, EventArgs e)
        {
            buttonSelectedf13 = "CHK";
            if (rdnof13.Checked)
            {
                f13name();
                NoOrderf13();
                lbf13.Text = "No Order";
            }
            else if (rdsof13.Checked)
            {
                f13name();
                SomeOrderf13();
                lbf13.Text = "Some Order";
            }
        }

        private void btnchkf14_Click(object sender, EventArgs e)
        {
            buttonSelectedf14 = "CHK";
            if (rdnof14.Checked)
            {
                f14name();
                NoOrderf14();
                lbf14.Text = "No Order";
            }
            else if (rdsof14.Checked)
            {
                f14name();
                SomeOrderf14();
                lbf14.Text = "Some Order";
            }
        }

        private void btnchkf15_Click(object sender, EventArgs e)
        {
            buttonSelectedf15 = "CHK";
            if (rdnof15.Checked)
            {
                f15name();
                NoOrderf15();
                lbf15.Text = "No Order";
            }
            else if (rdsof15.Checked)
            {
                f15name();
                SomeOrderf15();
                lbf15.Text = "Some Order";
            }
        }

        private void btnchkf16_Click(object sender, EventArgs e)
        {
            buttonSelectedf16 = "CHK";
            if (rdnof16.Checked)
            {
                f16name();
                NoOrderf16();
                lbf16.Text = "No Order";
            }
            else if (rdsof16.Checked)
            {
                f16name();
                SomeOrderf16();
                lbf16.Text = "Some Order";
            }
        }

        private void btnchkf17_Click(object sender, EventArgs e)
        {
            buttonSelectedf17 = "CHK";
            if (rdnof17.Checked)
            {
                f17name();
                NoOrderf17();
                lbf17.Text = "No Order";
            }
            else if (rdsof17.Checked)
            {
                f17name();
                SomeOrderf17();
                lbf17.Text = "Some Order";
            }
        }

        private void btnchkf18_Click(object sender, EventArgs e)
        {
            buttonSelectedf18 = "CHK";
            if (rdnof18.Checked)
            {
                f18name();
                NoOrderf18();
                lbf18.Text = "No Order";
            }
            else if (rdsof18.Checked)
            {
                f18name();
                SomeOrderf18();
                lbf18.Text = "Some Order";
            }
        }

        private void btnchkf19_Click(object sender, EventArgs e)
        {
            buttonSelectedf19 = "CHK";
            if (rdnof19.Checked)
            {
                f19name();
                NoOrderf19();
                lbf19.Text = "No Order";
            }
            else if (rdsof19.Checked)
            {
                f19name();
                SomeOrderf19();
                lbf19.Text = "Some Order";
            }
        }

        private void btnchkf20_Click(object sender, EventArgs e)
        {
            buttonSelectedf20 = "CHK";
            if (rdnof20.Checked)
            {
                f20name();
                NoOrderf20();
                lbf20.Text = "No Order";
            }
            else if (rdsof20.Checked)
            {
                f20name();
                SomeOrderf20();
                lbf20.Text = "Some Order";
            }
        }

        private void btnchkf21_Click(object sender, EventArgs e)
        {
            buttonSelectedf21 = "CHK";
            if (rdnof21.Checked)
            {
                f21name();
                NoOrderf21();
                lbf21.Text = "No Order";
            }
            else if (rdsof21.Checked)
            {
                f21name();
                SomeOrderf21();
                lbf21.Text = "Some Order";
            }
        }

        private void f1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf1.Equals("CHK") && f1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f1.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf2.Equals("CHK") && f2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f2.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf3.Equals("CHK") && f3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f3.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f4_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf4.Equals("CHK") && f4.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f4.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf5.Equals("CHK") && f5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f5.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf6.Equals("CHK") && f6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f6.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f7_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf7.Equals("CHK") && f7.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f7.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f8_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf8.Equals("CHK") && f8.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f8.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f9_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf9.Equals("CHK") && f9.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f9.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f10_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf10.Equals("CHK") && f10.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f10.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf12.Equals("CHK") && f12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f12.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf13.Equals("CHK") && f13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f13.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf14.Equals("CHK") && f14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f14.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f15_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf15.Equals("CHK") && f15.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f15.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f16_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf16.Equals("CHK") && f16.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f16.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f17_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf17.Equals("CHK") && f17.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f17.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f18_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf18.Equals("CHK") && f18.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f18.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f19_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf19.Equals("CHK") && f19.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f19.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f20_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf20.Equals("CHK") && f20.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f20.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void f21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf21.Equals("CHK") && f21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f21.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void fs11_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf1.Equals("CHK") && fs11.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f1.Text, fs11.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs12_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf1.Equals("CHK") && fs12.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f1.Text, fs12.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs13_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf1.Equals("CHK") && fs13.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f1.Text, fs13.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs14_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf1.Equals("CHK") && fs14.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f1.Text, fs14.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs21_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf2.Equals("CHK") && fs21.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f2.Text, fs21.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs22_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf2.Equals("CHK") && fs22.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f2.Text, fs22.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs23_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf2.Equals("CHK") && fs23.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f2.Text, fs23.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs24_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf2.Equals("CHK") && fs24.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f2.Text, fs24.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs31_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf3.Equals("CHK") && fs31.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f3.Text, fs31.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs32_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf3.Equals("CHK") && fs32.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f3.Text, fs32.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs33_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf3.Equals("CHK") && fs33.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f3.Text, fs33.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs34_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf3.Equals("CHK") && fs34.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f3.Text, fs34.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs41_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf4.Equals("CHK") && fs41.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f4.Text, fs41.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs42_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf4.Equals("CHK") && fs42.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f4.Text, fs42.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs43_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf4.Equals("CHK") && fs43.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f4.Text, fs43.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs44_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf4.Equals("CHK") && fs44.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f4.Text, fs44.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs51_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf5.Equals("CHK") && fs51.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f5.Text, fs51.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs52_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf5.Equals("CHK") && fs52.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f5.Text, fs52.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs53_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf5.Equals("CHK") && fs53.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f5.Text, fs53.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs54_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf5.Equals("CHK") && fs54.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f5.Text, fs54.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs61_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf6.Equals("CHK") && fs61.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f6.Text, fs61.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs62_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf6.Equals("CHK") && fs62.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f6.Text, fs62.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs63_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf6.Equals("CHK") && fs63.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f6.Text, fs63.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs64_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf6.Equals("CHK") && fs64.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f6.Text, fs64.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs71_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf7.Equals("CHK") && fs71.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f7.Text, fs71.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs72_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf7.Equals("CHK") && fs72.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f7.Text, fs72.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs73_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf7.Equals("CHK") && fs73.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f7.Text, fs73.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs74_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf7.Equals("CHK") && fs74.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f7.Text, fs74.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs81_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf8.Equals("CHK") && fs81.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f8.Text, fs81.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs82_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf8.Equals("CHK") && fs82.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f8.Text, fs82.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs83_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf8.Equals("CHK") && fs83.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f8.Text, fs83.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs84_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf8.Equals("CHK") && fs84.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f8.Text, fs84.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs91_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf9.Equals("CHK") && fs91.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f9.Text, fs91.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs92_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf9.Equals("CHK") && fs92.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f9.Text, fs92.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs93_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf9.Equals("CHK") && fs93.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f9.Text, fs93.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs94_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf9.Equals("CHK") && fs94.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f9.Text, fs94.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs101_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf10.Equals("CHK") && fs101.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f10.Text, fs101.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs102_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf10.Equals("CHK") && fs102.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f10.Text, fs102.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs103_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf10.Equals("CHK") && fs103.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f10.Text, fs103.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs104_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf10.Equals("CHK") && fs104.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f10.Text, fs104.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs111_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf11.Equals("CHK") && fs111.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f11.Text, fs111.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs112_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf11.Equals("CHK") && fs112.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f11.Text, fs112.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs113_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf11.Equals("CHK") && fs113.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f11.Text, fs113.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs121_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf12.Equals("CHK") && fs121.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f12.Text, fs121.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs122_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf12.Equals("CHK") && fs122.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f12.Text, fs122.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs123_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf12.Equals("CHK") && fs123.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f12.Text, fs123.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs124_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf12.Equals("CHK") && fs124.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f12.Text, fs124.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs131_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf13.Equals("CHK") && fs131.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f13.Text, fs131.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs132_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf13.Equals("CHK") && fs132.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f13.Text, fs132.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs133_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf13.Equals("CHK") && fs133.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f13.Text, fs133.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs134_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf13.Equals("CHK") && fs134.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f13.Text, fs134.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs141_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf14.Equals("CHK") && fs141.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f14.Text, fs141.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs142_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf14.Equals("CHK") && fs142.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f14.Text, fs142.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs143_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf14.Equals("CHK") && fs143.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f14.Text, fs143.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs144_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf14.Equals("CHK") && fs144.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f14.Text, fs144.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs151_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf15.Equals("CHK") && fs151.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f15.Text, fs151.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs152_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf15.Equals("CHK") && fs152.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f15.Text, fs152.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs153_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf15.Equals("CHK") && fs153.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f15.Text, fs153.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs154_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf15.Equals("CHK") && fs154.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f15.Text, fs154.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs161_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf16.Equals("CHK") && fs161.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f16.Text, fs161.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs162_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf16.Equals("CHK") && fs162.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f16.Text, fs162.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs163_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf16.Equals("CHK") && fs163.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f16.Text, fs163.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs164_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf16.Equals("CHK") && fs164.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f16.Text, fs164.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs171_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf17.Equals("CHK") && fs171.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f17.Text, fs171.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs172_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf17.Equals("CHK") && fs172.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f17.Text, fs172.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs173_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf17.Equals("CHK") && fs173.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f17.Text, fs173.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs174_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf17.Equals("CHK") && fs174.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f17.Text, fs174.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs181_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf18.Equals("CHK") && fs181.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f18.Text, fs181.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs182_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf18.Equals("CHK") && fs182.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f18.Text, fs182.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs183_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf18.Equals("CHK") && fs183.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f18.Text, fs183.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs184_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf18.Equals("CHK") && fs184.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f18.Text, fs184.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs191_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf19.Equals("CHK") && fs191.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f19.Text, fs191.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs192_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf19.Equals("CHK") && fs192.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f19.Text, fs192.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs193_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf19.Equals("CHK") && fs193.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f19.Text, fs193.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs194_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf19.Equals("CHK") && fs194.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f19.Text, fs194.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs201_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf20.Equals("CHK") && fs201.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f20.Text, fs201.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs202_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf20.Equals("CHK") && fs202.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f20.Text, fs202.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs203_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf20.Equals("CHK") && fs203.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f20.Text, fs203.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs204_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf20.Equals("CHK") && fs204.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f20.Text, fs204.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs211_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf21.Equals("CHK") && fs211.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f21.Text, fs211.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs212_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf21.Equals("CHK") && fs212.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f21.Text, fs212.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs213_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf21.Equals("CHK") && fs213.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f21.Text, fs213.Name, "0");
                p.ShowDialog();
            }
        }

        private void fs214_Click(object sender, EventArgs e)
        {
            if (buttonSelectedf21.Equals("CHK") && fs214.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(f21.Text, fs214.Name, "0");
                p.ShowDialog();
            }
        }

        private void button371_Click(object sender, EventArgs e)
        {
            //Leyoa
            btnnumofQout_Click(null, null);
            button3_Click(null, null);
            button6_Click(null, null);
            button9_Click(null, null);
            button12_Click(null, null);
            button15_Click(null, null);
            button18_Click(null, null);
            button21_Click(null, null);
            button24_Click(null, null);
            button27_Click(null, null);
            button30_Click(null, null);
            button35_Click(null, null);
            button75_Click(null, null);
            button115_Click(null, null);
            //Fog
            button160_Click(null, null);
            button166_Click(null,null);
            button175_Click(null,null);
            button184_Click(null,null);
            button193_Click(null,null);
            button202_Click(null,null);
            button211_Click(null,null);
            button220_Click(null,null);
            button229_Click(null,null);
            button238_Click(null,null);
            button247_Click(null,null);
            button256_Click(null,null);
            button265_Click(null,null);
            button274_Click(null,null);
            button283_Click(null,null);
            button292_Click(null, null);
            button302_Click(null, null);
            button311_Click(null, null);
            button320_Click(null, null);
            button329_Click(null, null);
            button338_Click(null, null);

            button343_Click(null,null);
            button348_Click(null,null);
            button353_Click(null,null);
            button358_Click(null,null);
            button363_Click(null,null);
            button368_Click(null,null);

        }

        private void button372_Click(object sender, EventArgs e)
        {
            //Lyoa
            Btnnumoforder_Click(null, null);
            button2_Click(null, null);
            button5_Click(null, null);
            button8_Click(null,null);
            button11_Click(null,null);
            button14_Click(null,null);
            button17_Click(null,null);
            button20_Click(null,null);
            button23_Click(null,null);
            button26_Click(null,null);
            button29_Click(null,null);
            button34_Click(null,null);
            button74_Click(null,null);
            button114_Click(null,null);
            //Fog
            button159_Click(null,null);
            button165_Click(null,null);
            button174_Click(null,null);
            button183_Click(null,null);
            button192_Click(null,null);
            button201_Click(null,null);
            button210_Click(null,null);
            button219_Click(null,null);
            button228_Click(null,null);
            button237_Click(null,null);
            button246_Click(null,null);
            button255_Click(null,null);
            button264_Click(null,null);
            button273_Click(null,null);
            button282_Click(null,null);
            button291_Click(null,null);
            button301_Click(null,null);
            button310_Click(null,null);
            button310_Click(null,null);
            button328_Click(null,null);
            button337_Click(null,null);
            button319_Click(null,null);

            button342_Click(null,null);
            button347_Click(null,null);
            button352_Click(null,null);
            button357_Click(null,null);
            button362_Click(null,null);
            button367_Click(null,null);
        }

        private void button373_Click(object sender, EventArgs e)
        {
            //
            BtnNumofbill_Click(null,null);
            button1_Click_1(null,null);
            button4_Click(null,null);
            button7_Click(null,null);
            button10_Click(null,null);
            button13_Click(null,null);
            button16_Click(null,null);
            button19_Click(null,null);
            button22_Click(null,null);
            button25_Click(null,null);
            button28_Click(null,null);
            button33_Click(null,null);
            button73_Click(null,null);
            button113_Click(null,null);
            //
            button158_Click(null,null);
            button164_Click(null,null);
            button173_Click(null,null);
            button182_Click(null,null);
            button191_Click(null,null);
            button200_Click(null,null);
            button209_Click(null,null);
            button218_Click(null,null);
            button227_Click(null,null);
            button236_Click(null,null);
            button245_Click(null,null);
            button254_Click(null,null);
            button263_Click(null,null);
            button272_Click(null,null);
            button281_Click(null,null);
            button290_Click(null,null);
            button300_Click(null,null);
            button309_Click(null,null);
            button318_Click(null,null);
            button327_Click(null,null);
            button336_Click(null,null);

            button341_Click(null,null);
            button346_Click(null,null);
            button351_Click(null,null);
            button356_Click(null,null);
            button361_Click(null,null);
            button366_Click(null,null);
        }

        private void button344_Click(object sender, EventArgs e)
        {
            buttonSelectedp1 = "CHK";
            if (rdnop1.Checked)
            {
                PiecesName();
                NoOrderp1();
                lp1.Text = "No Order";
            }
            else if (rdsop1.Checked)
            {
                PiecesName();
                SomeOrderp1();
                lp1.Text = "Some Order";
            }
        }

        private void button349_Click(object sender, EventArgs e)
        {
            buttonSelectedp2 = "CHK";
            if (rdnop2.Checked)
            {
                PiecesName();
                NoOrderp2();
                lp2.Text = "No Order";
            }
            else if (rdsop2.Checked)
            {
                PiecesName();
                SomeOrderp2();
                lp2.Text = "Some Order";
            }
        }

        private void button354_Click(object sender, EventArgs e)
        {
            buttonSelectedp3 = "CHK";
            if (rdnop3.Checked)
            {
                PiecesName();
                NoOrderp3();
                lp3.Text = "No Order";
            }
            else if (rdsop3.Checked)
            {
                PiecesName();
                SomeOrderp3();
                lp3.Text = "Some Order";
            }
        }

        private void button359_Click(object sender, EventArgs e)
        {
            buttonSelectedp4 = "CHK";
            if (rdnop4.Checked)
            {
                PiecesName();
                NoOrderp4();
                lp4.Text = "No Order";
            }
            else if (rdsop4.Checked)
            {
                PiecesName();
                SomeOrderp4();
                lp4.Text = "Some Order";
            }
        }

        private void button364_Click(object sender, EventArgs e)
        {
            buttonSelectedp5 = "CHK";
            if (rdnop5.Checked)
            {
                PiecesName();
                NoOrderp5();
                lp5.Text = "No Order";
            }
            else if (rdsop5.Checked)
            {
                PiecesName();
                SomeOrderp5();
                lp5.Text = "Some Order";
            }
        }

        private void button369_Click(object sender, EventArgs e)
        {
            buttonSelectedp6 = "CHK";
            if (rdnop6.Checked)
            {
                PiecesName();
                NoOrderp6();
                lp6.Text = "No Order";
            }
            else if (rdsop6.Checked)
            {
                PiecesName();
                SomeOrderp6();
                lp6.Text = "Some Order";
            }
        }

        private void button343_Click(object sender, EventArgs e)
        {
            buttonSelectedp1 = btnnumofQout.Text;
            PiecesName();
            calQoutationp1();
            lp1.Text = "Quotation";
        }

        private void button348_Click(object sender, EventArgs e)
        {
            buttonSelectedp2 = btnnumofQout.Text;
            PiecesName();
            calQoutationp2();
            lp2.Text = "Quotation";
        }

        private void button353_Click(object sender, EventArgs e)
        {
            buttonSelectedp3 = btnnumofQout.Text;
            PiecesName();
            calQoutationp3();
            lp3.Text = "Quotation";
        }

        private void button358_Click(object sender, EventArgs e)
        {
            buttonSelectedp4 = btnnumofQout.Text;
            PiecesName();
            calQoutationp4();
            lp4.Text = "Quotation";
        }

        private void button363_Click(object sender, EventArgs e)
        {
            buttonSelectedp5 = btnnumofQout.Text;
            PiecesName();
            calQoutationp5();
            lp5.Text = "Quotation";
        }

        private void button368_Click(object sender, EventArgs e)
        {
            buttonSelectedp6 = btnnumofQout.Text;
            PiecesName();
            calQoutationp6();
            lp6.Text = "Quotation";
        }

        private void button342_Click(object sender, EventArgs e)
        {
            buttonSelectedp1 = Btnnumoforder.Text;
            PiecesName();
            calOrderp1();
            lp1.Text = "Order";
        }

        private void button347_Click(object sender, EventArgs e)
        {
            buttonSelectedp2 = Btnnumoforder.Text;
            PiecesName();
            calOrderp2();
            lp2.Text = "Order";
        }

        private void button352_Click(object sender, EventArgs e)
        {
            buttonSelectedp3 = Btnnumoforder.Text;
            PiecesName();
            calOrderp3();
            lp3.Text = "Order";
        }

        private void button357_Click(object sender, EventArgs e)
        {
            buttonSelectedp4 = Btnnumoforder.Text;
            PiecesName();
            calOrderp4();
            lp4.Text = "Order";
        }

        private void button362_Click(object sender, EventArgs e)
        {
            buttonSelectedp5 = Btnnumoforder.Text;
            PiecesName();
            calOrderp5();
            lp5.Text = "Order";
        }

        private void button367_Click(object sender, EventArgs e)
        {
            buttonSelectedp6 = Btnnumoforder.Text;
            PiecesName();
            calOrderp6();
            lp6.Text = "Order";
        }

        private void button341_Click(object sender, EventArgs e)
        {
            buttonSelectedp1 = BtnNumofbill.Text;
            PiecesName();
            calBillp1();
            lp1.Text = "Bill";
        }

        private void button346_Click(object sender, EventArgs e)
        {
            buttonSelectedp2 = BtnNumofbill.Text;
            PiecesName();
            calBillp2();
            lp2.Text = "Bill";
        }

        private void button351_Click(object sender, EventArgs e)
        {
            buttonSelectedp3 = BtnNumofbill.Text;
            PiecesName();
            calBillp3();
            lp3.Text = "Bill";
        }

        private void button356_Click(object sender, EventArgs e)
        {
            buttonSelectedp4 = BtnNumofbill.Text;
            PiecesName();
            calBillp4();
            lp4.Text = "Bill";
        }

        private void button361_Click(object sender, EventArgs e)
        {
            buttonSelectedp5 = BtnNumofbill.Text;
            PiecesName();
            calBillp5();
            lp5.Text = "Bill";
        }

        private void button366_Click(object sender, EventArgs e)
        {
            buttonSelectedp6 = BtnNumofbill.Text;
            PiecesName();
            calBillp6();
            lp6.Text = "Bill";
        }

        private void Piece1_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp1.Equals("CHK") && Piece1.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece1.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void Piece2_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp2.Equals("CHK") && Piece2.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece2.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void Piece3_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp3.Equals("CHK") && Piece3.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece3.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void Piece4_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp4.Equals("CHK") && Piece4.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece4.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void Piece5_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp5.Equals("CHK") && Piece5.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece5.Text, "0", "0");
                p.ShowDialog();
            }
        }

        private void Piece6_Click(object sender, EventArgs e)
        {
            if (buttonSelectedp6.Equals("CHK") && Piece6.BackColor == ActiveQuot)
            {
                FRM_ProcessDetails p = new FRM_ProcessDetails(Piece6.Text, "0", "0");
                p.ShowDialog();
            }
        }

       
        //***********************************************************
        //***********************************************************
        //************************************************************
        
        //***********************************************************
        //***********************************************************
        //************************************************************

        
    }
}
