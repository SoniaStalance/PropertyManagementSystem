<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="wardInfo.aspx.cs" Inherits="PropertyManagementSystem.user.wardInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Wards</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Id</th>
                                  <th scope="col">Ward</th>
                                  <th scope="col">Zone</th>
                                 
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                            
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("name")%></td>
                              <td><%#Eval("zid")%></td>
                              
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
