<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRouting.aspx.cs" Inherits="Contacts.TestRouting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<script type="text/javascript" src="Scripts/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
 
        GetCustomers();
 
    });
function GetCustomers() {
    //     debugger;
    $.ajax({
        type: "POST",
        url: "TestRouting/GetCustomers",
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        failure: function (response) {
            alert(response.d);
        },
        error: function (response) {
            alert(response.d);
        }
    });
}
 
function OnSuccess(response) {
    // debugger;
    var xmlDoc = $.parseXML(response.d);
    var xml = $(xmlDoc);
    var customers = xml.find("Customers");
    var row = $("[id*=gvCustomers] tr:last-child").clone(true);
    $("[id*=gvCustomers] tr").not($("[id*=gvCustomers] tr:first-child")).remove();
    $.each(customers, function () {
        //  debugger;
        var customer = $(this);
        $("td", row).eq(0).html($(this).find("CustomerID").text());
        $("td", row).eq(1).html($(this).find("ContactName").text());
        $("td", row).eq(2).html($(this).find("City").text());
        $("[id*=gvCustomers]").append(row);
        row = $("[id*=gvCustomers] tr:last-child").clone(true);
    });
};
</script>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" RowStyle-BackColor="#A1DCF2"
            HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White">
            <Columns>
                <asp:BoundField ItemStyle-Width="150px" DataField="CustomerID" HeaderText="CustomerID" />
                <asp:BoundField ItemStyle-Width="150px" DataField="ContactName" HeaderText="Contact Name" />
                <asp:BoundField ItemStyle-Width="150px" DataField="City" HeaderText="City" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
