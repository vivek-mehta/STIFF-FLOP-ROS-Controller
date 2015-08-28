<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VirtualJoystickSettings.aspx_Mod2.cs" Inherits="VirtualJoystickProperties" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>
        $(document).ready(function () {
            $(".button-collapse").sideNav();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <%--Header--%>
    <header>
        <nav>
            <div class="nav-wrapper">

                <%--Application Name--%>
                <a href="Default.aspx" class="brand-logo center"><span class="flow-text">STIFF-FLOP ROS Controller</span></a>

                <%--Back Button--%>
                <a href="VirtualJoystick_Mod2.aspx" class="left"><i class="mdi-hardware-keyboard-backspace"></i></a>
            </div>
        </nav>
    </header>

    <div class="container">
        <div class="row">

            <%--Maximum X,Y & Z Values Details Form--%>
            <form class="col s12" runat="server">

                <br />
                <%--Maximum X1 Value Property Field--%>
                <div class="row">
                    <div class="input-field col s12">
                        <label for="MaxX2Val" class="active">Maximum X Velocity</label>
                        <input runat="server" value="" id="MaxX2Val" type="text" class="validate" />
                    </div>
                </div>

                <%--Maximum Y1 Value Property Field--%>
                <div class="row">
                    <div class="input-field col s12">
                        <label for="MaxY2Val" class="active">Maximum Y Velocity</label>
                        <input runat="server" value="" id="MaxY2Val" type="text" class="validate" />
                    </div>
                </div>

                <%--Maximum Z1 Value Property Field--%>
                <div class="row">
                    <div class="input-field col s12">
                        <label for="MaxZ2Val" class="active">Maximum Z Velocity</label>
                        <input runat="server" value="" id="MaxZ2Val" type="text" class="validate" />
                    </div>
                </div>

                <%--Submit Button--%>
                <div class="row">
                    <div class="grid-example col s12">
                        <button class="btn waves-effect waves-light"  style="display: block; width: 100%;" type="submit" name="action" runat="server" onserverclick="SaveProperties">Save
                            <i class="mdi-content-save right"></i>
                        </button>
                    </div>
                </div>

            </form>

        </div>
    </div>
</asp:Content>

