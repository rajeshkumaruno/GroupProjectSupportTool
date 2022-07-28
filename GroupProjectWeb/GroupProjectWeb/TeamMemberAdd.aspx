<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TeamMemberAdd.aspx.cs" Inherits="TeamMemberAdd" %>

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
    <td class="center" colspan="2" style="align" >Add New Team Member</td>

  </tr>


  <tr>
    <td class="tg-0pky">First Name:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbFirstName" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Last Name:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbLastName" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Initials:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbInitial" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">SSN:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbSSN" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Role :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlRole" runat="server" Width="411px" >
        </telerik:RadDropDownList>

    </td>
  </tr>



      <tr>
    <td class="tg-0pky" colspan="2">
        <telerik:RadButton ID="rbtnAddTeamMember" runat="server"  Text="Add Team Member" OnClick="rbtnAddtask_Click">
        </telerik:RadButton>
          </td>
  </tr>

</tbody>
</table>
        </center>






</asp:Content>

