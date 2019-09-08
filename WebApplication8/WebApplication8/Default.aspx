<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication8.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Styles.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <title>Young parents training classes</title>
<script>
    // Password keeping for session
    $(document).ready(function () {
        if ($("#TextBox2").val() == "psw_ok") {
            $("#div_psw").show();
            $("#div_add").show();
            $("#div_list").show();
        }
    });

    // Too much lessons on Monday
    $(document).ready(function () {
            $("#Arr_Add_Btn-0").click(function () {
                var a1=parseInt($("#tb_monday_num").val());
                if (a1 == 4)
                    alert("Sorry, we have only 5 lessons a day");
                });
    });

    // Too much lessons on Tuesday
    $(document).ready(function () {
        $("#Arr_Add_Btn-1").click(function () {
            var a1 = parseInt($("#tb_tuesday_num").val());
            if (a1 == 4)
                alert("Sorry, we have only 5 lessons a day");
        });
    });

    // Too much lessons on Wednesday
    $(document).ready(function () {
        $("#Arr_Add_Btn-2").click(function () {
            var a1 = parseInt($("#tb_wednesday_num").val());
            if (a1 == 4)
                alert("Sorry, we have only 5 lessons a day");
        });
    });
    
    // Too much lessons on Thursday
    $(document).ready(function () {
        $("#Arr_Add_Btn-3").click(function () {
            var a1 = parseInt($("#tb_thursday_num").val());
            if (a1 == 4)
                alert("Sorry, we have only 5 lessons a day");
        });
    });

    // Too much lessons on Friday
    $(document).ready(function () {
        $("#Arr_Add_Btn-4").click(function () {
            var a1 = parseInt($("#tb_friday_num").val());
            if (a1 == 4)
                alert("Sorry, we have only 5 lessons a day");
        });
    });

    // Unhide 'password' div
    $(document).ready(function () {
        $("#Btn_edit_db").click(function () {
            $("#div_psw").slideToggle();
            return false;
        });
    });
    
    // Unhide 'add subject' div
    $(document).ready(function () {
        $("#btn_psw").click(function () {
            var v1;
            v1 = $("#input_1").val();
            if (v1 == "psw") {
                $("#div_add").slideToggle();
                $("#div_list").slideToggle();
                psw_status = "psw_ok";
                $("#TextBox2").val("psw_ok");
                return false;
            }
            else {
                alert("Password is invalid");
                return false;
            }
        });
    });
</script>
    <style>        
        body 
        {
            background-image: url(at_13.jpg);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="main_title">Young parents training classes</p>
        <p id="sub_title">Schedule</p>
        <p id="link"><a href="https://drive.google.com/open?id=1qbXD-VT6N5AD0fpK0bcl5cIv5lNB7pD2" target="_blank">download source files (Google-drive)</a></p>
    </div>
    <div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
        <div class="div_general">
            Choose subject for adding to the schedule:</br>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" style="margin-left: 0px" Width="189px"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="Btn_edit_db" runat="server" margin-bottom=8px Text="Edit subject database" />
        </div>
        <div id="div_psw">
            <input id="input_1"></input>
            <asp:Button ID="btn_psw" runat="server" Text="Enter password" />
            <span class="prompt">(password = psw)</span>
        </div>
        <div id="div_add">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="btn_add_subj_to_db" runat="server" Text="Add Subject" />
        </div>
        <div id="div_list">
            <asp:BulletedList ID="BulletedList2" runat="server"></asp:BulletedList>
        </div>
        <div>
            <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        </div>
        <div>
            <asp:TextBox type="hidden" ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox type="hidden" ID="tb_monday_num" runat="server"></asp:TextBox>
            <asp:TextBox type="hidden" ID="tb_tuesday_num" runat="server"></asp:TextBox>
            <asp:TextBox type="hidden" ID="tb_wednesday_num" runat="server"></asp:TextBox>
            <asp:TextBox type="hidden" ID="tb_thursday_num" runat="server"></asp:TextBox>
            <asp:TextBox type="hidden" ID="tb_friday_num" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
