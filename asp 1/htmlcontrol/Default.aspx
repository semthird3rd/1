﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>HTML Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HTML Controls Demo</h1>
            
            <!-- HTML Input Control -->
            <p>
                <label for="txtName">Enter your name:</label>
                <input type="text" id="txtName" name="txtName" />
            </p>
            
            <!-- HTML Button Control -->
            <p>
                <input type="button" value="Submit" onclick="submitForm()" />
            </p>
            
            <!-- HTML Div for Displaying Result -->
            <p>
                <div id="result"></div>
            </p>
        </div>
    </form>

    <script type="text/javascript">
        function submitForm() {
            var userName = document.getElementById("txtName").value;
            var resultDiv = document.getElementById("result");
            resultDiv.innerHTML = "Hello, " + userName + "! You clicked the Submit button.";
        }
    </script>
</body>
</html>
