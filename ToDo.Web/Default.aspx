<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ToDo.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACME To Do List</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            // detect editlink click and get id to pass to web method to pull related/associated teaks
            $(".editlink").click(function () {

                var id = $(this).data("id");

                // make call to webmethod to get associated uncompleted tasks if any
                $.ajax({
                    type: "POST",
                    url: "Default.aspx/GetDependents",
                    data: '{name: "' + $("#<%=txtUserName.ClientID%>")[0].value + '" }',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {
                        if (data["hasAssociation"] == true) {
                            // disable save button

                            // show dependent associations
                            $("#" + id).append(data["dependentlist"]);
                        }
                    },
                    failure: function (response) {
                        alert(response.d);
                    }
                });

            });

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ACME To Do List</h1>
        <div>
            <asp:TextBox runat="server" ID="txtTask"></asp:TextBox>
            <br />
            <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
            <asp:Button runat="server" ID="btnAddTask" Text="Add Task" OnClick="btn_AddTask_Click" />
        </div>
        <asp:DataList runat="server" ID="dlTasks" OnEditCommand="dlTasks_EditCommand" OnUpdateCommand="dlTasks_UpdateCommand" DataKeyField="Id" >
            <HeaderTemplate>
                <div id="todoItems">
                    <ol>
            </HeaderTemplate>

            <ItemTemplate>
                        <li>
                            <%# DataBinder.Eval(Container.DataItem, "Title") %> <asp:CheckBox runat="server" ID="chkComplete" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "Complete") %>' />
                            <br />
                            <asp:LinkButton runat="server" ID="lbEdit" Text="Edit" class="editlink" data-id='<%# DataBinder.Eval(Container.DataItem, "id") %>' CommandName="Edit"></asp:LinkButton>
                        </li>
            </ItemTemplate>

            <EditItemTemplate>
                        <li>
                            <asp:TextBox runat="server" ID="txtUpdateTitle" Text='<%# DataBinder.Eval(Container.DataItem, "Title") %>'></asp:TextBox>
                            <br />
                            <asp:TextBox runat="server" ID="txtUpdateDescription" Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>'></asp:TextBox>
                            <br />
                            <asp:CheckBox runat="server" ID="chkComplete" Checked='<%# DataBinder.Eval(Container.DataItem, "Complete") %>' />
                            <br />
                            Associated Tasks:
                            <br />
                            <div id='<%# DataBinder.Eval(Container.DataItem, "id") %>' class="dvatasks"></div>
                            <br />

                            <asp:Button runat="server" ID="btnUpdate" Text="Save" CommandName="Update" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' />
                        </li>
            </EditItemTemplate>

            <FooterTemplate>
                    </ol>
                </div>    
            </FooterTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
