<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <header>
        <nav>
            <div class="nav-wrapper">
                <a href="Default.aspx" class="brand-logo center"><span class="flow-text">About</span></a>
            </div>
        </nav>
    </header>

<div class="container">
    <ul class="collection">
        <li class="collection-item avatar">
            <span class="title"><b>Vivek Mehta</b></span>
            <p>Re-Devloped Ros Controller For STIFF-FLOP<br />Nuffield Research Placement Student</p>
        </li>
        <li class="collection-item avatar">
            <span class="title"><b>Dr Helge A Wurdemann</b></span>
            <p>Project Supervisor<br />King's College London</p>
        </li>
        <li class="collection-item avatar">
            <span class="title"><b>Ahmad Ataka</b></span>
            <p>Project Supervisor<br />King's College London</p>
        </li>
    </ul>
    <h4 class="center-align"><span class="flow-text">Acknowledgements</span></h4>
    <ul class="collapsible popout" data-collapsible="accordion">
        <li>
            <div class="collapsible-header"><i class=""></i>Harsh Kukadia</div>
            <div class="collapsible-body"><p>Harsh developed the first version of the ROS Controller.</p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class=""></i>Prof. Kaspar Althoefer</div>
            <div class="collapsible-body"><p>Harsh's Project Supervisor</p></div>
        </li>        
        <li>
            <div class="collapsible-header"><i class="mdi-editor-format-paint"></i>Materialize</div>
            <div class="collapsible-body"><p>For providing a modern responsive front-end framework based on Material Design</p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class="mdi-av-web"></i>Google Developer's Guide</div>
            <div class="collapsible-body"><p>For providing web-based app and material ui guidelines</p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class="mdi-hardware-memory"></i>ROS.org</div>
            <div class="collapsible-body"><p>For providing roslibjs - the core JavaScript library for interacting with ROS from the browser</p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class="mdi-hardware-memory"></i>Jerome Etienne</div>
            <div class="collapsible-body"><p>of <a href="http://jetienne.com/">jetienne.com</a> For providing virtualjoystick.js - a JavaScript library for creating virtual joysticks</p></div>
        </li>
    </ul>
    <a href="javascript: history.go(-1)" class="btn waves-effect waves-light left-align" style="display: block; width: 100%;">Close<i class="mdi-content-clear right"></i></a>
</div>
</asp:Content>

