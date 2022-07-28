<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskAdd.aspx.cs" Inherits="TaskAdd" %>

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
    <td class="center" colspan="2" style="align" >Add New Task</td>

  </tr>


  <tr>
    <td class="tg-0pky">Task Name:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbTaskName" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Task Notes:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbTaskNotes"  runat="server" TextMode="MultiLine"
  Rows="5" 
  Wrap="true" 
  Text="Please add description of task" Width="411px">
</telerik:RadTextBox></td>
  </tr>

      <tr>
    <td class="tg-0pky">Iteration:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbIteration" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Task Start Date:</td>
    <td class="tg-0lax">
        <telerik:RadCalendar ID="rcStartDate" runat="server"></telerik:RadCalendar>
    </td>
  </tr>

      <tr>
    <td class="tg-0pky">Task End Data:</td>
    <td class="tg-0lax">
        <telerik:RadCalendar ID="rcEndDate" runat="server"></telerik:RadCalendar>
    </td>
  </tr>


      <tr>
    <td class="tg-0pky">Completition Percent:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbCompletitionPercent" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Status:</td>
    <td class="tg-0lax">
       <telerik:RadDropDownList ID="rddlistStatus" Height="30px" runat="server" Skin="Metro">
    <Items>
        <telerik:DropDownListItem Text="New" Value="New" Selected="true" />
        <telerik:DropDownListItem Text="In Development" Value="InDevelopment" />
        <telerik:DropDownListItem Text="Blocked" Value="Blocked" />
        <telerik:DropDownListItem Text="Completed" Value="Completed" />
    </Items>
</telerik:RadDropDownList>
    </td>
  </tr>


          <tr>
    <td class="tg-0pky">Remove Task:</td>
    <td class="tg-0lax">
          <telerik:RadCheckBox ID="rcbRemoved" runat="server" AutoPostBack="false" Text="Remove Task"></telerik:RadCheckBox>
    </td>
  </tr>






      <tr>
    <td class="tg-0pky">Project :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlProject" runat="server" Width="411px" >
        </telerik:RadDropDownList>

    </td>
  </tr>


              <tr>
    <td class="tg-0pky">Is this task a milestone?:</td>
    <td class="tg-0lax">
          <telerik:RadCheckBox ID="rcbIsMileStone" runat="server" AutoPostBack="false" Text="Milestone"></telerik:RadCheckBox>
    </td>
  </tr>




      <tr>
    <td class="tg-0pky" colspan="2">
        <telerik:RadButton ID="rbtnAddtask" runat="server"  Text="Add Task" OnClick="rbtnAddtask_Click">
        </telerik:RadButton>
          </td>
  </tr>


</tbody>
</table>
        </center>






</asp:Content>

