<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ControlTypes.aspx.cs" Inherits="ControlTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <%--Header--%>
    <header>
        <nav>
            <div class="nav-wrapper">
                <a href="Default.aspx" class="brand-logo center"><span class="flow-text">STIFF-FLOP ROS Controller</span></a>
                <a href="#" data-activates="mobile-demo" class="button-collapse left"><i class="mdi-navigation-menu"></i></a>
                <ul class="right hide-on-med-and-down">
                    <li><a href="About.aspx"><i class="mdi-action-info-outline left"></i>About</a></li>
                </ul>
                <ul class="side-nav" id="mobile-demo">
                    <li>
                        <div class="row">
                          <div class="col s6"><a href="Default.aspx"><i class="mdi-hardware-keyboard-backspace"></i></a></div>
                          <div class="col s6"><a href="Default.aspx"><i class="mdi-action-home"></i></a></div>  
                        </div>
                    </li>
                    <li><a href="About.aspx"><i class="mdi-action-info-outline left"></i>About</a></li>
                </ul>
            </div>
        </nav>
    </header>
    <br />
    <div class="container">
      <ul class="collapsible popout" data-collapsible="accordion">
        <li>
          <div class="collapsible-header"><i class="mdi-image-hdr-weak"></i>STIFF-FLOP First Module Virtual Joystick X, Y, Z Direction</div>
          <div class="collapsible-body"><p>This controller gives you the ability to control the first module on the manipulator using two on-screen Virtual Joysticks that control the X, Y, Z Direction.</p><a href="VirtualJoystick_Mod1.aspx" class="btn waves-effect waves-light" style="display: block; width: 100%;">Run</a></div>
        </li>
        <li>
          <div class="collapsible-header"><i class="mdi-image-hdr-weak"></i>STIFF-FLOP Second Module Virtual Joystick X, Y, Z Direction</div>
          <div class="collapsible-body"><p>This controller gives you the ability to control the second module on the manipulator using two on-screen Virtual Joysticks that control the X, Y, Z Direction.</p><a href="VirtualJoystick_Mod2.aspx" class="btn waves-effect waves-light" style="display: block; width: 100%;">Run</a></div>
        </li>
      </ul>
    </div>

</asp:Content>

