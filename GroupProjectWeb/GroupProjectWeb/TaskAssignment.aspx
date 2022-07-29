<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskAssignment.aspx.cs" Inherits="TaskAssignment" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link rel="Stylesheet" type="text/css" href="/css/StyleProjectAdd.css" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <br /><br /><br />
<br /><br /><br />
<center>
<table class="tg" style="undefined;table-layout: fixed; width: 800px; vertical-align=center; background-color: #D6EEEE; ">
<colgroup>
<col style="width: 249px">
<col style="width: 335px">
</colgroup>

<tbody>



      <tr>
    <td class="center" colspan="2" style="align" >
        <telerik:RadLabel ID="rlblMessage" runat="server" CssClass="center">
        </telerik:RadLabel>
          </td>

  </tr>


      <tr>
    <td class="center" colspan="2" style="align" >Task Assignment</td>

  </tr>





      <tr>
    <td class="tg-0pky">Project :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlProject" runat="server" Width="411px" AutoPostBack="true" OnSelectedIndexChanged="rddlProject_SelectedIndexChanged" >
        </telerik:RadDropDownList>

    </td>
  </tr>


    
      <tr>
    <td class="tg-0pky">Tasks :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlTask" runat="server" Width="411px" >
        </telerik:RadDropDownList>

    </td>
  </tr>



    
      <tr>
    <td class="tg-0pky">Team Member :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddTeamMember" runat="server" Width="411px" >
        </telerik:RadDropDownList>

    </td>
  </tr>



      <tr>
    <td class="tg-0pky" colspan="2">
        <telerik:RadButton ID="rbtnAssignTask" runat="server"  Text="Assign Task" OnClick="rbtnAssignTask_Click" >
        </telerik:RadButton>
          </td>
  </tr>


</tbody>
</table>
        </center>






</asp:Content>




