using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication8
{

    public partial class Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            // Custom Class instances creating
            string str001=" ";
            WeekDay monday = new WeekDay(str001);
            WeekDay tuesday = new WeekDay();
            WeekDay wednesday = new WeekDay();
            WeekDay thursday = new WeekDay();
            WeekDay friday = new WeekDay();

            // Table creating
            Table table = new Table();
            table.HorizontalAlign = HorizontalAlign.Center;
            table.Width = new Unit("60%");
            //table.CssClass = "table_background";

            Label[] l_Lesson = new Label[5];

            TableCell[] Arr_Cell = new TableCell[50];
            TableRow[] Arr_Row = new TableRow[7];


            // --- Table Header ---
            TableHeaderRow hRow = new TableHeaderRow();
            hRow.CssClass = "table_header_row";

            // --- HCell 1
            TableHeaderCell hCell_1 = new TableHeaderCell();
            Label hLabel_1 = new Label();
            hLabel_1.Text = "Lesson/Time";
            hCell_1.Controls.Add(hLabel_1);
            hRow.Cells.Add(hCell_1);
            // --- End of HCell 1

            // --- HCell 2
            TableHeaderCell hCell_2 = new TableHeaderCell();
            Label hLabel_2 = new Label();
            hLabel_2.Text = "Monday";
            hCell_2.Controls.Add(hLabel_2);
            hRow.Cells.Add(hCell_2);
            // --- End of Cell 2

            // --- HCell 3
            TableHeaderCell hCell_3 = new TableHeaderCell();
            Label hLabel_3 = new Label();
            hLabel_3.Text = "Tuesday";
            hCell_3.Controls.Add(hLabel_3);
            hRow.Cells.Add(hCell_3);
            // --- End of HCell 3

            // --- HCell 4
            TableHeaderCell hCell_4 = new TableHeaderCell();
            Label hLabel_4 = new Label();
            hLabel_4.Text = "Wednesday";
            hCell_4.Controls.Add(hLabel_4);
            hRow.Cells.Add(hCell_4);
            // --- End of HCell 4

            // --- HCell 5
            TableHeaderCell hCell_5 = new TableHeaderCell();
            Label hLabel_5 = new Label();
            hLabel_5.Text = "Thursday";
            hCell_5.Controls.Add(hLabel_5);
            hRow.Cells.Add(hCell_5);
            // --- End of HCell 5

            // --- HCell 6
            TableHeaderCell hCell_6 = new TableHeaderCell();
            Label hLabel_6 = new Label();
            hLabel_6.Text = "Friday";
            hCell_6.Controls.Add(hLabel_6);
            hRow.Cells.Add(hCell_6);
            // --- End of HCell 6

            table.Rows.Add(hRow);
            // --- End of Table  Header ---

            // --- Rows (creating in a cycle) ---
            int k = new int();
            k = 1;
            string empty_element = "   ";

            for (int i = 0; i < 5; i++)
            {
                Arr_Row[i] = new TableRow();
                if ((i + 2) % 2 == 0)
                {
                    Arr_Row[i].CssClass = "table_even_row";
                }
                else
                {
                    Arr_Row[i].CssClass = "table_odd_row";
                }
                int j = new int();
                j = 0;
                // Row # i, Add Lesson Cell
                l_Lesson[i] = new Label();
                //l_Lesson[i].Text = "Lesson " + Convert.ToString(i + 1) + "</br>" + Convert.ToString(i + 8) + ":00 - " + Convert.ToString(i + 8) + ":45 AM";
                l_Lesson[i].Text = "Lesson " + Convert.ToString(i + 1);            
                Arr_Cell[j] = new TableCell();
                //Arr_Cell[j].CssClass = "lesson_cell";
                Arr_Cell[j].Controls.Add(l_Lesson[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;
                // Row # i, Add Monday Cell
                Arr_Cell[j] = new TableCell();
                Arr_Cell[j].Controls.Add(monday.l_name[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;
                // Row # i, Add Tuesday Cell
                Arr_Cell[j] = new TableCell();
                Arr_Cell[j].Controls.Add(tuesday.l_name[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;
                // Row # i, Add Wednesday Cell
                Arr_Cell[j] = new TableCell();
                Arr_Cell[j].Controls.Add(wednesday.l_name[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;
                // Row # i, Add Thursday Cell
                Arr_Cell[j] = new TableCell();
                Arr_Cell[j].Controls.Add(thursday.l_name[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;
                // Row # i, Add Friday Cell
                Arr_Cell[j] = new TableCell();
                Arr_Cell[j].Controls.Add(friday.l_name[i]);
                Arr_Row[i].Cells.Add(Arr_Cell[j]);
                j++;
                k++;

                table.Rows.Add(Arr_Row[i]);
            }
            // ---- End of Rows creating ----

            Button[] Arr_Rem_Btn = new Button[5];
            Button[] Arr_Add_Btn = new Button[5];
            TableCell[] Arr_RemBtn_Cell = new TableCell[5];
            TableCell[] Arr_AddBtn_Cell = new TableCell[5];

            // Row "Remove Buttons"
            Label EmptyLabel = new Label();
            EmptyLabel.Text = " ";

            TableCell tCell_6_1 = new TableCell();
            tCell_6_1.Controls.Add(EmptyLabel);

            TableRow fRow_1 = new TableRow();
            fRow_1.Cells.Add(tCell_6_1);
            //Row_1.CssClass = "table_odd_row";



            for (int i = 0; i < 5; i++)
            {
                Arr_Rem_Btn[i] = new Button();
                Arr_Rem_Btn[i].Text = "Remove Subject";
                Arr_Rem_Btn[i].CssClass = "btn_cell";

                Arr_RemBtn_Cell[i] = new TableCell();
                Arr_RemBtn_Cell[i].Controls.Add(Arr_Rem_Btn[i]);
                //Arr_RemBtn_Cell[i].HorizontalAlign="Center";
                //tCell_6_1.Controls.Add(Arr_Rem_Btn[i]);
                fRow_1.Cells.Add(Arr_RemBtn_Cell[i]);
            }

            table.Rows.Add(fRow_1);

            // --------------------------------
            // --------------------------------

            // Row "Add Buttons"
            TableCell tCell_7_1 = new TableCell();
            tCell_7_1.Controls.Add(EmptyLabel);
            //tCell_7_1.Controls.Add(SubjectDropDownList);

            TableRow fRow_2 = new TableRow();
            fRow_2.Cells.Add(tCell_7_1);
            //Row_1.CssClass = "table_odd_row";



            for (int i = 0; i < 5; i++)
            {
                Arr_Add_Btn[i] = new Button();
                Arr_Add_Btn[i].Text = "Add Subject";
                Arr_Add_Btn[i].CssClass = "btn_cell";
                Arr_Add_Btn[i].ID = "Arr_Add_Btn-"+Convert.ToString(i);
                Arr_Add_Btn[i].ClientIDMode = ClientIDMode.Static;



                Arr_AddBtn_Cell[i] = new TableCell();
                Arr_AddBtn_Cell[i].Controls.Add(Arr_Add_Btn[i]);
                //Arr_RemBtn_Cell[i].HorizontalAlign="Center";
                //tCell_6_1.Controls.Add(Arr_Rem_Btn[i]);
                fRow_2.Cells.Add(Arr_AddBtn_Cell[i]);
            }

            table.Rows.Add(fRow_2);

            PlaceHolder1.Controls.Add(table);

            // DropDownList creating

            ListItem ListItem_01 = new ListItem("Diapers replacing");
            ListItem ListItem_02 = new ListItem("Tiptoeing");
            ListItem ListItem_03 = new ListItem("Hygiene");
            ListItem ListItem_04 = new ListItem("Gymnastics");
            ListItem ListItem_05 = new ListItem("Pacifier. How to choose");
            ListItem ListItem_06 = new ListItem("First toys");


            if (!IsPostBack)
            {
                DropDownList1.Items.Add(ListItem_01);
                DropDownList1.Items.Add(ListItem_02);
                DropDownList1.Items.Add(ListItem_03);
                DropDownList1.Items.Add(ListItem_04);
                DropDownList1.Items.Add(ListItem_05);
                DropDownList1.Items.Add(ListItem_06);
            }


            if (!IsPostBack)
            {
                BulletedList2.Items.Add(ListItem_01);
                BulletedList2.Items.Add(ListItem_02);
                BulletedList2.Items.Add(ListItem_03);
                BulletedList2.Items.Add(ListItem_04);
                BulletedList2.Items.Add(ListItem_05);
                BulletedList2.Items.Add(ListItem_06);
            }

         // Monday Add&Remove buttons hadler
            Arr_Add_Btn[0].Click += delegate(object sender2, EventArgs e2)
            {
                //monday.AppendLesson("new lesson");
                if (monday.AvailableLesson() > -1)
                    monday.AppendLesson(DropDownList1.SelectedItem.Text);

                tb_monday_num.Text = Convert.ToString(monday.LastLesson());
            };

            Arr_Rem_Btn[0].Click += delegate(object sender3, EventArgs e3)
            {
                monday.DeleteLesson();
                tb_monday_num.Text = Convert.ToString(monday.LastLesson());
            };
         // end of Monday-handler
         //------------------------------------------------------
         // Tuesday Add&Remove buttons hadler
            Arr_Add_Btn[1].Click += delegate(object sender4, EventArgs e4)
            {
                if (tuesday.AvailableLesson() > -1)
                    tuesday.AppendLesson(DropDownList1.SelectedItem.Text);

                tb_tuesday_num.Text = Convert.ToString(tuesday.LastLesson());
            };

            Arr_Rem_Btn[1].Click += delegate(object sender5, EventArgs e5)
            {
                tuesday.DeleteLesson();
                tb_tuesday_num.Text = Convert.ToString(tuesday.LastLesson());
            };
         // end of Tuesday-handler
         // Wednesday Add&Remove buttons hadler
            Arr_Add_Btn[2].Click += delegate(object sender4, EventArgs e4)
            {
                if (wednesday.AvailableLesson() > -1)
                    wednesday.AppendLesson(DropDownList1.SelectedItem.Text);

                tb_wednesday_num.Text = Convert.ToString(wednesday.LastLesson());
            };

            Arr_Rem_Btn[2].Click += delegate(object sender5, EventArgs e5)
            {
                wednesday.DeleteLesson();
                tb_wednesday_num.Text = Convert.ToString(wednesday.LastLesson());
            };
         // end of Wednesday-handler
         // Thursday Add&Remove buttons hadler
            Arr_Add_Btn[3].Click += delegate(object sender4, EventArgs e4)
            {
                if (thursday.AvailableLesson() > -1)
                    thursday.AppendLesson(DropDownList1.SelectedItem.Text);

                tb_thursday_num.Text = Convert.ToString(thursday.LastLesson());
            };

            Arr_Rem_Btn[3].Click += delegate(object sender5, EventArgs e5)
            {
                thursday.DeleteLesson();
                tb_thursday_num.Text = Convert.ToString(thursday.LastLesson());
            };
            // end of Thursday-handler
            // Friday Add&Remove buttons hadler
            Arr_Add_Btn[4].Click += delegate(object sender4, EventArgs e4)
            {
                if (friday.AvailableLesson() > -1)
                    friday.AppendLesson(DropDownList1.SelectedItem.Text);

                tb_friday_num.Text = Convert.ToString(friday.LastLesson());
            };

            Arr_Rem_Btn[4].Click += delegate(object sender5, EventArgs e5)
            {
                friday.DeleteLesson();
                tb_friday_num.Text = Convert.ToString(friday.LastLesson());
            };
            // end of Friday-handler

            btn_add_subj_to_db.Click += delegate(object sender4, EventArgs e4)
            {
                ListItem ListItem_10 = new ListItem(TextBox1.Text);
                DropDownList1.Items.Add(ListItem_10);
                BulletedList2.Items.Add(ListItem_10);
            };


            // ---- test variable region ----
            //Application["glvar"] = "asd";
            Label lab_01 = new Label();
            //lab_01.Text = Convert.ToString(Session["glvar"]);
            lab_01.Text = Arr_Add_Btn[1].ID;
            //PlaceHolder3.Controls.Add(lab_01);

            // $("#<%=TextBox2.ClientID%>").val("psw_ok");
            //background-color:rgba(255, 253, 148, 0.60);

            /*
                $(document).ready(function () {
        $("#Arr_Add_Btn-0").click(function () {
            var a1=parseInt($("#tb_monday_num").val());
            if (a1 == 4)
                alert("Sorry. We have only 5 lessons a day");
            return false;
        });
    });*/
            //<p id="link"><a href="schedule_prj_rev01.zip" download>download project source files (direct)</a></p>
           
            // ---- End of test variable region ----

        }
    }
}