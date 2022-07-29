<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MeetingAdd.aspx.cs" Inherits="MeetingAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
    <td class="center" colspan="2" style="align" >Schedule a Meeting</td>

  </tr>


  <tr>
    <td class="tg-0pky">Meeting Name:</td>
    <td class="tg-0lax">
        <telerik:RadTextBox ID="rtbMeetingName" runat="server" Height="30px" LabelWidth="64px" Resize="None" Width="316px">
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
    <td class="tg-0pky">Pick a Date Time Slot :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlSlot" runat="server" Width="411px" >
        </telerik:RadDropDownList>

    </td>
  </tr>


          <tr>
    <td class="tg-0pky">Select Team Member(s) :</td>
    <td class="tg-0lax">
<telerik:RadComboBox ID="rcbTeamMember" runat="server" CheckBoxes="true">
</telerik:RadComboBox>

    </td>
  </tr>





      <tr>
    <td class="tg-0pky" colspan="2">
        <telerik:RadButton ID="rbtnSchedule" runat="server"  Text="Schedule" OnClick="rbtnSchedule_Click" >
        </telerik:RadButton>
          </td>
  </tr>


</tbody>
</table>
        </center>






</asp:Content>

