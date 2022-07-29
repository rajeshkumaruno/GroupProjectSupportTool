<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaskByMemberProject.aspx.cs" Inherits="TaskByMemberProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br />
<br /><br /><br />
<center>
    <table>

        

      <tr>
    <td class="tg-0pky" style="color:white">Project :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddlProject" runat="server" Width="411px" AutoPostBack="true" OnSelectedIndexChanged="rddlProject_SelectedIndexChanged" >
        </telerik:RadDropDownList>

    </td>
  </tr>

    
      <tr>
    <td class="tg-0pky" style="color:white">Team Member :</td>
    <td class="tg-0lax">
        <telerik:RadDropDownList ID="rddTeamMember" AutoPostBack="true" runat="server"  Width="411px" OnSelectedIndexChanged="rddTeamMember_SelectedIndexChanged" >
        </telerik:RadDropDownList>

    </td>
  </tr>


    </table>
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">            function rowDblClick(sender, eventArgs) { sender.get_masterTableView().editItem(eventArgs.get_itemIndexHierarchical()); }            </script>
</telerik:RadCodeBlock>
<telerik:RadAjaxManager runat="server" ID="RadAjaxManager1" DefaultLoadingPanelID="RadAjaxLoadingPanel1">
    <ajaxsettings>
  <telerik:AjaxSetting AjaxControlID="RadGrid1">
    <UpdatedControls>
      <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
      <telerik:AjaxUpdatedControl ControlID="RadWindowManager1" />
      <telerik:AjaxUpdatedControl ControlID="RadInputManager1" />
    </UpdatedControls>
  </telerik:AjaxSetting>
</ajaxsettings>
</telerik:RadAjaxManager>
<telerik:RadAjaxLoadingPanel runat="server" ID="RadAjaxLoadingPanel1" />
<telerik:RadGrid RenderMode="Lightweight" runat="server" ID="RadGrid1" AutoGenerateColumns="False" AllowPaging="True"

    >
    <mastertableview datakeynames="TaskAssignmentID" commanditemdisplay="Top" insertitempageindexaction="ShowItemOnCurrentPage">
        <CommandItemSettings ShowAddNewRecordButton="false" />
  <Columns>
    <telerik:GridBoundColumn DataField="TaskAssignmentID" HeaderText="TaskAssignmentID" ReadOnly="true"
      ForceExtractValue="Always" ConvertEmptyStringToNull="true" />
    <telerik:GridBoundColumn DataField="TaskName" HeaderText="Task Name" />
      <telerik:GridBoundColumn DataField="ProjectName" HeaderText="Project Name" />
    <telerik:GridBoundColumn DataField="FirstName" HeaderText="First Name" />
    <telerik:GridBoundColumn DataField="LastName" HeaderText="Last Name" />
      <telerik:GridBoundColumn DataField="ProjectStartDate" HeaderText="Project Start Date" />
      <telerik:GridBoundColumn DataField="ProjectEndDate" HeaderText="Project End Date" />
  </Columns>
 
</mastertableview>
    <pagerstyle mode="NextPrevAndNumeric" />

</telerik:RadGrid>
<telerik:RadInputManager RenderMode="Lightweight" runat="server" ID="RadInputManager1" Enabled="true">
    <telerik:TextBoxSetting BehaviorID="TextBoxSetting1">
    </telerik:TextBoxSetting>
  
</telerik:RadInputManager>
<telerik:RadWindowManager RenderMode="Lightweight" ID="RadWindowManager1" runat="server" />
</center>

</asp:Content>

