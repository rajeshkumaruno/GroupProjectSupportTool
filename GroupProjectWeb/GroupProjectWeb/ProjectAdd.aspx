<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProjectAdd.aspx.cs" Inherits="ProjectAdd" %>

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
    <td class="center" colspan="2" style="align" >Add Project Details</td>

  </tr>


  <tr>
    <td class="tg-0pky">Project Name:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbProjectName" runat="server" Height="19px" LabelWidth="64px" Resize="None" Width="316px">
            <EmptyMessageStyle Resize="None" />
            <ReadOnlyStyle Resize="None" />
            <FocusedStyle Resize="None" />
            <DisabledStyle Resize="None" />
            <InvalidStyle Resize="None" />
            <HoveredStyle Resize="None" />
            <EnabledStyle Resize="None" />
        </telerik:RadTextBox></td>
  </tr>

      <tr>
    <td class="tg-0pky">Project Start Date:</td>
    <td class="tg-0lax">
        <telerik:RadCalendar ID="rcStartDate" runat="server"></telerik:RadCalendar>
    </td>
  </tr>

      <tr>
    <td class="tg-0pky">Project End Data:</td>
    <td class="tg-0lax">
        <telerik:RadCalendar ID="rcEndDate" runat="server"></telerik:RadCalendar>
    </td>
  </tr>


      <tr>
    <td class="tg-0pky">Project Manager:</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlManager" runat="server" >
        </telerik:RadDropDownList>

    </td>
  </tr>


      <tr>
    <td class="tg-0pky" colspan="2">
        <telerik:RadButton ID="RadButton1" runat="server" OnClick="RadButton1_Click" Text="Add Project">
        </telerik:RadButton>
          </td>
  </tr>


</tbody>
</table>
        </center>






</asp:Content>

