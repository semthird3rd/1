﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TreeView ID="TreeView1" runat="server">
        <Nodes>
            <asp:TreeNode NavigateUrl="~/Default.aspx" Text="bca" Value="bca">
                <asp:TreeNode NavigateUrl="~/p1.aspx" Text="fybca" Value="fybca"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/p2.aspx" Text="sybca" Value="sybca"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/p3.aspx" Text="tybca" Value="tybca"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
    </form>
</body>
</html>