using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;



namespace LoadWordSearch
{
    public partial class _Default : Page
    {

        string[][] validEntries;
        bool[][] openSpace;

        StreamWriter answerKey;
        public string RandomChar(Random random)
        {


      //      Random rand = new Random();

            int newCharIndex = random.Next(0, 26);


            string[] theAlphabet = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.WriteLine(theAlphabet[newCharIndex]);

            return theAlphabet[newCharIndex];




        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {





            }
            else
            {
               StreamReader answerKey = new StreamReader((@"C:\Users\Nathan\Desktop\AnswerKeys\answerKey54.txt"));


                Random random = new Random();


                openSpace = new bool[20][];
                validEntries = new string[20][];
                for (int i = 0; i < 20; i++)

                {
                    openSpace[i] = new bool[20];
                    validEntries[i] = new string[20];

                }

                for (int i = 0; i < 20; i++)
                    for (int j = 0; j < 20; j++)
                    {

                        openSpace[i][j] = false;
                        validEntries[i][j] = "";
                    }

                String answerLine = "";
                for (int i = 0; i < 20; i++)
                    for (int j = 0; j < 20; j++)
                    {
                        answerLine = answerKey.ReadLine();
                        if (!String.IsNullOrEmpty(answerLine))
                            // openSpace[i][j] = answerKey.ReadLine();
                            validEntries[i][j] = answerLine;


                    }

                for (int i = 0; i < 20; i++)
                    for (int j = 0; j < 20; j++)
                    {
                        String boolLine = answerKey.ReadLine();

                        if (!String.IsNullOrEmpty(boolLine))
                            openSpace[i][j] = Boolean.Parse(boolLine);

                    }


                #region tbs
                /*                #region tbs

                                if (tb0x0y.Text != "")
                                    if (tb0x0y.Text != "") { validEntries[0][0] = tb0x0y.Text; openSpace[0][0] = true; }
                                if (tb0x1y.Text != "") { validEntries[0][1] = tb0x1y.Text; openSpace[0][1] = true; }
                                if (tb0x2y.Text != "") { validEntries[0][2] = tb0x2y.Text; openSpace[0][2] = true; }
                                if (tb0x3y.Text != "") { validEntries[0][3] = tb0x3y.Text; openSpace[0][3] = true; }
                                if (tb0x4y.Text != "") { validEntries[0][4] = tb0x4y.Text; openSpace[0][4] = true; }
                                if (tb0x5y.Text != "") { validEntries[0][5] = tb0x5y.Text; openSpace[0][5] = true; }
                                if (tb0x6y.Text != "") { validEntries[0][6] = tb0x6y.Text; openSpace[0][6] = true; }
                                if (tb0x7y.Text != "") { validEntries[0][7] = tb0x7y.Text; openSpace[0][7] = true; }
                                if (tb0x8y.Text != "") { validEntries[0][8] = tb0x8y.Text; openSpace[0][8] = true; }
                                if (tb0x9y.Text != "") { validEntries[0][9] = tb0x9y.Text; openSpace[0][9] = true; }
                                if (tb0x10y.Text != "") { validEntries[0][10] = tb0x10y.Text; openSpace[0][10] = true; }
                                if (tb0x11y.Text != "") { validEntries[0][11] = tb0x11y.Text; openSpace[0][11] = true; }
                                if (tb0x12y.Text != "") { validEntries[0][12] = tb0x12y.Text; openSpace[0][12] = true; }
                                if (tb0x13y.Text != "") { validEntries[0][13] = tb0x13y.Text; openSpace[0][13] = true; }
                                if (tb0x14y.Text != "") { validEntries[0][14] = tb0x14y.Text; openSpace[0][14] = true; }
                                if (tb0x15y.Text != "") { validEntries[0][15] = tb0x15y.Text; openSpace[0][15] = true; }
                                if (tb0x16y.Text != "") { validEntries[0][16] = tb0x16y.Text; openSpace[0][16] = true; }
                                if (tb0x17y.Text != "") { validEntries[0][17] = tb0x17y.Text; openSpace[0][17] = true; }
                                if (tb0x18y.Text != "") { validEntries[0][18] = tb0x18y.Text; openSpace[0][18] = true; }
                                if (tb0x19y.Text != "") { validEntries[0][19] = tb0x19y.Text; openSpace[0][19] = true; }

                                if (tb1x0y.Text != "") { validEntries[1][0] = tb1x0y.Text; openSpace[1][0] = true; }
                                if (tb1x1y.Text != "") { validEntries[1][1] = tb1x1y.Text; openSpace[1][1] = true; }
                                if (tb1x2y.Text != "") { validEntries[1][2] = tb1x2y.Text; openSpace[1][2] = true; }
                                if (tb1x3y.Text != "") { validEntries[1][3] = tb1x3y.Text; openSpace[1][3] = true; }
                                if (tb1x4y.Text != "") { validEntries[1][4] = tb1x4y.Text; openSpace[1][4] = true; }
                                if (tb1x5y.Text != "") { validEntries[1][5] = tb1x5y.Text; openSpace[1][5] = true; }
                                if (tb1x6y.Text != "") { validEntries[1][6] = tb1x6y.Text; openSpace[1][6] = true; }
                                if (tb1x7y.Text != "") { validEntries[1][7] = tb1x7y.Text; openSpace[1][7] = true; }
                                if (tb1x8y.Text != "") { validEntries[1][8] = tb1x8y.Text; openSpace[1][8] = true; }
                                if (tb1x9y.Text != "") { validEntries[1][9] = tb1x9y.Text; openSpace[1][9] = true; }
                                if (tb1x10y.Text != "") { validEntries[1][10] = tb1x10y.Text; openSpace[1][10] = true; }
                                if (tb1x11y.Text != "") { validEntries[1][11] = tb1x11y.Text; openSpace[1][11] = true; }
                                if (tb1x12y.Text != "") { validEntries[1][12] = tb1x12y.Text; openSpace[1][12] = true; }
                                if (tb1x13y.Text != "") { validEntries[1][13] = tb1x13y.Text; openSpace[1][13] = true; }
                                if (tb1x14y.Text != "") { validEntries[1][14] = tb1x14y.Text; openSpace[1][14] = true; }
                                if (tb1x15y.Text != "") { validEntries[1][15] = tb1x15y.Text; openSpace[1][15] = true; }
                                if (tb1x16y.Text != "") { validEntries[1][16] = tb1x16y.Text; openSpace[1][16] = true; }
                                if (tb1x17y.Text != "") { validEntries[1][17] = tb1x17y.Text; openSpace[1][17] = true; }
                                if (tb1x18y.Text != "") { validEntries[1][18] = tb1x18y.Text; openSpace[1][18] = true; }
                                if (tb1x19y.Text != "") { validEntries[1][19] = tb1x19y.Text; openSpace[1][19] = true; }

                                if (tb2x0y.Text != "") { validEntries[2][0] = tb2x0y.Text; openSpace[2][0] = true; }
                                if (tb2x1y.Text != "") { validEntries[2][1] = tb2x1y.Text; openSpace[2][1] = true; }
                                if (tb2x2y.Text != "") { validEntries[2][2] = tb2x2y.Text; openSpace[2][2] = true; }
                                if (tb2x3y.Text != "") { validEntries[2][3] = tb2x3y.Text; openSpace[2][3] = true; }
                                if (tb2x4y.Text != "") { validEntries[2][4] = tb2x4y.Text; openSpace[2][4] = true; }
                                if (tb2x5y.Text != "") { validEntries[2][5] = tb2x5y.Text; openSpace[2][5] = true; }
                                if (tb2x6y.Text != "") { validEntries[2][6] = tb2x6y.Text; openSpace[2][6] = true; }
                                if (tb2x7y.Text != "") { validEntries[2][7] = tb2x7y.Text; openSpace[2][7] = true; }
                                if (tb2x8y.Text != "") { validEntries[2][8] = tb2x8y.Text; openSpace[2][8] = true; }
                                if (tb2x9y.Text != "") { validEntries[2][9] = tb2x9y.Text; openSpace[2][9] = true; }
                                if (tb2x10y.Text != "") { validEntries[2][10] = tb2x10y.Text; openSpace[2][10] = true; }
                                if (tb2x11y.Text != "") { validEntries[2][11] = tb2x11y.Text; openSpace[2][11] = true; }
                                if (tb2x12y.Text != "") { validEntries[2][12] = tb2x12y.Text; openSpace[2][12] = true; }
                                if (tb2x13y.Text != "") { validEntries[2][13] = tb2x13y.Text; openSpace[2][13] = true; }
                                if (tb2x14y.Text != "") { validEntries[2][14] = tb2x14y.Text; openSpace[2][14] = true; }
                                if (tb2x15y.Text != "") { validEntries[2][15] = tb2x15y.Text; openSpace[2][15] = true; }
                                if (tb2x16y.Text != "") { validEntries[2][16] = tb2x16y.Text; openSpace[2][16] = true; }
                                if (tb2x17y.Text != "") { validEntries[2][17] = tb2x17y.Text; openSpace[2][17] = true; }
                                if (tb2x18y.Text != "") { validEntries[2][18] = tb2x18y.Text; openSpace[2][18] = true; }
                                if (tb2x19y.Text != "") { validEntries[2][19] = tb2x19y.Text; openSpace[2][19] = true; }

                                if (tb3x0y.Text != "") { validEntries[3][0] = tb3x0y.Text; openSpace[3][0] = true; }
                                if (tb3x1y.Text != "") { validEntries[3][1] = tb3x1y.Text; openSpace[3][1] = true; }
                                if (tb3x2y.Text != "") { validEntries[3][2] = tb3x2y.Text; openSpace[3][2] = true; }
                                if (tb3x3y.Text != "") { validEntries[3][3] = tb3x3y.Text; openSpace[3][3] = true; }
                                if (tb3x4y.Text != "") { validEntries[3][4] = tb3x4y.Text; openSpace[3][4] = true; }
                                if (tb3x5y.Text != "") { validEntries[3][5] = tb3x5y.Text; openSpace[3][5] = true; }
                                if (tb3x6y.Text != "") { validEntries[3][6] = tb3x6y.Text; openSpace[3][6] = true; }
                                if (tb3x7y.Text != "") { validEntries[3][7] = tb3x7y.Text; openSpace[3][7] = true; }
                                if (tb3x8y.Text != "") { validEntries[3][8] = tb3x8y.Text; openSpace[3][8] = true; }
                                if (tb3x9y.Text != "") { validEntries[3][9] = tb3x9y.Text; openSpace[3][9] = true; }
                                if (tb3x10y.Text != "") { validEntries[3][10] = tb3x10y.Text; openSpace[3][10] = true; }
                                if (tb3x11y.Text != "") { validEntries[3][11] = tb3x11y.Text; openSpace[3][11] = true; }
                                if (tb3x12y.Text != "") { validEntries[3][12] = tb3x12y.Text; openSpace[3][12] = true; }
                                if (tb3x13y.Text != "") { validEntries[3][13] = tb3x13y.Text; openSpace[3][13] = true; }
                                if (tb3x14y.Text != "") { validEntries[3][14] = tb3x14y.Text; openSpace[3][14] = true; }
                                if (tb3x15y.Text != "") { validEntries[3][15] = tb3x15y.Text; openSpace[3][15] = true; }
                                if (tb3x16y.Text != "") { validEntries[3][16] = tb3x16y.Text; openSpace[3][16] = true; }
                                if (tb3x17y.Text != "") { validEntries[3][17] = tb3x17y.Text; openSpace[3][17] = true; }
                                if (tb3x18y.Text != "") { validEntries[3][18] = tb3x18y.Text; openSpace[3][18] = true; }
                                if (tb3x19y.Text != "") { validEntries[3][19] = tb3x19y.Text; openSpace[3][19] = true; }

                                if (tb4x0y.Text != "") { validEntries[4][0] = tb4x0y.Text; openSpace[4][0] = true; }
                                if (tb4x1y.Text != "") { validEntries[4][1] = tb4x1y.Text; openSpace[4][1] = true; }
                                if (tb4x2y.Text != "") { validEntries[4][2] = tb4x2y.Text; openSpace[4][2] = true; }
                                if (tb4x3y.Text != "") { validEntries[4][3] = tb4x3y.Text; openSpace[4][3] = true; }
                                if (tb4x4y.Text != "") { validEntries[4][4] = tb4x4y.Text; openSpace[4][4] = true; }
                                if (tb4x5y.Text != "") { validEntries[4][5] = tb4x5y.Text; openSpace[4][5] = true; }
                                if (tb4x6y.Text != "") { validEntries[4][6] = tb4x6y.Text; openSpace[4][6] = true; }
                                if (tb4x7y.Text != "") { validEntries[4][7] = tb4x7y.Text; openSpace[4][7] = true; }
                                if (tb4x8y.Text != "") { validEntries[4][8] = tb4x8y.Text; openSpace[4][8] = true; }
                                if (tb4x9y.Text != "") { validEntries[4][9] = tb4x9y.Text; openSpace[4][9] = true; }
                                if (tb4x10y.Text != "") { validEntries[4][10] = tb4x10y.Text; openSpace[4][10] = true; }
                                if (tb4x11y.Text != "") { validEntries[4][11] = tb4x11y.Text; openSpace[4][11] = true; }
                                if (tb4x12y.Text != "") { validEntries[4][12] = tb4x12y.Text; openSpace[4][12] = true; }
                                if (tb4x13y.Text != "") { validEntries[4][13] = tb4x13y.Text; openSpace[4][13] = true; }
                                if (tb4x14y.Text != "") { validEntries[4][14] = tb4x14y.Text; openSpace[4][14] = true; }
                                if (tb4x15y.Text != "") { validEntries[4][15] = tb4x15y.Text; openSpace[4][15] = true; }
                                if (tb4x16y.Text != "") { validEntries[4][16] = tb4x16y.Text; openSpace[4][16] = true; }
                                if (tb4x17y.Text != "") { validEntries[4][17] = tb4x17y.Text; openSpace[4][17] = true; }
                                if (tb4x18y.Text != "") { validEntries[4][18] = tb4x18y.Text; openSpace[4][18] = true; }
                                if (tb4x19y.Text != "") { validEntries[4][19] = tb4x19y.Text; openSpace[4][19] = true; }

                                if (tb5x0y.Text != "") { validEntries[5][0] = tb5x0y.Text; openSpace[5][0] = true; }
                                if (tb5x1y.Text != "") { validEntries[5][1] = tb5x1y.Text; openSpace[5][1] = true; }
                                if (tb5x2y.Text != "") { validEntries[5][2] = tb5x2y.Text; openSpace[5][2] = true; }
                                if (tb5x3y.Text != "") { validEntries[5][3] = tb5x3y.Text; openSpace[5][3] = true; }
                                if (tb5x4y.Text != "") { validEntries[5][4] = tb5x4y.Text; openSpace[5][4] = true; }
                                if (tb5x5y.Text != "") { validEntries[5][5] = tb5x5y.Text; openSpace[5][5] = true; }
                                if (tb5x6y.Text != "") { validEntries[5][6] = tb5x6y.Text; openSpace[5][6] = true; }
                                if (tb5x7y.Text != "") { validEntries[5][7] = tb5x7y.Text; openSpace[5][7] = true; }
                                if (tb5x8y.Text != "") { validEntries[5][8] = tb5x8y.Text; openSpace[5][8] = true; }
                                if (tb5x9y.Text != "") { validEntries[5][9] = tb5x9y.Text; openSpace[5][9] = true; }
                                if (tb5x10y.Text != "") { validEntries[5][10] = tb5x10y.Text; openSpace[5][10] = true; }
                                if (tb5x11y.Text != "") { validEntries[5][11] = tb5x11y.Text; openSpace[5][11] = true; }
                                if (tb5x12y.Text != "") { validEntries[5][12] = tb5x12y.Text; openSpace[5][12] = true; }
                                if (tb5x13y.Text != "") { validEntries[5][13] = tb5x13y.Text; openSpace[5][13] = true; }
                                if (tb5x14y.Text != "") { validEntries[5][14] = tb5x14y.Text; openSpace[5][14] = true; }
                                if (tb5x15y.Text != "") { validEntries[5][15] = tb5x15y.Text; openSpace[5][15] = true; }
                                if (tb5x16y.Text != "") { validEntries[5][16] = tb5x16y.Text; openSpace[5][16] = true; }
                                if (tb5x17y.Text != "") { validEntries[5][17] = tb5x17y.Text; openSpace[5][17] = true; }
                                if (tb5x18y.Text != "") { validEntries[5][18] = tb5x18y.Text; openSpace[5][18] = true; }
                                if (tb5x19y.Text != "") { validEntries[5][19] = tb5x19y.Text; openSpace[5][19] = true; }

                                if (tb6x0y.Text != "") { validEntries[6][0] = tb6x0y.Text; openSpace[6][0] = true; }
                                if (tb6x1y.Text != "") { validEntries[6][1] = tb6x1y.Text; openSpace[6][1] = true; }
                                if (tb6x2y.Text != "") { validEntries[6][2] = tb6x2y.Text; openSpace[6][2] = true; }
                                if (tb6x3y.Text != "") { validEntries[6][3] = tb6x3y.Text; openSpace[6][3] = true; }
                                if (tb6x4y.Text != "") { validEntries[6][4] = tb6x4y.Text; openSpace[6][4] = true; }
                                if (tb6x5y.Text != "") { validEntries[6][5] = tb6x5y.Text; openSpace[6][5] = true; }
                                if (tb6x6y.Text != "") { validEntries[6][6] = tb6x6y.Text; openSpace[6][6] = true; }
                                if (tb6x7y.Text != "") { validEntries[6][7] = tb6x7y.Text; openSpace[6][7] = true; }
                                if (tb6x8y.Text != "") { validEntries[6][8] = tb6x8y.Text; openSpace[6][8] = true; }
                                if (tb6x9y.Text != "") { validEntries[6][9] = tb6x9y.Text; openSpace[6][9] = true; }
                                if (tb6x10y.Text != "") { validEntries[6][10] = tb6x10y.Text; openSpace[6][10] = true; }
                                if (tb6x11y.Text != "") { validEntries[6][11] = tb6x11y.Text; openSpace[6][11] = true; }
                                if (tb6x12y.Text != "") { validEntries[6][12] = tb6x12y.Text; openSpace[6][12] = true; }
                                if (tb6x13y.Text != "") { validEntries[6][13] = tb6x13y.Text; openSpace[6][13] = true; }
                                if (tb6x14y.Text != "") { validEntries[6][14] = tb6x14y.Text; openSpace[6][14] = true; }
                                if (tb6x15y.Text != "") { validEntries[6][15] = tb6x15y.Text; openSpace[6][15] = true; }
                                if (tb6x16y.Text != "") { validEntries[6][16] = tb6x16y.Text; openSpace[6][16] = true; }
                                if (tb6x17y.Text != "") { validEntries[6][17] = tb6x17y.Text; openSpace[6][17] = true; }
                                if (tb6x18y.Text != "") { validEntries[6][18] = tb6x18y.Text; openSpace[6][18] = true; }
                                if (tb6x19y.Text != "") { validEntries[6][19] = tb6x19y.Text; openSpace[6][19] = true; }

                                if (tb7x0y.Text != "") { validEntries[7][0] = tb7x0y.Text; openSpace[7][0] = true; }
                                if (tb7x1y.Text != "") { validEntries[7][1] = tb7x1y.Text; openSpace[7][1] = true; }
                                if (tb7x2y.Text != "") { validEntries[7][2] = tb7x2y.Text; openSpace[7][2] = true; }
                                if (tb7x3y.Text != "") { validEntries[7][3] = tb7x3y.Text; openSpace[7][3] = true; }
                                if (tb7x4y.Text != "") { validEntries[7][4] = tb7x4y.Text; openSpace[7][4] = true; }
                                if (tb7x5y.Text != "") { validEntries[7][5] = tb7x5y.Text; openSpace[7][5] = true; }
                                if (tb7x6y.Text != "") { validEntries[7][6] = tb7x6y.Text; openSpace[7][6] = true; }
                                if (tb7x7y.Text != "") { validEntries[7][7] = tb7x7y.Text; openSpace[7][7] = true; }
                                if (tb7x8y.Text != "") { validEntries[7][8] = tb7x8y.Text; openSpace[7][8] = true; }
                                if (tb7x9y.Text != "") { validEntries[7][9] = tb7x9y.Text; openSpace[7][9] = true; }
                                if (tb7x10y.Text != "") { validEntries[7][10] = tb7x10y.Text; openSpace[7][10] = true; }
                                if (tb7x11y.Text != "") { validEntries[7][11] = tb7x11y.Text; openSpace[7][11] = true; }
                                if (tb7x12y.Text != "") { validEntries[7][12] = tb7x12y.Text; openSpace[7][12] = true; }
                                if (tb7x13y.Text != "") { validEntries[7][13] = tb7x13y.Text; openSpace[7][13] = true; }
                                if (tb7x14y.Text != "") { validEntries[7][14] = tb7x14y.Text; openSpace[7][14] = true; }
                                if (tb7x15y.Text != "") { validEntries[7][15] = tb7x15y.Text; openSpace[7][15] = true; }
                                if (tb7x16y.Text != "") { validEntries[7][16] = tb7x16y.Text; openSpace[7][16] = true; }
                                if (tb7x17y.Text != "") { validEntries[7][17] = tb7x17y.Text; openSpace[7][17] = true; }
                                if (tb7x18y.Text != "") { validEntries[7][18] = tb7x18y.Text; openSpace[7][18] = true; }
                                if (tb7x19y.Text != "") { validEntries[7][19] = tb7x19y.Text; openSpace[7][19] = true; }

                                if (tb8x0y.Text != "") { validEntries[8][0] = tb8x0y.Text; openSpace[8][0] = true; }
                                if (tb8x1y.Text != "") { validEntries[8][1] = tb8x1y.Text; openSpace[8][1] = true; }
                                if (tb8x2y.Text != "") { validEntries[8][2] = tb8x2y.Text; openSpace[8][2] = true; }
                                if (tb8x3y.Text != "") { validEntries[8][3] = tb8x3y.Text; openSpace[8][3] = true; }
                                if (tb8x4y.Text != "") { validEntries[8][4] = tb8x4y.Text; openSpace[8][4] = true; }
                                if (tb8x5y.Text != "") { validEntries[8][5] = tb8x5y.Text; openSpace[8][5] = true; }
                                if (tb8x6y.Text != "") { validEntries[8][6] = tb8x6y.Text; openSpace[8][6] = true; }
                                if (tb8x7y.Text != "") { validEntries[8][7] = tb8x7y.Text; openSpace[8][7] = true; }
                                if (tb8x8y.Text != "") { validEntries[8][8] = tb8x8y.Text; openSpace[8][8] = true; }
                                if (tb8x9y.Text != "") { validEntries[8][9] = tb8x9y.Text; openSpace[8][9] = true; }
                                if (tb8x10y.Text != "") { validEntries[8][10] = tb8x10y.Text; openSpace[8][10] = true; }
                                if (tb8x11y.Text != "") { validEntries[8][11] = tb8x11y.Text; openSpace[8][11] = true; }
                                if (tb8x12y.Text != "") { validEntries[8][12] = tb8x12y.Text; openSpace[8][12] = true; }
                                if (tb8x13y.Text != "") { validEntries[8][13] = tb8x13y.Text; openSpace[8][13] = true; }
                                if (tb8x14y.Text != "") { validEntries[8][14] = tb8x14y.Text; openSpace[8][14] = true; }
                                if (tb8x15y.Text != "") { validEntries[8][15] = tb8x15y.Text; openSpace[8][15] = true; }
                                if (tb8x16y.Text != "") { validEntries[8][16] = tb8x16y.Text; openSpace[8][16] = true; }
                                if (tb8x17y.Text != "") { validEntries[8][17] = tb8x17y.Text; openSpace[8][17] = true; }
                                if (tb8x18y.Text != "") { validEntries[8][18] = tb8x18y.Text; openSpace[8][18] = true; }
                                if (tb8x19y.Text != "") { validEntries[8][19] = tb8x19y.Text; openSpace[8][19] = true; }

                                if (tb9x0y.Text != "") { validEntries[9][0] = tb9x0y.Text; openSpace[9][0] = true; }
                                if (tb9x1y.Text != "") { validEntries[9][1] = tb9x1y.Text; openSpace[9][1] = true; }
                                if (tb9x2y.Text != "") { validEntries[9][2] = tb9x2y.Text; openSpace[9][2] = true; }
                                if (tb9x3y.Text != "") { validEntries[9][3] = tb9x3y.Text; openSpace[9][3] = true; }
                                if (tb9x4y.Text != "") { validEntries[9][4] = tb9x4y.Text; openSpace[9][4] = true; }
                                if (tb9x5y.Text != "") { validEntries[9][5] = tb9x5y.Text; openSpace[9][5] = true; }
                                if (tb9x6y.Text != "") { validEntries[9][6] = tb9x6y.Text; openSpace[9][6] = true; }
                                if (tb9x7y.Text != "") { validEntries[9][7] = tb9x7y.Text; openSpace[9][7] = true; }
                                if (tb9x8y.Text != "") { validEntries[9][8] = tb9x8y.Text; openSpace[9][8] = true; }
                                if (tb9x9y.Text != "") { validEntries[9][9] = tb9x9y.Text; openSpace[9][9] = true; }
                                if (tb9x10y.Text != "") { validEntries[9][10] = tb9x10y.Text; openSpace[9][10] = true; }
                                if (tb9x11y.Text != "") { validEntries[9][11] = tb9x11y.Text; openSpace[9][11] = true; }
                                if (tb9x12y.Text != "") { validEntries[9][12] = tb9x12y.Text; openSpace[9][12] = true; }
                                if (tb9x13y.Text != "") { validEntries[9][13] = tb9x13y.Text; openSpace[9][13] = true; }
                                if (tb9x14y.Text != "") { validEntries[9][14] = tb9x14y.Text; openSpace[9][14] = true; }
                                if (tb9x15y.Text != "") { validEntries[9][15] = tb9x15y.Text; openSpace[9][15] = true; }
                                if (tb9x16y.Text != "") { validEntries[9][16] = tb9x16y.Text; openSpace[9][16] = true; }
                                if (tb9x17y.Text != "") { validEntries[9][17] = tb9x17y.Text; openSpace[9][17] = true; }
                                if (tb9x18y.Text != "") { validEntries[9][18] = tb9x18y.Text; openSpace[9][18] = true; }
                                if (tb9x19y.Text != "") { validEntries[9][19] = tb9x19y.Text; openSpace[9][19] = true; }

                                if (tb10x0y.Text != "") { validEntries[10][0] = tb10x0y.Text; openSpace[10][0] = true; }
                                if (tb10x1y.Text != "") { validEntries[10][1] = tb10x1y.Text; openSpace[10][1] = true; }
                                if (tb10x2y.Text != "") { validEntries[10][2] = tb10x2y.Text; openSpace[10][2] = true; }
                                if (tb10x3y.Text != "") { validEntries[10][3] = tb10x3y.Text; openSpace[10][3] = true; }
                                if (tb10x4y.Text != "") { validEntries[10][4] = tb10x4y.Text; openSpace[10][4] = true; }
                                if (tb10x5y.Text != "") { validEntries[10][5] = tb10x5y.Text; openSpace[10][5] = true; }
                                if (tb10x6y.Text != "") { validEntries[10][6] = tb10x6y.Text; openSpace[10][6] = true; }
                                if (tb10x7y.Text != "") { validEntries[10][7] = tb10x7y.Text; openSpace[10][7] = true; }
                                if (tb10x8y.Text != "") { validEntries[10][8] = tb10x8y.Text; openSpace[10][8] = true; }
                                if (tb10x9y.Text != "") { validEntries[10][9] = tb10x9y.Text; openSpace[10][9] = true; }
                                if (tb10x10y.Text != "") { validEntries[10][10] = tb10x10y.Text; openSpace[10][10] = true; }
                                if (tb10x11y.Text != "") { validEntries[10][11] = tb10x11y.Text; openSpace[10][11] = true; }
                                if (tb10x12y.Text != "") { validEntries[10][12] = tb10x12y.Text; openSpace[10][12] = true; }
                                if (tb10x13y.Text != "") { validEntries[10][13] = tb10x13y.Text; openSpace[10][13] = true; }
                                if (tb10x14y.Text != "") { validEntries[10][14] = tb10x14y.Text; openSpace[10][14] = true; }
                                if (tb10x15y.Text != "") { validEntries[10][15] = tb10x15y.Text; openSpace[10][15] = true; }
                                if (tb10x16y.Text != "") { validEntries[10][16] = tb10x16y.Text; openSpace[10][16] = true; }
                                if (tb10x17y.Text != "") { validEntries[10][17] = tb10x17y.Text; openSpace[10][17] = true; }
                                if (tb10x18y.Text != "") { validEntries[10][18] = tb10x18y.Text; openSpace[10][18] = true; }
                                if (tb10x19y.Text != "") { validEntries[10][19] = tb10x19y.Text; openSpace[10][19] = true; }

                                if (tb11x0y.Text != "") { validEntries[11][0] = tb11x0y.Text; openSpace[11][0] = true; }
                                if (tb11x1y.Text != "") { validEntries[11][1] = tb11x1y.Text; openSpace[11][1] = true; }
                                if (tb11x2y.Text != "") { validEntries[11][2] = tb11x2y.Text; openSpace[11][2] = true; }
                                if (tb11x3y.Text != "") { validEntries[11][3] = tb11x3y.Text; openSpace[11][3] = true; }
                                if (tb11x4y.Text != "") { validEntries[11][4] = tb11x4y.Text; openSpace[11][4] = true; }
                                if (tb11x5y.Text != "") { validEntries[11][5] = tb11x5y.Text; openSpace[11][5] = true; }
                                if (tb11x6y.Text != "") { validEntries[11][6] = tb11x6y.Text; openSpace[11][6] = true; }
                                if (tb11x7y.Text != "") { validEntries[11][7] = tb11x7y.Text; openSpace[11][7] = true; }
                                if (tb11x8y.Text != "") { validEntries[11][8] = tb11x8y.Text; openSpace[11][8] = true; }
                                if (tb11x9y.Text != "") { validEntries[11][9] = tb11x9y.Text; openSpace[11][9] = true; }
                                if (tb11x10y.Text != "") { validEntries[11][10] = tb11x10y.Text; openSpace[11][10] = true; }
                                if (tb11x11y.Text != "") { validEntries[11][11] = tb11x11y.Text; openSpace[11][11] = true; }
                                if (tb11x12y.Text != "") { validEntries[11][12] = tb11x12y.Text; openSpace[11][12] = true; }
                                if (tb11x13y.Text != "") { validEntries[11][13] = tb11x13y.Text; openSpace[11][13] = true; }
                                if (tb11x14y.Text != "") { validEntries[11][14] = tb11x14y.Text; openSpace[11][14] = true; }
                                if (tb11x15y.Text != "") { validEntries[11][15] = tb11x15y.Text; openSpace[11][15] = true; }
                                if (tb11x16y.Text != "") { validEntries[11][16] = tb11x16y.Text; openSpace[11][16] = true; }
                                if (tb11x17y.Text != "") { validEntries[11][17] = tb11x17y.Text; openSpace[11][17] = true; }
                                if (tb11x18y.Text != "") { validEntries[11][18] = tb11x18y.Text; openSpace[11][18] = true; }
                                if (tb11x19y.Text != "") { validEntries[11][19] = tb11x19y.Text; openSpace[11][19] = true; }

                                if (tb12x0y.Text != "") { validEntries[12][0] = tb12x0y.Text; openSpace[12][0] = true; }
                                if (tb12x1y.Text != "") { validEntries[12][1] = tb12x1y.Text; openSpace[12][1] = true; }
                                if (tb12x2y.Text != "") { validEntries[12][2] = tb12x2y.Text; openSpace[12][2] = true; }
                                if (tb12x3y.Text != "") { validEntries[12][3] = tb12x3y.Text; openSpace[12][3] = true; }
                                if (tb12x4y.Text != "") { validEntries[12][4] = tb12x4y.Text; openSpace[12][4] = true; }
                                if (tb12x5y.Text != "") { validEntries[12][5] = tb12x5y.Text; openSpace[12][5] = true; }
                                if (tb12x6y.Text != "") { validEntries[12][6] = tb12x6y.Text; openSpace[12][6] = true; }
                                if (tb12x7y.Text != "") { validEntries[12][7] = tb12x7y.Text; openSpace[12][7] = true; }
                                if (tb12x8y.Text != "") { validEntries[12][8] = tb12x8y.Text; openSpace[12][8] = true; }
                                if (tb12x9y.Text != "") { validEntries[12][9] = tb12x9y.Text; openSpace[12][9] = true; }
                                if (tb12x10y.Text != "") { validEntries[12][10] = tb12x10y.Text; openSpace[12][10] = true; }
                                if (tb12x11y.Text != "") { validEntries[12][11] = tb12x11y.Text; openSpace[12][11] = true; }
                                if (tb12x12y.Text != "") { validEntries[12][12] = tb12x12y.Text; openSpace[12][12] = true; }
                                if (tb12x13y.Text != "") { validEntries[12][13] = tb12x13y.Text; openSpace[12][13] = true; }
                                if (tb12x14y.Text != "") { validEntries[12][14] = tb12x14y.Text; openSpace[12][14] = true; }
                                if (tb12x15y.Text != "") { validEntries[12][15] = tb12x15y.Text; openSpace[12][15] = true; }
                                if (tb12x16y.Text != "") { validEntries[12][16] = tb12x16y.Text; openSpace[12][16] = true; }
                                if (tb12x17y.Text != "") { validEntries[12][17] = tb12x17y.Text; openSpace[12][17] = true; }
                                if (tb12x18y.Text != "") { validEntries[12][18] = tb12x18y.Text; openSpace[12][18] = true; }
                                if (tb12x19y.Text != "") { validEntries[12][19] = tb12x19y.Text; openSpace[12][19] = true; }

                                if (tb13x0y.Text != "") { validEntries[13][0] = tb13x0y.Text; openSpace[13][0] = true; }
                                if (tb13x1y.Text != "") { validEntries[13][1] = tb13x1y.Text; openSpace[13][1] = true; }
                                if (tb13x2y.Text != "") { validEntries[13][2] = tb13x2y.Text; openSpace[13][2] = true; }
                                if (tb13x3y.Text != "") { validEntries[13][3] = tb13x3y.Text; openSpace[13][3] = true; }
                                if (tb13x4y.Text != "") { validEntries[13][4] = tb13x4y.Text; openSpace[13][4] = true; }
                                if (tb13x5y.Text != "") { validEntries[13][5] = tb13x5y.Text; openSpace[13][5] = true; }
                                if (tb13x6y.Text != "") { validEntries[13][6] = tb13x6y.Text; openSpace[13][6] = true; }
                                if (tb13x7y.Text != "") { validEntries[13][7] = tb13x7y.Text; openSpace[13][7] = true; }
                                if (tb13x8y.Text != "") { validEntries[13][8] = tb13x8y.Text; openSpace[13][8] = true; }
                                if (tb13x9y.Text != "") { validEntries[13][9] = tb13x9y.Text; openSpace[13][9] = true; }
                                if (tb13x10y.Text != "") { validEntries[13][10] = tb13x10y.Text; openSpace[13][10] = true; }
                                if (tb13x11y.Text != "") { validEntries[13][11] = tb13x11y.Text; openSpace[13][11] = true; }
                                if (tb13x12y.Text != "") { validEntries[13][12] = tb13x12y.Text; openSpace[13][12] = true; }
                                if (tb13x13y.Text != "") { validEntries[13][13] = tb13x13y.Text; openSpace[13][13] = true; }
                                if (tb13x14y.Text != "") { validEntries[13][14] = tb13x14y.Text; openSpace[13][14] = true; }
                                if (tb13x15y.Text != "") { validEntries[13][15] = tb13x15y.Text; openSpace[13][15] = true; }
                                if (tb13x16y.Text != "") { validEntries[13][16] = tb13x16y.Text; openSpace[13][16] = true; }
                                if (tb13x17y.Text != "") { validEntries[13][17] = tb13x17y.Text; openSpace[13][17] = true; }
                                if (tb13x18y.Text != "") { validEntries[13][18] = tb13x18y.Text; openSpace[13][18] = true; }
                                if (tb13x19y.Text != "") { validEntries[13][19] = tb13x19y.Text; openSpace[13][19] = true; }

                                if (tb14x0y.Text != "") { validEntries[14][0] = tb14x0y.Text; openSpace[14][0] = true; }
                                if (tb14x1y.Text != "") { validEntries[14][1] = tb14x1y.Text; openSpace[14][1] = true; }
                                if (tb14x2y.Text != "") { validEntries[14][2] = tb14x2y.Text; openSpace[14][2] = true; }
                                if (tb14x3y.Text != "") { validEntries[14][3] = tb14x3y.Text; openSpace[14][3] = true; }
                                if (tb14x4y.Text != "") { validEntries[14][4] = tb14x4y.Text; openSpace[14][4] = true; }
                                if (tb14x5y.Text != "") { validEntries[14][5] = tb14x5y.Text; openSpace[14][5] = true; }
                                if (tb14x6y.Text != "") { validEntries[14][6] = tb14x6y.Text; openSpace[14][6] = true; }
                                if (tb14x7y.Text != "") { validEntries[14][7] = tb14x7y.Text; openSpace[14][7] = true; }
                                if (tb14x8y.Text != "") { validEntries[14][8] = tb14x8y.Text; openSpace[14][8] = true; }
                                if (tb14x9y.Text != "") { validEntries[14][9] = tb14x9y.Text; openSpace[14][9] = true; }
                                if (tb14x10y.Text != "") { validEntries[14][10] = tb14x10y.Text; openSpace[14][10] = true; }
                                if (tb14x11y.Text != "") { validEntries[14][11] = tb14x11y.Text; openSpace[14][11] = true; }
                                if (tb14x12y.Text != "") { validEntries[14][12] = tb14x12y.Text; openSpace[14][12] = true; }
                                if (tb14x13y.Text != "") { validEntries[14][13] = tb14x13y.Text; openSpace[14][13] = true; }
                                if (tb14x14y.Text != "") { validEntries[14][14] = tb14x14y.Text; openSpace[14][14] = true; }
                                if (tb14x15y.Text != "") { validEntries[14][15] = tb14x15y.Text; openSpace[14][15] = true; }
                                if (tb14x16y.Text != "") { validEntries[14][16] = tb14x16y.Text; openSpace[14][16] = true; }
                                if (tb14x17y.Text != "") { validEntries[14][17] = tb14x17y.Text; openSpace[14][17] = true; }
                                if (tb14x18y.Text != "") { validEntries[14][18] = tb14x18y.Text; openSpace[14][18] = true; }
                                if (tb14x19y.Text != "") { validEntries[14][19] = tb14x19y.Text; openSpace[14][19] = true; }

                                if (tb15x0y.Text != "") { validEntries[15][0] = tb15x0y.Text; openSpace[15][0] = true; }
                                if (tb15x1y.Text != "") { validEntries[15][1] = tb15x1y.Text; openSpace[15][1] = true; }
                                if (tb15x2y.Text != "") { validEntries[15][2] = tb15x2y.Text; openSpace[15][2] = true; }
                                if (tb15x3y.Text != "") { validEntries[15][3] = tb15x3y.Text; openSpace[15][3] = true; }
                                if (tb15x4y.Text != "") { validEntries[15][4] = tb15x4y.Text; openSpace[15][4] = true; }
                                if (tb15x5y.Text != "") { validEntries[15][5] = tb15x5y.Text; openSpace[15][5] = true; }
                                if (tb15x6y.Text != "") { validEntries[15][6] = tb15x6y.Text; openSpace[15][6] = true; }
                                if (tb15x7y.Text != "") { validEntries[15][7] = tb15x7y.Text; openSpace[15][7] = true; }
                                if (tb15x8y.Text != "") { validEntries[15][8] = tb15x8y.Text; openSpace[15][8] = true; }
                                if (tb15x9y.Text != "") { validEntries[15][9] = tb15x9y.Text; openSpace[15][9] = true; }
                                if (tb15x10y.Text != "") { validEntries[15][10] = tb15x10y.Text; openSpace[15][10] = true; }
                                if (tb15x11y.Text != "") { validEntries[15][11] = tb15x11y.Text; openSpace[15][11] = true; }
                                if (tb15x12y.Text != "") { validEntries[15][12] = tb15x12y.Text; openSpace[15][12] = true; }
                                if (tb15x13y.Text != "") { validEntries[15][13] = tb15x13y.Text; openSpace[15][13] = true; }
                                if (tb15x14y.Text != "") { validEntries[15][14] = tb15x14y.Text; openSpace[15][14] = true; }
                                if (tb15x15y.Text != "") { validEntries[15][15] = tb15x15y.Text; openSpace[15][15] = true; }
                                if (tb15x16y.Text != "") { validEntries[15][16] = tb15x16y.Text; openSpace[15][16] = true; }
                                if (tb15x17y.Text != "") { validEntries[15][17] = tb15x17y.Text; openSpace[15][17] = true; }
                                if (tb15x18y.Text != "") { validEntries[15][18] = tb15x18y.Text; openSpace[15][18] = true; }
                                if (tb15x19y.Text != "") { validEntries[15][19] = tb15x19y.Text; openSpace[15][19] = true; }

                                if (tb16x0y.Text != "") { validEntries[16][0] = tb16x0y.Text; openSpace[16][0] = true; }
                                if (tb16x1y.Text != "") { validEntries[16][1] = tb16x1y.Text; openSpace[16][1] = true; }
                                if (tb16x2y.Text != "") { validEntries[16][2] = tb16x2y.Text; openSpace[16][2] = true; }
                                if (tb16x3y.Text != "") { validEntries[16][3] = tb16x3y.Text; openSpace[16][3] = true; }
                                if (tb16x4y.Text != "") { validEntries[16][4] = tb16x4y.Text; openSpace[16][4] = true; }
                                if (tb16x5y.Text != "") { validEntries[16][5] = tb16x5y.Text; openSpace[16][5] = true; }
                                if (tb16x6y.Text != "") { validEntries[16][6] = tb16x6y.Text; openSpace[16][6] = true; }
                                if (tb16x7y.Text != "") { validEntries[16][7] = tb16x7y.Text; openSpace[16][7] = true; }
                                if (tb16x8y.Text != "") { validEntries[16][8] = tb16x8y.Text; openSpace[16][8] = true; }
                                if (tb16x9y.Text != "") { validEntries[16][9] = tb16x9y.Text; openSpace[16][9] = true; }
                                if (tb16x10y.Text != "") { validEntries[16][10] = tb16x10y.Text; openSpace[16][10] = true; }
                                if (tb16x11y.Text != "") { validEntries[16][11] = tb16x11y.Text; openSpace[16][11] = true; }
                                if (tb16x12y.Text != "") { validEntries[16][12] = tb16x12y.Text; openSpace[16][12] = true; }
                                if (tb16x13y.Text != "") { validEntries[16][13] = tb16x13y.Text; openSpace[16][13] = true; }
                                if (tb16x14y.Text != "") { validEntries[16][14] = tb16x14y.Text; openSpace[16][14] = true; }
                                if (tb16x15y.Text != "") { validEntries[16][15] = tb16x15y.Text; openSpace[16][15] = true; }
                                if (tb16x16y.Text != "") { validEntries[16][16] = tb16x16y.Text; openSpace[16][16] = true; }
                                if (tb16x17y.Text != "") { validEntries[16][17] = tb16x17y.Text; openSpace[16][17] = true; }
                                if (tb16x18y.Text != "") { validEntries[16][18] = tb16x18y.Text; openSpace[16][18] = true; }
                                if (tb16x19y.Text != "") { validEntries[16][19] = tb16x19y.Text; openSpace[16][19] = true; }

                                if (tb17x0y.Text != "") { validEntries[17][0] = tb17x0y.Text; openSpace[17][0] = true; }
                                if (tb17x1y.Text != "") { validEntries[17][1] = tb17x1y.Text; openSpace[17][1] = true; }
                                if (tb17x2y.Text != "") { validEntries[17][2] = tb17x2y.Text; openSpace[17][2] = true; }
                                if (tb17x3y.Text != "") { validEntries[17][3] = tb17x3y.Text; openSpace[17][3] = true; }
                                if (tb17x4y.Text != "") { validEntries[17][4] = tb17x4y.Text; openSpace[17][4] = true; }
                                if (tb17x5y.Text != "") { validEntries[17][5] = tb17x5y.Text; openSpace[17][5] = true; }
                                if (tb17x6y.Text != "") { validEntries[17][6] = tb17x6y.Text; openSpace[17][6] = true; }
                                if (tb17x7y.Text != "") { validEntries[17][7] = tb17x7y.Text; openSpace[17][7] = true; }
                                if (tb17x8y.Text != "") { validEntries[17][8] = tb17x8y.Text; openSpace[17][8] = true; }
                                if (tb17x9y.Text != "") { validEntries[17][9] = tb17x9y.Text; openSpace[17][9] = true; }
                                if (tb17x10y.Text != "") { validEntries[17][10] = tb17x10y.Text; openSpace[17][10] = true; }
                                if (tb17x11y.Text != "") { validEntries[17][11] = tb17x11y.Text; openSpace[17][11] = true; }
                                if (tb17x12y.Text != "") { validEntries[17][12] = tb17x12y.Text; openSpace[17][12] = true; }
                                if (tb17x13y.Text != "") { validEntries[17][13] = tb17x13y.Text; openSpace[17][13] = true; }
                                if (tb17x14y.Text != "") { validEntries[17][14] = tb17x14y.Text; openSpace[17][14] = true; }
                                if (tb17x15y.Text != "") { validEntries[17][15] = tb17x15y.Text; openSpace[17][15] = true; }
                                if (tb17x16y.Text != "") { validEntries[17][16] = tb17x16y.Text; openSpace[17][16] = true; }
                                if (tb17x17y.Text != "") { validEntries[17][17] = tb17x17y.Text; openSpace[17][17] = true; }
                                if (tb17x18y.Text != "") { validEntries[17][18] = tb17x18y.Text; openSpace[17][18] = true; }
                                if (tb17x19y.Text != "") { validEntries[17][19] = tb17x19y.Text; openSpace[17][19] = true; }

                                if (tb18x0y.Text != "") { validEntries[18][0] = tb18x0y.Text; openSpace[18][0] = true; }
                                if (tb18x1y.Text != "") { validEntries[18][1] = tb18x1y.Text; openSpace[18][1] = true; }
                                if (tb18x2y.Text != "") { validEntries[18][2] = tb18x2y.Text; openSpace[18][2] = true; }
                                if (tb18x3y.Text != "") { validEntries[18][3] = tb18x3y.Text; openSpace[18][3] = true; }
                                if (tb18x4y.Text != "") { validEntries[18][4] = tb18x4y.Text; openSpace[18][4] = true; }
                                if (tb18x5y.Text != "") { validEntries[18][5] = tb18x5y.Text; openSpace[18][5] = true; }
                                if (tb18x6y.Text != "") { validEntries[18][6] = tb18x6y.Text; openSpace[18][6] = true; }
                                if (tb18x7y.Text != "") { validEntries[18][7] = tb18x7y.Text; openSpace[18][7] = true; }
                                if (tb18x8y.Text != "") { validEntries[18][8] = tb18x8y.Text; openSpace[18][8] = true; }
                                if (tb18x9y.Text != "") { validEntries[18][9] = tb18x9y.Text; openSpace[18][9] = true; }
                                if (tb18x10y.Text != "") { validEntries[18][10] = tb18x10y.Text; openSpace[18][10] = true; }
                                if (tb18x11y.Text != "") { validEntries[18][11] = tb18x11y.Text; openSpace[18][11] = true; }
                                if (tb18x12y.Text != "") { validEntries[18][12] = tb18x12y.Text; openSpace[18][12] = true; }
                                if (tb18x13y.Text != "") { validEntries[18][13] = tb18x13y.Text; openSpace[18][13] = true; }
                                if (tb18x14y.Text != "") { validEntries[18][14] = tb18x14y.Text; openSpace[18][14] = true; }
                                if (tb18x15y.Text != "") { validEntries[18][15] = tb18x15y.Text; openSpace[18][15] = true; }
                                if (tb18x16y.Text != "") { validEntries[18][16] = tb18x16y.Text; openSpace[18][16] = true; }
                                if (tb18x17y.Text != "") { validEntries[18][17] = tb18x17y.Text; openSpace[18][17] = true; }
                                if (tb18x18y.Text != "") { validEntries[18][18] = tb18x18y.Text; openSpace[18][18] = true; }
                                if (tb18x19y.Text != "") { validEntries[18][19] = tb18x19y.Text; openSpace[18][19] = true; }

                                if (tb19x0y.Text != "") { validEntries[19][0] = tb19x0y.Text; openSpace[19][0] = true; }
                                if (tb19x1y.Text != "") { validEntries[19][1] = tb19x1y.Text; openSpace[19][1] = true; }
                                if (tb19x2y.Text != "") { validEntries[19][2] = tb19x2y.Text; openSpace[19][2] = true; }
                                if (tb19x3y.Text != "") { validEntries[19][3] = tb19x3y.Text; openSpace[19][3] = true; }
                                if (tb19x4y.Text != "") { validEntries[19][4] = tb19x4y.Text; openSpace[19][4] = true; }
                                if (tb19x5y.Text != "") { validEntries[19][5] = tb19x5y.Text; openSpace[19][5] = true; }
                                if (tb19x6y.Text != "") { validEntries[19][6] = tb19x6y.Text; openSpace[19][6] = true; }
                                if (tb19x7y.Text != "") { validEntries[19][7] = tb19x7y.Text; openSpace[19][7] = true; }
                                if (tb19x8y.Text != "") { validEntries[19][8] = tb19x8y.Text; openSpace[19][8] = true; }
                                if (tb19x9y.Text != "") { validEntries[19][9] = tb19x9y.Text; openSpace[19][9] = true; }

                                #endregion


                                */

                #endregion
                if (openSpace[0][0] == true) { tb0x0y.CssClass = "charBlock whiteBlock"; tb0x0y.Text = validEntries[0][0]; }
                else { tb0x0y.CssClass = "charBlock whiteBlock"; tb0x0y.Text = RandomChar(random); }
                if (openSpace[0][1] == true) { tb0x1y.CssClass = "charBlock whiteBlock"; tb0x1y.Text = validEntries[0][1]; } 
                else { tb0x1y.CssClass = "charBlock whiteBlock"; tb0x1y.Text = RandomChar(random); }
                if (openSpace[0][2] == true) { tb0x2y.CssClass = "charBlock whiteBlock"; tb0x2y.Text = validEntries[0][2]; } 
                else { tb0x2y.CssClass = "charBlock whiteBlock"; tb0x2y.Text = RandomChar(random); }
                if (openSpace[0][3] == true) { tb0x3y.CssClass = "charBlock whiteBlock"; tb0x3y.Text = validEntries[0][3]; }
                else { tb0x3y.CssClass = "charBlock whiteBlock"; tb0x3y.Text = RandomChar(random); }
                if (openSpace[0][4] == true) { tb0x4y.CssClass = "charBlock whiteBlock"; tb0x4y.Text = validEntries[0][4]; } else { tb0x4y.CssClass = "charBlock whiteBlock"; tb0x4y.Text = RandomChar(random); }
                if (openSpace[0][5] == true) { tb0x5y.CssClass = "charBlock whiteBlock"; tb0x5y.Text = validEntries[0][5]; } else { tb0x5y.CssClass = "charBlock whiteBlock"; tb0x5y.Text = RandomChar(random); }
                if (openSpace[0][6] == true) { tb0x6y.CssClass = "charBlock whiteBlock"; tb0x6y.Text = validEntries[0][6]; } else { tb0x6y.CssClass = "charBlock whiteBlock"; tb0x6y.Text = RandomChar(random); }
                if (openSpace[0][7] == true) { tb0x7y.CssClass = "charBlock whiteBlock"; tb0x7y.Text = validEntries[0][7]; } else { tb0x7y.CssClass = "charBlock whiteBlock"; tb0x7y.Text = RandomChar(random); }
                if (openSpace[0][8] == true) { tb0x8y.CssClass = "charBlock whiteBlock"; tb0x8y.Text = validEntries[0][8]; } else { tb0x8y.CssClass = "charBlock whiteBlock"; tb0x8y.Text = RandomChar(random); }
                if (openSpace[0][9] == true) { tb0x9y.CssClass = "charBlock whiteBlock"; tb0x9y.Text = validEntries[0][9]; } else { tb0x9y.CssClass = "charBlock whiteBlock"; tb0x9y.Text = RandomChar(random); }
                if (openSpace[0][10] == true) { tb0x10y.CssClass = "charBlock whiteBlock"; tb0x10y.Text = validEntries[0][10]; } else { tb0x10y.CssClass = "charBlock whiteBlock"; tb0x10y.Text = RandomChar(random); }
                if (openSpace[0][11] == true) { tb0x11y.CssClass = "charBlock whiteBlock"; tb0x11y.Text = validEntries[0][11]; } else { tb0x11y.CssClass = "charBlock whiteBlock"; tb0x11y.Text = RandomChar(random); }
                if (openSpace[0][12] == true) { tb0x12y.CssClass = "charBlock whiteBlock"; tb0x12y.Text = validEntries[0][12]; } else { tb0x12y.CssClass = "charBlock whiteBlock"; tb0x12y.Text = RandomChar(random); }
                if (openSpace[0][13] == true) { tb0x13y.CssClass = "charBlock whiteBlock"; tb0x13y.Text = validEntries[0][13]; } else { tb0x13y.CssClass = "charBlock whiteBlock"; tb0x13y.Text = RandomChar(random); }
                if (openSpace[0][14] == true) { tb0x14y.CssClass = "charBlock whiteBlock"; tb0x14y.Text = validEntries[0][14]; } else { tb0x14y.CssClass = "charBlock whiteBlock"; tb0x14y.Text = RandomChar(random); }
                if (openSpace[0][15] == true) { tb0x15y.CssClass = "charBlock whiteBlock"; tb0x15y.Text = validEntries[0][15]; } else { tb0x15y.CssClass = "charBlock whiteBlock"; tb0x15y.Text = RandomChar(random); }
                if (openSpace[0][16] == true) { tb0x16y.CssClass = "charBlock whiteBlock"; tb0x16y.Text = validEntries[0][16]; } else { tb0x16y.CssClass = "charBlock whiteBlock"; tb0x16y.Text = RandomChar(random); }
                if (openSpace[0][17] == true) { tb0x17y.CssClass = "charBlock whiteBlock"; tb0x17y.Text = validEntries[0][17]; } else { tb0x17y.CssClass = "charBlock whiteBlock"; tb0x17y.Text = RandomChar(random); }
                if (openSpace[0][18] == true) { tb0x18y.CssClass = "charBlock whiteBlock"; tb0x18y.Text = validEntries[0][18]; } else { tb0x18y.CssClass = "charBlock whiteBlock"; tb0x18y.Text = RandomChar(random); }
                if (openSpace[0][19] == true) { tb0x19y.CssClass = "charBlock whiteBlock"; tb0x19y.Text = validEntries[0][19]; } else { tb0x19y.CssClass = "charBlock whiteBlock"; tb0x19y.Text = RandomChar(random); }
                if (openSpace[1][0] == true) { tb1x0y.CssClass = "charBlock whiteBlock"; tb1x0y.Text = validEntries[1][0]; } else { tb1x0y.CssClass = "charBlock whiteBlock"; tb1x0y.Text = RandomChar(random); }
                if (openSpace[1][1] == true) { tb1x1y.CssClass = "charBlock whiteBlock"; tb1x1y.Text = validEntries[1][1]; } else { tb1x1y.CssClass = "charBlock whiteBlock"; tb1x1y.Text = RandomChar(random); }
                if (openSpace[1][2] == true) { tb1x2y.CssClass = "charBlock whiteBlock"; tb1x2y.Text = validEntries[1][2]; } else { tb1x2y.CssClass = "charBlock whiteBlock"; tb1x2y.Text = RandomChar(random); }
                if (openSpace[1][3] == true) { tb1x3y.CssClass = "charBlock whiteBlock"; tb1x3y.Text = validEntries[1][3]; } else { tb1x3y.CssClass = "charBlock whiteBlock"; tb1x3y.Text = RandomChar(random); }
                if (openSpace[1][4] == true) { tb1x4y.CssClass = "charBlock whiteBlock"; tb1x4y.Text = validEntries[1][4]; } else { tb1x4y.CssClass = "charBlock whiteBlock"; tb1x4y.Text = RandomChar(random); }
                if (openSpace[1][5] == true) { tb1x5y.CssClass = "charBlock whiteBlock"; tb1x5y.Text = validEntries[1][5]; } else { tb1x5y.CssClass = "charBlock whiteBlock"; tb1x5y.Text = RandomChar(random); }
                if (openSpace[1][6] == true) { tb1x6y.CssClass = "charBlock whiteBlock"; tb1x6y.Text = validEntries[1][6]; } else { tb1x6y.CssClass = "charBlock whiteBlock"; tb1x6y.Text = RandomChar(random); }
                if (openSpace[1][7] == true) { tb1x7y.CssClass = "charBlock whiteBlock"; tb1x7y.Text = validEntries[1][7]; } else { tb1x7y.CssClass = "charBlock whiteBlock"; tb1x7y.Text = RandomChar(random); }
                if (openSpace[1][8] == true) { tb1x8y.CssClass = "charBlock whiteBlock"; tb1x8y.Text = validEntries[1][8]; } else { tb1x8y.CssClass = "charBlock whiteBlock"; tb1x8y.Text = RandomChar(random); }
                if (openSpace[1][9] == true) { tb1x9y.CssClass = "charBlock whiteBlock"; tb1x9y.Text = validEntries[1][9]; } else { tb1x9y.CssClass = "charBlock whiteBlock"; tb1x9y.Text = RandomChar(random); }
                if (openSpace[1][10] == true) { tb1x10y.CssClass = "charBlock whiteBlock"; tb1x10y.Text = validEntries[1][10]; } else { tb1x10y.CssClass = "charBlock whiteBlock"; tb1x10y.Text = RandomChar(random); }
                if (openSpace[1][11] == true) { tb1x11y.CssClass = "charBlock whiteBlock"; tb1x11y.Text = validEntries[1][11]; } else { tb1x11y.CssClass = "charBlock whiteBlock"; tb1x11y.Text = RandomChar(random); }
                if (openSpace[1][12] == true) { tb1x12y.CssClass = "charBlock whiteBlock"; tb1x12y.Text = validEntries[1][12]; } else { tb1x12y.CssClass = "charBlock whiteBlock"; tb1x12y.Text = RandomChar(random); }
                if (openSpace[1][13] == true) { tb1x13y.CssClass = "charBlock whiteBlock"; tb1x13y.Text = validEntries[1][13]; } else { tb1x13y.CssClass = "charBlock whiteBlock"; tb1x13y.Text = RandomChar(random); }
                if (openSpace[1][14] == true) { tb1x14y.CssClass = "charBlock whiteBlock"; tb1x14y.Text = validEntries[1][14]; } else { tb1x14y.CssClass = "charBlock whiteBlock"; tb1x14y.Text = RandomChar(random); }
                if (openSpace[1][15] == true) { tb1x15y.CssClass = "charBlock whiteBlock"; tb1x15y.Text = validEntries[1][15]; } else { tb1x15y.CssClass = "charBlock whiteBlock"; tb1x15y.Text = RandomChar(random); }
                if (openSpace[1][16] == true) { tb1x16y.CssClass = "charBlock whiteBlock"; tb1x16y.Text = validEntries[1][16]; } else { tb1x16y.CssClass = "charBlock whiteBlock"; tb1x16y.Text = RandomChar(random); }
                if (openSpace[1][17] == true) { tb1x17y.CssClass = "charBlock whiteBlock"; tb1x17y.Text = validEntries[1][17]; } else { tb1x17y.CssClass = "charBlock whiteBlock"; tb1x17y.Text = RandomChar(random); }
                if (openSpace[1][18] == true) { tb1x18y.CssClass = "charBlock whiteBlock"; tb1x18y.Text = validEntries[1][18]; } else { tb1x18y.CssClass = "charBlock whiteBlock"; tb1x18y.Text = RandomChar(random); }
                if (openSpace[1][19] == true) { tb1x19y.CssClass = "charBlock whiteBlock"; tb1x19y.Text = validEntries[1][19]; } else { tb1x19y.CssClass = "charBlock whiteBlock"; tb1x19y.Text = RandomChar(random); }
                if (openSpace[2][0] == true) { tb2x0y.CssClass = "charBlock whiteBlock"; tb2x0y.Text = validEntries[2][0]; } else { tb2x0y.CssClass = "charBlock whiteBlock"; tb2x0y.Text = RandomChar(random); }
                if (openSpace[2][1] == true) { tb2x1y.CssClass = "charBlock whiteBlock"; tb2x1y.Text = validEntries[2][1]; } else { tb2x1y.CssClass = "charBlock whiteBlock"; tb2x1y.Text = RandomChar(random); }
                if (openSpace[2][2] == true) { tb2x2y.CssClass = "charBlock whiteBlock"; tb2x2y.Text = validEntries[2][2]; } else { tb2x2y.CssClass = "charBlock whiteBlock"; tb2x2y.Text = RandomChar(random); }
                if (openSpace[2][3] == true) { tb2x3y.CssClass = "charBlock whiteBlock"; tb2x3y.Text = validEntries[2][3]; } else { tb2x3y.CssClass = "charBlock whiteBlock"; tb2x3y.Text = RandomChar(random); }
                if (openSpace[2][4] == true) { tb2x4y.CssClass = "charBlock whiteBlock"; tb2x4y.Text = validEntries[2][4]; } else { tb2x4y.CssClass = "charBlock whiteBlock"; tb2x4y.Text = RandomChar(random); }
                if (openSpace[2][5] == true) { tb2x5y.CssClass = "charBlock whiteBlock"; tb2x5y.Text = validEntries[2][5]; } else { tb2x5y.CssClass = "charBlock whiteBlock"; tb2x5y.Text = RandomChar(random); }
                if (openSpace[2][6] == true) { tb2x6y.CssClass = "charBlock whiteBlock"; tb2x6y.Text = validEntries[2][6]; } else { tb2x6y.CssClass = "charBlock whiteBlock"; tb2x6y.Text = RandomChar(random); }
                if (openSpace[2][7] == true) { tb2x7y.CssClass = "charBlock whiteBlock"; tb2x7y.Text = validEntries[2][7]; } else { tb2x7y.CssClass = "charBlock whiteBlock"; tb2x7y.Text = RandomChar(random); }
                if (openSpace[2][8] == true) { tb2x8y.CssClass = "charBlock whiteBlock"; tb2x8y.Text = validEntries[2][8]; } else { tb2x8y.CssClass = "charBlock whiteBlock"; tb2x8y.Text = RandomChar(random); }
                if (openSpace[2][9] == true) { tb2x9y.CssClass = "charBlock whiteBlock"; tb2x9y.Text = validEntries[2][9]; } else { tb2x9y.CssClass = "charBlock whiteBlock"; tb2x9y.Text = RandomChar(random); }
                if (openSpace[2][10] == true) { tb2x10y.CssClass = "charBlock whiteBlock"; tb2x10y.Text = validEntries[2][10]; } else { tb2x10y.CssClass = "charBlock whiteBlock"; tb2x10y.Text = RandomChar(random); }
                if (openSpace[2][11] == true) { tb2x11y.CssClass = "charBlock whiteBlock"; tb2x11y.Text = validEntries[2][11]; } else { tb2x11y.CssClass = "charBlock whiteBlock"; tb2x11y.Text = RandomChar(random); }
                if (openSpace[2][12] == true) { tb2x12y.CssClass = "charBlock whiteBlock"; tb2x12y.Text = validEntries[2][12]; } else { tb2x12y.CssClass = "charBlock whiteBlock"; tb2x12y.Text = RandomChar(random); }
                if (openSpace[2][13] == true) { tb2x13y.CssClass = "charBlock whiteBlock"; tb2x13y.Text = validEntries[2][13]; } else { tb2x13y.CssClass = "charBlock whiteBlock"; tb2x13y.Text = RandomChar(random); }
                if (openSpace[2][14] == true) { tb2x14y.CssClass = "charBlock whiteBlock"; tb2x14y.Text = validEntries[2][14]; } else { tb2x14y.CssClass = "charBlock whiteBlock"; tb2x14y.Text = RandomChar(random); }
                if (openSpace[2][15] == true) { tb2x15y.CssClass = "charBlock whiteBlock"; tb2x15y.Text = validEntries[2][15]; } else { tb2x15y.CssClass = "charBlock whiteBlock"; tb2x15y.Text = RandomChar(random); }
                if (openSpace[2][16] == true) { tb2x16y.CssClass = "charBlock whiteBlock"; tb2x16y.Text = validEntries[2][16]; } else { tb2x16y.CssClass = "charBlock whiteBlock"; tb2x16y.Text = RandomChar(random); }
                if (openSpace[2][17] == true) { tb2x17y.CssClass = "charBlock whiteBlock"; tb2x17y.Text = validEntries[2][17]; } else { tb2x17y.CssClass = "charBlock whiteBlock"; tb2x17y.Text = RandomChar(random); }
                if (openSpace[2][18] == true) { tb2x18y.CssClass = "charBlock whiteBlock"; tb2x18y.Text = validEntries[2][18]; } else { tb2x18y.CssClass = "charBlock whiteBlock"; tb2x18y.Text = RandomChar(random); }
                if (openSpace[2][19] == true) { tb2x19y.CssClass = "charBlock whiteBlock"; tb2x19y.Text = validEntries[2][19]; } else { tb2x19y.CssClass = "charBlock whiteBlock"; tb2x19y.Text = RandomChar(random); }
                if (openSpace[3][0] == true) { tb3x0y.CssClass = "charBlock whiteBlock"; tb3x0y.Text = validEntries[3][0]; } else { tb3x0y.CssClass = "charBlock whiteBlock"; tb3x0y.Text = RandomChar(random); }
                if (openSpace[3][1] == true) { tb3x1y.CssClass = "charBlock whiteBlock"; tb3x1y.Text = validEntries[3][1]; } else { tb3x1y.CssClass = "charBlock whiteBlock"; tb3x1y.Text = RandomChar(random); }
                if (openSpace[3][2] == true) { tb3x2y.CssClass = "charBlock whiteBlock"; tb3x2y.Text = validEntries[3][2]; } else { tb3x2y.CssClass = "charBlock whiteBlock"; tb3x2y.Text = RandomChar(random); }
                if (openSpace[3][3] == true) { tb3x3y.CssClass = "charBlock whiteBlock"; tb3x3y.Text = validEntries[3][3]; } else { tb3x3y.CssClass = "charBlock whiteBlock"; tb3x3y.Text = RandomChar(random); }
                if (openSpace[3][4] == true) { tb3x4y.CssClass = "charBlock whiteBlock"; tb3x4y.Text = validEntries[3][4]; } else { tb3x4y.CssClass = "charBlock whiteBlock"; tb3x4y.Text = RandomChar(random); }
                if (openSpace[3][5] == true) { tb3x5y.CssClass = "charBlock whiteBlock"; tb3x5y.Text = validEntries[3][5]; } else { tb3x5y.CssClass = "charBlock whiteBlock"; tb3x5y.Text = RandomChar(random); }
                if (openSpace[3][6] == true) { tb3x6y.CssClass = "charBlock whiteBlock"; tb3x6y.Text = validEntries[3][6]; } else { tb3x6y.CssClass = "charBlock whiteBlock"; tb3x6y.Text = RandomChar(random); }
                if (openSpace[3][7] == true) { tb3x7y.CssClass = "charBlock whiteBlock"; tb3x7y.Text = validEntries[3][7]; } else { tb3x7y.CssClass = "charBlock whiteBlock"; tb3x7y.Text = RandomChar(random); }
                if (openSpace[3][8] == true) { tb3x8y.CssClass = "charBlock whiteBlock"; tb3x8y.Text = validEntries[3][8]; } else { tb3x8y.CssClass = "charBlock whiteBlock"; tb3x8y.Text = RandomChar(random); }
                if (openSpace[3][9] == true) { tb3x9y.CssClass = "charBlock whiteBlock"; tb3x9y.Text = validEntries[3][9]; } else { tb3x9y.CssClass = "charBlock whiteBlock"; tb3x9y.Text = RandomChar(random); }
                if (openSpace[3][10] == true) { tb3x10y.CssClass = "charBlock whiteBlock"; tb3x10y.Text = validEntries[3][10]; } else { tb3x10y.CssClass = "charBlock whiteBlock"; tb3x10y.Text = RandomChar(random); }
                if (openSpace[3][11] == true) { tb3x11y.CssClass = "charBlock whiteBlock"; tb3x11y.Text = validEntries[3][11]; } else { tb3x11y.CssClass = "charBlock whiteBlock"; tb3x11y.Text = RandomChar(random); }
                if (openSpace[3][12] == true) { tb3x12y.CssClass = "charBlock whiteBlock"; tb3x12y.Text = validEntries[3][12]; } else { tb3x12y.CssClass = "charBlock whiteBlock"; tb3x12y.Text = RandomChar(random); }
                if (openSpace[3][13] == true) { tb3x13y.CssClass = "charBlock whiteBlock"; tb3x13y.Text = validEntries[3][13]; } else { tb3x13y.CssClass = "charBlock whiteBlock"; tb3x13y.Text = RandomChar(random); }
                if (openSpace[3][14] == true) { tb3x14y.CssClass = "charBlock whiteBlock"; tb3x14y.Text = validEntries[3][14]; } else { tb3x14y.CssClass = "charBlock whiteBlock"; tb3x14y.Text = RandomChar(random); }
                if (openSpace[3][15] == true) { tb3x15y.CssClass = "charBlock whiteBlock"; tb3x15y.Text = validEntries[3][15]; } else { tb3x15y.CssClass = "charBlock whiteBlock"; tb3x15y.Text = RandomChar(random); }
                if (openSpace[3][16] == true) { tb3x16y.CssClass = "charBlock whiteBlock"; tb3x16y.Text = validEntries[3][16]; } else { tb3x16y.CssClass = "charBlock whiteBlock"; tb3x16y.Text = RandomChar(random); }
                if (openSpace[3][17] == true) { tb3x17y.CssClass = "charBlock whiteBlock"; tb3x17y.Text = validEntries[3][17]; } else { tb3x17y.CssClass = "charBlock whiteBlock"; tb3x17y.Text = RandomChar(random); }
                if (openSpace[3][18] == true) { tb3x18y.CssClass = "charBlock whiteBlock"; tb3x18y.Text = validEntries[3][18]; } else { tb3x18y.CssClass = "charBlock whiteBlock"; tb3x18y.Text = RandomChar(random); }
                if (openSpace[3][19] == true) { tb3x19y.CssClass = "charBlock whiteBlock"; tb3x19y.Text = validEntries[3][19]; } else { tb3x19y.CssClass = "charBlock whiteBlock"; tb3x19y.Text = RandomChar(random); }
                if (openSpace[4][0] == true) { tb4x0y.CssClass = "charBlock whiteBlock"; tb4x0y.Text = validEntries[4][0]; } else { tb4x0y.CssClass = "charBlock whiteBlock"; tb4x0y.Text = RandomChar(random); }
                if (openSpace[4][1] == true) { tb4x1y.CssClass = "charBlock whiteBlock"; tb4x1y.Text = validEntries[4][1]; } else { tb4x1y.CssClass = "charBlock whiteBlock"; tb4x1y.Text = RandomChar(random); }
                if (openSpace[4][2] == true) { tb4x2y.CssClass = "charBlock whiteBlock"; tb4x2y.Text = validEntries[4][2]; } else { tb4x2y.CssClass = "charBlock whiteBlock"; tb4x2y.Text = RandomChar(random); }
                if (openSpace[4][3] == true) { tb4x3y.CssClass = "charBlock whiteBlock"; tb4x3y.Text = validEntries[4][3]; } else { tb4x3y.CssClass = "charBlock whiteBlock"; tb4x3y.Text = RandomChar(random); }
                if (openSpace[4][4] == true) { tb4x4y.CssClass = "charBlock whiteBlock"; tb4x4y.Text = validEntries[4][4]; } else { tb4x4y.CssClass = "charBlock whiteBlock"; tb4x4y.Text = RandomChar(random); }
                if (openSpace[4][5] == true) { tb4x5y.CssClass = "charBlock whiteBlock"; tb4x5y.Text = validEntries[4][5]; } else { tb4x5y.CssClass = "charBlock whiteBlock"; tb4x5y.Text = RandomChar(random); }
                if (openSpace[4][6] == true) { tb4x6y.CssClass = "charBlock whiteBlock"; tb4x6y.Text = validEntries[4][6]; } else { tb4x6y.CssClass = "charBlock whiteBlock"; tb4x6y.Text = RandomChar(random); }
                if (openSpace[4][7] == true) { tb4x7y.CssClass = "charBlock whiteBlock"; tb4x7y.Text = validEntries[4][7]; } else { tb4x7y.CssClass = "charBlock whiteBlock"; tb4x7y.Text = RandomChar(random); }
                if (openSpace[4][8] == true) { tb4x8y.CssClass = "charBlock whiteBlock"; tb4x8y.Text = validEntries[4][8]; } else { tb4x8y.CssClass = "charBlock whiteBlock"; tb4x8y.Text = RandomChar(random); }
                if (openSpace[4][9] == true) { tb4x9y.CssClass = "charBlock whiteBlock"; tb4x9y.Text = validEntries[4][9]; } else { tb4x9y.CssClass = "charBlock whiteBlock"; tb4x9y.Text = RandomChar(random); }
                if (openSpace[4][10] == true) { tb4x10y.CssClass = "charBlock whiteBlock"; tb4x10y.Text = validEntries[4][10]; } else { tb4x10y.CssClass = "charBlock whiteBlock"; tb4x10y.Text = RandomChar(random); }
                if (openSpace[4][11] == true) { tb4x11y.CssClass = "charBlock whiteBlock"; tb4x11y.Text = validEntries[4][11]; } else { tb4x11y.CssClass = "charBlock whiteBlock"; tb4x11y.Text = RandomChar(random); }
                if (openSpace[4][12] == true) { tb4x12y.CssClass = "charBlock whiteBlock"; tb4x12y.Text = validEntries[4][12]; } else { tb4x12y.CssClass = "charBlock whiteBlock"; tb4x12y.Text = RandomChar(random); }
                if (openSpace[4][13] == true) { tb4x13y.CssClass = "charBlock whiteBlock"; tb4x13y.Text = validEntries[4][13]; } else { tb4x13y.CssClass = "charBlock whiteBlock"; tb4x13y.Text = RandomChar(random); }
                if (openSpace[4][14] == true) { tb4x14y.CssClass = "charBlock whiteBlock"; tb4x14y.Text = validEntries[4][14]; } else { tb4x14y.CssClass = "charBlock whiteBlock"; tb4x14y.Text = RandomChar(random); }
                if (openSpace[4][15] == true) { tb4x15y.CssClass = "charBlock whiteBlock"; tb4x15y.Text = validEntries[4][15]; } else { tb4x15y.CssClass = "charBlock whiteBlock"; tb4x15y.Text = RandomChar(random); }
                if (openSpace[4][16] == true) { tb4x16y.CssClass = "charBlock whiteBlock"; tb4x16y.Text = validEntries[4][16]; } else { tb4x16y.CssClass = "charBlock whiteBlock"; tb4x16y.Text = RandomChar(random); }
                if (openSpace[4][17] == true) { tb4x17y.CssClass = "charBlock whiteBlock"; tb4x17y.Text = validEntries[4][17]; } else { tb4x17y.CssClass = "charBlock whiteBlock"; tb4x17y.Text = RandomChar(random); }
                if (openSpace[4][18] == true) { tb4x18y.CssClass = "charBlock whiteBlock"; tb4x18y.Text = validEntries[4][18]; } else { tb4x18y.CssClass = "charBlock whiteBlock"; tb4x18y.Text = RandomChar(random); }
                if (openSpace[4][19] == true) { tb4x19y.CssClass = "charBlock whiteBlock"; tb4x19y.Text = validEntries[4][19]; } else { tb4x19y.CssClass = "charBlock whiteBlock"; tb4x19y.Text = RandomChar(random); }
                if (openSpace[5][0] == true) { tb5x0y.CssClass = "charBlock whiteBlock"; tb5x0y.Text = validEntries[5][0]; } else { tb5x0y.CssClass = "charBlock whiteBlock"; tb5x0y.Text = RandomChar(random); }
                if (openSpace[5][1] == true) { tb5x1y.CssClass = "charBlock whiteBlock"; tb5x1y.Text = validEntries[5][1]; } else { tb5x1y.CssClass = "charBlock whiteBlock"; tb5x1y.Text = RandomChar(random); }
                if (openSpace[5][2] == true) { tb5x2y.CssClass = "charBlock whiteBlock"; tb5x2y.Text = validEntries[5][2]; } else { tb5x2y.CssClass = "charBlock whiteBlock"; tb5x2y.Text = RandomChar(random); }
                if (openSpace[5][3] == true) { tb5x3y.CssClass = "charBlock whiteBlock"; tb5x3y.Text = validEntries[5][3]; } else { tb5x3y.CssClass = "charBlock whiteBlock"; tb5x3y.Text = RandomChar(random); }
                if (openSpace[5][4] == true) { tb5x4y.CssClass = "charBlock whiteBlock"; tb5x4y.Text = validEntries[5][4]; } else { tb5x4y.CssClass = "charBlock whiteBlock"; tb5x4y.Text = RandomChar(random); }
                if (openSpace[5][5] == true) { tb5x5y.CssClass = "charBlock whiteBlock"; tb5x5y.Text = validEntries[5][5]; } else { tb5x5y.CssClass = "charBlock whiteBlock"; tb5x5y.Text = RandomChar(random); }
                if (openSpace[5][6] == true) { tb5x6y.CssClass = "charBlock whiteBlock"; tb5x6y.Text = validEntries[5][6]; } else { tb5x6y.CssClass = "charBlock whiteBlock"; tb5x6y.Text = RandomChar(random); }
                if (openSpace[5][7] == true) { tb5x7y.CssClass = "charBlock whiteBlock"; tb5x7y.Text = validEntries[5][7]; } else { tb5x7y.CssClass = "charBlock whiteBlock"; tb5x7y.Text = RandomChar(random); }
                if (openSpace[5][8] == true) { tb5x8y.CssClass = "charBlock whiteBlock"; tb5x8y.Text = validEntries[5][8]; } else { tb5x8y.CssClass = "charBlock whiteBlock"; tb5x8y.Text = RandomChar(random); }
                if (openSpace[5][9] == true) { tb5x9y.CssClass = "charBlock whiteBlock"; tb5x9y.Text = validEntries[5][9]; } else { tb5x9y.CssClass = "charBlock whiteBlock"; tb5x9y.Text = RandomChar(random); }
                if (openSpace[5][10] == true) { tb5x10y.CssClass = "charBlock whiteBlock"; tb5x10y.Text = validEntries[5][10]; } else { tb5x10y.CssClass = "charBlock whiteBlock"; tb5x10y.Text = RandomChar(random); }
                if (openSpace[5][11] == true) { tb5x11y.CssClass = "charBlock whiteBlock"; tb5x11y.Text = validEntries[5][11]; } else { tb5x11y.CssClass = "charBlock whiteBlock"; tb5x11y.Text = RandomChar(random); }
                if (openSpace[5][12] == true) { tb5x12y.CssClass = "charBlock whiteBlock"; tb5x12y.Text = validEntries[5][12]; } else { tb5x12y.CssClass = "charBlock whiteBlock"; tb5x12y.Text = RandomChar(random); }
                if (openSpace[5][13] == true) { tb5x13y.CssClass = "charBlock whiteBlock"; tb5x13y.Text = validEntries[5][13]; } else { tb5x13y.CssClass = "charBlock whiteBlock"; tb5x13y.Text = RandomChar(random); }
                if (openSpace[5][14] == true) { tb5x14y.CssClass = "charBlock whiteBlock"; tb5x14y.Text = validEntries[5][14]; } else { tb5x14y.CssClass = "charBlock whiteBlock"; tb5x14y.Text = RandomChar(random); }
                if (openSpace[5][15] == true) { tb5x15y.CssClass = "charBlock whiteBlock"; tb5x15y.Text = validEntries[5][15]; } else { tb5x15y.CssClass = "charBlock whiteBlock"; tb5x15y.Text = RandomChar(random); }
                if (openSpace[5][16] == true) { tb5x16y.CssClass = "charBlock whiteBlock"; tb5x16y.Text = validEntries[5][16]; } else { tb5x16y.CssClass = "charBlock whiteBlock"; tb5x16y.Text = RandomChar(random); }
                if (openSpace[5][17] == true) { tb5x17y.CssClass = "charBlock whiteBlock"; tb5x17y.Text = validEntries[5][17]; } else { tb5x17y.CssClass = "charBlock whiteBlock"; tb5x17y.Text = RandomChar(random); }
                if (openSpace[5][18] == true) { tb5x18y.CssClass = "charBlock whiteBlock"; tb5x18y.Text = validEntries[5][18]; } else { tb5x18y.CssClass = "charBlock whiteBlock"; tb5x18y.Text = RandomChar(random); }
                if (openSpace[5][19] == true) { tb5x19y.CssClass = "charBlock whiteBlock"; tb5x19y.Text = validEntries[5][19]; } else { tb5x19y.CssClass = "charBlock whiteBlock"; tb5x19y.Text = RandomChar(random); }
                if (openSpace[6][0] == true) { tb6x0y.CssClass = "charBlock whiteBlock"; tb6x0y.Text = validEntries[6][0]; } else { tb6x0y.CssClass = "charBlock whiteBlock"; tb6x0y.Text = RandomChar(random); }
                if (openSpace[6][1] == true) { tb6x1y.CssClass = "charBlock whiteBlock"; tb6x1y.Text = validEntries[6][1]; } else { tb6x1y.CssClass = "charBlock whiteBlock"; tb6x1y.Text = RandomChar(random); }
                if (openSpace[6][2] == true) { tb6x2y.CssClass = "charBlock whiteBlock"; tb6x2y.Text = validEntries[6][2]; } else { tb6x2y.CssClass = "charBlock whiteBlock"; tb6x2y.Text = RandomChar(random); }
                if (openSpace[6][3] == true) { tb6x3y.CssClass = "charBlock whiteBlock"; tb6x3y.Text = validEntries[6][3]; } else { tb6x3y.CssClass = "charBlock whiteBlock"; tb6x3y.Text = RandomChar(random); }
                if (openSpace[6][4] == true) { tb6x4y.CssClass = "charBlock whiteBlock"; tb6x4y.Text = validEntries[6][4]; } else { tb6x4y.CssClass = "charBlock whiteBlock"; tb6x4y.Text = RandomChar(random); }
                if (openSpace[6][5] == true) { tb6x5y.CssClass = "charBlock whiteBlock"; tb6x5y.Text = validEntries[6][5]; } else { tb6x5y.CssClass = "charBlock whiteBlock"; tb6x5y.Text = RandomChar(random); }
                if (openSpace[6][6] == true) { tb6x6y.CssClass = "charBlock whiteBlock"; tb6x6y.Text = validEntries[6][6]; } else { tb6x6y.CssClass = "charBlock whiteBlock"; tb6x6y.Text = RandomChar(random); }
                if (openSpace[6][7] == true) { tb6x7y.CssClass = "charBlock whiteBlock"; tb6x7y.Text = validEntries[6][7]; } else { tb6x7y.CssClass = "charBlock whiteBlock"; tb6x7y.Text = RandomChar(random); }
                if (openSpace[6][8] == true) { tb6x8y.CssClass = "charBlock whiteBlock"; tb6x8y.Text = validEntries[6][8]; } else { tb6x8y.CssClass = "charBlock whiteBlock"; tb6x8y.Text = RandomChar(random); }
                if (openSpace[6][9] == true) { tb6x9y.CssClass = "charBlock whiteBlock"; tb6x9y.Text = validEntries[6][9]; } else { tb6x9y.CssClass = "charBlock whiteBlock"; tb6x9y.Text = RandomChar(random); }
                if (openSpace[6][10] == true) { tb6x10y.CssClass = "charBlock whiteBlock"; tb6x10y.Text = validEntries[6][10]; } else { tb6x10y.CssClass = "charBlock whiteBlock"; tb6x10y.Text = RandomChar(random); }
                if (openSpace[6][11] == true) { tb6x11y.CssClass = "charBlock whiteBlock"; tb6x11y.Text = validEntries[6][11]; } else { tb6x11y.CssClass = "charBlock whiteBlock"; tb6x11y.Text = RandomChar(random); }
                if (openSpace[6][12] == true) { tb6x12y.CssClass = "charBlock whiteBlock"; tb6x12y.Text = validEntries[6][12]; } else { tb6x12y.CssClass = "charBlock whiteBlock"; tb6x12y.Text = RandomChar(random); }
                if (openSpace[6][13] == true) { tb6x13y.CssClass = "charBlock whiteBlock"; tb6x13y.Text = validEntries[6][13]; } else { tb6x13y.CssClass = "charBlock whiteBlock"; tb6x13y.Text = RandomChar(random); }
                if (openSpace[6][14] == true) { tb6x14y.CssClass = "charBlock whiteBlock"; tb6x14y.Text = validEntries[6][14]; } else { tb6x14y.CssClass = "charBlock whiteBlock"; tb6x14y.Text = RandomChar(random); }
                if (openSpace[6][15] == true) { tb6x15y.CssClass = "charBlock whiteBlock"; tb6x15y.Text = validEntries[6][15]; } else { tb6x15y.CssClass = "charBlock whiteBlock"; tb6x15y.Text = RandomChar(random); }
                if (openSpace[6][16] == true) { tb6x16y.CssClass = "charBlock whiteBlock"; tb6x16y.Text = validEntries[6][16]; } else { tb6x16y.CssClass = "charBlock whiteBlock"; tb6x16y.Text = RandomChar(random); }
                if (openSpace[6][17] == true) { tb6x17y.CssClass = "charBlock whiteBlock"; tb6x17y.Text = validEntries[6][17]; } else { tb6x17y.CssClass = "charBlock whiteBlock"; tb6x17y.Text = RandomChar(random); }
                if (openSpace[6][18] == true) { tb6x18y.CssClass = "charBlock whiteBlock"; tb6x18y.Text = validEntries[6][18]; } else { tb6x18y.CssClass = "charBlock whiteBlock"; tb6x18y.Text = RandomChar(random); }
                if (openSpace[6][19] == true) { tb6x19y.CssClass = "charBlock whiteBlock"; tb6x19y.Text = validEntries[6][19]; } else { tb6x19y.CssClass = "charBlock whiteBlock"; tb6x19y.Text = RandomChar(random); }
                if (openSpace[7][0] == true) { tb7x0y.CssClass = "charBlock whiteBlock"; tb7x0y.Text = validEntries[7][0]; } else { tb7x0y.CssClass = "charBlock whiteBlock"; tb7x0y.Text = RandomChar(random); }
                if (openSpace[7][1] == true) { tb7x1y.CssClass = "charBlock whiteBlock"; tb7x1y.Text = validEntries[7][1]; } else { tb7x1y.CssClass = "charBlock whiteBlock"; tb7x1y.Text = RandomChar(random); }
                if (openSpace[7][2] == true) { tb7x2y.CssClass = "charBlock whiteBlock"; tb7x2y.Text = validEntries[7][2]; } else { tb7x2y.CssClass = "charBlock whiteBlock"; tb7x2y.Text = RandomChar(random); }
                if (openSpace[7][3] == true) { tb7x3y.CssClass = "charBlock whiteBlock"; tb7x3y.Text = validEntries[7][3]; } else { tb7x3y.CssClass = "charBlock whiteBlock"; tb7x3y.Text = RandomChar(random); }
                if (openSpace[7][4] == true) { tb7x4y.CssClass = "charBlock whiteBlock"; tb7x4y.Text = validEntries[7][4]; } else { tb7x4y.CssClass = "charBlock whiteBlock"; tb7x4y.Text = RandomChar(random); }
                if (openSpace[7][5] == true) { tb7x5y.CssClass = "charBlock whiteBlock"; tb7x5y.Text = validEntries[7][5]; } else { tb7x5y.CssClass = "charBlock whiteBlock"; tb7x5y.Text = RandomChar(random); }
                if (openSpace[7][6] == true) { tb7x6y.CssClass = "charBlock whiteBlock"; tb7x6y.Text = validEntries[7][6]; } else { tb7x6y.CssClass = "charBlock whiteBlock"; tb7x6y.Text = RandomChar(random); }
                if (openSpace[7][7] == true) { tb7x7y.CssClass = "charBlock whiteBlock"; tb7x7y.Text = validEntries[7][7]; } else { tb7x7y.CssClass = "charBlock whiteBlock"; tb7x7y.Text = RandomChar(random); }
                if (openSpace[7][8] == true) { tb7x8y.CssClass = "charBlock whiteBlock"; tb7x8y.Text = validEntries[7][8]; } else { tb7x8y.CssClass = "charBlock whiteBlock"; tb7x8y.Text = RandomChar(random); }
                if (openSpace[7][9] == true) { tb7x9y.CssClass = "charBlock whiteBlock"; tb7x9y.Text = validEntries[7][9]; } else { tb7x9y.CssClass = "charBlock whiteBlock"; tb7x9y.Text = RandomChar(random); }
                if (openSpace[7][10] == true) { tb7x10y.CssClass = "charBlock whiteBlock"; tb7x10y.Text = validEntries[7][10]; } else { tb7x10y.CssClass = "charBlock whiteBlock"; tb7x10y.Text = RandomChar(random); }
                if (openSpace[7][11] == true) { tb7x11y.CssClass = "charBlock whiteBlock"; tb7x11y.Text = validEntries[7][11]; } else { tb7x11y.CssClass = "charBlock whiteBlock"; tb7x11y.Text = RandomChar(random); }
                if (openSpace[7][12] == true) { tb7x12y.CssClass = "charBlock whiteBlock"; tb7x12y.Text = validEntries[7][12]; } else { tb7x12y.CssClass = "charBlock whiteBlock"; tb7x12y.Text = RandomChar(random); }
                if (openSpace[7][13] == true) { tb7x13y.CssClass = "charBlock whiteBlock"; tb7x13y.Text = validEntries[7][13]; } else { tb7x13y.CssClass = "charBlock whiteBlock"; tb7x13y.Text = RandomChar(random); }
                if (openSpace[7][14] == true) { tb7x14y.CssClass = "charBlock whiteBlock"; tb7x14y.Text = validEntries[7][14]; } else { tb7x14y.CssClass = "charBlock whiteBlock"; tb7x14y.Text = RandomChar(random); }
                if (openSpace[7][15] == true) { tb7x15y.CssClass = "charBlock whiteBlock"; tb7x15y.Text = validEntries[7][15]; } else { tb7x15y.CssClass = "charBlock whiteBlock"; tb7x15y.Text = RandomChar(random); }
                if (openSpace[7][16] == true) { tb7x16y.CssClass = "charBlock whiteBlock"; tb7x16y.Text = validEntries[7][16]; } else { tb7x16y.CssClass = "charBlock whiteBlock"; tb7x16y.Text = RandomChar(random); }
                if (openSpace[7][17] == true) { tb7x17y.CssClass = "charBlock whiteBlock"; tb7x17y.Text = validEntries[7][17]; } else { tb7x17y.CssClass = "charBlock whiteBlock"; tb7x17y.Text = RandomChar(random); }
                if (openSpace[7][18] == true) { tb7x18y.CssClass = "charBlock whiteBlock"; tb7x18y.Text = validEntries[7][18]; } else { tb7x18y.CssClass = "charBlock whiteBlock"; tb7x18y.Text = RandomChar(random); }
                if (openSpace[7][19] == true) { tb7x19y.CssClass = "charBlock whiteBlock"; tb7x19y.Text = validEntries[7][19]; } else { tb7x19y.CssClass = "charBlock whiteBlock"; tb7x19y.Text = RandomChar(random); }
                if (openSpace[8][0] == true) { tb8x0y.CssClass = "charBlock whiteBlock"; tb8x0y.Text = validEntries[8][0]; } else { tb8x0y.CssClass = "charBlock whiteBlock"; tb8x0y.Text = RandomChar(random); }
                if (openSpace[8][1] == true) { tb8x1y.CssClass = "charBlock whiteBlock"; tb8x1y.Text = validEntries[8][1]; } else { tb8x1y.CssClass = "charBlock whiteBlock"; tb8x1y.Text = RandomChar(random); }
                if (openSpace[8][2] == true) { tb8x2y.CssClass = "charBlock whiteBlock"; tb8x2y.Text = validEntries[8][2]; } else { tb8x2y.CssClass = "charBlock whiteBlock"; tb8x2y.Text = RandomChar(random); }
                if (openSpace[8][3] == true) { tb8x3y.CssClass = "charBlock whiteBlock"; tb8x3y.Text = validEntries[8][3]; } else { tb8x3y.CssClass = "charBlock whiteBlock"; tb8x3y.Text = RandomChar(random); }
                if (openSpace[8][4] == true) { tb8x4y.CssClass = "charBlock whiteBlock"; tb8x4y.Text = validEntries[8][4]; } else { tb8x4y.CssClass = "charBlock whiteBlock"; tb8x4y.Text = RandomChar(random); }
                if (openSpace[8][5] == true) { tb8x5y.CssClass = "charBlock whiteBlock"; tb8x5y.Text = validEntries[8][5]; } else { tb8x5y.CssClass = "charBlock whiteBlock"; tb8x5y.Text = RandomChar(random); }
                if (openSpace[8][6] == true) { tb8x6y.CssClass = "charBlock whiteBlock"; tb8x6y.Text = validEntries[8][6]; } else { tb8x6y.CssClass = "charBlock whiteBlock"; tb8x6y.Text = RandomChar(random); }
                if (openSpace[8][7] == true) { tb8x7y.CssClass = "charBlock whiteBlock"; tb8x7y.Text = validEntries[8][7]; } else { tb8x7y.CssClass = "charBlock whiteBlock"; tb8x7y.Text = RandomChar(random); }
                if (openSpace[8][8] == true) { tb8x8y.CssClass = "charBlock whiteBlock"; tb8x8y.Text = validEntries[8][8]; } else { tb8x8y.CssClass = "charBlock whiteBlock"; tb8x8y.Text = RandomChar(random); }
                if (openSpace[8][9] == true) { tb8x9y.CssClass = "charBlock whiteBlock"; tb8x9y.Text = validEntries[8][9]; } else { tb8x9y.CssClass = "charBlock whiteBlock"; tb8x9y.Text = RandomChar(random); }
                if (openSpace[8][10] == true) { tb8x10y.CssClass = "charBlock whiteBlock"; tb8x10y.Text = validEntries[8][10]; } else { tb8x10y.CssClass = "charBlock whiteBlock"; tb8x10y.Text = RandomChar(random); }
                if (openSpace[8][11] == true) { tb8x11y.CssClass = "charBlock whiteBlock"; tb8x11y.Text = validEntries[8][11]; } else { tb8x11y.CssClass = "charBlock whiteBlock"; tb8x11y.Text = RandomChar(random); }
                if (openSpace[8][12] == true) { tb8x12y.CssClass = "charBlock whiteBlock"; tb8x12y.Text = validEntries[8][12]; } else { tb8x12y.CssClass = "charBlock whiteBlock"; tb8x12y.Text = RandomChar(random); }
                if (openSpace[8][13] == true) { tb8x13y.CssClass = "charBlock whiteBlock"; tb8x13y.Text = validEntries[8][13]; } else { tb8x13y.CssClass = "charBlock whiteBlock"; tb8x13y.Text = RandomChar(random); }
                if (openSpace[8][14] == true) { tb8x14y.CssClass = "charBlock whiteBlock"; tb8x14y.Text = validEntries[8][14]; } else { tb8x14y.CssClass = "charBlock whiteBlock"; tb8x14y.Text = RandomChar(random); }
                if (openSpace[8][15] == true) { tb8x15y.CssClass = "charBlock whiteBlock"; tb8x15y.Text = validEntries[8][15]; } else { tb8x15y.CssClass = "charBlock whiteBlock"; tb8x15y.Text = RandomChar(random); }
                if (openSpace[8][16] == true) { tb8x16y.CssClass = "charBlock whiteBlock"; tb8x16y.Text = validEntries[8][16]; } else { tb8x16y.CssClass = "charBlock whiteBlock"; tb8x16y.Text = RandomChar(random); }
                if (openSpace[8][17] == true) { tb8x17y.CssClass = "charBlock whiteBlock"; tb8x17y.Text = validEntries[8][17]; } else { tb8x17y.CssClass = "charBlock whiteBlock"; tb8x17y.Text = RandomChar(random); }
                if (openSpace[8][18] == true) { tb8x18y.CssClass = "charBlock whiteBlock"; tb8x18y.Text = validEntries[8][18]; } else { tb8x18y.CssClass = "charBlock whiteBlock"; tb8x18y.Text = RandomChar(random); }
                if (openSpace[8][19] == true) { tb8x19y.CssClass = "charBlock whiteBlock"; tb8x19y.Text = validEntries[8][19]; } else { tb8x19y.CssClass = "charBlock whiteBlock"; tb8x19y.Text = RandomChar(random); }
                if (openSpace[9][0] == true) { tb9x0y.CssClass = "charBlock whiteBlock"; tb9x0y.Text = validEntries[9][0]; } else { tb9x0y.CssClass = "charBlock whiteBlock"; tb9x0y.Text = RandomChar(random); }
                if (openSpace[9][1] == true) { tb9x1y.CssClass = "charBlock whiteBlock"; tb9x1y.Text = validEntries[9][1]; } else { tb9x1y.CssClass = "charBlock whiteBlock"; tb9x1y.Text = RandomChar(random); }
                if (openSpace[9][2] == true) { tb9x2y.CssClass = "charBlock whiteBlock"; tb9x2y.Text = validEntries[9][2]; } else { tb9x2y.CssClass = "charBlock whiteBlock"; tb9x2y.Text = RandomChar(random); }
                if (openSpace[9][3] == true) { tb9x3y.CssClass = "charBlock whiteBlock"; tb9x3y.Text = validEntries[9][3]; } else { tb9x3y.CssClass = "charBlock whiteBlock"; tb9x3y.Text = RandomChar(random); }
                if (openSpace[9][4] == true) { tb9x4y.CssClass = "charBlock whiteBlock"; tb9x4y.Text = validEntries[9][4]; } else { tb9x4y.CssClass = "charBlock whiteBlock"; tb9x4y.Text = RandomChar(random); }
                if (openSpace[9][5] == true) { tb9x5y.CssClass = "charBlock whiteBlock"; tb9x5y.Text = validEntries[9][5]; } else { tb9x5y.CssClass = "charBlock whiteBlock"; tb9x5y.Text = RandomChar(random); }
                if (openSpace[9][6] == true) { tb9x6y.CssClass = "charBlock whiteBlock"; tb9x6y.Text = validEntries[9][6]; } else { tb9x6y.CssClass = "charBlock whiteBlock"; tb9x6y.Text = RandomChar(random); }
                if (openSpace[9][7] == true) { tb9x7y.CssClass = "charBlock whiteBlock"; tb9x7y.Text = validEntries[9][7]; } else { tb9x7y.CssClass = "charBlock whiteBlock"; tb9x7y.Text = RandomChar(random); }
                if (openSpace[9][8] == true) { tb9x8y.CssClass = "charBlock whiteBlock"; tb9x8y.Text = validEntries[9][8]; } else { tb9x8y.CssClass = "charBlock whiteBlock"; tb9x8y.Text = RandomChar(random); }
                if (openSpace[9][9] == true) { tb9x9y.CssClass = "charBlock whiteBlock"; tb9x9y.Text = validEntries[9][9]; } else { tb9x9y.CssClass = "charBlock whiteBlock"; tb9x9y.Text = RandomChar(random); }
                if (openSpace[9][10] == true) { tb9x10y.CssClass = "charBlock whiteBlock"; tb9x10y.Text = validEntries[9][10]; } else { tb9x10y.CssClass = "charBlock whiteBlock"; tb9x10y.Text = RandomChar(random); }
                if (openSpace[9][11] == true) { tb9x11y.CssClass = "charBlock whiteBlock"; tb9x11y.Text = validEntries[9][11]; } else { tb9x11y.CssClass = "charBlock whiteBlock"; tb9x11y.Text = RandomChar(random); }
                if (openSpace[9][12] == true) { tb9x12y.CssClass = "charBlock whiteBlock"; tb9x12y.Text = validEntries[9][12]; } else { tb9x12y.CssClass = "charBlock whiteBlock"; tb9x12y.Text = RandomChar(random); }
                if (openSpace[9][13] == true) { tb9x13y.CssClass = "charBlock whiteBlock"; tb9x13y.Text = validEntries[9][13]; } else { tb9x13y.CssClass = "charBlock whiteBlock"; tb9x13y.Text = RandomChar(random); }
                if (openSpace[9][14] == true) { tb9x14y.CssClass = "charBlock whiteBlock"; tb9x14y.Text = validEntries[9][14]; } else { tb9x14y.CssClass = "charBlock whiteBlock"; tb9x14y.Text = RandomChar(random); }
                if (openSpace[9][15] == true) { tb9x15y.CssClass = "charBlock whiteBlock"; tb9x15y.Text = validEntries[9][15]; } else { tb9x15y.CssClass = "charBlock whiteBlock"; tb9x15y.Text = RandomChar(random); }
                if (openSpace[9][16] == true) { tb9x16y.CssClass = "charBlock whiteBlock"; tb9x16y.Text = validEntries[9][16]; } else { tb9x16y.CssClass = "charBlock whiteBlock"; tb9x16y.Text = RandomChar(random); }
                if (openSpace[9][17] == true) { tb9x17y.CssClass = "charBlock whiteBlock"; tb9x17y.Text = validEntries[9][17]; } else { tb9x17y.CssClass = "charBlock whiteBlock"; tb9x17y.Text = RandomChar(random); }
                if (openSpace[9][18] == true) { tb9x18y.CssClass = "charBlock whiteBlock"; tb9x18y.Text = validEntries[9][18]; } else { tb9x18y.CssClass = "charBlock whiteBlock"; tb9x18y.Text = RandomChar(random); }
                if (openSpace[9][19] == true) { tb9x19y.CssClass = "charBlock whiteBlock"; tb9x19y.Text = validEntries[9][19]; } else { tb9x19y.CssClass = "charBlock whiteBlock"; tb9x19y.Text = RandomChar(random); }
                if (openSpace[10][0] == true) { tb10x0y.CssClass = "charBlock whiteBlock"; tb10x0y.Text = validEntries[10][0]; } else { tb10x0y.CssClass = "charBlock whiteBlock"; tb10x0y.Text = RandomChar(random); }
                if (openSpace[10][1] == true) { tb10x1y.CssClass = "charBlock whiteBlock"; tb10x1y.Text = validEntries[10][1]; } else { tb10x1y.CssClass = "charBlock whiteBlock"; tb10x1y.Text = RandomChar(random); }
                if (openSpace[10][2] == true) { tb10x2y.CssClass = "charBlock whiteBlock"; tb10x2y.Text = validEntries[10][2]; } else { tb10x2y.CssClass = "charBlock whiteBlock"; tb10x2y.Text = RandomChar(random); }
                if (openSpace[10][3] == true) { tb10x3y.CssClass = "charBlock whiteBlock"; tb10x3y.Text = validEntries[10][3]; } else { tb10x3y.CssClass = "charBlock whiteBlock"; tb10x3y.Text = RandomChar(random); }
                if (openSpace[10][4] == true) { tb10x4y.CssClass = "charBlock whiteBlock"; tb10x4y.Text = validEntries[10][4]; } else { tb10x4y.CssClass = "charBlock whiteBlock"; tb10x4y.Text = RandomChar(random); }
                if (openSpace[10][5] == true) { tb10x5y.CssClass = "charBlock whiteBlock"; tb10x5y.Text = validEntries[10][5]; } else { tb10x5y.CssClass = "charBlock whiteBlock"; tb10x5y.Text = RandomChar(random); }
                if (openSpace[10][6] == true) { tb10x6y.CssClass = "charBlock whiteBlock"; tb10x6y.Text = validEntries[10][6]; } else { tb10x6y.CssClass = "charBlock whiteBlock"; tb10x6y.Text = RandomChar(random); }
                if (openSpace[10][7] == true) { tb10x7y.CssClass = "charBlock whiteBlock"; tb10x7y.Text = validEntries[10][7]; } else { tb10x7y.CssClass = "charBlock whiteBlock"; tb10x7y.Text = RandomChar(random); }
                if (openSpace[10][8] == true) { tb10x8y.CssClass = "charBlock whiteBlock"; tb10x8y.Text = validEntries[10][8]; } else { tb10x8y.CssClass = "charBlock whiteBlock"; tb10x8y.Text = RandomChar(random); }
                if (openSpace[10][9] == true) { tb10x9y.CssClass = "charBlock whiteBlock"; tb10x9y.Text = validEntries[10][9]; } else { tb10x9y.CssClass = "charBlock whiteBlock"; tb10x9y.Text = RandomChar(random); }
                if (openSpace[10][10] == true) { tb10x10y.CssClass = "charBlock whiteBlock"; tb10x10y.Text = validEntries[10][10]; } else { tb10x10y.CssClass = "charBlock whiteBlock"; tb10x10y.Text = RandomChar(random); }
                if (openSpace[10][11] == true) { tb10x11y.CssClass = "charBlock whiteBlock"; tb10x11y.Text = validEntries[10][11]; } else { tb10x11y.CssClass = "charBlock whiteBlock"; tb10x11y.Text = RandomChar(random); }
                if (openSpace[10][12] == true) { tb10x12y.CssClass = "charBlock whiteBlock"; tb10x12y.Text = validEntries[10][12]; } else { tb10x12y.CssClass = "charBlock whiteBlock"; tb10x12y.Text = RandomChar(random); }
                if (openSpace[10][13] == true) { tb10x13y.CssClass = "charBlock whiteBlock"; tb10x13y.Text = validEntries[10][13]; } else { tb10x13y.CssClass = "charBlock whiteBlock"; tb10x13y.Text = RandomChar(random); }
                if (openSpace[10][14] == true) { tb10x14y.CssClass = "charBlock whiteBlock"; tb10x14y.Text = validEntries[10][14]; } else { tb10x14y.CssClass = "charBlock whiteBlock"; tb10x14y.Text = RandomChar(random); }
                if (openSpace[10][15] == true) { tb10x15y.CssClass = "charBlock whiteBlock"; tb10x15y.Text = validEntries[10][15]; } else { tb10x15y.CssClass = "charBlock whiteBlock"; tb10x15y.Text = RandomChar(random); }
                if (openSpace[10][16] == true) { tb10x16y.CssClass = "charBlock whiteBlock"; tb10x16y.Text = validEntries[10][16]; } else { tb10x16y.CssClass = "charBlock whiteBlock"; tb10x16y.Text = RandomChar(random); }
                if (openSpace[10][17] == true) { tb10x17y.CssClass = "charBlock whiteBlock"; tb10x17y.Text = validEntries[10][17]; } else { tb10x17y.CssClass = "charBlock whiteBlock"; tb10x17y.Text = RandomChar(random); }
                if (openSpace[10][18] == true) { tb10x18y.CssClass = "charBlock whiteBlock"; tb10x18y.Text = validEntries[10][18]; } else { tb10x18y.CssClass = "charBlock whiteBlock"; tb10x18y.Text = RandomChar(random); }
                if (openSpace[10][19] == true) { tb10x19y.CssClass = "charBlock whiteBlock"; tb10x19y.Text = validEntries[10][19]; } else { tb10x19y.CssClass = "charBlock whiteBlock"; tb10x19y.Text = RandomChar(random); }
                if (openSpace[11][0] == true) { tb11x0y.CssClass = "charBlock whiteBlock"; tb11x0y.Text = validEntries[11][0]; } else { tb11x0y.CssClass = "charBlock whiteBlock"; tb11x0y.Text = RandomChar(random); }
                if (openSpace[11][1] == true) { tb11x1y.CssClass = "charBlock whiteBlock"; tb11x1y.Text = validEntries[11][1]; } else { tb11x1y.CssClass = "charBlock whiteBlock"; tb11x1y.Text = RandomChar(random); }
                if (openSpace[11][2] == true) { tb11x2y.CssClass = "charBlock whiteBlock"; tb11x2y.Text = validEntries[11][2]; } else { tb11x2y.CssClass = "charBlock whiteBlock"; tb11x2y.Text = RandomChar(random); }
                if (openSpace[11][3] == true) { tb11x3y.CssClass = "charBlock whiteBlock"; tb11x3y.Text = validEntries[11][3]; } else { tb11x3y.CssClass = "charBlock whiteBlock"; tb11x3y.Text = RandomChar(random); }
                if (openSpace[11][4] == true) { tb11x4y.CssClass = "charBlock whiteBlock"; tb11x4y.Text = validEntries[11][4]; } else { tb11x4y.CssClass = "charBlock whiteBlock"; tb11x4y.Text = RandomChar(random); }
                if (openSpace[11][5] == true) { tb11x5y.CssClass = "charBlock whiteBlock"; tb11x5y.Text = validEntries[11][5]; } else { tb11x5y.CssClass = "charBlock whiteBlock"; tb11x5y.Text = RandomChar(random); }
                if (openSpace[11][6] == true) { tb11x6y.CssClass = "charBlock whiteBlock"; tb11x6y.Text = validEntries[11][6]; } else { tb11x6y.CssClass = "charBlock whiteBlock"; tb11x6y.Text = RandomChar(random); }
                if (openSpace[11][7] == true) { tb11x7y.CssClass = "charBlock whiteBlock"; tb11x7y.Text = validEntries[11][7]; } else { tb11x7y.CssClass = "charBlock whiteBlock"; tb11x7y.Text = RandomChar(random); }
                if (openSpace[11][8] == true) { tb11x8y.CssClass = "charBlock whiteBlock"; tb11x8y.Text = validEntries[11][8]; } else { tb11x8y.CssClass = "charBlock whiteBlock"; tb11x8y.Text = RandomChar(random); }
                if (openSpace[11][9] == true) { tb11x9y.CssClass = "charBlock whiteBlock"; tb11x9y.Text = validEntries[11][9]; } else { tb11x9y.CssClass = "charBlock whiteBlock"; tb11x9y.Text = RandomChar(random); }
                if (openSpace[11][10] == true) { tb11x10y.CssClass = "charBlock whiteBlock"; tb11x10y.Text = validEntries[11][10]; } else { tb11x10y.CssClass = "charBlock whiteBlock"; tb11x10y.Text = RandomChar(random); }
                if (openSpace[11][11] == true) { tb11x11y.CssClass = "charBlock whiteBlock"; tb11x11y.Text = validEntries[11][11]; } else { tb11x11y.CssClass = "charBlock whiteBlock"; tb11x11y.Text = RandomChar(random); }
                if (openSpace[11][12] == true) { tb11x12y.CssClass = "charBlock whiteBlock"; tb11x12y.Text = validEntries[11][12]; } else { tb11x12y.CssClass = "charBlock whiteBlock"; tb11x12y.Text = RandomChar(random); }
                if (openSpace[11][13] == true) { tb11x13y.CssClass = "charBlock whiteBlock"; tb11x13y.Text = validEntries[11][13]; } else { tb11x13y.CssClass = "charBlock whiteBlock"; tb11x13y.Text = RandomChar(random); }
                if (openSpace[11][14] == true) { tb11x14y.CssClass = "charBlock whiteBlock"; tb11x14y.Text = validEntries[11][14]; } else { tb11x14y.CssClass = "charBlock whiteBlock"; tb11x14y.Text = RandomChar(random); }
                if (openSpace[11][15] == true) { tb11x15y.CssClass = "charBlock whiteBlock"; tb11x15y.Text = validEntries[11][15]; } else { tb11x15y.CssClass = "charBlock whiteBlock"; tb11x15y.Text = RandomChar(random); }
                if (openSpace[11][16] == true) { tb11x16y.CssClass = "charBlock whiteBlock"; tb11x16y.Text = validEntries[11][16]; } else { tb11x16y.CssClass = "charBlock whiteBlock"; tb11x16y.Text = RandomChar(random); }
                if (openSpace[11][17] == true) { tb11x17y.CssClass = "charBlock whiteBlock"; tb11x17y.Text = validEntries[11][17]; } else { tb11x17y.CssClass = "charBlock whiteBlock"; tb11x17y.Text = RandomChar(random); }
                if (openSpace[11][18] == true) { tb11x18y.CssClass = "charBlock whiteBlock"; tb11x18y.Text = validEntries[11][18]; } else { tb11x18y.CssClass = "charBlock whiteBlock"; tb11x18y.Text = RandomChar(random); }
                if (openSpace[11][19] == true) { tb11x19y.CssClass = "charBlock whiteBlock"; tb11x19y.Text = validEntries[11][19]; } else { tb11x19y.CssClass = "charBlock whiteBlock"; tb11x19y.Text = RandomChar(random); }
                if (openSpace[12][0] == true) { tb12x0y.CssClass = "charBlock whiteBlock"; tb12x0y.Text = validEntries[12][0]; } else { tb12x0y.CssClass = "charBlock whiteBlock"; tb12x0y.Text = RandomChar(random); }
                if (openSpace[12][1] == true) { tb12x1y.CssClass = "charBlock whiteBlock"; tb12x1y.Text = validEntries[12][1]; } else { tb12x1y.CssClass = "charBlock whiteBlock"; tb12x1y.Text = RandomChar(random); }
                if (openSpace[12][2] == true) { tb12x2y.CssClass = "charBlock whiteBlock"; tb12x2y.Text = validEntries[12][2]; } else { tb12x2y.CssClass = "charBlock whiteBlock"; tb12x2y.Text = RandomChar(random); }
                if (openSpace[12][3] == true) { tb12x3y.CssClass = "charBlock whiteBlock"; tb12x3y.Text = validEntries[12][3]; } else { tb12x3y.CssClass = "charBlock whiteBlock"; tb12x3y.Text = RandomChar(random); }
                if (openSpace[12][4] == true) { tb12x4y.CssClass = "charBlock whiteBlock"; tb12x4y.Text = validEntries[12][4]; } else { tb12x4y.CssClass = "charBlock whiteBlock"; tb12x4y.Text = RandomChar(random); }
                if (openSpace[12][5] == true) { tb12x5y.CssClass = "charBlock whiteBlock"; tb12x5y.Text = validEntries[12][5]; } else { tb12x5y.CssClass = "charBlock whiteBlock"; tb12x5y.Text = RandomChar(random); }
                if (openSpace[12][6] == true) { tb12x6y.CssClass = "charBlock whiteBlock"; tb12x6y.Text = validEntries[12][6]; } else { tb12x6y.CssClass = "charBlock whiteBlock"; tb12x6y.Text = RandomChar(random); }
                if (openSpace[12][7] == true) { tb12x7y.CssClass = "charBlock whiteBlock"; tb12x7y.Text = validEntries[12][7]; } else { tb12x7y.CssClass = "charBlock whiteBlock"; tb12x7y.Text = RandomChar(random); }
                if (openSpace[12][8] == true) { tb12x8y.CssClass = "charBlock whiteBlock"; tb12x8y.Text = validEntries[12][8]; } else { tb12x8y.CssClass = "charBlock whiteBlock"; tb12x8y.Text = RandomChar(random); }
                if (openSpace[12][9] == true) { tb12x9y.CssClass = "charBlock whiteBlock"; tb12x9y.Text = validEntries[12][9]; } else { tb12x9y.CssClass = "charBlock whiteBlock"; tb12x9y.Text = RandomChar(random); }
                if (openSpace[12][10] == true) { tb12x10y.CssClass = "charBlock whiteBlock"; tb12x10y.Text = validEntries[12][10]; } else { tb12x10y.CssClass = "charBlock whiteBlock"; tb12x10y.Text = RandomChar(random); }
                if (openSpace[12][11] == true) { tb12x11y.CssClass = "charBlock whiteBlock"; tb12x11y.Text = validEntries[12][11]; } else { tb12x11y.CssClass = "charBlock whiteBlock"; tb12x11y.Text = RandomChar(random); }
                if (openSpace[12][12] == true) { tb12x12y.CssClass = "charBlock whiteBlock"; tb12x12y.Text = validEntries[12][12]; } else { tb12x12y.CssClass = "charBlock whiteBlock"; tb12x12y.Text = RandomChar(random); }
                if (openSpace[12][13] == true) { tb12x13y.CssClass = "charBlock whiteBlock"; tb12x13y.Text = validEntries[12][13]; } else { tb12x13y.CssClass = "charBlock whiteBlock"; tb12x13y.Text = RandomChar(random); }
                if (openSpace[12][14] == true) { tb12x14y.CssClass = "charBlock whiteBlock"; tb12x14y.Text = validEntries[12][14]; } else { tb12x14y.CssClass = "charBlock whiteBlock"; tb12x14y.Text = RandomChar(random); }
                if (openSpace[12][15] == true) { tb12x15y.CssClass = "charBlock whiteBlock"; tb12x15y.Text = validEntries[12][15]; } else { tb12x15y.CssClass = "charBlock whiteBlock"; tb12x15y.Text = RandomChar(random); }
                if (openSpace[12][16] == true) { tb12x16y.CssClass = "charBlock whiteBlock"; tb12x16y.Text = validEntries[12][16]; } else { tb12x16y.CssClass = "charBlock whiteBlock"; tb12x16y.Text = RandomChar(random); }
                if (openSpace[12][17] == true) { tb12x17y.CssClass = "charBlock whiteBlock"; tb12x17y.Text = validEntries[12][17]; } else { tb12x17y.CssClass = "charBlock whiteBlock"; tb12x17y.Text = RandomChar(random); }
                if (openSpace[12][18] == true) { tb12x18y.CssClass = "charBlock whiteBlock"; tb12x18y.Text = validEntries[12][18]; } else { tb12x18y.CssClass = "charBlock whiteBlock"; tb12x18y.Text = RandomChar(random); }
                if (openSpace[12][19] == true) { tb12x19y.CssClass = "charBlock whiteBlock"; tb12x19y.Text = validEntries[12][19]; } else { tb12x19y.CssClass = "charBlock whiteBlock"; tb12x19y.Text = RandomChar(random); }
                if (openSpace[13][0] == true) { tb13x0y.CssClass = "charBlock whiteBlock"; tb13x0y.Text = validEntries[13][0]; } else { tb13x0y.CssClass = "charBlock whiteBlock"; tb13x0y.Text = RandomChar(random); }
                if (openSpace[13][1] == true) { tb13x1y.CssClass = "charBlock whiteBlock"; tb13x1y.Text = validEntries[13][1]; } else { tb13x1y.CssClass = "charBlock whiteBlock"; tb13x1y.Text = RandomChar(random); }
                if (openSpace[13][2] == true) { tb13x2y.CssClass = "charBlock whiteBlock"; tb13x2y.Text = validEntries[13][2]; } else { tb13x2y.CssClass = "charBlock whiteBlock"; tb13x2y.Text = RandomChar(random); }
                if (openSpace[13][3] == true) { tb13x3y.CssClass = "charBlock whiteBlock"; tb13x3y.Text = validEntries[13][3]; } else { tb13x3y.CssClass = "charBlock whiteBlock"; tb13x3y.Text = RandomChar(random); }
                if (openSpace[13][4] == true) { tb13x4y.CssClass = "charBlock whiteBlock"; tb13x4y.Text = validEntries[13][4]; } else { tb13x4y.CssClass = "charBlock whiteBlock"; tb13x4y.Text = RandomChar(random); }
                if (openSpace[13][5] == true) { tb13x5y.CssClass = "charBlock whiteBlock"; tb13x5y.Text = validEntries[13][5]; } else { tb13x5y.CssClass = "charBlock whiteBlock"; tb13x5y.Text = RandomChar(random); }
                if (openSpace[13][6] == true) { tb13x6y.CssClass = "charBlock whiteBlock"; tb13x6y.Text = validEntries[13][6]; } else { tb13x6y.CssClass = "charBlock whiteBlock"; tb13x6y.Text = RandomChar(random); }
                if (openSpace[13][7] == true) { tb13x7y.CssClass = "charBlock whiteBlock"; tb13x7y.Text = validEntries[13][7]; } else { tb13x7y.CssClass = "charBlock whiteBlock"; tb13x7y.Text = RandomChar(random); }
                if (openSpace[13][8] == true) { tb13x8y.CssClass = "charBlock whiteBlock"; tb13x8y.Text = validEntries[13][8]; } else { tb13x8y.CssClass = "charBlock whiteBlock"; tb13x8y.Text = RandomChar(random); }
                if (openSpace[13][9] == true) { tb13x9y.CssClass = "charBlock whiteBlock"; tb13x9y.Text = validEntries[13][9]; } else { tb13x9y.CssClass = "charBlock whiteBlock"; tb13x9y.Text = RandomChar(random); }
                if (openSpace[13][10] == true) { tb13x10y.CssClass = "charBlock whiteBlock"; tb13x10y.Text = validEntries[13][10]; } else { tb13x10y.CssClass = "charBlock whiteBlock"; tb13x10y.Text = RandomChar(random); }
                if (openSpace[13][11] == true) { tb13x11y.CssClass = "charBlock whiteBlock"; tb13x11y.Text = validEntries[13][11]; } else { tb13x11y.CssClass = "charBlock whiteBlock"; tb13x11y.Text = RandomChar(random); }
                if (openSpace[13][12] == true) { tb13x12y.CssClass = "charBlock whiteBlock"; tb13x12y.Text = validEntries[13][12]; } else { tb13x12y.CssClass = "charBlock whiteBlock"; tb13x12y.Text = RandomChar(random); }
                if (openSpace[13][13] == true) { tb13x13y.CssClass = "charBlock whiteBlock"; tb13x13y.Text = validEntries[13][13]; } else { tb13x13y.CssClass = "charBlock whiteBlock"; tb13x13y.Text = RandomChar(random); }
                if (openSpace[13][14] == true) { tb13x14y.CssClass = "charBlock whiteBlock"; tb13x14y.Text = validEntries[13][14]; } else { tb13x14y.CssClass = "charBlock whiteBlock"; tb13x14y.Text = RandomChar(random); }
                if (openSpace[13][15] == true) { tb13x15y.CssClass = "charBlock whiteBlock"; tb13x15y.Text = validEntries[13][15]; } else { tb13x15y.CssClass = "charBlock whiteBlock"; tb13x15y.Text = RandomChar(random); }
                if (openSpace[13][16] == true) { tb13x16y.CssClass = "charBlock whiteBlock"; tb13x16y.Text = validEntries[13][16]; } else { tb13x16y.CssClass = "charBlock whiteBlock"; tb13x16y.Text = RandomChar(random); }
                if (openSpace[13][17] == true) { tb13x17y.CssClass = "charBlock whiteBlock"; tb13x17y.Text = validEntries[13][17]; } else { tb13x17y.CssClass = "charBlock whiteBlock"; tb13x17y.Text = RandomChar(random); }
                if (openSpace[13][18] == true) { tb13x18y.CssClass = "charBlock whiteBlock"; tb13x18y.Text = validEntries[13][18]; } else { tb13x18y.CssClass = "charBlock whiteBlock"; tb13x18y.Text = RandomChar(random); }
                if (openSpace[13][19] == true) { tb13x19y.CssClass = "charBlock whiteBlock"; tb13x19y.Text = validEntries[13][19]; } else { tb13x19y.CssClass = "charBlock whiteBlock"; tb13x19y.Text = RandomChar(random); }
                if (openSpace[14][0] == true) { tb14x0y.CssClass = "charBlock whiteBlock"; tb14x0y.Text = validEntries[14][0]; } else { tb14x0y.CssClass = "charBlock whiteBlock"; tb14x0y.Text = RandomChar(random); }
                if (openSpace[14][1] == true) { tb14x1y.CssClass = "charBlock whiteBlock"; tb14x1y.Text = validEntries[14][1]; } else { tb14x1y.CssClass = "charBlock whiteBlock"; tb14x1y.Text = RandomChar(random); }
                if (openSpace[14][2] == true) { tb14x2y.CssClass = "charBlock whiteBlock"; tb14x2y.Text = validEntries[14][2]; } else { tb14x2y.CssClass = "charBlock whiteBlock"; tb14x2y.Text = RandomChar(random); }
                if (openSpace[14][3] == true) { tb14x3y.CssClass = "charBlock whiteBlock"; tb14x3y.Text = validEntries[14][3]; } else { tb14x3y.CssClass = "charBlock whiteBlock"; tb14x3y.Text = RandomChar(random); }
                if (openSpace[14][4] == true) { tb14x4y.CssClass = "charBlock whiteBlock"; tb14x4y.Text = validEntries[14][4]; } else { tb14x4y.CssClass = "charBlock whiteBlock"; tb14x4y.Text = RandomChar(random); }
                if (openSpace[14][5] == true) { tb14x5y.CssClass = "charBlock whiteBlock"; tb14x5y.Text = validEntries[14][5]; } else { tb14x5y.CssClass = "charBlock whiteBlock"; tb14x5y.Text = RandomChar(random); }
                if (openSpace[14][6] == true) { tb14x6y.CssClass = "charBlock whiteBlock"; tb14x6y.Text = validEntries[14][6]; } else { tb14x6y.CssClass = "charBlock whiteBlock"; tb14x6y.Text = RandomChar(random); }
                if (openSpace[14][7] == true) { tb14x7y.CssClass = "charBlock whiteBlock"; tb14x7y.Text = validEntries[14][7]; } else { tb14x7y.CssClass = "charBlock whiteBlock"; tb14x7y.Text = RandomChar(random); }
                if (openSpace[14][8] == true) { tb14x8y.CssClass = "charBlock whiteBlock"; tb14x8y.Text = validEntries[14][8]; } else { tb14x8y.CssClass = "charBlock whiteBlock"; tb14x8y.Text = RandomChar(random); }
                if (openSpace[14][9] == true) { tb14x9y.CssClass = "charBlock whiteBlock"; tb14x9y.Text = validEntries[14][9]; } else { tb14x9y.CssClass = "charBlock whiteBlock"; tb14x9y.Text = RandomChar(random); }
                if (openSpace[14][10] == true) { tb14x10y.CssClass = "charBlock whiteBlock"; tb14x10y.Text = validEntries[14][10]; } else { tb14x10y.CssClass = "charBlock whiteBlock"; tb14x10y.Text = RandomChar(random); }
                if (openSpace[14][11] == true) { tb14x11y.CssClass = "charBlock whiteBlock"; tb14x11y.Text = validEntries[14][11]; } else { tb14x11y.CssClass = "charBlock whiteBlock"; tb14x11y.Text = RandomChar(random); }
                if (openSpace[14][12] == true) { tb14x12y.CssClass = "charBlock whiteBlock"; tb14x12y.Text = validEntries[14][12]; } else { tb14x12y.CssClass = "charBlock whiteBlock"; tb14x12y.Text = RandomChar(random); }
                if (openSpace[14][13] == true) { tb14x13y.CssClass = "charBlock whiteBlock"; tb14x13y.Text = validEntries[14][13]; } else { tb14x13y.CssClass = "charBlock whiteBlock"; tb14x13y.Text = RandomChar(random); }
                if (openSpace[14][14] == true) { tb14x14y.CssClass = "charBlock whiteBlock"; tb14x14y.Text = validEntries[14][14]; } else { tb14x14y.CssClass = "charBlock whiteBlock"; tb14x14y.Text = RandomChar(random); }
                if (openSpace[14][15] == true) { tb14x15y.CssClass = "charBlock whiteBlock"; tb14x15y.Text = validEntries[14][15]; } else { tb14x15y.CssClass = "charBlock whiteBlock"; tb14x15y.Text = RandomChar(random); }
                if (openSpace[14][16] == true) { tb14x16y.CssClass = "charBlock whiteBlock"; tb14x16y.Text = validEntries[14][16]; } else { tb14x16y.CssClass = "charBlock whiteBlock"; tb14x16y.Text = RandomChar(random); }
                if (openSpace[14][17] == true) { tb14x17y.CssClass = "charBlock whiteBlock"; tb14x17y.Text = validEntries[14][17]; } else { tb14x17y.CssClass = "charBlock whiteBlock"; tb14x17y.Text = RandomChar(random); }
                if (openSpace[14][18] == true) { tb14x18y.CssClass = "charBlock whiteBlock"; tb14x18y.Text = validEntries[14][18]; } else { tb14x18y.CssClass = "charBlock whiteBlock"; tb14x18y.Text = RandomChar(random); }
                if (openSpace[14][19] == true) { tb14x19y.CssClass = "charBlock whiteBlock"; tb14x19y.Text = validEntries[14][19]; } else { tb14x19y.CssClass = "charBlock whiteBlock"; tb14x19y.Text = RandomChar(random); }
                if (openSpace[15][0] == true) { tb15x0y.CssClass = "charBlock whiteBlock"; tb15x0y.Text = validEntries[15][0]; } else { tb15x0y.CssClass = "charBlock whiteBlock"; tb15x0y.Text = RandomChar(random); }
                if (openSpace[15][1] == true) { tb15x1y.CssClass = "charBlock whiteBlock"; tb15x1y.Text = validEntries[15][1]; } else { tb15x1y.CssClass = "charBlock whiteBlock"; tb15x1y.Text = RandomChar(random); }
                if (openSpace[15][2] == true) { tb15x2y.CssClass = "charBlock whiteBlock"; tb15x2y.Text = validEntries[15][2]; } else { tb15x2y.CssClass = "charBlock whiteBlock"; tb15x2y.Text = RandomChar(random); }
                if (openSpace[15][3] == true) { tb15x3y.CssClass = "charBlock whiteBlock"; tb15x3y.Text = validEntries[15][3]; } else { tb15x3y.CssClass = "charBlock whiteBlock"; tb15x3y.Text = RandomChar(random); }
                if (openSpace[15][4] == true) { tb15x4y.CssClass = "charBlock whiteBlock"; tb15x4y.Text = validEntries[15][4]; } else { tb15x4y.CssClass = "charBlock whiteBlock"; tb15x4y.Text = RandomChar(random); }
                if (openSpace[15][5] == true) { tb15x5y.CssClass = "charBlock whiteBlock"; tb15x5y.Text = validEntries[15][5]; } else { tb15x5y.CssClass = "charBlock whiteBlock"; tb15x5y.Text = RandomChar(random); }
                if (openSpace[15][6] == true) { tb15x6y.CssClass = "charBlock whiteBlock"; tb15x6y.Text = validEntries[15][6]; } else { tb15x6y.CssClass = "charBlock whiteBlock"; tb15x6y.Text = RandomChar(random); }
                if (openSpace[15][7] == true) { tb15x7y.CssClass = "charBlock whiteBlock"; tb15x7y.Text = validEntries[15][7]; } else { tb15x7y.CssClass = "charBlock whiteBlock"; tb15x7y.Text = RandomChar(random); }
                if (openSpace[15][8] == true) { tb15x8y.CssClass = "charBlock whiteBlock"; tb15x8y.Text = validEntries[15][8]; } else { tb15x8y.CssClass = "charBlock whiteBlock"; tb15x8y.Text = RandomChar(random); }
                if (openSpace[15][9] == true) { tb15x9y.CssClass = "charBlock whiteBlock"; tb15x9y.Text = validEntries[15][9]; } else { tb15x9y.CssClass = "charBlock whiteBlock"; tb15x9y.Text = RandomChar(random); }
                if (openSpace[15][10] == true) { tb15x10y.CssClass = "charBlock whiteBlock"; tb15x10y.Text = validEntries[15][10]; } else { tb15x10y.CssClass = "charBlock whiteBlock"; tb15x10y.Text = RandomChar(random); }
                if (openSpace[15][11] == true) { tb15x11y.CssClass = "charBlock whiteBlock"; tb15x11y.Text = validEntries[15][11]; } else { tb15x11y.CssClass = "charBlock whiteBlock"; tb15x11y.Text = RandomChar(random); }
                if (openSpace[15][12] == true) { tb15x12y.CssClass = "charBlock whiteBlock"; tb15x12y.Text = validEntries[15][12]; } else { tb15x12y.CssClass = "charBlock whiteBlock"; tb15x12y.Text = RandomChar(random); }
                if (openSpace[15][13] == true) { tb15x13y.CssClass = "charBlock whiteBlock"; tb15x13y.Text = validEntries[15][13]; } else { tb15x13y.CssClass = "charBlock whiteBlock"; tb15x13y.Text = RandomChar(random); }
                if (openSpace[15][14] == true) { tb15x14y.CssClass = "charBlock whiteBlock"; tb15x14y.Text = validEntries[15][14]; } else { tb15x14y.CssClass = "charBlock whiteBlock"; tb15x14y.Text = RandomChar(random); }
                if (openSpace[15][15] == true) { tb15x15y.CssClass = "charBlock whiteBlock"; tb15x15y.Text = validEntries[15][15]; } else { tb15x15y.CssClass = "charBlock whiteBlock"; tb15x15y.Text = RandomChar(random); }
                if (openSpace[15][16] == true) { tb15x16y.CssClass = "charBlock whiteBlock"; tb15x16y.Text = validEntries[15][16]; } else { tb15x16y.CssClass = "charBlock whiteBlock"; tb15x16y.Text = RandomChar(random); }
                if (openSpace[15][17] == true) { tb15x17y.CssClass = "charBlock whiteBlock"; tb15x17y.Text = validEntries[15][17]; } else { tb15x17y.CssClass = "charBlock whiteBlock"; tb15x17y.Text = RandomChar(random); }
                if (openSpace[15][18] == true) { tb15x18y.CssClass = "charBlock whiteBlock"; tb15x18y.Text = validEntries[15][18]; } else { tb15x18y.CssClass = "charBlock whiteBlock"; tb15x18y.Text = RandomChar(random); }
                if (openSpace[15][19] == true) { tb15x19y.CssClass = "charBlock whiteBlock"; tb15x19y.Text = validEntries[15][19]; } else { tb15x19y.CssClass = "charBlock whiteBlock"; tb15x19y.Text = RandomChar(random); }
                if (openSpace[16][0] == true) { tb16x0y.CssClass = "charBlock whiteBlock"; tb16x0y.Text = validEntries[16][0]; } else { tb16x0y.CssClass = "charBlock whiteBlock"; tb16x0y.Text = RandomChar(random); }
                if (openSpace[16][1] == true) { tb16x1y.CssClass = "charBlock whiteBlock"; tb16x1y.Text = validEntries[16][1]; } else { tb16x1y.CssClass = "charBlock whiteBlock"; tb16x1y.Text = RandomChar(random); }
                if (openSpace[16][2] == true) { tb16x2y.CssClass = "charBlock whiteBlock"; tb16x2y.Text = validEntries[16][2]; } else { tb16x2y.CssClass = "charBlock whiteBlock"; tb16x2y.Text = RandomChar(random); }
                if (openSpace[16][3] == true) { tb16x3y.CssClass = "charBlock whiteBlock"; tb16x3y.Text = validEntries[16][3]; } else { tb16x3y.CssClass = "charBlock whiteBlock"; tb16x3y.Text = RandomChar(random); }
                if (openSpace[16][4] == true) { tb16x4y.CssClass = "charBlock whiteBlock"; tb16x4y.Text = validEntries[16][4]; } else { tb16x4y.CssClass = "charBlock whiteBlock"; tb16x4y.Text = RandomChar(random); }
                if (openSpace[16][5] == true) { tb16x5y.CssClass = "charBlock whiteBlock"; tb16x5y.Text = validEntries[16][5]; } else { tb16x5y.CssClass = "charBlock whiteBlock"; tb16x5y.Text = RandomChar(random); }
                if (openSpace[16][6] == true) { tb16x6y.CssClass = "charBlock whiteBlock"; tb16x6y.Text = validEntries[16][6]; } else { tb16x6y.CssClass = "charBlock whiteBlock"; tb16x6y.Text = RandomChar(random); }
                if (openSpace[16][7] == true) { tb16x7y.CssClass = "charBlock whiteBlock"; tb16x7y.Text = validEntries[16][7]; } else { tb16x7y.CssClass = "charBlock whiteBlock"; tb16x7y.Text = RandomChar(random); }
                if (openSpace[16][8] == true) { tb16x8y.CssClass = "charBlock whiteBlock"; tb16x8y.Text = validEntries[16][8]; } else { tb16x8y.CssClass = "charBlock whiteBlock"; tb16x8y.Text = RandomChar(random); }
                if (openSpace[16][9] == true) { tb16x9y.CssClass = "charBlock whiteBlock"; tb16x9y.Text = validEntries[16][9]; } else { tb16x9y.CssClass = "charBlock whiteBlock"; tb16x9y.Text = RandomChar(random); }
                if (openSpace[16][10] == true) { tb16x10y.CssClass = "charBlock whiteBlock"; tb16x10y.Text = validEntries[16][10]; } else { tb16x10y.CssClass = "charBlock whiteBlock"; tb16x10y.Text = RandomChar(random); }
                if (openSpace[16][11] == true) { tb16x11y.CssClass = "charBlock whiteBlock"; tb16x11y.Text = validEntries[16][11]; } else { tb16x11y.CssClass = "charBlock whiteBlock"; tb16x11y.Text = RandomChar(random); }
                if (openSpace[16][12] == true) { tb16x12y.CssClass = "charBlock whiteBlock"; tb16x12y.Text = validEntries[16][12]; } else { tb16x12y.CssClass = "charBlock whiteBlock"; tb16x12y.Text = RandomChar(random); }
                if (openSpace[16][13] == true) { tb16x13y.CssClass = "charBlock whiteBlock"; tb16x13y.Text = validEntries[16][13]; } else { tb16x13y.CssClass = "charBlock whiteBlock"; tb16x13y.Text = RandomChar(random); }
                if (openSpace[16][14] == true) { tb16x14y.CssClass = "charBlock whiteBlock"; tb16x14y.Text = validEntries[16][14]; } else { tb16x14y.CssClass = "charBlock whiteBlock"; tb16x14y.Text = RandomChar(random); }
                if (openSpace[16][15] == true) { tb16x15y.CssClass = "charBlock whiteBlock"; tb16x15y.Text = validEntries[16][15]; } else { tb16x15y.CssClass = "charBlock whiteBlock"; tb16x15y.Text = RandomChar(random); }
                if (openSpace[16][16] == true) { tb16x16y.CssClass = "charBlock whiteBlock"; tb16x16y.Text = validEntries[16][16]; } else { tb16x16y.CssClass = "charBlock whiteBlock"; tb16x16y.Text = RandomChar(random); }
                if (openSpace[16][17] == true) { tb16x17y.CssClass = "charBlock whiteBlock"; tb16x17y.Text = validEntries[16][17]; } else { tb16x17y.CssClass = "charBlock whiteBlock"; tb16x17y.Text = RandomChar(random); }
                if (openSpace[16][18] == true) { tb16x18y.CssClass = "charBlock whiteBlock"; tb16x18y.Text = validEntries[16][18]; } else { tb16x18y.CssClass = "charBlock whiteBlock"; tb16x18y.Text = RandomChar(random); }
                if (openSpace[16][19] == true) { tb16x19y.CssClass = "charBlock whiteBlock"; tb16x19y.Text = validEntries[16][19]; } else { tb16x19y.CssClass = "charBlock whiteBlock"; tb16x19y.Text = RandomChar(random); }
                if (openSpace[17][0] == true) { tb17x0y.CssClass = "charBlock whiteBlock"; tb17x0y.Text = validEntries[17][0]; } else { tb17x0y.CssClass = "charBlock whiteBlock"; tb17x0y.Text = RandomChar(random); }
                if (openSpace[17][1] == true) { tb17x1y.CssClass = "charBlock whiteBlock"; tb17x1y.Text = validEntries[17][1]; } else { tb17x1y.CssClass = "charBlock whiteBlock"; tb17x1y.Text = RandomChar(random); }
                if (openSpace[17][2] == true) { tb17x2y.CssClass = "charBlock whiteBlock"; tb17x2y.Text = validEntries[17][2]; } else { tb17x2y.CssClass = "charBlock whiteBlock"; tb17x2y.Text = RandomChar(random); }
                if (openSpace[17][3] == true) { tb17x3y.CssClass = "charBlock whiteBlock"; tb17x3y.Text = validEntries[17][3]; } else { tb17x3y.CssClass = "charBlock whiteBlock"; tb17x3y.Text = RandomChar(random); }
                if (openSpace[17][4] == true) { tb17x4y.CssClass = "charBlock whiteBlock"; tb17x4y.Text = validEntries[17][4]; } else { tb17x4y.CssClass = "charBlock whiteBlock"; tb17x4y.Text = RandomChar(random); }
                if (openSpace[17][5] == true) { tb17x5y.CssClass = "charBlock whiteBlock"; tb17x5y.Text = validEntries[17][5]; } else { tb17x5y.CssClass = "charBlock whiteBlock"; tb17x5y.Text = RandomChar(random); }
                if (openSpace[17][6] == true) { tb17x6y.CssClass = "charBlock whiteBlock"; tb17x6y.Text = validEntries[17][6]; } else { tb17x6y.CssClass = "charBlock whiteBlock"; tb17x6y.Text = RandomChar(random); }
                if (openSpace[17][7] == true) { tb17x7y.CssClass = "charBlock whiteBlock"; tb17x7y.Text = validEntries[17][7]; } else { tb17x7y.CssClass = "charBlock whiteBlock"; tb17x7y.Text = RandomChar(random); }
                if (openSpace[17][8] == true) { tb17x8y.CssClass = "charBlock whiteBlock"; tb17x8y.Text = validEntries[17][8]; } else { tb17x8y.CssClass = "charBlock whiteBlock"; tb17x8y.Text = RandomChar(random); }
                if (openSpace[17][9] == true) { tb17x9y.CssClass = "charBlock whiteBlock"; tb17x9y.Text = validEntries[17][9]; } else { tb17x9y.CssClass = "charBlock whiteBlock"; tb17x9y.Text = RandomChar(random); }
                if (openSpace[17][10] == true) { tb17x10y.CssClass = "charBlock whiteBlock"; tb17x10y.Text = validEntries[17][10]; } else { tb17x10y.CssClass = "charBlock whiteBlock"; tb17x10y.Text = RandomChar(random); }
                if (openSpace[17][11] == true) { tb17x11y.CssClass = "charBlock whiteBlock"; tb17x11y.Text = validEntries[17][11]; } else { tb17x11y.CssClass = "charBlock whiteBlock"; tb17x11y.Text = RandomChar(random); }
                if (openSpace[17][12] == true) { tb17x12y.CssClass = "charBlock whiteBlock"; tb17x12y.Text = validEntries[17][12]; } else { tb17x12y.CssClass = "charBlock whiteBlock"; tb17x12y.Text = RandomChar(random); }
                if (openSpace[17][13] == true) { tb17x13y.CssClass = "charBlock whiteBlock"; tb17x13y.Text = validEntries[17][13]; } else { tb17x13y.CssClass = "charBlock whiteBlock"; tb17x13y.Text = RandomChar(random); }
                if (openSpace[17][14] == true) { tb17x14y.CssClass = "charBlock whiteBlock"; tb17x14y.Text = validEntries[17][14]; } else { tb17x14y.CssClass = "charBlock whiteBlock"; tb17x14y.Text = RandomChar(random); }
                if (openSpace[17][15] == true) { tb17x15y.CssClass = "charBlock whiteBlock"; tb17x15y.Text = validEntries[17][15]; } else { tb17x15y.CssClass = "charBlock whiteBlock"; tb17x15y.Text = RandomChar(random); }
                if (openSpace[17][16] == true) { tb17x16y.CssClass = "charBlock whiteBlock"; tb17x16y.Text = validEntries[17][16]; } else { tb17x16y.CssClass = "charBlock whiteBlock"; tb17x16y.Text = RandomChar(random); }
                if (openSpace[17][17] == true) { tb17x17y.CssClass = "charBlock whiteBlock"; tb17x17y.Text = validEntries[17][17]; } else { tb17x17y.CssClass = "charBlock whiteBlock"; tb17x17y.Text = RandomChar(random); }
                if (openSpace[17][18] == true) { tb17x18y.CssClass = "charBlock whiteBlock"; tb17x18y.Text = validEntries[17][18]; } else { tb17x18y.CssClass = "charBlock whiteBlock"; tb17x18y.Text = RandomChar(random); }
                if (openSpace[17][19] == true) { tb17x19y.CssClass = "charBlock whiteBlock"; tb17x19y.Text = validEntries[17][19]; } else { tb17x19y.CssClass = "charBlock whiteBlock"; tb17x19y.Text = RandomChar(random); }
                if (openSpace[18][0] == true) { tb18x0y.CssClass = "charBlock whiteBlock"; tb18x0y.Text = validEntries[18][0]; } else { tb18x0y.CssClass = "charBlock whiteBlock"; tb18x0y.Text = RandomChar(random); }
                if (openSpace[18][1] == true) { tb18x1y.CssClass = "charBlock whiteBlock"; tb18x1y.Text = validEntries[18][1]; } else { tb18x1y.CssClass = "charBlock whiteBlock"; tb18x1y.Text = RandomChar(random); }
                if (openSpace[18][2] == true) { tb18x2y.CssClass = "charBlock whiteBlock"; tb18x2y.Text = validEntries[18][2]; } else { tb18x2y.CssClass = "charBlock whiteBlock"; tb18x2y.Text = RandomChar(random); }
                if (openSpace[18][3] == true) { tb18x3y.CssClass = "charBlock whiteBlock"; tb18x3y.Text = validEntries[18][3]; } else { tb18x3y.CssClass = "charBlock whiteBlock"; tb18x3y.Text = RandomChar(random); }
                if (openSpace[18][4] == true) { tb18x4y.CssClass = "charBlock whiteBlock"; tb18x4y.Text = validEntries[18][4]; } else { tb18x4y.CssClass = "charBlock whiteBlock"; tb18x4y.Text = RandomChar(random); }
                if (openSpace[18][5] == true) { tb18x5y.CssClass = "charBlock whiteBlock"; tb18x5y.Text = validEntries[18][5]; } else { tb18x5y.CssClass = "charBlock whiteBlock"; tb18x5y.Text = RandomChar(random); }
                if (openSpace[18][6] == true) { tb18x6y.CssClass = "charBlock whiteBlock"; tb18x6y.Text = validEntries[18][6]; } else { tb18x6y.CssClass = "charBlock whiteBlock"; tb18x6y.Text = RandomChar(random); }
                if (openSpace[18][7] == true) { tb18x7y.CssClass = "charBlock whiteBlock"; tb18x7y.Text = validEntries[18][7]; } else { tb18x7y.CssClass = "charBlock whiteBlock"; tb18x7y.Text = RandomChar(random); }
                if (openSpace[18][8] == true) { tb18x8y.CssClass = "charBlock whiteBlock"; tb18x8y.Text = validEntries[18][8]; } else { tb18x8y.CssClass = "charBlock whiteBlock"; tb18x8y.Text = RandomChar(random); }
                if (openSpace[18][9] == true) { tb18x9y.CssClass = "charBlock whiteBlock"; tb18x9y.Text = validEntries[18][9]; } else { tb18x9y.CssClass = "charBlock whiteBlock"; tb18x9y.Text = RandomChar(random); }
                if (openSpace[18][10] == true) { tb18x10y.CssClass = "charBlock whiteBlock"; tb18x10y.Text = validEntries[18][10]; } else { tb18x10y.CssClass = "charBlock whiteBlock"; tb18x10y.Text = RandomChar(random); }
                if (openSpace[18][11] == true) { tb18x11y.CssClass = "charBlock whiteBlock"; tb18x11y.Text = validEntries[18][11]; } else { tb18x11y.CssClass = "charBlock whiteBlock"; tb18x11y.Text = RandomChar(random); }
                if (openSpace[18][12] == true) { tb18x12y.CssClass = "charBlock whiteBlock"; tb18x12y.Text = validEntries[18][12]; } else { tb18x12y.CssClass = "charBlock whiteBlock"; tb18x12y.Text = RandomChar(random); }
                if (openSpace[18][13] == true) { tb18x13y.CssClass = "charBlock whiteBlock"; tb18x13y.Text = validEntries[18][13]; } else { tb18x13y.CssClass = "charBlock whiteBlock"; tb18x13y.Text = RandomChar(random); }
                if (openSpace[18][14] == true) { tb18x14y.CssClass = "charBlock whiteBlock"; tb18x14y.Text = validEntries[18][14]; } else { tb18x14y.CssClass = "charBlock whiteBlock"; tb18x14y.Text = RandomChar(random); }
                if (openSpace[18][15] == true) { tb18x15y.CssClass = "charBlock whiteBlock"; tb18x15y.Text = validEntries[18][15]; } else { tb18x15y.CssClass = "charBlock whiteBlock"; tb18x15y.Text = RandomChar(random); }
                if (openSpace[18][16] == true) { tb18x16y.CssClass = "charBlock whiteBlock"; tb18x16y.Text = validEntries[18][16]; } else { tb18x16y.CssClass = "charBlock whiteBlock"; tb18x16y.Text = RandomChar(random); }
                if (openSpace[18][17] == true) { tb18x17y.CssClass = "charBlock whiteBlock"; tb18x17y.Text = validEntries[18][17]; } else { tb18x17y.CssClass = "charBlock whiteBlock"; tb18x17y.Text = RandomChar(random); }
                if (openSpace[18][18] == true) { tb18x18y.CssClass = "charBlock whiteBlock"; tb18x18y.Text = validEntries[18][18]; } else { tb18x18y.CssClass = "charBlock whiteBlock"; tb18x18y.Text = RandomChar(random); }
                if (openSpace[18][19] == true) { tb18x19y.CssClass = "charBlock whiteBlock"; tb18x19y.Text = validEntries[18][19]; } else { tb18x19y.CssClass = "charBlock whiteBlock"; tb18x19y.Text = RandomChar(random); }
                if (openSpace[19][0] == true) { tb19x0y.CssClass = "charBlock whiteBlock"; tb19x0y.Text = validEntries[19][0]; } else { tb19x0y.CssClass = "charBlock whiteBlock"; tb19x0y.Text = RandomChar(random); }
                if (openSpace[19][1] == true) { tb19x1y.CssClass = "charBlock whiteBlock"; tb19x1y.Text = validEntries[19][1]; } else { tb19x1y.CssClass = "charBlock whiteBlock"; tb19x1y.Text = RandomChar(random); }
                if (openSpace[19][2] == true) { tb19x2y.CssClass = "charBlock whiteBlock"; tb19x2y.Text = validEntries[19][2]; } else { tb19x2y.CssClass = "charBlock whiteBlock"; tb19x2y.Text = RandomChar(random); }
                if (openSpace[19][3] == true) { tb19x3y.CssClass = "charBlock whiteBlock"; tb19x3y.Text = validEntries[19][3]; } else { tb19x3y.CssClass = "charBlock whiteBlock"; tb19x3y.Text = RandomChar(random); }
                if (openSpace[19][4] == true) { tb19x4y.CssClass = "charBlock whiteBlock"; tb19x4y.Text = validEntries[19][4]; } else { tb19x4y.CssClass = "charBlock whiteBlock"; tb19x4y.Text = RandomChar(random); }
                if (openSpace[19][5] == true) { tb19x5y.CssClass = "charBlock whiteBlock"; tb19x5y.Text = validEntries[19][5]; } else { tb19x5y.CssClass = "charBlock whiteBlock"; tb19x5y.Text = RandomChar(random); }
                if (openSpace[19][6] == true) { tb19x6y.CssClass = "charBlock whiteBlock"; tb19x6y.Text = validEntries[19][6]; } else { tb19x6y.CssClass = "charBlock whiteBlock"; tb19x6y.Text = RandomChar(random); }
                if (openSpace[19][7] == true) { tb19x7y.CssClass = "charBlock whiteBlock"; tb19x7y.Text = validEntries[19][7]; } else { tb19x7y.CssClass = "charBlock whiteBlock"; tb19x7y.Text = RandomChar(random); }
                if (openSpace[19][8] == true) { tb19x8y.CssClass = "charBlock whiteBlock"; tb19x8y.Text = validEntries[19][8]; } else { tb19x8y.CssClass = "charBlock whiteBlock"; tb19x8y.Text = RandomChar(random); }
                if (openSpace[19][9] == true) { tb19x9y.CssClass = "charBlock whiteBlock"; tb19x9y.Text = validEntries[19][9]; } else { tb19x9y.CssClass = "charBlock whiteBlock"; tb19x9y.Text = RandomChar(random); }
                if (openSpace[19][10] == true) { tb19x10y.CssClass = "charBlock whiteBlock"; tb19x10y.Text = validEntries[19][10]; } else { tb19x10y.CssClass = "charBlock whiteBlock"; tb19x10y.Text = RandomChar(random); }
                if (openSpace[19][11] == true) { tb19x11y.CssClass = "charBlock whiteBlock"; tb19x11y.Text = validEntries[19][11]; } else { tb19x11y.CssClass = "charBlock whiteBlock"; tb19x11y.Text = RandomChar(random); }
                if (openSpace[19][12] == true) { tb19x12y.CssClass = "charBlock whiteBlock"; tb19x12y.Text = validEntries[19][12]; } else { tb19x12y.CssClass = "charBlock whiteBlock"; tb19x12y.Text = RandomChar(random); }
                if (openSpace[19][13] == true) { tb19x13y.CssClass = "charBlock whiteBlock"; tb19x13y.Text = validEntries[19][13]; } else { tb19x13y.CssClass = "charBlock whiteBlock"; tb19x13y.Text = RandomChar(random); }
                if (openSpace[19][14] == true) { tb19x14y.CssClass = "charBlock whiteBlock"; tb19x14y.Text = validEntries[19][14]; } else { tb19x14y.CssClass = "charBlock whiteBlock"; tb19x14y.Text = RandomChar(random); }
                if (openSpace[19][15] == true) { tb19x15y.CssClass = "charBlock whiteBlock"; tb19x15y.Text = validEntries[19][15]; } else { tb19x15y.CssClass = "charBlock whiteBlock"; tb19x15y.Text = RandomChar(random); }
                if (openSpace[19][16] == true) { tb19x16y.CssClass = "charBlock whiteBlock"; tb19x16y.Text = validEntries[19][16]; } else { tb19x16y.CssClass = "charBlock whiteBlock"; tb19x16y.Text = RandomChar(random); }
                if (openSpace[19][17] == true) { tb19x17y.CssClass = "charBlock whiteBlock"; tb19x17y.Text = validEntries[19][17]; } else { tb19x17y.CssClass = "charBlock whiteBlock"; tb19x17y.Text = RandomChar(random); }
                if (openSpace[19][18] == true) { tb19x18y.CssClass = "charBlock whiteBlock"; tb19x18y.Text = validEntries[19][18]; } else { tb19x18y.CssClass = "charBlock whiteBlock"; tb19x18y.Text = RandomChar(random); }
                if (openSpace[19][19] == true) { tb19x19y.CssClass = "charBlock whiteBlock"; tb19x19y.Text = validEntries[19][19]; } else { tb19x19y.CssClass = "charBlock whiteBlock"; tb19x19y.Text = RandomChar(random); }

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }





        }
}