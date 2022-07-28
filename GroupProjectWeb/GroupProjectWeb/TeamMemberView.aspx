<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TeamMemberView.aspx.cs" Inherits="TeamMemberView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br /><br /><br />
<br /><br /><br />
<center>
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
    OnNeedDataSource="RadGrid1_NeedDataSource" OnUpdateCommand="RadGrid1_UpdateCommand"
     OnDeleteCommand="RadGrid1_DeleteCommand"
    >
    <mastertableview datakeynames="TeamMemberID" commanditemdisplay="Top" insertitempageindexaction="ShowItemOnCurrentPage">
        <CommandItemSettings ShowAddNewRecordButton="false" />
  <Columns>
    <telerik:GridEditCommandColumn ButtonType="ImageButton" />
    <telerik:GridBoundColumn DataField="TeamMemberID" HeaderText="Team Member ID" ReadOnly="true"
      ForceExtractValue="Always" ConvertEmptyStringToNull="true" />
    <telerik:GridBoundColumn DataField="FirstName" HeaderText="First Name" />
      <telerik:GridBoundColumn DataField="LastName" HeaderText="Last Name" />
    <telerik:GridBoundColumn DataField="SSN" HeaderText="SSN" />
    <telerik:GridBoundColumn DataField="RoleName" HeaderText="RoleName" />

    <telerik:GridButtonColumn ConfirmText="Delete this team member?" ConfirmDialogType="RadWindow"
      ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" />
  </Columns>
  <EditFormSettings>
    <EditColumn ButtonType="ImageButton" />
  </EditFormSettings>
</mastertableview>
    <pagerstyle mode="NextPrevAndNumeric" />
    <clientsettings>
  <ClientEvents OnRowDblClick="rowDblClick" />
</clientsettings>
</telerik:RadGrid>
<telerik:RadInputManager RenderMode="Lightweight" runat="server" ID="RadInputManager1" Enabled="true">
    <telerik:TextBoxSetting BehaviorID="TextBoxSetting1">
    </telerik:TextBoxSetting>
    <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting1" Type="Currency"
        AllowRounding="true" DecimalDigits="2">
    </telerik:NumericTextBoxSetting>
    <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting2" Type="Number"
        AllowRounding="true" DecimalDigits="0" MinValue="0">
    </telerik:NumericTextBoxSetting>
</telerik:RadInputManager>
<telerik:RadWindowManager RenderMode="Lightweight" ID="RadWindowManager1" runat="server" />
</center>

</asp:Content>


