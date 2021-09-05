<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="zoneInfo.aspx.cs" Inherits="PropertyManagementSystem.user.zoneInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
                    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Zones</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  
                                  <th scope="col">Zone Id</th>
                                  <th scope="col">Zone Name</th>
                                 
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("name")%></td>
                              
                          </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                  </table>
                                </FooterTemplate>
                                </asp:Repeater>
                            
                        </div>
                        
                    </div>
                </div>
</asp:Content>
