<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="displayZone.aspx.cs" Inherits="PropertyManagementSystem.admin.displayZone" %>
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
                                  <th scope="col">Edit</th>
                                  <th scope="col">Delete</th>
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("name")%></td>
                              <td><a href="editZone.aspx?id=<%#Eval("id")%>">Edit</a></td>
                              <td><a href="delZone.aspx?id=<%#Eval("id")%>">Delete</a></td>
                              
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
